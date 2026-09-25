using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWIPS
{
    public partial class SendProduct : Form
    {
        private TextEditor _parentForm;
        private string _productCategory;
        private string _productDesignator;
        private string alertTypeText = string.Empty;
        public SendProduct(TextEditor parentForm, string product, string designator)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _productCategory = product;
            _productDesignator = designator;

            int index = Globals.TTMapping.IndexOf(_productCategory);
            if (index != -1)
            {
                alertTypeText = Globals.TTMapping[index + 3];
            }
            else
            {
                alertTypeText = "Unrecognized Message";
            }
            // MessageBox.Show($"This is the uuid: {_parentForm.localuuidLoad}");
            if (Globals.testMode == 1)
            {
                lbl1.Text = "Practice";
                if (_parentForm.localuuidLoad != "")
                {
                    lbl2.Text = $"You are about to SEND a {_productCategory}{_productDesignator} {alertTypeText}. ***REPLACE***" + Environment.NewLine + Environment.NewLine + "The workstation is in Practice mode. The product will not be stored in the text database and not be sent on the WAN.";
                }
                else
                {
                    lbl2.Text = $"You are about to SEND a {_productCategory}{_productDesignator} {alertTypeText}." + Environment.NewLine + Environment.NewLine + "The workstation is in Practice mode. The product will not be stored in the text database and not be sent on the WAN.";

                }
                // btnSend.Enabled = false;
            }
            else
            {
                if (_parentForm.localuuidLoad != "")
                {
                    lbl2.Text = $"You are about to SEND a {_productCategory}{_productDesignator} {alertTypeText}. ***REPLACE***" + Environment.NewLine + Environment.NewLine + "The workstation is in Operational mode. The product will be stored in the text database and will be sent on the WAN." + Environment.NewLine + Environment.NewLine + "Sending this product will update/replace a product in the text database.";
                }
                else
                {
                    lbl2.Text = $"You are about to SEND a {_productCategory}{_productDesignator} {alertTypeText}." + Environment.NewLine + Environment.NewLine + "The workstation is in Operational mode. The product will be stored in the text database and will be sent on the WAN." + Environment.NewLine + Environment.NewLine + "Sending this product will update/replace a product in the text database.";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentForm.abortSend();
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            btnAbort.Enabled = false;
            if (Globals.testMode == 0)
            {
                int result = await _parentForm.SendProduct();
                if (result == 1)
                {
                    _parentForm.abortSend();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("FAILED TO SEND PRODUCT");
                }
            }
            else
            {
                _parentForm.SendProductPractice();
                _parentForm.abortSend();
                this.Close();
            }
            btnSend.Enabled = true;
            btnAbort.Enabled = true;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentForm.abortSend();
        }
    }
}
