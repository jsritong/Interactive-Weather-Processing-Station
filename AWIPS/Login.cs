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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbUsername.Text = Globals.username;
            tbPassword.Text = "";
            tbServer.Text = Globals.serverip;
            Globals.loginForm = this;
        }

        private static readonly HttpClient client = new HttpClient();
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            lbLoginStatus.Text = "Logging in...";
            string url = $"http://{Globals.serverip}/login/{tbUsername.Text}/{tbPassword.Text}";

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
                        Globals.username = tbUsername.Text;
                        Globals.password = tbPassword.Text;
                        if (root.TryGetProperty("authority", out JsonElement statusElement2))
                        {
                            Globals.officeId = statusElement2.GetString().Substring(1, 3);
                        }
                        if (root.TryGetProperty("officeLoc", out JsonElement statusElement3))
                        {
                            Globals.officeLoc = statusElement3.GetString();
                        }
                        if (root.TryGetProperty("officeName", out JsonElement statusElement4))
                        {
                            Globals.officeName = statusElement4.GetString();
                        }
                        if (root.TryGetProperty("fullname", out JsonElement statusElement5))
                        {
                            Globals.forecasterName = statusElement5.GetString();
                        }
                        if (root.TryGetProperty("signature", out JsonElement statusElement6))
                        {
                            Globals.forecasterSignature = statusElement6.GetString();
                        }
                        AWIPSForm AWIPSFormForm = new AWIPSForm();
                        AWIPSFormForm.FormClosed += (s, args) => Application.Exit();
                        AWIPSFormForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbLoginStatus.Text = "Failed to login. Please try again.";
                    }
                }
            }
            catch
            {
                lbLoginStatus.Text = "Failed to login. Please try again.";
            }
            btnLogin.Enabled = true;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbServer_TextChanged(object sender, EventArgs e)
        {
            Globals.serverip = tbServer.Text;
        }
    }
}
