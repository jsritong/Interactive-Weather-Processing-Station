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
    public partial class WarnGen : Form
    {
        private AWIPSForm _parentForm;
        private List<string> warngenVtecIndex = new List<string>(){
            "TO.W","SV.W","","","FF.W","FF.W","FF.W","FF.W","FA.W","FA.W","FA.Y","FA.Y"
        };
        private List<string> dataList = new List<string>();
        public WarnGen(AWIPSForm parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
            lblInstructions.Text = "Drag point to storm location";
            rdoSingleStm.Checked = true;
            rdoBoxTrack.Checked = true;
            rdoSevereTstm.Checked = true;
            Globals.stormMode = 0;
            Globals.boxTrackType = 2;
            Globals.durationSelected = 2;
            Globals.warningSelected = 1;
            cbUpdateList.Enabled = false;
            ddDuration.SelectedIndex = Globals.durationSelected;
            ddOther.SelectedIndex = 0;
            Globals.warngenBullets = new List<string>();
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenSevereThunderstormSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
            DateTimeOffset now = DateTimeOffset.Now;
            string currentPart = now.ToString("HH:mm ddd d-MMM");
            DateTimeOffset futureDateTime = now.AddMinutes(Globals.warngenDurationsList[Globals.durationSelected]);
            string futureTime = futureDateTime.ToString("HH:mm ddd d-MMM");
            lblDuration.Text = currentPart + " to " + futureTime;
            _parentForm.ResetWarningSystem();
        }
        private static readonly HttpClient client = new HttpClient();
        private async Task fetchVtecInformation()
        {
            Globals.nextVtec = "0000";
            string url = $"http://{Globals.serverip}/getvtecnumber/{Globals.username}/{Globals.password}/{Globals.officeId}.{warngenVtecIndex[Globals.warningSelected]}";
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
                                cbUpdateList.Items.Add(dataList[i+1]);
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
                            if ((Globals.warningSelected == 5 || Globals.warningSelected == 7 || Globals.warningSelected == 9 || Globals.warningSelected == 11) && dataList[uuid + 2] == "EXT")
                            {
                                Globals.expTimeSvs = 0;
                            }
                            if (dataList[uuid + 2] == "CAN" || dataList[uuid + 2] == "EXP")
                            {
                                Globals.expTimeSvs = -1;
                                Globals.expTimeSvs2 = Convert.ToInt32($"{statusElement5}");
                            }
                            // MessageBox.Show($"expTimeSvs: {Globals.expTimeSvs}");
                        }
                        if (root.TryGetProperty("vteccurrent", out JsonElement statusElement7))
                        {
                            Globals.nextVtecForContinuations = Convert.ToInt32($"{statusElement7}").ToString("D4");
                        }
                        if (root.TryGetProperty("type", out JsonElement statusElement6))
                        {
                            Globals.svsWarningType = Convert.ToString(statusElement6);
                            if (Convert.ToString(statusElement6) == "SV.W")
                            {
                                lbSelections.Items.Clear();
                                foreach (var item in Globals.warngenSevereThunderstormSelections)
                                {
                                    if (item is string textItem)
                                    {
                                        lbSelections.Items.Add(textItem);
                                    }
                                }
                            }
                            else if (Convert.ToString(statusElement6) == "TO.W")
                            {
                                lbSelections.Items.Clear();
                                foreach (var item in Globals.warngenTornadoSelections)
                                {
                                    if (item is string textItem)
                                    {
                                        lbSelections.Items.Add(textItem);
                                    }
                                }
                            }
                            else if (Convert.ToString(statusElement6) == "FF.W")
                            {
                                if (Globals.warningSelected == 7)
                                {
                                    lbSelections.Items.Clear();
                                    foreach (var item in Globals.nonConvectiveFlashFloodWarningSelections)
                                    {
                                        if (item is string textItem)
                                        {
                                            lbSelections.Items.Add(textItem);
                                        }
                                    }
                                }
                                else
                                {
                                    lbSelections.Items.Clear();
                                    foreach (var item in Globals.warngenFlashFloodWarningSelections)
                                    {
                                        if (item is string textItem)
                                        {
                                            lbSelections.Items.Add(textItem);
                                        }
                                    }
                                }
                            }
                            else if (Convert.ToString(statusElement6) == "FA.W")
                            {
                                lbSelections.Items.Clear();
                                foreach (var item in Globals.arealFloodWarningSelections)
                                {
                                    if (item is string textItem)
                                    {
                                        lbSelections.Items.Add(textItem);
                                    }
                                }
                            }
                            else if (Convert.ToString(statusElement6) == "FA.Y")
                            {
                                lbSelections.Items.Clear();
                                foreach (var item in Globals.floodAdvisorySelections)
                                {
                                    if (item is string textItem)
                                    {
                                        lbSelections.Items.Add(textItem);
                                    }
                                }
                            }
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
                if (dataList[uuid+2] == "EXP" || dataList[uuid + 2] == "CAN")
                {
                    btnCreate.Enabled = false;
                    GeneratingProduct GeneratingProductForm = new GeneratingProduct();
                    GeneratingProductForm.Show();
                    await _parentForm.HarvestDataAutomaticallyFromWeb();
                    await fetchVtecInformation();
                    Globals.warngenGenerate();
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

        private void button1_Click(object sender, EventArgs e)
        {
            lblInstructions.Text = "Drag point to storm location";
            rdoSingleStm.Checked = true;
            rdoBoxTrack.Checked = true;
            rdoSevereTstm.Checked = true;
            cbUpdateList.Enabled = false;
            Globals.stormMode = 0;
            Globals.boxTrackType = 2;
            Globals.durationSelected = 2;
            Globals.warningSelected = 1;
            cbUpdateList.Enabled = false;
            ddDuration.SelectedIndex = Globals.durationSelected;
            ddOther.SelectedIndex = 0;
            Globals.warngenBullets = new List<string>();
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenSevereThunderstormSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
            _parentForm.ResetWarningSystem();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (Globals.warningSelected == 2 || Globals.warningSelected == 5 || Globals.warningSelected == 7 || Globals.warningSelected == 9 || Globals.warningSelected == 11)
            {

            }
            else
            {
                Globals.uuidStore = "";
            }
            btnCreate.Enabled = false;
            GeneratingProduct GeneratingProductForm = new GeneratingProduct();
            GeneratingProductForm.Show();
            await _parentForm.HarvestDataAutomaticallyFromWeb();
            await fetchVtecInformation();
            Globals.warngenGenerate();
            Globals.startEditor = 1;
            if (Globals.bringUpWorkstation == true)
            {
                TextEditor TextEditorForm = new TextEditor();
                TextEditorForm.Show();
            }
            GeneratingProductForm.Close();
            btnCreate.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            Globals.boxTrackType = 2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ddOther_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdoOther.Checked)
            {
                Globals.warningSelected = ddOther.SelectedIndex + 5;
                if (Globals.warningSelected == 5 || Globals.warningSelected == 7)
                {
                    cbUpdateList.Enabled = true;
                    lbSelections.Items.Clear();
                    foreach (var item in Globals.warngenSevereWeatherStatementSelections)
                    {
                        if (item is string textItem)
                        {
                            lbSelections.Items.Add(textItem);
                        }
                    }
                    fetchSevereWeatherStatementFollowups("ffs");
                }
                else if (Globals.warningSelected == 9)
                {
                    cbUpdateList.Enabled = true;
                    lbSelections.Items.Clear();
                    foreach (var item in Globals.warngenSevereWeatherStatementSelections)
                    {
                        if (item is string textItem)
                        {
                            lbSelections.Items.Add(textItem);
                        }
                    }
                    fetchSevereWeatherStatementFollowups("fls");
                }
                else if (Globals.warningSelected == 11)
                {
                    cbUpdateList.Enabled = true;
                    lbSelections.Items.Clear();
                    foreach (var item in Globals.warngenSevereWeatherStatementSelections)
                    {
                        if (item is string textItem)
                        {
                            lbSelections.Items.Add(textItem);
                        }
                    }
                    fetchSevereWeatherStatementFollowups("flsy");
                }
                else if (Globals.warningSelected == 6)
                {
                    cbUpdateList.Enabled = false;
                    lbSelections.Items.Clear();
                    foreach (var item in Globals.nonConvectiveFlashFloodWarningSelections)
                    {
                        if (item is string textItem)
                        {
                            lbSelections.Items.Add(textItem);
                        }
                    }
                }
                else if (Globals.warningSelected == 8)
                {
                    cbUpdateList.Enabled = false;
                    lbSelections.Items.Clear();
                    foreach (var item in Globals.arealFloodWarningSelections)
                    {
                        if (item is string textItem)
                        {
                            lbSelections.Items.Add(textItem);
                        }
                    }
                }
                else if (Globals.warningSelected == 10)
                {
                    cbUpdateList.Enabled = false;
                    lbSelections.Items.Clear();
                    foreach (var item in Globals.floodAdvisorySelections)
                    {
                        if (item is string textItem)
                        {
                            lbSelections.Items.Add(textItem);
                        }
                    }
                }
                else
                {
                    cbUpdateList.Enabled = false;
                    lbSelections.Items.Clear();
                }
            }
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            Globals.warningSelected = ddOther.SelectedIndex + 5;
            if (Globals.warningSelected == 5 || Globals.warningSelected == 7)
            {
                cbUpdateList.Enabled = true;
                lbSelections.Items.Clear();
                foreach (var item in Globals.warngenSevereWeatherStatementSelections)
                {
                    if (item is string textItem)
                    {
                        lbSelections.Items.Add(textItem);
                    }
                }
                fetchSevereWeatherStatementFollowups("ffs");
            }
            else if (Globals.warningSelected == 9)
            {
                cbUpdateList.Enabled = true;
                lbSelections.Items.Clear();
                foreach (var item in Globals.warngenSevereWeatherStatementSelections)
                {
                    if (item is string textItem)
                    {
                        lbSelections.Items.Add(textItem);
                    }
                }
                fetchSevereWeatherStatementFollowups("fls");
            }
            else if (Globals.warningSelected == 6)
            {
                cbUpdateList.Enabled = false;
                lbSelections.Items.Clear();
                foreach (var item in Globals.nonConvectiveFlashFloodWarningSelections)
                {
                    if (item is string textItem)
                    {
                        lbSelections.Items.Add(textItem);
                    }
                }
            }
            else if (Globals.warningSelected == 8)
            {
                cbUpdateList.Enabled = false;
                lbSelections.Items.Clear();
                foreach (var item in Globals.arealFloodWarningSelections)
                {
                    if (item is string textItem)
                    {
                        lbSelections.Items.Add(textItem);
                    }
                }
            }
            else if (Globals.warningSelected == 10)
            {
                cbUpdateList.Enabled = false;
                lbSelections.Items.Clear();
                foreach (var item in Globals.floodAdvisorySelections)
                {
                    if (item is string textItem)
                    {
                        lbSelections.Items.Add(textItem);
                    }
                }
            }
            else
            {
                cbUpdateList.Enabled = false;
                lbSelections.Items.Clear();
            }
        }

        private void rdoSevereTstm_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = false;
            Globals.warningSelected = 1;
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenSevereThunderstormSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private void rdoTornado_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = false;
            Globals.warningSelected = 0;
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenTornadoSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private void rdoSevereWx_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = true;
            Globals.warningSelected = 2;
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenSevereWeatherStatementSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
            fetchSevereWeatherStatementFollowups("svs");
        }

        private void rdoSpecialWx_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = false;
            Globals.warningSelected = 3;
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenSpecialWeatherStatementSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private void rdoFlashFlood_CheckedChanged(object sender, EventArgs e)
        {
            cbUpdateList.Enabled = false;
            Globals.warningSelected = 4;
            lbSelections.Items.Clear();
            foreach (var item in Globals.warngenFlashFloodWarningSelections)
            {
                if (item is string textItem)
                {
                    lbSelections.Items.Add(textItem);
                }
            }
        }

        private void rdoSingleStm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSevereWx.Checked)
            {

            }
            else
            {
                Globals.stormMode = 0;
                _parentForm.ResetWarningSystem();
            }
        }

        private void rdoLineStm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSevereWx.Checked)
            {

            }
            else
            {
                Globals.stormMode = 1;
                _parentForm.ResetWarningSystem();
            }
        }

        private void rdoBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.boxTrackType = 0;
        }

        private void rdoTrack_CheckedChanged(object sender, EventArgs e)
        {
            Globals.boxTrackType = 1;
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

        private void lbSelections_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.warngenBullets = new List<string>();
            foreach (var item in lbSelections.SelectedItems)
            {
                string selectedText = item.ToString();
                Globals.warngenBullets.Add(selectedText);
            }
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (rdoSevereWx.Checked || Globals.warningSelected == 5 || Globals.warningSelected == 7 || Globals.warningSelected == 9 || Globals.warningSelected == 11)
            {
                
            }
            else
            {
                _parentForm.RecalculateTrackFromMarkers();
            }
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void cbUpdateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUpdateList.SelectedIndex == 1)
            {
                if (Globals.warningSelected == 2)
                {
                    fetchSevereWeatherStatementFollowups("svs");
                }
                if (Globals.warningSelected == 5 || Globals.warningSelected == 7)
                {
                    fetchSevereWeatherStatementFollowups("ffs");
                }
                if (Globals.warningSelected == 9)
                {
                    fetchSevereWeatherStatementFollowups("fls");
                }
                if (Globals.warningSelected == 11)
                {
                    fetchSevereWeatherStatementFollowups("flsy");
                }
                lbSelections.Items.Clear();
                foreach (var item in Globals.warngenSevereWeatherStatementSelections)
                {
                    if (item is string textItem)
                    {
                        lbSelections.Items.Add(textItem);
                    }
                }
            }
            else if (cbUpdateList.SelectedIndex > 1)
            {
                fetchSevereWeatherStatementProduct((cbUpdateList.SelectedIndex - 2)*3);
            }
            else
            {
                lbSelections.Items.Clear();
                foreach (var item in Globals.warngenSevereWeatherStatementSelections)
                {
                    if (item is string textItem)
                    {
                        lbSelections.Items.Add(textItem);
                    }
                }
            }
        }

        private void boxProductType_Enter(object sender, EventArgs e)
        {

        }

        private void cbUpdateList_Click(object sender, EventArgs e)
        {
            if (Globals.warningSelected == 2)
            {
                fetchSevereWeatherStatementFollowups("svs");
            }
            if (Globals.warningSelected == 5 || Globals.warningSelected == 7)
            {
                fetchSevereWeatherStatementFollowups("ffs");
            }
            if (Globals.warningSelected == 9)
            {
                fetchSevereWeatherStatementFollowups("fls");
            }
            if (Globals.warningSelected == 11)
            {
                fetchSevereWeatherStatementFollowups("flsy");
            }
        }
    }
}