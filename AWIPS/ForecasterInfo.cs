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
    public partial class ForecasterInfo : Form
    {
        public ForecasterInfo()
        {
            InitializeComponent();
            lblForecaster.Text = "";
            lblForecaster.Text += $"Forecaster: {Globals.forecasterName}" + Environment.NewLine;
            lblForecaster.Text += $"Signature: {Globals.forecasterSignature}";
            chkAutofill.Checked = Globals.autofillSignature;
            if (Globals.testMode == 1)
            {
                chkPractice.Checked = true;
            }
            else
            {
                chkPractice.Checked = false;
            }
            lblWfo.Text = "";
            lblWfo.Text += $"Authority: {Globals.officeId}" + Environment.NewLine;
            lblWfo.Text += $"Office Name: {Globals.officeName}" + Environment.NewLine;
            lblWfo.Text += $"Localization: {Globals.officeLoc}" + Environment.NewLine;
        }

        private void ForecasterInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void chkAutofill_CheckedChanged(object sender, EventArgs e)
        {
            Globals.autofillSignature = chkAutofill.Checked;
        }

        private void chkPractice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPractice.Checked == true)
            {
                Globals.testMode = 1;
            }
            else
            {
                Globals.testMode = 0;
            }
        }

        private void btnRefLogin_Click(object sender, EventArgs e)
        {
            Globals.loginForm.Show();
            this.Close();
        }
    }
}