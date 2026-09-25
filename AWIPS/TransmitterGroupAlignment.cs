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
    public partial class TransmitterGroupAlignment : Form
    {
        private bool _isRunning = false;
        private List<string> dataList = new List<string>();
        private string lastDataPull = "";
        private List<string> dataList2 = new List<string>()
        {

        };
        private bool currentlyExecuting = false;
        private int selectedTransmitter = -1;
        private string transmitterMode = "D";
        public TransmitterGroupAlignment()
        {
            InitializeComponent();
            fetchTransmitters();
        }

        private static readonly HttpClient client = new HttpClient();
        private async void fetchTransmitters()
        {
            string url = $"http://{Globals.serverip}/gettransmitterstations/{Globals.username}/{Globals.password}";

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
                            dataList = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            lbTransmitterSelect.Items.Clear();
                            foreach (var item in dataList)
                            {
                                if (item is string textItem)
                                {
                                    lbTransmitterSelect.Items.Add(textItem);
                                }
                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to load transmitters");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to load transmitters");
            }
        }
        private async void fetchTransmittersContent()
        {
            btnMaintenance.Enabled = false;
            btnEnable.Enabled = false;
            btnDisable.Enabled = false;
            tbAlert.Enabled = false;
            tbSame.Enabled = false;
            tbAudio.Enabled = false;
            tb1800.Enabled = false;
            tb2400.Enabled = false;
            rbAudio.Enabled = false;
            rbSame.Enabled = false;
            rbAlert.Enabled = false;
            rb1800.Enabled = false;
            rb2400.Enabled = false;
            btnRunTest.Enabled = false;
            tbDuration.Enabled = false;
            btnAudioUp.Enabled = false;
            btnAudioDown.Enabled = false;
            btnSameUp.Enabled = false;
            btnSameDown.Enabled = false;
            btnAlertUp.Enabled = false;
            btnAlertDown.Enabled = false;
            btn1800Up.Enabled = false;
            btn1800Down.Enabled = false;
            btn2400Up.Enabled = false;
            btn2400Down.Enabled = false;
            btnDurationDown.Enabled = false;
            btnDurationUp.Enabled = false;
            btnSave.Enabled = false;
            lblAudioValue.Text = "";
            lblSameValue.Text = "";
            lblAlertValue.Text = "";
            lbl1800Value.Text = "";
            lbl2400Value.Text = "";
            lblDurationDisplay.Text = "10";
            tbDuration.Value = 10;
            lblTransmitterGroup.Text = "";
            currentlyExecuting = true;
            if (selectedTransmitter != -1)
            {
                string url = $"http://{Globals.serverip}/gettransmitteralignmentdata/{Globals.username}/{Globals.password}/{dataList[selectedTransmitter]}";
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
                                dataList2 = input.Split(new Char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                transmitterMode = dataList2[0];
                                tbAudio.Value = Convert.ToInt32(dataList2[1]);
                                tbSame.Value = Convert.ToInt32(dataList2[2]);
                                tbAlert.Value = Convert.ToInt32(dataList2[3]);
                                tb1800.Value = Convert.ToInt32(dataList2[4]);
                                tb2400.Value = Convert.ToInt32(dataList2[5]);
                                tbAlert.Enabled = true;
                                tbSame.Enabled = true;
                                tbAudio.Enabled = true;
                                tb1800.Enabled = true;
                                tb2400.Enabled = true;
                                btnAudioUp.Enabled = true;
                                btnAudioDown.Enabled = true;
                                btnSameUp.Enabled = true;
                                btnSameDown.Enabled = true;
                                btnAlertUp.Enabled = true;
                                btnAlertDown.Enabled = true;
                                btn1800Up.Enabled = true;
                                btn1800Down.Enabled = true;
                                btn2400Up.Enabled = true;
                                btn2400Down.Enabled = true;
                                btnSave.Enabled = true;
                                lblAudioValue.Text = $"{tbAudio.Value}%";
                                lblSameValue.Text = $"{tbSame.Value}%";
                                lblAlertValue.Text = $"{tbAlert.Value}%";
                                lbl1800Value.Text = $"{tb1800.Value}%";
                                lbl2400Value.Text = $"{tb2400.Value}%";
                                if (transmitterMode == "M")
                                {
                                    btnEnable.Enabled = true;
                                    btnDisable.Enabled = true;
                                    lblTransmitterGroup.Text = $"Transmitter Group {dataList[selectedTransmitter]} is MAINT";
                                    rbAudio.Enabled = true;
                                    rbSame.Enabled = true;
                                    rbAlert.Enabled = true;
                                    rb1800.Enabled = true;
                                    rb2400.Enabled = true;
                                    btnRunTest.Enabled = true;
                                    tbDuration.Enabled = true;
                                    btnDurationDown.Enabled = true;
                                    btnDurationUp.Enabled = true;
                                }
                                if (transmitterMode == "E")
                                {
                                    btnMaintenance.Enabled = true;
                                    btnDisable.Enabled = true;
                                    lblTransmitterGroup.Text = $"Transmitter Group {dataList[selectedTransmitter]} is ENABL";
                                }
                                if (transmitterMode == "D")
                                {
                                    btnMaintenance.Enabled = true;
                                    btnEnable.Enabled = true;
                                    lblTransmitterGroup.Text = $"Transmitter Group {dataList[selectedTransmitter]} is DISBL";
                                }

                            }
                            else
                            {
                                MessageBox.Show("Failed to load alignment data");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to load alignment data");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to load alignment data");
                }
            }
            currentlyExecuting = false;
        }

        private async void saveTransmitterContent()
        {
            btnSave.Enabled = false;
            currentlyExecuting = true;
            if (selectedTransmitter != -1)
            {
                string url = $"http://{Globals.serverip}/savetransmitteralignment/{Globals.username}/{Globals.password}/{dataList[selectedTransmitter]}/{tbAudio.Value}/{tbSame.Value}/{tbAlert.Value}/{tb1800.Value}/{tb2400.Value}";
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
                            
                        }
                        else
                        {
                            MessageBox.Show("Failed to save volume");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to save volume");
                }
            }
            currentlyExecuting = false;
            btnSave.Enabled = true;
        }

        private async void updateTransmitterStatus(string status)
        {
            btnSave.Enabled = false;
            currentlyExecuting = true;
            if (selectedTransmitter != -1)
            {
                string url = $"http://{Globals.serverip}/updatetransmitterstatus/{Globals.username}/{Globals.password}/{dataList[selectedTransmitter]}/{status}";
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

                        }
                        else
                        {
                            MessageBox.Show("Failed to update status");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to update status");
                }
            }
            currentlyExecuting = false;
            btnSave.Enabled = true;
        }

        private async void runTest()
        {
            btnRunTest.Enabled = false;
            currentlyExecuting = true;
            int levelTestType = 0;
            if (rbAudio.Checked)
            {
                levelTestType = 0;
            }
            else if (rbSame.Checked)
            {
                levelTestType = 1;
            }
            else if (rbAlert.Checked)
            {
                levelTestType = 2;
            }
            else if (rb1800.Checked)
            {
                levelTestType = 3;
            }
            else if (rb2400.Checked)
            {
                levelTestType = 4;
            }

            if (selectedTransmitter != -1)
            {
                string url = $"http://{Globals.serverip}/transmitterleveltest/{Globals.username}/{Globals.password}/{dataList[selectedTransmitter]}/{levelTestType}/{tbDuration.Value}";
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
                            MessageBox.Show($"Test is now running on {dataList[selectedTransmitter]}");
                        }
                        else
                        {
                            MessageBox.Show("Failed to run test");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to run test");
                }
            }
            currentlyExecuting = false;
            btnRunTest.Enabled = true;
        }

        private void lbTransmitterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTransmitterSelect.SelectedIndex != selectedTransmitter)
            {
                selectedTransmitter = lbTransmitterSelect.SelectedIndex;
                fetchTransmittersContent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateTransmitterStatus("D");
            fetchTransmittersContent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblSameValue.Text = $"{tbSame.Value}%";
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            lbl1800Value.Text = $"{tb1800.Value}%";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb2400.Value < 100)
            {
                tb2400.Value++;
            }
            lbl2400Value.Text = $"{tb2400.Value}%";
        }

        private void TransmitterGroupAlignment_Load(object sender, EventArgs e)
        {

        }

        private void btnSameUp_Click(object sender, EventArgs e)
        {
            if (tbSame.Value < 100)
            {
                tbSame.Value++;
            }
            lblSameValue.Text = $"{tbSame.Value}%";
        }

        private void btnAudioUp_Click(object sender, EventArgs e)
        {
            if (tbAudio.Value < 100)
            {
                tbAudio.Value++;
            }
            lblAudioValue.Text = $"{tbAudio.Value}%";
        }

        private void btnSameDown_Click(object sender, EventArgs e)
        {
            if (tbSame.Value > 0)
            {
                tbSame.Value -= 1;
            }
            lblSameValue.Text = $"{tbSame.Value}%";
        }

        private void btnAudioDown_Click(object sender, EventArgs e)
        {
            if (tbAudio.Value > 0)
            {
                tbAudio.Value -= 1;
            }
            lblAudioValue.Text = $"{tbAudio.Value}%";
        }

        private void btnAlertDown_Click(object sender, EventArgs e)
        {
            if (tbAlert.Value > 0)
            {
                tbAlert.Value -= 1;
            }
            lblAlertValue.Text = $"{tbAlert.Value}%";
        }

        private void btnAlertUp_Click(object sender, EventArgs e)
        {
            if (tbAlert.Value < 100)
            {
                tbAlert.Value++;
            }
            lblAlertValue.Text = $"{tbAlert.Value}%";
        }

        private void btn1800Down_Click(object sender, EventArgs e)
        {
            if (tb1800.Value > 0)
            {
                tb1800.Value -= 1;
            }
            lbl1800Value.Text = $"{tb1800.Value}%";
        }

        private void btn1800Up_Click(object sender, EventArgs e)
        {
            if (tb1800.Value < 100)
            {
                tb1800.Value++;
            }
            lbl1800Value.Text = $"{tb1800.Value}%";
        }

        private void btn2400Down_Click(object sender, EventArgs e)
        {
            if (tb2400.Value > 0)
            {
                tb2400.Value -= 1;
            }
            lbl2400Value.Text = $"{tb2400.Value}%";
        }

        private void tbAudio_Scroll(object sender, EventArgs e)
        {
            lblAudioValue.Text = $"{tbAudio.Value}%";
        }

        private void tbDuration_Scroll(object sender, EventArgs e)
        {
            lblDurationDisplay.Text = $"{tbDuration.Value}";
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void lbl2400Value_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbTransmitterSelect.SelectedIndex = -1;
            selectedTransmitter = -1;
            dataList2 = null;
            lastDataPull = null;
            btnMaintenance.Enabled = false;
            btnEnable.Enabled = false;
            btnDisable.Enabled = false;
            tbAlert.Enabled = false;
            tbSame.Enabled = false;
            tbAudio.Enabled = false;
            tb1800.Enabled = false;
            tb2400.Enabled = false;
            rbAudio.Enabled = false;
            rbSame.Enabled = false;
            rbAlert.Enabled = false;
            rb1800.Enabled = false;
            rb2400.Enabled = false;
            tbDuration.Enabled = false;
            btnAudioUp.Enabled = false;
            btnAudioDown.Enabled = false;
            btnSameUp.Enabled = false;
            btnSameDown.Enabled = false;
            btnAlertUp.Enabled = false;
            btnAlertDown.Enabled = false;
            btn1800Up.Enabled = false;
            btn1800Down.Enabled = false;
            btn2400Up.Enabled = false;
            btn2400Down.Enabled = false;
            btnSave.Enabled = false;
            btnRunTest.Enabled = false;
            btnDurationDown.Enabled = false;
            btnDurationUp.Enabled = false;
            lblAudioValue.Text = "";
            lblSameValue.Text = "";
            lblAlertValue.Text = "";
            lbl1800Value.Text = "";
            lbl2400Value.Text = "";
            lblDurationDisplay.Text = "10";
            tbDuration.Value = 10;
            lblTransmitterGroup.Text = "";
            fetchTransmitters();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveTransmitterContent();
        }

        private void lblAudioValue_Click(object sender, EventArgs e)
        {

        }

        private void tbAlert_Scroll(object sender, EventArgs e)
        {
            lblAlertValue.Text = $"{tbAlert.Value}%";
        }

        private void tb2400_Scroll(object sender, EventArgs e)
        {
            lbl2400Value.Text = $"{tb2400.Value}%";
        }

        private void gbTransmitterGroupVolume_Enter(object sender, EventArgs e)
        {

        }

        private void btnDurationDown_Click(object sender, EventArgs e)
        {
            if (tbDuration.Value > 0)
            {
                tbDuration.Value -= 1;
            }
            lblDurationDisplay.Text = $"{tbDuration.Value}";
        }

        private void btnDurationUp_Click(object sender, EventArgs e)
        {
            if (tbDuration.Value < 30)
            {
                tbDuration.Value++;
            }
            lblDurationDisplay.Text = $"{tbDuration.Value}";
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            updateTransmitterStatus("M");
            fetchTransmittersContent();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            updateTransmitterStatus("E");
            fetchTransmittersContent();
        }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            runTest();
        }
    }
}
