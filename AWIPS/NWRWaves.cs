using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AWIPS
{
    public partial class NWRWaves : Form
    {
        private List<string> dataList = new List<string>();
        private List<string> dataList2  = new List<string>();
        public NWRWaves()
        {
            InitializeComponent();
            fetchProducts();
        }
        private string deleteUuidStore = "";
        private static readonly HttpClient client = new HttpClient();
        private async void fetchProducts()
        {
            string url = $"http://{Globals.serverip}/getfulldatabaseserver/{Globals.username}/{Globals.password}";
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
                            lbDateTime.Text = DateTimeOffset.UtcNow.ToString("yyyy-MM-dd HH:mm:ss 'UTC'");
                            string input = Convert.ToString(statusElement2);
                            dataList = new List<string>();
                            dataList2 = input.Split(new char[] { '|' }, StringSplitOptions.None).ToList();
                            lbSent.Items.Clear();
                            string productId;
                            string officeId;
                            string versionNumber;
                            DateTimeOffset now = DateTimeOffset.Now;
                            if (input != "")
                            {
                                for (int i = 0; i < dataList2.Count; i += 9)
                                {
                                    DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt32(dataList2[i + 6]));
                                    DateTimeOffset dateTimeEnd = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt32(dataList2[i + 7]));
                                    productId = dataList2[i + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[5];
                                    officeId = dataList2[i + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[1];
                                    versionNumber = dataList2[i + 4];
                                    if (Convert.ToInt32(dataList2[i + 7]) != 0 || chkHideIndefinite.Checked)
                                    {
                                        if (Convert.ToInt32(dataList2[i + 7]) == 0)
                                        {
                                            lbSent.Items.Add($"{officeId} {productId} issued: {dateTime.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss")} - ends: indefinite - MRD: {versionNumber}");
                                        }
                                        else
                                        {
                                            lbSent.Items.Add($"{officeId} {productId} issued: {dateTime.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss")} - ends: {dateTimeEnd.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss")} - MRD: {versionNumber}");
                                        }
                                        for (int b = 0; b < 9; b++)
                                        {
                                            dataList.Add(dataList2[i+b].ToString());
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to load products","Failed to load products",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to load products", "Failed to load products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load products: {ex}", "Failed to load products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteProducts()
        {
            string url = $"http://{Globals.serverip}/deleteproduct/{Globals.username}/{Globals.password}/{deleteUuidStore}";
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
                        MessageBox.Show("Failed to delete product");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to delete product");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSent.SelectedIndex > -1)
            {
                btnView.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void NWRWaves_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTimeOffset now = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 6]));
                int mrd = -1;
                try
                {
                    mrd = Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 4]);
                }
                catch
                {

                }
                string timePart = now.ToString("hmm tt");
                string tz = now.Offset.TotalHours == -4 ? "EDT" : "EST";
                string datePart = now.ToString("ddd MMM d yyyy");
                Globals.dateTimeStamp = $"{timePart} {tz} {datePart}";
                Globals.startEditor = 0;
                Globals.TTAAii = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[0];
                Globals.CCCC = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[1];
                Globals.BBB = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[2];
                Globals.BBBver = Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[3]);
                try
                {
                    if (mrd != -1)
                    {
                        Globals.BBB = $"RR";
                        Globals.BBBver = mrd + 1;
                    }
                }
                catch
                {

                }
                Globals.WSFOid = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[4];
                Globals.productCategory = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[5];
                Globals.productDesignator = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[6];
                Globals.productOriginator = Globals.orgList.IndexOf(dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[7]);
                Globals.vtecHeader = dataList[(lbSent.SelectedIndex * 9) + 3];
                Globals.countiesAffected = "";
                string countyCodesAffected = dataList[(lbSent.SelectedIndex * 9) + 5];
                List<string> countyList = countyCodesAffected.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string county in countyList)
                {
                    Globals.countiesAffected += $"{county.Substring(1, 5)}-";
                }
                if (Globals.countiesAffected == "")
                {
                    Globals.countiesAffected = "-";
                }
                string unencodedResult = dataList[(lbSent.SelectedIndex * 9) + 8].Replace("%0A", Environment.NewLine);
                string rawText = Uri.UnescapeDataString(unencodedResult);
                Globals.tbPrimaryTextWorkstation = rawText;
                int firstBreak = rawText.IndexOf(Environment.NewLine);
                int secondBreak = rawText.IndexOf(Environment.NewLine, firstBreak + Environment.NewLine.Length);
                Globals.productText = rawText.Substring(secondBreak + Environment.NewLine.Length);
                Globals.uuidStore = dataList[lbSent.SelectedIndex * 9];
                Globals.endUnixTimestamp = Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 7]);
                Globals.SAMETonage = false;
                Globals.Tonage1050 = false;
                Globals.Interrupt = false;
                Globals.Repeat = false;
                string broadcastCode = dataList[(lbSent.SelectedIndex * 9) + 2];
                if (broadcastCode[0] == Convert.ToChar("T"))
                {
                    Globals.SAMETonage = true;
                }
                if (broadcastCode[1] == Convert.ToChar("T"))
                {
                    Globals.Tonage1050 = true;
                }
                if (broadcastCode[2] == Convert.ToChar("I"))
                {
                    Globals.Repeat = true;
                }
                if (broadcastCode[3] == Convert.ToChar("S"))
                {
                    Globals.Interrupt = true;
                }
                TextEditor TextEditorForm = new TextEditor();
                TextEditorForm.Show();
            }
            catch
            {
                Globals.startEditor = 0;
                Globals.TTAAii = "";
                Globals.CCCC = "";
                Globals.BBB = "";
                Globals.BBBver = 0;
                Globals.WSFOid = "";
                Globals.productCategory = "";
                Globals.productDesignator = "";
                Globals.productOriginator = 0;
                Globals.vtecHeader = "";
                Globals.countiesAffected = "";
                Globals.productText = "";
                Globals.uuidStore = "";
                Globals.endUnixTimestamp = 0;
                Globals.SAMETonage = false;
                Globals.Tonage1050 = false;
                Globals.Interrupt = false;
                Globals.Repeat = false;
                MessageBox.Show("Cannot edit product");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            fetchProducts();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string unencodedResult = dataList[(lbSent.SelectedIndex * 9) + 8].Replace("%0A", Environment.NewLine);
            string rawText = Uri.UnescapeDataString(unencodedResult);
            MessageBox.Show(rawText, "Viewing Product");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteUuidStore = dataList[lbSent.SelectedIndex * 9];
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm deletion of product",
                MessageBoxButtons.YesNo
            );

            if (confirmResult == DialogResult.Yes)
            {
                deleteProducts();
                btnView.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                fetchProducts();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            fetchProducts();
        }

        private void lbPending_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkHideIndefinite_CheckedChanged(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            fetchProducts();
        }

        private void lbSent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && btnDelete.Enabled)
            {
                deleteUuidStore = dataList[lbSent.SelectedIndex * 9];
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm deletion of product",
                    MessageBoxButtons.YesNo
                );

                if (confirmResult == DialogResult.Yes)
                {
                    deleteProducts();
                    btnView.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    fetchProducts();
                }
            }
            if (e.KeyCode == Keys.Enter && btnEdit.Enabled)
            {
                try
                {
                    DateTimeOffset now = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 6]));
                    int mrd = -1;
                    try
                    {
                        mrd = Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 4]);
                    }
                    catch
                    {

                    }
                    string timePart = now.ToString("hmm tt");
                    string tz = now.Offset.TotalHours == -4 ? "EDT" : "EST";
                    string datePart = now.ToString("ddd MMM d yyyy");
                    Globals.dateTimeStamp = $"{timePart} {tz} {datePart}";
                    Globals.startEditor = 0;
                    Globals.TTAAii = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[0];
                    Globals.CCCC = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[1];
                    Globals.BBB = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[2];
                    Globals.BBBver = Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[3]);
                    try
                    {
                        if (mrd != -1)
                        {
                            Globals.BBB = $"RR";
                            Globals.BBBver = mrd + 1;
                        }
                    }
                    catch
                    {

                    }
                    Globals.WSFOid = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[4];
                    Globals.productCategory = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[5];
                    Globals.productDesignator = dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[6];
                    Globals.productOriginator = Globals.orgList.IndexOf(dataList[(lbSent.SelectedIndex * 9) + 1].Split(new char[] { '-' }, StringSplitOptions.None).ToList()[7]);
                    Globals.vtecHeader = dataList[(lbSent.SelectedIndex * 9) + 3];
                    Globals.countiesAffected = "";
                    string countyCodesAffected = dataList[(lbSent.SelectedIndex * 9) + 5];
                    List<string> countyList = countyCodesAffected.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (string county in countyList)
                    {
                        Globals.countiesAffected += $"{county.Substring(1, 5)}-";
                    }
                    if (Globals.countiesAffected == "")
                    {
                        Globals.countiesAffected = "-";
                    }
                    string unencodedResult = dataList[(lbSent.SelectedIndex * 9) + 8].Replace("%0A", Environment.NewLine);
                    string rawText = Uri.UnescapeDataString(unencodedResult);
                    Globals.tbPrimaryTextWorkstation = rawText;
                    int firstBreak = rawText.IndexOf(Environment.NewLine);
                    int secondBreak = rawText.IndexOf(Environment.NewLine, firstBreak + Environment.NewLine.Length);
                    Globals.productText = rawText.Substring(secondBreak + Environment.NewLine.Length);
                    Globals.uuidStore = dataList[lbSent.SelectedIndex * 9];
                    Globals.endUnixTimestamp = Convert.ToInt32(dataList[(lbSent.SelectedIndex * 9) + 7]);
                    Globals.SAMETonage = false;
                    Globals.Tonage1050 = false;
                    Globals.Interrupt = false;
                    Globals.Repeat = false;
                    string broadcastCode = dataList[(lbSent.SelectedIndex * 9) + 2];
                    if (broadcastCode[0] == Convert.ToChar("T"))
                    {
                        Globals.SAMETonage = true;
                    }
                    if (broadcastCode[1] == Convert.ToChar("T"))
                    {
                        Globals.Tonage1050 = true;
                    }
                    if (broadcastCode[2] == Convert.ToChar("I"))
                    {
                        Globals.Repeat = true;
                    }
                    if (broadcastCode[3] == Convert.ToChar("S"))
                    {
                        Globals.Interrupt = true;
                    }
                    TextEditor TextEditorForm = new TextEditor();
                    TextEditorForm.Show();
                }
                catch
                {
                    Globals.startEditor = 0;
                    Globals.TTAAii = "";
                    Globals.CCCC = "";
                    Globals.BBB = "";
                    Globals.BBBver = 0;
                    Globals.WSFOid = "";
                    Globals.productCategory = "";
                    Globals.productDesignator = "";
                    Globals.productOriginator = 0;
                    Globals.vtecHeader = "";
                    Globals.countiesAffected = "";
                    Globals.productText = "";
                    Globals.uuidStore = "";
                    Globals.endUnixTimestamp = 0;
                    Globals.SAMETonage = false;
                    Globals.Tonage1050 = false;
                    Globals.Interrupt = false;
                    Globals.Repeat = false;
                    MessageBox.Show("Cannot edit product");
                }
            }
        }
    }
}