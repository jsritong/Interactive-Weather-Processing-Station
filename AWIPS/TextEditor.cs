using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace AWIPS
{
    public partial class TextEditor : Form
    {
        private string broadcastModifiers = string.Empty;
        private string localTTAAii = string.Empty;
        private string localCCCC = string.Empty;
        private string localBBB = string.Empty;
        private int localBBBver = 0;
        private string localWSFOID = string.Empty;
        private string localProductCat = string.Empty;
        private string localProductDes = string.Empty;
        private string localCountiesAffected = string.Empty;
        private string localVtecHeader = string.Empty;
        public string localuuidLoad = "";
        private int localVersion = 0;
        private int localProductOrg = 0;
        private string dateTimeStampStore = string.Empty;
        private int localEndUnixTimestamp = 0;
        int inEditor = Globals.startEditor;

        public TextEditor()
        {
            InitializeComponent();
            localTTAAii = Globals.TTAAii;
            localCCCC = Globals.CCCC;
            localBBB = Globals.BBB;
            localBBBver = Globals.BBBver;
            localWSFOID = Globals.WSFOid;
            localProductCat = Globals.productCategory;
            localProductDes = Globals.productDesignator;
            localProductOrg = Globals.productOriginator;
            localCountiesAffected = Globals.countiesAffected;
            localVtecHeader = Globals.vtecHeader;
            dateTimeStampStore = Globals.dateTimeStamp;
            tbMain.Text = Globals.productText;
            tbPrimary.Text = Globals.tbPrimaryTextWorkstation;
            localEndUnixTimestamp = Globals.endUnixTimestamp;
            if (Globals.uuidStore != "")
            {
                localuuidLoad = Globals.uuidStore;
                Globals.uuidStore = "";
            }
            else
            {
                Globals.uuidStore = "";
            }
            if (inEditor == 1)
            {
                btnSave.Visible = true;
                btnSend.Visible = true;
                sendToolStripMenuItem1.Enabled = true;
                btnCut.Visible = true;
                btnCopy.Visible = true;
                btnPaste.Visible = true;
                btnFill.Visible = true;
                btnEditHeader.Visible = true;
                aWIPSBrowserToolStripMenuItem.Enabled = true;
                btnSend.Visible = true;
                btnCancel.Visible = true;
                btnEnterEditor.Enabled = false;
                tbPrimary.Visible = false;
                tbMain.Visible = true;
                tbHeaderFull.Visible = true;
                Globals.TTAAii = localTTAAii;
                Globals.CCCC = localCCCC;
                Globals.BBB = localBBB;
                Globals.BBBver = localBBBver;
                Globals.WSFOid = localWSFOID;
                Globals.productCategory = localProductCat;
                Globals.productDesignator = localProductDes;
                Globals.productOriginator = localProductOrg;
                Globals.countiesAffected = localCountiesAffected;
                Globals.vtecHeader = localVtecHeader;
                if (Globals.autofillSignature && Globals.forecasterSignature != "")
                {
                    tbMain.Text = tbMain.Text.Replace("!**NAME/INITIALS**!", Globals.forecasterSignature);
                }
                AWIPSHeaderBlock EditHeaderForm = new AWIPSHeaderBlock(this);
                EditHeaderForm.Show(this);
                if (localEndUnixTimestamp != 0)
                {
                    DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt32(localEndUnixTimestamp));
                    // MessageBox.Show($"Your product will expire at {dateTime.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss")} (UTC)", "Product Will Expire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MessageBox.Show("Your product will not expire (indefinite product).", "Product Will Not Expire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                btnSave.Visible = false;
                btnSend.Visible = false;
                sendToolStripMenuItem1.Enabled = false;
                btnCut.Visible = false;
                btnCopy.Visible = false;
                btnPaste.Visible = false;
                btnFill.Visible = false;
                btnEditHeader.Visible = false;
                aWIPSBrowserToolStripMenuItem.Enabled = false;
                btnSend.Visible = false;
                btnCancel.Visible = false;
                btnEnterEditor.Enabled = true;
                tbPrimary.Visible = true;
                tbMain.Visible = false;
                tbHeaderFull.Visible = false;
            }
        }
        public void abortSend()
        {
            btnSend.Enabled = true;
        }

        private void updateTextWorkstationMode()
        {
            if (inEditor == 1)
            {
                btnSave.Visible = true;
                btnSend.Visible = true;
                sendToolStripMenuItem1.Enabled = true;
                btnCut.Visible = true;
                btnCopy.Visible = true;
                btnPaste.Visible = true;
                btnFill.Visible = true;
                btnEditHeader.Visible = true;
                aWIPSBrowserToolStripMenuItem.Enabled = true;
                btnSend.Visible = true;
                btnCancel.Visible = true;
                btnEnterEditor.Enabled = false;
                tbPrimary.Visible = false;
                tbMain.Visible = true;
                tbHeaderFull.Visible = true;
                Globals.TTAAii = localTTAAii;
                Globals.CCCC = localCCCC;
                Globals.BBB = localBBB;
                Globals.BBBver = localBBBver;
                Globals.WSFOid = localWSFOID;
                Globals.productCategory = localProductCat;
                Globals.productDesignator = localProductDes;
                Globals.productOriginator = localProductOrg;
                Globals.countiesAffected = localCountiesAffected;
                Globals.vtecHeader = localVtecHeader;
                if (Globals.autofillSignature && Globals.forecasterSignature != "")
                {
                    tbMain.Text = tbMain.Text.Replace("!**NAME/INITIALS**!", Globals.forecasterSignature);
                }
                AWIPSHeaderBlock EditHeaderForm = new AWIPSHeaderBlock(this);
                EditHeaderForm.Show(this);
                if (localEndUnixTimestamp != 0)
                {
                    DateTimeOffset dateTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt32(localEndUnixTimestamp));
                    // MessageBox.Show($"Your product will expire at {dateTime.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss")} (UTC)", "Product Will Expire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MessageBox.Show("Your product will not expire (indefinite product).", "Product Will Not Expire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                btnSave.Visible = false;
                btnSend.Visible = false;
                sendToolStripMenuItem1.Enabled = false;
                btnCut.Visible = false;
                btnCopy.Visible = false;
                btnPaste.Visible = false;
                btnFill.Visible = false;
                btnEditHeader.Visible = false;
                aWIPSBrowserToolStripMenuItem.Enabled = false;
                btnSend.Visible = false;
                btnCancel.Visible = false;
                btnEnterEditor.Enabled = true;
                tbPrimary.Visible = true;
                tbMain.Visible = false;
                tbHeaderFull.Visible = false;
            }
        }

        public void UpdateAWIPSHeaderData()
        {
            string BBBvalue = "";
            if (Globals.BBB == "RR" || Globals.BBB == "CC")
            {
                char letter = (char)('a' + Globals.BBBver);
                BBBvalue = $" {Globals.BBB}{letter.ToString().ToUpper()}";
            }
            else if (Globals.BBB == "RTD")
            {
                BBBvalue = $" {Globals.BBB}";
            }
            tbHeaderFull.Text = $"{Globals.TTAAii} {Globals.CCCC} DDHHMM{BBBvalue}" + Environment.NewLine + $"{Globals.productCategory}{Globals.productDesignator}";
            string SAMETone = "N";
            string Tone1050 = "N";
            string InterruptValue = "N";
            string repeatValue = "N";
            localTTAAii = Globals.TTAAii;
            localCCCC = Globals.CCCC;
            localBBB = Globals.BBB;
            localBBBver = Globals.BBBver;
            localWSFOID = Globals.WSFOid;
            localProductCat = Globals.productCategory;
            localProductDes = Globals.productDesignator;
            localProductOrg = Globals.productOriginator;
            localCountiesAffected = Globals.countiesAffected;
            localVtecHeader = Globals.vtecHeader;
            dateTimeStampStore = Globals.dateTimeStamp;

            if (Globals.SAMETonage == true)
            {
                SAMETone = "T";
            }
            if (Globals.Tonage1050 == true)
            {
                Tone1050 = "T";
            }
            if (Globals.Interrupt == true)
            {
                InterruptValue = "S";
            }
            if (Globals.Repeat == true)
            {
                repeatValue = "I";
            }
            broadcastModifiers = $"{SAMETone}{Tone1050}{repeatValue}{InterruptValue}";
        }

        private static readonly HttpClient client = new HttpClient();
        public async Task<int> SendProduct()
        {
            if (localCountiesAffected != "*-" && Globals.officeId != "WNS")
            {
                if (localCountiesAffected.Substring(localCountiesAffected.Length - 1) == "-")
                {
                    List<string> countiesList = localCountiesAffected.Split(new Char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (string county in countiesList)
                    {
                        try
                        {
                            if (Globals.countyData[county].officeId == Globals.officeId)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Please check that you have formatted your counties correctly and only include counties in your CWA.", "County error");
                                return 0;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Please check that you have formatted your counties correctly using valid FIPS codes.", "County error");
                            return 0;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please check that you have formatted your counties correctly with the string of counties ending with a dash (-).", "County error");
                    return 0;
                }
            }

            List<string> countiesAffectedList = localCountiesAffected.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Globals.timeZonesInAlert.Clear();
            try
            {
                foreach (string fips in countiesAffectedList)
                {
                    if (Globals.countyData[fips].officeId == Globals.officeId)
                    {
                        if (Globals.timeZonesInAlert.Contains(Globals.countyData[fips].timeZone))
                        {

                        }
                        else
                        {
                            Globals.timeZonesInAlert.Add(Globals.countyData[fips].timeZone);
                        }
                        // MessageBox.Show(Globals.countyData[fips].timeZone);
                    }
                    else
                    {

                    }
                }
            }
            catch
            {

            }
            int startUnixTimestamp = (int)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000.0);
            DateTime currentUtc = DateTime.UtcNow;
            string startUtcAwipsHeaderBlock = currentUtc.ToString("ddHHmm");
            DateTimeOffset now = DateTimeOffset.Now;
            string tz = "EDT";
            // MessageBox.Show(Globals.timeZonesInAlert[0]);
            if (Globals.timeZonesInAlert.Count == 0)
            {
                try
                {
                    Globals.timeZonesInAlert.Add(Globals.officeDefaultTimeZone[Globals.officeId]);
                }
                catch
                {

                }
            }
            if (Globals.officeId == "WNS")
            {
                try
                {
                    Globals.timeZonesInAlert.Add(Globals.officeDefaultTimeZone[Globals.officeId]);
                }
                catch
                {

                }
            }
            try
            {
                if (Globals.timeZonesInAlert[0] == "E")
                {

                }
                else if (Globals.timeZonesInAlert[0] == "C")
                {
                    now = now.AddHours(-1);
                    tz = "CDT";
                }
                else if (Globals.timeZonesInAlert[0] == "M")
                {
                    now = now.AddHours(-2);
                    tz = "MDT";
                }
                else if (Globals.timeZonesInAlert[0] == "P")
                {
                    now = now.AddHours(-2);
                    tz = "PDT";
                }
            }
            catch
            {

            }
            string timePart = now.ToString("hmm tt");
            string datePart = now.ToString("ddd MMM d yyyy");
            string currentTime = $"{timePart} {tz} {datePart}";
            // tbMain.Text = tbMain.Text.Replace($"{dateTimeStampStore}", currentTime);
            List<string> textSplit = tbMain.Text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None
            ).ToList();
            int blanksEncountered = 0;
            string replaceRegex = "";
            if (textSplit[0] == "")
            {
                blanksEncountered++;
            }
            for (int i = 0; i < textSplit.Count; i++)
            {
                try
                {
                    if (textSplit[i] == "$$")
                    {
                        blanksEncountered = 0;
                    }
                    if (textSplit[i + 1] == "")
                    {
                        blanksEncountered++;
                        if (blanksEncountered == 2)
                        {
                            if (replaceRegex == "")
                            {
                                replaceRegex = textSplit[i];
                                break;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            tbMain.Text = string.Join(Environment.NewLine, textSplit);
            if (replaceRegex != "")
            {
                if (replaceRegex == replaceRegex.ToUpper())
                {
                    tbMain.Text = tbMain.Text.Replace($"{replaceRegex}", currentTime.ToUpper());
                }
                else
                {
                    tbMain.Text = tbMain.Text.Replace($"{replaceRegex}", currentTime);
                }
            }
            string newTbHeader = tbHeaderFull.Text.Replace("DDHHMM", startUtcAwipsHeaderBlock);
            string combinedText = newTbHeader + Environment.NewLine + tbMain.Text;
            tbPrimary.Text = combinedText;
            Globals.tbPrimaryTextWorkstation = combinedText;
            string normalizedInput = combinedText.Replace(Environment.NewLine, "\n");
            string encodedResult = Uri.EscapeDataString(normalizedInput);

            var formData = new
            {
                product = $"{encodedResult}",
                vtec = $"{localVtecHeader}",
                uuid = $"{localuuidLoad}"
            };

            List<string> fipsList = new List<string>();
            string counties = "";

            if (localCountiesAffected == "-" || localCountiesAffected == "")
            {
                counties = "-";
            }
            else
            {
                if (localCountiesAffected.Contains("-"))
                {
                    fipsList = localCountiesAffected.Split('-').ToList();
                    fipsList.Remove("");
                    fipsList.Sort();
                }
                foreach (var item in fipsList)
                {
                    counties += $"0{item}-";
                }

            }

            string url = $"http://{Globals.serverip}/sendproduct/{Globals.username}/{Globals.password}/{localTTAAii}-{localCCCC}-{localBBB}-{localBBBver}-{localWSFOID}-{localProductCat}-{localProductDes}-{Globals.orgList[localProductOrg]}-{startUnixTimestamp}/{broadcastModifiers}/{counties}/{startUnixTimestamp}/{localEndUnixTimestamp}";

            try	
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(url, formData);
                response.EnsureSuccessStatusCode();
                string jsonString = await response.Content.ReadAsStringAsync();
                using (JsonDocument doc = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = doc.RootElement;
                    if (root.TryGetProperty("status", out JsonElement statusElement) &&
                        statusElement.GetString() == "success")
                    {
                        if (root.TryGetProperty("uuid", out JsonElement statusElement2))
                        {
                            localuuidLoad = statusElement2.GetString();
                        }
                        inEditor = 0;
                        updateTextWorkstationMode();
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (HttpRequestException)
            {
                return 0;
            }
        }

        public void SendProductPractice()
        {
            if (localCountiesAffected != "*-" && Globals.officeId != "WNS")
            {
                if (localCountiesAffected.Substring(localCountiesAffected.Length - 1) == "-")
                {
                    List<string> countiesList = localCountiesAffected.Split(new Char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (string county in countiesList)
                    {
                        try
                        {
                            if (Globals.countyData[county].officeId == Globals.officeId)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Please check that you have formatted your counties correctly and only include counties in your CWA.", "County error");
                                return;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Please check that you have formatted your counties correctly using valid FIPS codes.", "County error");
                            return;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please check that you have formatted your counties correctly with the string of counties ending with a dash (-).", "County error");
                    return;
                }
            }
            List<string> countiesAffectedList = localCountiesAffected.Split(new char[] { '-' }, StringSplitOptions.None).ToList();
            Globals.timeZonesInAlert.Clear();
            try
            {
                foreach (string fips in countiesAffectedList)
                {
                    if (Globals.countyData[fips].officeId == Globals.officeId)
                    {
                        if (Globals.timeZonesInAlert.Contains(Globals.countyData[fips].timeZone))
                        {

                        }
                        else
                        {
                            Globals.timeZonesInAlert.Add(Globals.countyData[fips].timeZone);
                        }
                        // MessageBox.Show(Globals.countyData[fips].timeZone);
                    }
                    else
                    {

                    }
                }
            }
            catch
            {

            }
            int startUnixTimestamp = (int)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000.0);
            DateTime currentUtc = DateTime.UtcNow;
            string startUtcAwipsHeaderBlock = currentUtc.ToString("ddHHmm");
            DateTimeOffset now = DateTimeOffset.Now;
            string tz = "EDT";
            // MessageBox.Show(Globals.timeZonesInAlert[0]);
            if (Globals.timeZonesInAlert.Count == 0)
            {
                try
                {
                    Globals.timeZonesInAlert.Add(Globals.officeDefaultTimeZone[Globals.officeId]);
                }
                catch
                {

                }
            }
            if (Globals.officeId == "WNS")
            {
                try
                {
                    Globals.timeZonesInAlert.Add(Globals.officeDefaultTimeZone[Globals.officeId]);
                }
                catch
                {

                }
            }
            try
            {
                if (Globals.timeZonesInAlert[0] == "E")
                {

                }
                else if (Globals.timeZonesInAlert[0] == "C")
                {
                    now = now.AddHours(-1);
                    tz = "CDT";
                }
                else if (Globals.timeZonesInAlert[0] == "M")
                {
                    now = now.AddHours(-2);
                    tz = "MDT";
                }
                else if (Globals.timeZonesInAlert[0] == "P")
                {
                    now = now.AddHours(-2);
                    tz = "PDT";
                }
            }
            catch
            {

            }
            string timePart = now.ToString("hmm tt");
            string datePart = now.ToString("ddd MMM d yyyy");
            string currentTime = $"{timePart} {tz} {datePart}";
            // tbMain.Text = tbMain.Text.Replace($"{dateTimeStampStore}", currentTime);
            List<string> textSplit = tbMain.Text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None
            ).ToList();
            int blanksEncountered = 0;
            string replaceRegex = "";
            if (textSplit[0] == "")
            {
                blanksEncountered++;
            }
            for (int i = 0; i < textSplit.Count; i++)
            {
                try
                {
                    if (textSplit[i] == "$$")
                    {
                        blanksEncountered = 0;
                    }
                    if (textSplit[i + 1] == "")
                    {
                        blanksEncountered++;
                        if (blanksEncountered == 2)
                        {
                            if (replaceRegex == "")
                            {
                                replaceRegex = textSplit[i];
                                break;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            tbMain.Text = string.Join(Environment.NewLine, textSplit);
            if (replaceRegex != "")
            {
                if (replaceRegex == replaceRegex.ToUpper())
                {
                    tbMain.Text = tbMain.Text.Replace($"{replaceRegex}", currentTime.ToUpper());
                }
                else
                {
                    tbMain.Text = tbMain.Text.Replace($"{replaceRegex}", currentTime);
                }
            }
            string newTbHeader = tbHeaderFull.Text.Replace("DDHHMM", startUtcAwipsHeaderBlock);
            string combinedText = newTbHeader + Environment.NewLine + tbMain.Text;
            tbPrimary.Text = combinedText;
            Globals.tbPrimaryTextWorkstation = combinedText;
            string normalizedInput = combinedText.Replace(Environment.NewLine, "\n");
            string encodedResult = Uri.EscapeDataString(normalizedInput);

            var formData = new
            {
                product = $"{encodedResult}",
                vtec = $"{localVtecHeader}",
                uuid = $"{localuuidLoad}"
            };

            List<string> fipsList = new List<string>();
            string counties = "";

            if (localCountiesAffected == "-" || localCountiesAffected == "")
            {
                counties = "-";
            }
            else
            {
                if (localCountiesAffected.Contains("-"))
                {
                    fipsList = localCountiesAffected.Split('-').ToList();
                    fipsList.Remove("");
                    fipsList.Sort();
                }
                foreach (var item in fipsList)
                {
                    counties += $"0{item}-";
                }

            }
            inEditor = 0;
            updateTextWorkstationMode();
            return;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbHeaderFull.TextLength != 0)
            {
                if (tbMain.Text.Contains("!**"))
                {
                    int startIndex = tbMain.Text.IndexOf("!**", StringComparison.OrdinalIgnoreCase);
                    int endIndex = tbMain.Text.IndexOf("**!", StringComparison.OrdinalIgnoreCase);

                    if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
                    {
                        int selectionLength = (endIndex + 3) - startIndex;

                        tbMain.Focus();
                        tbMain.Select(startIndex, selectionLength);
                        MessageBox.Show("You must modify the selected region before sending or saving this product");
                    }
                    else
                    {
                        SendProduct SendProductForm = new SendProduct(this, localProductCat, localProductDes);
                        SendProductForm.Show(this);
                    }
                }
                else
                {
                    SendProduct SendProductForm = new SendProduct(this, localProductCat, localProductDes);
                    SendProductForm.Show(this);
                }
            }
            else
            {
                MessageBox.Show("Please check that you have filled all parts of the AWIPS header.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void tbMain_TextChanged(object sender, EventArgs e)
        {
            Globals.productText = tbMain.Text;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditHeader_Click(object sender, EventArgs e)
        {
            Globals.TTAAii = localTTAAii;
            Globals.CCCC = localCCCC;
            Globals.BBB = localBBB;
            Globals.BBBver = localBBBver;
            Globals.WSFOid = localWSFOID;
            Globals.productCategory = localProductCat;
            Globals.productDesignator = localProductDes;
            Globals.productOriginator = localProductOrg;
            Globals.countiesAffected = localCountiesAffected;
            Globals.vtecHeader = localVtecHeader;
            Globals.dateTimeStamp = dateTimeStampStore;
            AWIPSHeaderBlock EditHeaderForm = new AWIPSHeaderBlock(this);
            EditHeaderForm.Show(this);
        }

        private void aWIPSBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AWIPSHeaderBlock EditHeaderForm = new AWIPSHeaderBlock(this);
            EditHeaderForm.Show(this);
        }

        private void tbHeaderFull_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbHeaderFull.TextLength != 0)
            {
                SendProduct SendProductForm = new SendProduct(this, localProductCat, localProductDes);
                SendProductForm.Show(this);
            }
            else
            {
                MessageBox.Show("Please check that you have filled all parts of the AWIPS header.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnterEditor_Click(object sender, EventArgs e)
        {
            inEditor = 1;
            updateTextWorkstationMode();
        }

        private void tbPrimary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            tbMain.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbMain.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            tbMain.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMain.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMain.Paste();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void wrapTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> textTemp = tbMain.Text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None
            ).ToList();
            List<string> textTemp2 = new List<string>();
            int offset = 0;
            bool reachDollar = false;
            try
            {
                foreach (string t in textTemp)
                {
                    bool yesTrim = false;
                    try
                    {
                        string trim2 = t.Trim();
                        if (trim2[0] == Convert.ToChar("*"))
                        {
                            yesTrim = true;
                        }
                        if (trim2[0] == Convert.ToChar("-"))
                        {
                            yesTrim = true;
                        }
                    }
                    catch
                    {

                    }
                    bool thisLineStartsWithChar = false;
                    if (offset == 0 || yesTrim)
                    {
                        try
                        {
                            for (int i = 0; i < t.Length; i++)
                            {
                                if (char.IsLetterOrDigit(Convert.ToChar(t[i])))
                                {
                                    offset = i;
                                    break;
                                }
                            }
                        }
                        catch
                        {

                        }
                        if (t.StartsWith("..."))
                        {
                            offset = 0;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("HAZARD..."))
                        {
                            offset = "HAZARD...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("SOURCE..."))
                        {
                            offset = "SOURCE...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("IMPACT..."))
                        {
                            offset = "IMPACT...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("IMPACTS..."))
                        {
                            offset = "IMPACTS...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("* HAZARD..."))
                        {
                            offset = "* HAZARD...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("* SOURCE..."))
                        {
                            offset = "* SOURCE...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("* IMPACT..."))
                        {
                            offset = "* IMPACT...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("* IMPACTS..."))
                        {
                            offset = "* IMPACTS...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("WHAT..."))
                        {
                            offset = "WHAT...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("WHERE..."))
                        {
                            offset = "WHERE...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("WHEN..."))
                        {
                            offset = "WHEN...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("* WHAT..."))
                        {
                            offset = "* WHAT...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("* WHEN..."))
                        {
                            offset = "* WHEN...".Length;
                            thisLineStartsWithChar = true;
                        }
                        if (t.StartsWith("* WHERE..."))
                        {
                            offset = "* WHERE...".Length;
                            thisLineStartsWithChar = true;
                        }
                    }
                    if (t == "")
                    {
                        offset = 0;
                    }
                    if (t == "&&" || t == "$$")
                    {
                        reachDollar = true;
                    }
                    string spaces = new string(' ', offset);
                    string currentProcess;
                    bool skip = false;
                    if (t.EndsWith("-") || t.EndsWith("/"))
                    {
                        skip = true;
                        spaces = "";
                        offset = 0;
                    }
                    if (yesTrim || reachDollar || thisLineStartsWithChar)
                    {
                        currentProcess = t;
                    }
                    else
                    {
                        currentProcess = spaces + t;
                    }
                    if (currentProcess.Length <= 69 || skip || reachDollar)
                    {
                        textTemp2.Add(currentProcess);
                    }
                    else
                    {
                        while (currentProcess.Length > 69)
                        {
                            bool correctlySeparated = false;
                            for (int i = 70; i > 0; i -= 1)
                            {
                                if (currentProcess[i] == Convert.ToChar(" ") || currentProcess[i] == Convert.ToChar("."))
                                {
                                    textTemp2.Add(currentProcess.Substring(0, i));
                                    currentProcess = currentProcess.Substring(i + 1);
                                    currentProcess = currentProcess.Trim();
                                    currentProcess = spaces + currentProcess;
                                    correctlySeparated = true;
                                    i = 0;
                                }
                            }
                            if (correctlySeparated == false)
                            {
                                textTemp2.Add(currentProcess.Substring(0, 70));
                                currentProcess = currentProcess.Substring(70 + 1);
                                currentProcess = currentProcess.Trim();
                                currentProcess = spaces + currentProcess;
                            }
                        }
                        if (currentProcess.Length > 0)
                        {
                            textTemp2.Add(currentProcess);
                        }
                    }
                }
            }
            catch
            {

            }
            tbMain.Text = string.Join(Environment.NewLine, textTemp2);
        }
    }
}
