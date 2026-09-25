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
    public partial class TextWorkstation : Form
    {
        private AWIPSForm _parentForm;
        public static Dictionary<string, string> alertMapping = new Dictionary<string, string>()
        {
            { "911 Telephone Outage Emergency", "TOE" },
            { "Administrative Message", "ADR" },
            { "Air Quality Alert", "AQA" },
            { "Area Forecast Discussion", "AFD" },
            { "Avalanche Warning", "AVW" },
            { "Avalanche Watch", "AVA" },
            { "Blizzard Warning", "BZW" },
            { "Blue Alert", "BLU" },
            { "Child Abduction Emergency", "CAE" },
            { "Civil Danger Warning", "CDW" },
            { "Civil Emergency Message", "CEM" },
            { "Coastal Flood Warning", "CFW" },
            { "Coastal Flood Watch", "CFA" },
            { "Dust Storm Warning", "DSW" },
            { "Earthquake Warning", "EQW" },
            { "Evacuation Immediate", "EVI" },
            { "Extreme Wind Warning", "EWW" },
            { "Fire Warning", "FRW" },
            { "Flash Flood Statement", "FFS" },
            { "Flash Flood Warning", "FFW" },
            { "Flash Flood Watch", "FFA" },
            { "Flood Statement", "FLS" },
            { "Flood Warning", "FLW" },
            { "Flood Watch", "FLA" },
            { "Hazardous Materials Warning", "HMW" },
            { "Hazardous Weather Outlook", "HWO" },
            { "High Wind Warning", "HWW" },
            { "High Wind Watch", "HWA" },
            { "Hurricane Statement", "HLS" },
            { "Hurricane Warning", "HUW" },
            { "Hurricane Watch", "HUA" },
            { "Law Enforcement Warning", "LEW" },
            { "Local Area Emergency", "LAE" },
            { "Local Storm Report", "LSR" },
            { "Non Precipitation Warning", "NPW" },
            { "Nuclear Power Plant Warning", "NUW" },
            { "Practice Demo Warning", "DMO" },
            { "Public Information Statement", "PNS" },
            { "Radiological Hazard Warning", "RHW" },
            { "Required Monthly Test", "RMT" },
            { "Required Weekly Test", "RWT" },
            { "Severe Thunderstorm Warning", "SVR" },
            { "Severe Thunderstorm Watch", "SVA" },
            { "Severe Weather Statement", "SVS" },
            { "Shelter in Place Warning", "SPW" },
            { "Snow Squall Warning", "SQW" },
            { "Special Marine Warning", "SMW" },
            { "Special Weather Statement", "SPS" },
            { "Storm Surge Warning", "SSW" },
            { "Storm Surge Watch", "SSA" },
            { "Tornado Warning", "TOR" },
            { "Tornado Watch", "TOA" },
            { "Tropical Storm Warning", "TRW" },
            { "Tropical Storm Watch", "TRA" },
            { "Tsunami Warning", "TSW" },
            { "Tsunami Watch", "TSA" },
            { "Volcano Warning", "VOW" },
            { "Watch County Notification", "WCN" },
            { "Winter Storm Warning", "WSW" },
            { "Winter Storm Watch", "WSA" }
        };
        public static List<string> multiProductListing = new List<string>()
        {
            "SVS","FFS","HWO","SPS","FLW","FLS","MCD","SEL","WCN"
        };
        public TextWorkstation(AWIPSForm parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
            ddDuration.SelectedIndex = 0;
            cbProduct.SelectedIndex = 0;
            cbBulletins.SelectedIndex = 0;
            cbIssuer.SelectedIndex = 0;
            cbCountyChooseSelection.SelectedIndex = 1;
            Globals.durationSelected = ddDuration.SelectedIndex;
            DateTimeOffset now = DateTimeOffset.Now;
            string currentPart = now.ToString("HH:mm ddd d-MMM");
            DateTimeOffset futureDateTime = now.AddMinutes(Globals.warngenDurationsList[Globals.durationSelected]);
            string futureTime = futureDateTime.ToString("HH:mm ddd d-MMM");
            lblDuration.Text = currentPart + " to " + futureTime;
            Globals.stormMode = 1;
            Globals.spcSelection = 0;
        }

        private void ddDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.durationSelected = ddDuration.SelectedIndex;
            // 22:38 Thu 18-Jun to 22:38 Thu 18-Jun
            DateTimeOffset now = DateTimeOffset.Now;
            string currentPart = now.ToString("HH:mm ddd d-MMM");
            DateTimeOffset futureDateTime = now.AddMinutes(Globals.warngenDurationsList[Globals.durationSelected]);
            string futureTime = futureDateTime.ToString("HH:mm ddd d-MMM");
            lblDuration.Text = currentPart + " to " + futureTime;
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ddDuration.SelectedIndex = 0;
            Globals.stormMode = 1;
            Globals.boxTrackType = 2;
            Globals.durationSelected = 2;
            chkRelay.Checked = false;
            cbProduct.SelectedIndex = 0;
            cbBulletins.SelectedIndex = 0;
            cbCountyChooseSelection.SelectedIndex = 1;
            cbIssuer.SelectedIndex = 0;
            chkInsertCities.Checked = false;
            chkInsertCounties.Checked = false;
            chkLatLon.Checked = false;
            chkUseTemplate.Checked = false;
            chkSelfExpire.Checked = false;
            chkEffectiveTimeRounding.Checked = false;
            ddDuration.SelectedIndex = Globals.durationSelected;
            _parentForm.ResetWarningSystem();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            Globals.warningSelected = 0;
            btnCreate.Enabled = false;
            GeneratingProduct GeneratingProductForm = new GeneratingProduct();
            GeneratingProductForm.Show();
            await _parentForm.HarvestDataAutomaticallyFromWeb();
            // MessageBox.Show(cbProduct.Text);
            // MessageBox.Show(alertMapping[cbProduct.Text]);
            bool useMutliProductFormatting = false;
            if (multiProductListing.Contains(alertMapping[cbProduct.Text]))
            {
                useMutliProductFormatting = true;
            }
            Globals.TextWorkstationCall(chkUseTemplate.Checked, chkLatLon.Checked, chkInsertCounties.Checked, chkInsertCities.Checked, cbCountyChooseSelection.SelectedIndex, chkRelay.Checked, chkSelfExpire.Checked, chkEffectiveTimeRounding.Checked, useMutliProductFormatting, cbBulletins.Text, cbIssuer.SelectedIndex, cbProduct.Text, alertMapping[cbProduct.Text]); /// REPLACE!!!
            Globals.startEditor = 1;
            if (Globals.bringUpWorkstation == true)
            {
                TextEditor TextEditorForm = new TextEditor();
                TextEditorForm.Show();
            }
            GeneratingProductForm.Close();
            btnCreate.Enabled = true;
        }

        private void gbResetTracking_Enter(object sender, EventArgs e)
        {

        }

        private void cbBulletins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            _parentForm.RecalculateTrackFromMarkers();
        }
    }
}
