namespace AWIPS
{
    partial class LocalStormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalStormReport));
            this.dtpStormReport = new System.Windows.Forms.DateTimePicker();
            this.boxResetTracking = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMagnitude = new System.Windows.Forms.TextBox();
            this.lblInjFat = new System.Windows.Forms.Label();
            this.nupInjFat = new System.Windows.Forms.NumericUpDown();
            this.rbFatalities = new System.Windows.Forms.RadioButton();
            this.rbInjuries = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblMagnitude = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.gbRemarks = new System.Windows.Forms.GroupBox();
            this.tbRemarks = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.boxResetTracking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupInjFat)).BeginInit();
            this.gbRemarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStormReport
            // 
            this.dtpStormReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStormReport.Location = new System.Drawing.Point(9, 19);
            this.dtpStormReport.Name = "dtpStormReport";
            this.dtpStormReport.Size = new System.Drawing.Size(323, 20);
            this.dtpStormReport.TabIndex = 0;
            // 
            // boxResetTracking
            // 
            this.boxResetTracking.Controls.Add(this.btnReset);
            this.boxResetTracking.Location = new System.Drawing.Point(10, 10);
            this.boxResetTracking.Margin = new System.Windows.Forms.Padding(1);
            this.boxResetTracking.Name = "boxResetTracking";
            this.boxResetTracking.Size = new System.Drawing.Size(338, 50);
            this.boxResetTracking.TabIndex = 0;
            this.boxResetTracking.TabStop = false;
            this.boxResetTracking.Text = "Reset Tracking";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(5, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(327, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMagnitude);
            this.groupBox1.Controls.Add(this.lblInjFat);
            this.groupBox1.Controls.Add(this.nupInjFat);
            this.groupBox1.Controls.Add(this.rbFatalities);
            this.groupBox1.Controls.Add(this.rbInjuries);
            this.groupBox1.Controls.Add(this.rbNone);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Controls.Add(this.lblMagnitude);
            this.groupBox1.Controls.Add(this.lblEvent);
            this.groupBox1.Controls.Add(this.cbEvent);
            this.groupBox1.Controls.Add(this.cbSource);
            this.groupBox1.Controls.Add(this.dtpStormReport);
            this.groupBox1.Location = new System.Drawing.Point(10, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Storm Report";
            // 
            // tbMagnitude
            // 
            this.tbMagnitude.Location = new System.Drawing.Point(65, 99);
            this.tbMagnitude.Name = "tbMagnitude";
            this.tbMagnitude.Size = new System.Drawing.Size(104, 20);
            this.tbMagnitude.TabIndex = 6;
            // 
            // lblInjFat
            // 
            this.lblInjFat.AutoSize = true;
            this.lblInjFat.Location = new System.Drawing.Point(173, 102);
            this.lblInjFat.Name = "lblInjFat";
            this.lblInjFat.Size = new System.Drawing.Size(99, 13);
            this.lblInjFat.TabIndex = 7;
            this.lblInjFat.Text = "# Injuries/Fatalities:";
            // 
            // nupInjFat
            // 
            this.nupInjFat.Location = new System.Drawing.Point(278, 100);
            this.nupInjFat.Name = "nupInjFat";
            this.nupInjFat.Size = new System.Drawing.Size(54, 20);
            this.nupInjFat.TabIndex = 8;
            // 
            // rbFatalities
            // 
            this.rbFatalities.AutoSize = true;
            this.rbFatalities.Location = new System.Drawing.Point(9, 170);
            this.rbFatalities.Name = "rbFatalities";
            this.rbFatalities.Size = new System.Drawing.Size(66, 17);
            this.rbFatalities.TabIndex = 11;
            this.rbFatalities.Text = "Fatalities";
            this.rbFatalities.UseVisualStyleBackColor = true;
            // 
            // rbInjuries
            // 
            this.rbInjuries.AutoSize = true;
            this.rbInjuries.Location = new System.Drawing.Point(9, 147);
            this.rbInjuries.Name = "rbInjuries";
            this.rbInjuries.Size = new System.Drawing.Size(58, 17);
            this.rbInjuries.TabIndex = 10;
            this.rbInjuries.Text = "Injuries";
            this.rbInjuries.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(9, 124);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(117, 17);
            this.rbNone.TabIndex = 9;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "No injuries/fatalities";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(6, 75);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Source:";
            // 
            // lblMagnitude
            // 
            this.lblMagnitude.AutoSize = true;
            this.lblMagnitude.Location = new System.Drawing.Point(6, 102);
            this.lblMagnitude.Name = "lblMagnitude";
            this.lblMagnitude.Size = new System.Drawing.Size(60, 13);
            this.lblMagnitude.TabIndex = 5;
            this.lblMagnitude.Text = "Magnitude:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(6, 48);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(38, 13);
            this.lblEvent.TabIndex = 1;
            this.lblEvent.Text = "Event:";
            // 
            // cbEvent
            // 
            this.cbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Flash Flood",
            "Flood",
            "Hail",
            "Heavy Rain",
            "Heavy Snow",
            "Ice Storm",
            "Lightning",
            "Rain",
            "Sleet",
            "Snow",
            "Tornado",
            "Funnel Cloud",
            "Waterspout",
            "Tstm Wind Dmg",
            "Tstm Wind Gst",
            "Non-Tstm Wnd Dmg",
            "Non-Tstm Wnd Gst",
            "High Sust Winds",
            "Marine Tstm Wind",
            "Marine Hail",
            "Marine High Wind",
            "Marine Strng Wnd",
            "Coastal Flood",
            "Storm Surge",
            "High Surf",
            "Rip Current",
            "Debris Flow",
            "Landslide",
            "Dust Storm",
            "Dense Fog",
            "Blizzard",
            "Lake Effect Snow",
            "Freezing Rain",
            "Frost",
            "Extreme Cold",
            "Excessive Heat",
            "Hurricane",
            "Tropical Storm",
            "Wildfire",
            "Avalanche",
            "Sneaker Wave"});
            this.cbEvent.Location = new System.Drawing.Point(50, 45);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(282, 21);
            this.cbEvent.TabIndex = 2;
            // 
            // cbSource
            // 
            this.cbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Items.AddRange(new object[] {
            "911 Call Center",
            "ASOS",
            "AWOS",
            "Broadcast Media",
            "Emergency Mngr",
            "NWS Employee",
            "Public",
            "Trained Spotter"});
            this.cbSource.Location = new System.Drawing.Point(56, 72);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(276, 21);
            this.cbSource.TabIndex = 4;
            // 
            // gbRemarks
            // 
            this.gbRemarks.Controls.Add(this.tbRemarks);
            this.gbRemarks.Location = new System.Drawing.Point(10, 266);
            this.gbRemarks.Name = "gbRemarks";
            this.gbRemarks.Size = new System.Drawing.Size(338, 100);
            this.gbRemarks.TabIndex = 2;
            this.gbRemarks.TabStop = false;
            this.gbRemarks.Text = "Remarks";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(5, 19);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(327, 75);
            this.tbRemarks.TabIndex = 0;
            this.tbRemarks.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(179, 369);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(75, 369);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create Text";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // LocalStormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbRemarks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxResetTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LocalStormReport";
            this.Text = "Local Storm Report";
            this.boxResetTracking.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupInjFat)).EndInit();
            this.gbRemarks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox boxResetTracking;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label lblEvent;
        public System.Windows.Forms.DateTimePicker dtpStormReport;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.Label lblMagnitude;
        private System.Windows.Forms.Label lblInjFat;
        private System.Windows.Forms.NumericUpDown nupInjFat;
        private System.Windows.Forms.RadioButton rbFatalities;
        private System.Windows.Forms.RadioButton rbInjuries;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.GroupBox gbRemarks;
        private System.Windows.Forms.RichTextBox tbRemarks;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbMagnitude;
    }
}