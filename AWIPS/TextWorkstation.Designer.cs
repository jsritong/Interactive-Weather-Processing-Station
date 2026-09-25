namespace AWIPS
{
    partial class TextWorkstation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextWorkstation));
            this.gbResetTracking = new System.Windows.Forms.GroupBox();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.chkRelay = new System.Windows.Forms.CheckBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lbCounty = new System.Windows.Forms.Label();
            this.cbCountyChooseSelection = new System.Windows.Forms.ComboBox();
            this.cbBulletins = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBulletin = new System.Windows.Forms.Label();
            this.cbIssuer = new System.Windows.Forms.ComboBox();
            this.chkUseTemplate = new System.Windows.Forms.CheckBox();
            this.gbAdditions = new System.Windows.Forms.GroupBox();
            this.chkInsertCities = new System.Windows.Forms.CheckBox();
            this.chkInsertCounties = new System.Windows.Forms.CheckBox();
            this.chkLatLon = new System.Windows.Forms.CheckBox();
            this.chkEffectiveTimeRounding = new System.Windows.Forms.CheckBox();
            this.boxTimeRange = new System.Windows.Forms.GroupBox();
            this.chkSelfExpire = new System.Windows.Forms.CheckBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.ddDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbResetTracking.SuspendLayout();
            this.gbProduct.SuspendLayout();
            this.gbAdditions.SuspendLayout();
            this.boxTimeRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResetTracking
            // 
            this.gbResetTracking.Controls.Add(this.btnTrack);
            this.gbResetTracking.Controls.Add(this.btnReset);
            this.gbResetTracking.Location = new System.Drawing.Point(12, 12);
            this.gbResetTracking.Name = "gbResetTracking";
            this.gbResetTracking.Size = new System.Drawing.Size(356, 50);
            this.gbResetTracking.TabIndex = 0;
            this.gbResetTracking.TabStop = false;
            this.gbResetTracking.Text = "Reset Tracking";
            this.gbResetTracking.Enter += new System.EventHandler(this.gbResetTracking_Enter);
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(179, 19);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(171, 23);
            this.btnTrack.TabIndex = 1;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.chkRelay);
            this.gbProduct.Controls.Add(this.cbProduct);
            this.gbProduct.Controls.Add(this.lbCounty);
            this.gbProduct.Controls.Add(this.cbCountyChooseSelection);
            this.gbProduct.Controls.Add(this.cbBulletins);
            this.gbProduct.Controls.Add(this.label1);
            this.gbProduct.Controls.Add(this.lbBulletin);
            this.gbProduct.Controls.Add(this.cbIssuer);
            this.gbProduct.Location = new System.Drawing.Point(12, 68);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(356, 145);
            this.gbProduct.TabIndex = 1;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Issuance";
            // 
            // chkRelay
            // 
            this.chkRelay.AutoSize = true;
            this.chkRelay.Location = new System.Drawing.Point(6, 122);
            this.chkRelay.Name = "chkRelay";
            this.chkRelay.Size = new System.Drawing.Size(193, 17);
            this.chkRelay.TabIndex = 4;
            this.chkRelay.Text = "Check for Relay by another agency";
            this.chkRelay.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            this.cbProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Items.AddRange(new object[] {
            "911 Telephone Outage Emergency",
            "Administrative Message",
            "Air Quality Alert",
            "Area Forecast Discussion",
            "Avalanche Warning",
            "Avalanche Watch",
            "Blizzard Warning",
            "Blue Alert",
            "Child Abduction Emergency",
            "Civil Danger Warning",
            "Civil Emergency Message",
            "Coastal Flood Warning",
            "Coastal Flood Watch",
            "Dust Storm Warning",
            "Earthquake Warning",
            "Evacuation Immediate",
            "Extreme Wind Warning",
            "Fire Warning",
            "Flash Flood Statement",
            "Flash Flood Warning",
            "Flash Flood Watch",
            "Flood Statement",
            "Flood Warning",
            "Flood Watch",
            "Hazardous Materials Warning",
            "Hazardous Weather Outlook",
            "High Wind Warning",
            "High Wind Watch",
            "Hurricane Statement",
            "Hurricane Warning",
            "Hurricane Watch",
            "Law Enforcement Warning",
            "Local Area Emergency",
            "Local Storm Report",
            "Non Precipitation Warning",
            "Nuclear Power Plant Warning",
            "Practice Demo Warning",
            "Public Information Statement",
            "Radiological Hazard Warning",
            "Required Monthly Test",
            "Required Weekly Test",
            "Severe Thunderstorm Warning",
            "Severe Thunderstorm Watch",
            "Severe Weather Statement",
            "Shelter in Place Warning",
            "Snow Squall Warning",
            "Special Marine Warning",
            "Special Weather Statement",
            "Storm Surge Warning",
            "Storm Surge Watch",
            "Tornado Warning",
            "Tornado Watch",
            "Tropical Storm Warning",
            "Tropical Storm Watch",
            "Tsunami Warning",
            "Tsunami Watch",
            "Volcano Warning",
            "Watch County Notification",
            "Winter Storm Warning",
            "Winter Storm Watch"});
            this.cbProduct.Location = new System.Drawing.Point(6, 19);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(344, 21);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // lbCounty
            // 
            this.lbCounty.AutoSize = true;
            this.lbCounty.Location = new System.Drawing.Point(5, 49);
            this.lbCounty.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbCounty.Name = "lbCounty";
            this.lbCounty.Size = new System.Drawing.Size(43, 13);
            this.lbCounty.TabIndex = 6;
            this.lbCounty.Text = "County:";
            // 
            // cbCountyChooseSelection
            // 
            this.cbCountyChooseSelection.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.cbCountyChooseSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountyChooseSelection.FormattingEnabled = true;
            this.cbCountyChooseSelection.Items.AddRange(new object[] {
            "Non county-based product",
            "Counties from polygon",
            "WFO counties - CWA",
            "WFO transmitters only"});
            this.cbCountyChooseSelection.Location = new System.Drawing.Point(50, 46);
            this.cbCountyChooseSelection.Name = "cbCountyChooseSelection";
            this.cbCountyChooseSelection.Size = new System.Drawing.Size(300, 21);
            this.cbCountyChooseSelection.TabIndex = 7;
            // 
            // cbBulletins
            // 
            this.cbBulletins.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.cbBulletins.AllowDrop = true;
            this.cbBulletins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBulletins.FormattingEnabled = true;
            this.cbBulletins.Items.AddRange(new object[] {
            "No bulletin",
            "URGENT - WEATHER MESSAGE",
            "BULLETIN - IMMEDIATE BROADCAST REQUESTED",
            "BULLETIN - EAS ACTIVATION REQUESTED"});
            this.cbBulletins.Location = new System.Drawing.Point(50, 71);
            this.cbBulletins.Margin = new System.Windows.Forms.Padding(1);
            this.cbBulletins.Name = "cbBulletins";
            this.cbBulletins.Size = new System.Drawing.Size(300, 21);
            this.cbBulletins.TabIndex = 9;
            this.cbBulletins.SelectedIndexChanged += new System.EventHandler(this.cbBulletins_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Issuer:";
            // 
            // lbBulletin
            // 
            this.lbBulletin.AutoSize = true;
            this.lbBulletin.Location = new System.Drawing.Point(4, 74);
            this.lbBulletin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbBulletin.Name = "lbBulletin";
            this.lbBulletin.Size = new System.Drawing.Size(44, 13);
            this.lbBulletin.TabIndex = 8;
            this.lbBulletin.Text = "Bulletin:";
            // 
            // cbIssuer
            // 
            this.cbIssuer.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.cbIssuer.AllowDrop = true;
            this.cbIssuer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIssuer.FormattingEnabled = true;
            this.cbIssuer.Items.AddRange(new object[] {
            "National Weather Service",
            "Civil Authorities",
            "EAS Participant",
            "Primary Entry Point System"});
            this.cbIssuer.Location = new System.Drawing.Point(50, 97);
            this.cbIssuer.Margin = new System.Windows.Forms.Padding(1);
            this.cbIssuer.Name = "cbIssuer";
            this.cbIssuer.Size = new System.Drawing.Size(300, 21);
            this.cbIssuer.TabIndex = 11;
            // 
            // chkUseTemplate
            // 
            this.chkUseTemplate.AutoSize = true;
            this.chkUseTemplate.Location = new System.Drawing.Point(6, 19);
            this.chkUseTemplate.Name = "chkUseTemplate";
            this.chkUseTemplate.Size = new System.Drawing.Size(195, 17);
            this.chkUseTemplate.TabIndex = 0;
            this.chkUseTemplate.Text = "Use template if available for product";
            this.chkUseTemplate.UseVisualStyleBackColor = true;
            // 
            // gbAdditions
            // 
            this.gbAdditions.Controls.Add(this.chkInsertCities);
            this.gbAdditions.Controls.Add(this.chkInsertCounties);
            this.gbAdditions.Controls.Add(this.chkUseTemplate);
            this.gbAdditions.Controls.Add(this.chkLatLon);
            this.gbAdditions.Location = new System.Drawing.Point(12, 219);
            this.gbAdditions.Name = "gbAdditions";
            this.gbAdditions.Size = new System.Drawing.Size(356, 112);
            this.gbAdditions.TabIndex = 2;
            this.gbAdditions.TabStop = false;
            this.gbAdditions.Text = "Additions";
            // 
            // chkInsertCities
            // 
            this.chkInsertCities.AutoSize = true;
            this.chkInsertCities.Location = new System.Drawing.Point(6, 65);
            this.chkInsertCities.Name = "chkInsertCities";
            this.chkInsertCities.Size = new System.Drawing.Size(156, 17);
            this.chkInsertCities.TabIndex = 3;
            this.chkInsertCities.Text = "Insert list of cities in product";
            this.chkInsertCities.UseVisualStyleBackColor = true;
            // 
            // chkInsertCounties
            // 
            this.chkInsertCounties.AutoSize = true;
            this.chkInsertCounties.Location = new System.Drawing.Point(6, 42);
            this.chkInsertCounties.Name = "chkInsertCounties";
            this.chkInsertCounties.Size = new System.Drawing.Size(171, 17);
            this.chkInsertCounties.TabIndex = 2;
            this.chkInsertCounties.Text = "Insert county names in product";
            this.chkInsertCounties.UseVisualStyleBackColor = true;
            // 
            // chkLatLon
            // 
            this.chkLatLon.AutoSize = true;
            this.chkLatLon.Location = new System.Drawing.Point(6, 88);
            this.chkLatLon.Name = "chkLatLon";
            this.chkLatLon.Size = new System.Drawing.Size(184, 17);
            this.chkLatLon.TabIndex = 1;
            this.chkLatLon.Text = "Insert LAT...LON points at bottom";
            this.chkLatLon.UseVisualStyleBackColor = true;
            // 
            // chkEffectiveTimeRounding
            // 
            this.chkEffectiveTimeRounding.AutoSize = true;
            this.chkEffectiveTimeRounding.Location = new System.Drawing.Point(6, 42);
            this.chkEffectiveTimeRounding.Name = "chkEffectiveTimeRounding";
            this.chkEffectiveTimeRounding.Size = new System.Drawing.Size(213, 17);
            this.chkEffectiveTimeRounding.TabIndex = 5;
            this.chkEffectiveTimeRounding.Text = "Remove 15 min. effective time rounding";
            this.chkEffectiveTimeRounding.UseVisualStyleBackColor = true;
            // 
            // boxTimeRange
            // 
            this.boxTimeRange.Controls.Add(this.chkEffectiveTimeRounding);
            this.boxTimeRange.Controls.Add(this.chkSelfExpire);
            this.boxTimeRange.Controls.Add(this.lblDuration);
            this.boxTimeRange.Controls.Add(this.ddDuration);
            this.boxTimeRange.Controls.Add(this.label2);
            this.boxTimeRange.Location = new System.Drawing.Point(12, 335);
            this.boxTimeRange.Margin = new System.Windows.Forms.Padding(1);
            this.boxTimeRange.Name = "boxTimeRange";
            this.boxTimeRange.Size = new System.Drawing.Size(356, 89);
            this.boxTimeRange.TabIndex = 3;
            this.boxTimeRange.TabStop = false;
            this.boxTimeRange.Text = "Time Range";
            // 
            // chkSelfExpire
            // 
            this.chkSelfExpire.AutoSize = true;
            this.chkSelfExpire.Location = new System.Drawing.Point(6, 65);
            this.chkSelfExpire.Name = "chkSelfExpire";
            this.chkSelfExpire.Size = new System.Drawing.Size(237, 17);
            this.chkSelfExpire.TabIndex = 3;
            this.chkSelfExpire.Text = "Indefinite product (ignores duration selection)";
            this.chkSelfExpire.UseVisualStyleBackColor = true;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDuration.Location = new System.Drawing.Point(153, 20);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(192, 15);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "22:38 Thu 18-Jun to 22:38 Thu 18-Jun";
            // 
            // ddDuration
            // 
            this.ddDuration.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.ddDuration.AllowDrop = true;
            this.ddDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddDuration.FormattingEnabled = true;
            this.ddDuration.Items.AddRange(new object[] {
            "15 min",
            "30 min",
            "45 min",
            "60 min",
            "90 min",
            "2 hr",
            "2 hr 30 min",
            "3 hr",
            "3 hr 30 min",
            "4 hr",
            "4 hr 30 min",
            "5 hr",
            "5 hr 30 min",
            "6 hr",
            "7 hr",
            "8 hr",
            "10 hr",
            "12 hr",
            "14 hr",
            "16 hr",
            "18 hr",
            "20 hr",
            "22 hr",
            "24 hr"});
            this.ddDuration.Location = new System.Drawing.Point(59, 17);
            this.ddDuration.Margin = new System.Windows.Forms.Padding(1);
            this.ddDuration.Name = "ddDuration";
            this.ddDuration.Size = new System.Drawing.Size(89, 21);
            this.ddDuration.TabIndex = 1;
            this.ddDuration.SelectedIndexChanged += new System.EventHandler(this.ddDuration_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duration:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(191, 428);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 428);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Text";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // TextWorkstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 457);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.boxTimeRange);
            this.Controls.Add(this.gbAdditions);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.gbResetTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TextWorkstation";
            this.Text = "Text Workstation";
            this.gbResetTracking.ResumeLayout(false);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.gbAdditions.ResumeLayout(false);
            this.gbAdditions.PerformLayout();
            this.boxTimeRange.ResumeLayout(false);
            this.boxTimeRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResetTracking;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.CheckBox chkUseTemplate;
        private System.Windows.Forms.GroupBox gbAdditions;
        private System.Windows.Forms.CheckBox chkLatLon;
        private System.Windows.Forms.CheckBox chkInsertCities;
        private System.Windows.Forms.CheckBox chkInsertCounties;
        private System.Windows.Forms.GroupBox boxTimeRange;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ComboBox ddDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkRelay;
        private System.Windows.Forms.ComboBox cbBulletins;
        private System.Windows.Forms.Label lbBulletin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIssuer;
        private System.Windows.Forms.CheckBox chkSelfExpire;
        private System.Windows.Forms.ComboBox cbCountyChooseSelection;
        private System.Windows.Forms.Label lbCounty;
        private System.Windows.Forms.CheckBox chkEffectiveTimeRounding;
    }
}