using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWIPS
{
    public partial class BMHMenu : Form
    {
        private bool _isRunning = false;
        private List<string> dataList = new List<string>();
        private string lastDataPull = "";
        private List<string> dataList2 = new List<string>()
        {

        };
        private bool currentlyExecuting = false;
        private int selectedTransmitter = -1;
        public BMHMenu()
        {
            InitializeComponent();
            dgvTransmitter.EnableHeadersVisualStyles = false;
            dgvTransmitter.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvTransmitter.ColumnHeadersDefaultCellStyle.BackColor;
            dgvTransmitter.DefaultCellStyle.SelectionBackColor = dgvTransmitter.DefaultCellStyle.BackColor;
            dgvTransmitter.DefaultCellStyle.SelectionForeColor = dgvTransmitter.DefaultCellStyle.ForeColor;
            dgvTransmitter.RowHeadersDefaultCellStyle.SelectionBackColor = dgvTransmitter.RowHeadersDefaultCellStyle.BackColor;
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
            currentlyExecuting = true;
            if (selectedTransmitter != -1)
            {
                if (lbTransmitter.Text == "Transmitter:  ")
                {
                    lbTransmitter.Text = "Transmitter:  REQUESTING INFORMATION...PLEASE WAIT";
                }
                string url = $"http://{Globals.serverip}/getbroadcastcycle/{Globals.username}/{Globals.password}/{dataList[selectedTransmitter]}";
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
                                int currentRow = 0;
                                dataList2 = input.Split(new Char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                if (lastDataPull != input)
                                {
                                    lbTransmitter.Text = $"Transmitter:  {dataList2[0]}";
                                    lbTimezone.Text = $"Timezone:  {dataList2[1]}";
                                    lbDAC.Text = $"DAC:  {dataList2[2]}";
                                    lblPort.Text = $"Port #:  {dataList2[3]}";
                                    lblProgram.Text = $"{dataList2[4]}";
                                    lblSuite.Text = $"{dataList2[5]}";
                                    lblSuiteCategory.Text = $"{dataList2[6]}";
                                    lblCycleDuration.Text = $"Cycle Duration:  {dataList2[7]}";
                                    this.dgvTransmitter.SuspendLayout();
                                    int selectedRowIndex = -1;
                                    if (dgvTransmitter.CurrentRow != null)
                                    {
                                        selectedRowIndex = dgvTransmitter.CurrentRow.Index;
                                    }
                                    dgvTransmitter.Rows.Clear();
                                    for (int i = 8; i < dataList2.Count; i += 15)
                                    {
                                        string playingRightNow = "";
                                        if (dataList2[i + 1] == "1")
                                        {
                                            playingRightNow = "▶";
                                        }
                                        string samePlayout = "";
                                        if (dataList2[i + 10] == "1")
                                        {
                                            samePlayout = "ALERT";
                                        }
                                        else if (dataList2[i + 10] == "0")
                                        {
                                            samePlayout = "NONE";
                                        }
                                        string alertPlayout = "";
                                        if (dataList2[i + 11] == "1")
                                        {
                                            alertPlayout = "ALERT";
                                        }
                                        else if (dataList2[i + 11] == "0")
                                        {
                                            alertPlayout = "NONE";
                                        }
                                        try
                                        {
                                            dgvTransmitter.Rows.Add($"{dataList2[i]}", $"{playingRightNow}", $"{dataList2[i + 3]}", $"{dataList2[i + 5]}", $"{dataList2[i + 6]}", $"{dataList2[i + 7]}", $"{dataList2[i + 8]}", $"{dataList2[i + 9]}", $"{samePlayout}", $"{alertPlayout}", $"{dataList2[i + 12]}");
                                            if (dataList2[i + 2] == "0")
                                            {
                                                dgvTransmitter.Rows[currentRow].Cells[2].Style.BackColor = Color.FromArgb(178, 220, 94);
                                            }
                                            else if (dataList2[i + 2] == "1")
                                            {
                                                dgvTransmitter.Rows[currentRow].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 152);
                                            }
                                            if (dataList2[i + 4] == "1")
                                            {
                                                dgvTransmitter.Rows[currentRow].Cells[3].Style.BackColor = Color.FromArgb(216, 84, 80);
                                            }
                                            else if (dataList2[i + 4] == "2")
                                            {
                                                dgvTransmitter.Rows[currentRow].Cells[3].Style.BackColor = Color.FromArgb(107, 107, 52);
                                            }
                                            else if (dataList2[i + 4] == "3")
                                            {
                                                dgvTransmitter.Rows[currentRow].Cells[3].Style.BackColor = Color.FromArgb(45, 169, 193);
                                            }
                                            currentRow++;
                                        }
                                        catch
                                        {

                                        }
                                        
                                    }
                                    dgvTransmitter.Rows[0].Height = 10;
                                    if (selectedRowIndex >= 0 && selectedRowIndex < dgvTransmitter.Rows.Count)
                                    {
                                        dgvTransmitter.ClearSelection();
                                        dgvTransmitter.CurrentCell = dgvTransmitter.Rows[selectedRowIndex].Cells[0];
                                        dgvTransmitter.Rows[selectedRowIndex].Selected = true;
                                        tbMessageText.Text = dataList2[(selectedRowIndex * 15) + 22];
                                    }
                                    this.dgvTransmitter.ResumeLayout();
                                }
                                lastDataPull = input;
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            // MessageBox.Show("Failed to load transmitters");
                        }
                    }
                }
                catch
                {
                    //  MessageBox.Show("Failed to load transmitters");
                }
            }
            currentlyExecuting = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BMHMenu_Load(object sender, EventArgs e)
        {

        }

        private void dgvTransmitTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbTransmitterGroup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbTransmitTime_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvTransmitter.CurrentRow.Index;
            if (rowIndex > 0)
            {
                btnMessageDetails.Enabled = true;
            }
            else
            {
                btnMessageDetails.Enabled = false;
            }
            tbMessageText.Text = dataList2[(rowIndex * 15) + 22];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dgvTransmitter.CurrentRow.Index;
            MessageBox.Show($"Transmit Time: {dataList2[(rowIndex * 15) + 8 + 3]}{Environment.NewLine}Expiration Time: {dataList2[(rowIndex * 15) + 8 + 9]}{Environment.NewLine}{Environment.NewLine}Message Id: {dataList2[(rowIndex * 15) + 8 + 5]}{Environment.NewLine}Message Title: {dataList2[(rowIndex * 15) + 8 + 6]}{Environment.NewLine}Message Name: {dataList2[(rowIndex * 15) + 8 + 7]}{Environment.NewLine}MRD: {dataList2[(rowIndex * 15) + 8 + 8]}{Environment.NewLine}Play Count: {dataList2[(rowIndex * 15) + 8 + 12]}{Environment.NewLine}{Environment.NewLine}SAME Header: {dataList2[(rowIndex * 15) + 8 + 13]}", "Message Details");
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblMRDMATReplace_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbTransmitterSelect.SelectedIndex = -1;
            selectedTransmitter = -1;
            dataList2 = null;
            lastDataPull = null;
            lbTransmitter.Text = "Transmitter:  ";
            lbTimezone.Text = "Timezone:  ";
            lbDAC.Text = "DAC:  ";
            lblPort.Text = "Port #:  ";
            lblProgram.Text = "";
            lblSuite.Text = "";
            lblSuiteCategory.Text = "";
            lblCycleDuration.Text = "Cycle Duration:  ";
            tbMessageText.Text = "";
            btnMessageDetails.Enabled = false;
            dgvTransmitter.Rows.Clear();
            fetchTransmitters();
        }

        private async void lbTransmitterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTransmitter = lbTransmitterSelect.SelectedIndex;
            if (_isRunning) {
                if (currentlyExecuting == false)
                {
                    fetchTransmittersContent();
                }
            }
            else
            {
                _isRunning = true;
                await Task.Run(() => RunIndefinitely());
            }
            
        }

        private void RunIndefinitely()
        {
            while (_isRunning)
            {
                PerformBackgroundWork();
                Thread.Sleep(1000);
            }
        }
        private void PerformBackgroundWork()
        {
            if (selectedTransmitter != -1)
            {
                if (currentlyExecuting == false)
                {
                    fetchTransmittersContent();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _isRunning = false;
        }

        private void lblPort_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbProgramSuite_Enter(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTransmitterSelect.SelectedIndex = -1;
            selectedTransmitter = -1;
            dataList2 = null;
            lastDataPull = null;
            lbTransmitter.Text = "Transmitter:  ";
            lbTimezone.Text = "Timezone:  ";
            lbDAC.Text = "DAC:  ";
            lblPort.Text = "Port #:  ";
            lblProgram.Text = "";
            lblSuite.Text = "";
            lblSuiteCategory.Text = "";
            lblCycleDuration.Text = "Cycle Duration:  ";
            tbMessageText.Text = "";
            btnMessageDetails.Enabled = false;
            dgvTransmitter.Rows.Clear();
            fetchTransmitters();
        }
    }
}