using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWIPS
{
    public partial class SPCIssuancePanel : Form
    {
        private AWIPSForm _parentForm;
        private string type = "";
        private List<string> warngenVtecIndex = new List<string>(){
            "MC.O","WW.A","WW.A","WW.A"
        };
        private List<string> dataList = new List<string>();
        private List<string> spcLayout = new List<string>()
        {
            "****SELECT FOR PDS MESSAGE****","","**** CONCERNING ****","Severe potential","Tornado Watch","Severe Thunderstorm Watch","","**** PROBABILITY ****","**** ONLY USE WITH SVR POT. ****","5 percent","20 percent","40 percent","60 percent","80 percent","95 percent","","**** WIND GUST HAZARD (CHOOSE 1) ****","55 MPH","55-70 MPH","65-80 MPH","75-90 MPH","85-100 MPH",">100 MPH","","**** HAIL HAZARD (CHOOSE 1) ****","1.25 IN","1.00-1.75 IN","1.50-2.25 IN","2.00-2.75 IN","2.50-3.25 IN","3.00-3.75 IN","3.50-4.25 IN",">4.00 IN","","**** TORNADO HAZARD (CHOOSE 1) ****","95 MPH","85-115 MPH","100-130 MPH","115-145 MPH","130-160 MPH","145-175 MPH","160-190 MPH","175-205 MPH","190-220 MPH",">220 MPH"
        };
        public static List<string> spcWatchThing = new List<string>()
        {
            "Please Select a Watch to", "Cancel from the Pull-Down Menu"
        };
        public SPCIssuancePanel(AWIPSForm parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
            ddDuration.SelectedIndex = 2;
            Globals.durationSelected = ddDuration.SelectedIndex;
            DateTimeOffset now = DateTimeOffset.Now;
            string currentPart = now.ToString("HH:mm ddd d-MMM");
            DateTimeOffset futureDateTime = now.AddMinutes(Globals.warngenDurationsList[Globals.durationSelected]);
            string futureTime = futureDateTime.ToString("HH:mm ddd d-MMM");
            lblDuration.Text = currentPart + " to " + futureTime;
            type = "MCD";
            Globals.stormMode = 1;
            Globals.spcSelection = 0;
            lbSelections.Items.Clear();
            foreach (var item in spcLayout)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private async void fetchSevereWeatherStatementFollowups(string type)
        {
            string url = $"http://{Globals.serverip}/getfollowupstatementssvs/{Globals.username}/{Globals.password}/{type}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string jsonString = await response.Content.ReadAsStringAsync();
                using (JsonDocument doc = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = doc.RootElement;

                    if (root.TryGetProperty("status", out JsonElement statusElement) &&
                        statusElement.GetString() == "success")
                    {
                        if (root.TryGetProperty("data", out JsonElement statusElement2))
                        {
                            string input = Convert.ToString(statusElement2);
                            dataList = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            cbUpdateList.Items.Clear();
                            cbUpdateList.Items.Add("FOLLOWUP");
                            cbUpdateList.Items.Add("UPDATE LIST");
                            for (int i = 0; i < dataList.Count; i += 3)
                            {
                                cbUpdateList.Items.Add(dataList[i + 1]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to load followup products");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to load followup products");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to load followup products");
            }
        }

        private async void fetchSevereWeatherStatementProduct(int uuid)
        {
            string url = $"http://{Globals.serverip}/followuploadproduct/{Globals.username}/{Globals.password}/{dataList[uuid]}";
            Globals.uuidStore = dataList[uuid];
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string jsonString = await response.Content.ReadAsStringAsync();
                using (JsonDocument doc = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = doc.RootElement;

                    if (root.TryGetProperty("status", out JsonElement statusElement) &&
                        statusElement.GetString() == "success")
                    {
                        string latlon = "";
                        string timemotloc = "";
                        if (root.TryGetProperty("counties", out JsonElement statusElement2))
                        {
                            Globals.countiesAffectedUpdate = Convert.ToString(statusElement2);
                        }
                        if (root.TryGetProperty("latlon", out JsonElement statusElement3))
                        {
                            latlon = Convert.ToString(statusElement3);
                        }
                        if (root.TryGetProperty("timemotloc", out JsonElement statusElement4))
                        {
                            timemotloc = Convert.ToString(statusElement4);
                        }
                        if (root.TryGetProperty("endtime", out JsonElement statusElement5))
                        {
                            // MessageBox.Show($"{statusElement5}");
                            Globals.expTimeSvs = Convert.ToInt32($"{statusElement5}");
                        }
                        if (root.TryGetProperty("starttime", out JsonElement statusElement8))
                        {
                            Globals.startTimeSvs = Convert.ToInt32($"{statusElement8}");
                        }
                        if (root.TryGetProperty("vteccurrent", out JsonElement statusElement7))
                        {
                            Globals.nextVtecForContinuations = Convert.ToInt32($"{statusElement7}").ToString("D4");
                        }
                        if (root.TryGetProperty("type", out JsonElement statusElement6))
                        {
                            Globals.svsWarningType = Convert.ToString(statusElement6);
                        }
                        else
                        {
                            MessageBox.Show("Failed to load product update");
                        }
                        _parentForm.regenPolygonFromUpdate(latlon, timemotloc);
                    }
                    else
                    {
                        MessageBox.Show("Failed to load product update");
                    }
                }
                Globals.followupProductValue = dataList[uuid + 2];
                if (dataList[uuid + 2] == "EXP" || dataList[uuid + 2] == "CAN" || dataList[uuid + 2] == "NEW")
                {
                    btnCreate.Enabled = false;
                    GeneratingProduct GeneratingProductForm = new GeneratingProduct();
                    GeneratingProductForm.Show();
                    await _parentForm.HarvestDataAutomaticallyFromWeb();
                    Globals.spcIssuanceGenerate();
                    Globals.startEditor = 1;
                    if (Globals.bringUpWorkstation == true)
                    {
                        TextEditor TextEditorForm = new TextEditor();
                        TextEditorForm.Show();
                    }
                    GeneratingProductForm.Close();
                    btnCreate.Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to load product update: {e}");
            }
        }

        private static readonly HttpClient client = new HttpClient();
        private async Task fetchVtecInformation()
        {
            Globals.nextVtec = "0000";
            string url = $"http://{Globals.serverip}/getvtecnumber/{Globals.username}/{Globals.password}/{Globals.officeId}.{warngenVtecIndex[Globals.spcSelection]}";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string jsonString = await response.Content.ReadAsStringAsync();
                using (JsonDocument doc = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = doc.RootElement;
                    if (root.TryGetProperty("status", out JsonElement statusElement) &&
                        statusElement.GetString() == "success")
                    {
                        if (root.TryGetProperty("vtec", out JsonElement statusElement2))
                        {
                            int vtecNumber = Convert.ToInt32($"{statusElement2}");
                            Globals.nextVtec = vtecNumber.ToString("D4");
                        }
                        else
                        {
                            MessageBox.Show("Failed to load vtec information");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to load vtec information");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load vtec information {ex}");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.stormMode = 1;
            rbMesoscale.Checked = true;
            cbUpdateList.Enabled = false;
            Globals.boxTrackType = 2;
            Globals.durationSelected = 2;
            Globals.warningSelected = 1;
            cbUpdateList.Enabled = false;
            ddDuration.SelectedIndex = Globals.durationSelected;
            Globals.warngenBullets = new List<string>();
            lbSelections.Items.Clear();
            foreach (var item in spcLayout) // REPLACE !!!!
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
            _parentForm.ResetWarningSystem();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            Globals.spcBullets = new List<string>();
            foreach (var item in lbSelections.SelectedItems)
            {
                string selectedText = item.ToString();
                Globals.spcBullets.Add(selectedText);
            }
            Globals.svsWarningType = warngenVtecIndex[Globals.spcSelection];
            btnCreate.Enabled = false;
            GeneratingProduct GeneratingProductForm = new GeneratingProduct();
            GeneratingProductForm.Show();
            await _parentForm.HarvestDataAutomaticallyFromWeb();
            await fetchVtecInformation();
            Globals.spcIssuanceGenerate(); /// REPLACE!!!
            Globals.startEditor = 1;
            if (Globals.bringUpWorkstation == true)
            {
                TextEditor TextEditorForm = new TextEditor();
                TextEditorForm.Show();
            }
            GeneratingProductForm.Close();
            btnCreate.Enabled = true;
        }

        private void rbTornadoWatch_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = false;
            Globals.spcSelection = 1;
            lbSelections.Items.Clear();
            foreach (var item in spcLayout)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private void rbSevereThunderstorm_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = false;
            Globals.spcSelection = 2;
            lbSelections.Items.Clear();
            foreach (var item in spcLayout)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private void rbWeatherWatch_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = true;
            Globals.spcSelection = 3;
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenSevereWeatherStatementSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
            fetchSevereWeatherStatementFollowups("wcnspc");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _parentForm.RecalculateTrackFromMarkers();
        }

        private void rbMesoscale_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = false;
            Globals.spcSelection = 0;
            lbSelections.Items.Clear();
            foreach (var item in spcLayout)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private void lbSelections_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.spcBullets = new List<string>();
            foreach (var item in lbSelections.SelectedItems)
            {
                string selectedText = item.ToString();
                Globals.spcBullets.Add(selectedText);
            }
        }

        private void gbProducts_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _parentForm.RecalculateTrackFromMarkers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUpdateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUpdateList.SelectedIndex > 1)
            {
                fetchSevereWeatherStatementProduct((cbUpdateList.SelectedIndex - 2) * 3);
            }
        }

        private void cbUpdateList_Click(object sender, EventArgs e)
        {
            fetchSevereWeatherStatementFollowups("wcnspc");
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }
    }
}