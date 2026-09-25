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
    public partial class AWIPSHeaderBlock : Form
    {
        private TextEditor _parentForm;
        private static List<string> ddBBBDrop = new List<string>() { 
            "NOR","RR","CC","RTD"
        };

        public AWIPSHeaderBlock(TextEditor parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            tbTTAAii.Text = Globals.TTAAii;
            tbCCCC.Text = Globals.CCCC;
            if (ddBBBDrop.Contains(Globals.BBB))
            {
                ddBBB.SelectedIndex = ddBBBDrop.IndexOf(Globals.BBB);
            }
            else
            {
                ddBBB.SelectedIndex = 0;
            }
            ddBBBVer.SelectedIndex = Globals.BBBver;
            tbWSFOID.Text = Globals.WSFOid;
            tbProductCat.Text = Globals.productCategory;
            tbProductDes.Text = Globals.productDesignator;
            ddProductOrg.SelectedIndex = Globals.productOriginator;
            cbSAME.Checked = Globals.SAMETonage;
            cb1050.Checked = Globals.Tonage1050;
            cbInterrupt.Checked = Globals.Interrupt;
            tbFIPS.Text = Globals.countiesAffected;
            tbVTECHeader.Text = Globals.vtecHeader;
            cbRepeat.Checked = Globals.Repeat;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTTAAii_TextChanged(object sender, EventArgs e)
        {
            Globals.TTAAii = tbTTAAii.Text;
        }

        private void tbCCCC_TextChanged(object sender, EventArgs e)
        {
            Globals.CCCC = tbCCCC.Text;
        }

        private void tbBBB_TextChanged(object sender, EventArgs e)
        {
            Globals.BBB = ddBBB.SelectedItem.ToString();
        }

        private void tbWSFOID_TextChanged(object sender, EventArgs e)
        {
            Globals.WSFOid = tbWSFOID.Text;
        }

        private void tbProductCat_TextChanged(object sender, EventArgs e)
        {
            Globals.productCategory = tbProductCat.Text;
            if (tbProductCat.TextLength == 3)
            {
                int index = Globals.TTMapping.IndexOf(tbProductCat.Text);
                if (index != -1)
                {
                    tbTTAAii.Text = $"{Globals.TTMapping[index + 1]}US{Globals.TTMapping[index + 2]}".ToUpper();
                    Globals.TTAAii = tbTTAAii.Text;
                }
                else
                {
                    tbTTAAii.Text = "";
                    Globals.TTAAii = tbTTAAii.Text;
                }
            }
            else
            {
                tbTTAAii.Text = "";
                Globals.TTAAii = tbTTAAii.Text;
            }
        }

        private void tbProductDes_TextChanged(object sender, EventArgs e)
        {
            Globals.productDesignator = tbProductDes.Text;
            if (tbProductDes.TextLength == 3)
            {
                tbCCCC.Text = $"K{tbProductDes.Text.ToUpper()}";
                Globals.CCCC = tbCCCC.Text;
            }
            else
            {
                tbCCCC.Text = "";
                Globals.CCCC = tbCCCC.Text;
            }
        }

        private void ddProductOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.productOriginator = ddProductOrg.SelectedIndex;
        }

        private void cbSAME_CheckedChanged(object sender, EventArgs e)
        {
            Globals.SAMETonage = cbSAME.Checked;
        }

        private void cb1050_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Tonage1050 = cb1050.Checked;
        }

        private void cbInterrupt_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Interrupt = cbInterrupt.Checked;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Globals.TTAAii != "" && Globals.CCCC != "" && Globals.productCategory != "" && Globals.productDesignator != "" && Globals.countiesAffected != "")
            {
                _parentForm.UpdateAWIPSHeaderData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields before entering headers.");
            }
        }

        private void box4_Enter(object sender, EventArgs e)
        {

        }

        private void tbFIPS_TextChanged(object sender, EventArgs e)
        {
            Globals.countiesAffected = tbFIPS.Text;
        }

        private void AWIPSHeaderBlock_Load(object sender, EventArgs e)
        {

        }

        private void tbVTECHeader_TextChanged(object sender, EventArgs e)
        {
            Globals.vtecHeader = tbVTECHeader.Text;
        }

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Repeat = cbRepeat.Checked;
        }

        private void ddBBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.BBB = ddBBBDrop[ddBBB.SelectedIndex];
        }

        private void ddBBBVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.BBBver = ddBBBVer.SelectedIndex;
        }
    }
}
