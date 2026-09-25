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
    public partial class LocalStormReport : Form
    {
        private AWIPSForm _parentForm;
        public LocalStormReport(AWIPSForm parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
            cbEvent.SelectedIndex = 0;
            cbSource.SelectedIndex = 7;
            tbMagnitude.Text = "";
            nupInjFat.Value = 0;
            rbNone.Checked = true;
            tbRemarks.Text = "";
            dtpStormReport.Format = DateTimePickerFormat.Custom;
            dtpStormReport.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpStormReport.ShowUpDown = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Globals.stormMode = 0;
            rbNone.Checked = true;
            Globals.boxTrackType = 2;
            Globals.durationSelected = 2;
            Globals.warningSelected = 1;
            Globals.warngenBullets = new List<string>();
            cbEvent.SelectedIndex = 0;
            cbSource.SelectedIndex = 7;
            tbMagnitude.Text = "";
            nupInjFat.Value = 0;
            rbNone.Checked = true;
            tbRemarks.Text = "";
            _parentForm.ResetWarningSystem();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            int injFataValue = 0;
            if (rbNone.Checked)
            {
                injFataValue = 0;
            }
            if (rbInjuries.Checked)
            {
                injFataValue = 1;
            }
            if (rbFatalities.Checked)
            {
                injFataValue = 2;
            }
            Globals.stormMode = 0;
            btnCreate.Enabled = false;
            _parentForm.RecalculateTrackFromMarkers2();
            DateTime selectedValue = dtpStormReport.Value;
            string dateOnly = selectedValue.ToString("MM/dd/yyyy");
            string timeOnly = selectedValue.ToString("hh:mm tt");
            timeOnly = timeOnly.Replace(":", "");
            GeneratingProduct GeneratingProductForm = new GeneratingProduct();
            GeneratingProductForm.Show();
            await _parentForm.HarvestDataAutomaticallyFromWeb();
            Globals.LocalStormReportTextGenerate(dateOnly, timeOnly, cbEvent.Text, tbMagnitude.Text, cbSource.Text, Convert.ToInt32(nupInjFat.Value), injFataValue, tbRemarks.Text); /// REPLACE!!!
            Globals.startEditor = 1;
            if (Globals.bringUpWorkstation == true)
            {
                TextEditor TextEditorForm = new TextEditor();
                TextEditorForm.Show();
            }
            GeneratingProductForm.Close();
            btnCreate.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
