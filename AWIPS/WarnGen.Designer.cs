namespace AWIPS
{
    partial class WarnGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarnGen));
            this.btnReset = new System.Windows.Forms.Button();
            this.rdoSingleStm = new System.Windows.Forms.RadioButton();
            this.boxResetTracking = new System.Windows.Forms.GroupBox();
            this.boxTrackType = new System.Windows.Forms.GroupBox();
            this.rdoLineStm = new System.Windows.Forms.RadioButton();
            this.boxEdit = new System.Windows.Forms.GroupBox();
            this.rdoBoxTrack = new System.Windows.Forms.RadioButton();
            this.rdoTrack = new System.Windows.Forms.RadioButton();
            this.rdoBox = new System.Windows.Forms.RadioButton();
            this.boxInstructions = new System.Windows.Forms.GroupBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.boxRedraw = new System.Windows.Forms.GroupBox();
            this.btnPresetThrt = new System.Windows.Forms.Button();
            this.btnWarnedHatched = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.chkWarnedArea = new System.Windows.Forms.CheckBox();
            this.boxProductType = new System.Windows.Forms.GroupBox();
            this.cbUpdateList = new System.Windows.Forms.ComboBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFlashFlood = new System.Windows.Forms.RadioButton();
            this.rdoSpecialWx = new System.Windows.Forms.RadioButton();
            this.rdoSevereWx = new System.Windows.Forms.RadioButton();
            this.ddOther = new System.Windows.Forms.ComboBox();
            this.rdoSevereTstm = new System.Windows.Forms.RadioButton();
            this.rdoTornado = new System.Windows.Forms.RadioButton();
            this.boxTimeRange = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.ddDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbSelections = new System.Windows.Forms.ListBox();
            this.boxResetTracking.SuspendLayout();
            this.boxTrackType.SuspendLayout();
            this.boxEdit.SuspendLayout();
            this.boxInstructions.SuspendLayout();
            this.boxRedraw.SuspendLayout();
            this.boxProductType.SuspendLayout();
            this.boxTimeRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(5, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoSingleStm
            // 
            this.rdoSingleStm.AutoSize = true;
            this.rdoSingleStm.Checked = true;
            this.rdoSingleStm.Location = new System.Drawing.Point(4, 17);
            this.rdoSingleStm.Margin = new System.Windows.Forms.Padding(1);
            this.rdoSingleStm.Name = "rdoSingleStm";
            this.rdoSingleStm.Size = new System.Drawing.Size(84, 17);
            this.rdoSingleStm.TabIndex = 0;
            this.rdoSingleStm.TabStop = true;
            this.rdoSingleStm.Text = "Single Storm";
            this.rdoSingleStm.UseVisualStyleBackColor = true;
            this.rdoSingleStm.CheckedChanged += new System.EventHandler(this.rdoSingleStm_CheckedChanged);
            // 
            // boxResetTracking
            // 
            this.boxResetTracking.Controls.Add(this.btnReset);
            this.boxResetTracking.Location = new System.Drawing.Point(12, 12);
            this.boxResetTracking.Margin = new System.Windows.Forms.Padding(1);
            this.boxResetTracking.Name = "boxResetTracking";
            this.boxResetTracking.Size = new System.Drawing.Size(133, 80);
            this.boxResetTracking.TabIndex = 0;
            this.boxResetTracking.TabStop = false;
            this.boxResetTracking.Text = "Reset Tracking";
            // 
            // boxTrackType
            // 
            this.boxTrackType.Controls.Add(this.rdoLineStm);
            this.boxTrackType.Controls.Add(this.rdoSingleStm);
            this.boxTrackType.Location = new System.Drawing.Point(147, 12);
            this.boxTrackType.Margin = new System.Windows.Forms.Padding(1);
            this.boxTrackType.Name = "boxTrackType";
            this.boxTrackType.Size = new System.Drawing.Size(131, 80);
            this.boxTrackType.TabIndex = 1;
            this.boxTrackType.TabStop = false;
            this.boxTrackType.Text = "Track type";
            // 
            // rdoLineStm
            // 
            this.rdoLineStm.AutoSize = true;
            this.rdoLineStm.Location = new System.Drawing.Point(4, 36);
            this.rdoLineStm.Margin = new System.Windows.Forms.Padding(1);
            this.rdoLineStm.Name = "rdoLineStm";
            this.rdoLineStm.Size = new System.Drawing.Size(92, 17);
            this.rdoLineStm.TabIndex = 1;
            this.rdoLineStm.TabStop = true;
            this.rdoLineStm.Text = "Line of Storms";
            this.rdoLineStm.UseVisualStyleBackColor = true;
            this.rdoLineStm.CheckedChanged += new System.EventHandler(this.rdoLineStm_CheckedChanged);
            // 
            // boxEdit
            // 
            this.boxEdit.Controls.Add(this.rdoBoxTrack);
            this.boxEdit.Controls.Add(this.rdoTrack);
            this.boxEdit.Controls.Add(this.rdoBox);
            this.boxEdit.Location = new System.Drawing.Point(280, 12);
            this.boxEdit.Margin = new System.Windows.Forms.Padding(1);
            this.boxEdit.Name = "boxEdit";
            this.boxEdit.Size = new System.Drawing.Size(116, 80);
            this.boxEdit.TabIndex = 2;
            this.boxEdit.TabStop = false;
            this.boxEdit.Text = "Edit";
            this.boxEdit.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rdoBoxTrack
            // 
            this.rdoBoxTrack.AutoSize = true;
            this.rdoBoxTrack.Checked = true;
            this.rdoBoxTrack.Location = new System.Drawing.Point(4, 55);
            this.rdoBoxTrack.Margin = new System.Windows.Forms.Padding(1);
            this.rdoBoxTrack.Name = "rdoBoxTrack";
            this.rdoBoxTrack.Size = new System.Drawing.Size(95, 17);
            this.rdoBoxTrack.TabIndex = 2;
            this.rdoBoxTrack.TabStop = true;
            this.rdoBoxTrack.Text = "Box and Track";
            this.rdoBoxTrack.UseVisualStyleBackColor = true;
            this.rdoBoxTrack.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged_1);
            // 
            // rdoTrack
            // 
            this.rdoTrack.AutoSize = true;
            this.rdoTrack.Enabled = false;
            this.rdoTrack.Location = new System.Drawing.Point(4, 36);
            this.rdoTrack.Margin = new System.Windows.Forms.Padding(1);
            this.rdoTrack.Name = "rdoTrack";
            this.rdoTrack.Size = new System.Drawing.Size(53, 17);
            this.rdoTrack.TabIndex = 1;
            this.rdoTrack.TabStop = true;
            this.rdoTrack.Text = "Track";
            this.rdoTrack.UseVisualStyleBackColor = true;
            this.rdoTrack.CheckedChanged += new System.EventHandler(this.rdoTrack_CheckedChanged);
            // 
            // rdoBox
            // 
            this.rdoBox.AutoSize = true;
            this.rdoBox.Enabled = false;
            this.rdoBox.Location = new System.Drawing.Point(4, 17);
            this.rdoBox.Margin = new System.Windows.Forms.Padding(1);
            this.rdoBox.Name = "rdoBox";
            this.rdoBox.Size = new System.Drawing.Size(43, 17);
            this.rdoBox.TabIndex = 0;
            this.rdoBox.Text = "Box";
            this.rdoBox.UseVisualStyleBackColor = true;
            this.rdoBox.CheckedChanged += new System.EventHandler(this.rdoBox_CheckedChanged);
            // 
            // boxInstructions
            // 
            this.boxInstructions.Controls.Add(this.lblInstructions);
            this.boxInstructions.Location = new System.Drawing.Point(12, 91);
            this.boxInstructions.Margin = new System.Windows.Forms.Padding(1);
            this.boxInstructions.Name = "boxInstructions";
            this.boxInstructions.Size = new System.Drawing.Size(384, 58);
            this.boxInstructions.TabIndex = 3;
            this.boxInstructions.TabStop = false;
            this.boxInstructions.Text = "Instructions";
            this.boxInstructions.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(6, 16);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(0, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // boxRedraw
            // 
            this.boxRedraw.Controls.Add(this.btnPresetThrt);
            this.boxRedraw.Controls.Add(this.btnWarnedHatched);
            this.boxRedraw.Controls.Add(this.btnTrack);
            this.boxRedraw.Controls.Add(this.chkWarnedArea);
            this.boxRedraw.Location = new System.Drawing.Point(12, 151);
            this.boxRedraw.Margin = new System.Windows.Forms.Padding(1);
            this.boxRedraw.Name = "boxRedraw";
            this.boxRedraw.Size = new System.Drawing.Size(384, 70);
            this.boxRedraw.TabIndex = 4;
            this.boxRedraw.TabStop = false;
            this.boxRedraw.Text = "Redraw Box on Screen from:";
            // 
            // btnPresetThrt
            // 
            this.btnPresetThrt.Enabled = false;
            this.btnPresetThrt.Location = new System.Drawing.Point(187, 42);
            this.btnPresetThrt.Margin = new System.Windows.Forms.Padding(0);
            this.btnPresetThrt.Name = "btnPresetThrt";
            this.btnPresetThrt.Size = new System.Drawing.Size(107, 23);
            this.btnPresetThrt.TabIndex = 0;
            this.btnPresetThrt.Text = "Preset Threat Area";
            this.btnPresetThrt.UseVisualStyleBackColor = true;
            this.btnPresetThrt.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnWarnedHatched
            // 
            this.btnWarnedHatched.Enabled = false;
            this.btnWarnedHatched.Location = new System.Drawing.Point(60, 42);
            this.btnWarnedHatched.Margin = new System.Windows.Forms.Padding(0);
            this.btnWarnedHatched.Name = "btnWarnedHatched";
            this.btnWarnedHatched.Size = new System.Drawing.Size(127, 23);
            this.btnWarnedHatched.TabIndex = 3;
            this.btnWarnedHatched.Text = "Warned/Hatched Area";
            this.btnWarnedHatched.UseVisualStyleBackColor = true;
            this.btnWarnedHatched.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(6, 42);
            this.btnTrack.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(54, 23);
            this.btnTrack.TabIndex = 2;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // chkWarnedArea
            // 
            this.chkWarnedArea.AutoSize = true;
            this.chkWarnedArea.Checked = true;
            this.chkWarnedArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarnedArea.Enabled = false;
            this.chkWarnedArea.Location = new System.Drawing.Point(258, 17);
            this.chkWarnedArea.Margin = new System.Windows.Forms.Padding(1);
            this.chkWarnedArea.Name = "chkWarnedArea";
            this.chkWarnedArea.Size = new System.Drawing.Size(122, 17);
            this.chkWarnedArea.TabIndex = 0;
            this.chkWarnedArea.Text = "Warned Area Visible";
            this.chkWarnedArea.UseVisualStyleBackColor = true;
            this.chkWarnedArea.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // boxProductType
            // 
            this.boxProductType.Controls.Add(this.cbUpdateList);
            this.boxProductType.Controls.Add(this.rdoOther);
            this.boxProductType.Controls.Add(this.rdoFlashFlood);
            this.boxProductType.Controls.Add(this.rdoSpecialWx);
            this.boxProductType.Controls.Add(this.rdoSevereWx);
            this.boxProductType.Controls.Add(this.ddOther);
            this.boxProductType.Controls.Add(this.rdoSevereTstm);
            this.boxProductType.Controls.Add(this.rdoTornado);
            this.boxProductType.Location = new System.Drawing.Point(12, 223);
            this.boxProductType.Margin = new System.Windows.Forms.Padding(1);
            this.boxProductType.Name = "boxProductType";
            this.boxProductType.Size = new System.Drawing.Size(384, 140);
            this.boxProductType.TabIndex = 5;
            this.boxProductType.TabStop = false;
            this.boxProductType.Text = "Product type";
            this.boxProductType.Enter += new System.EventHandler(this.boxProductType_Enter);
            // 
            // cbUpdateList
            // 
            this.cbUpdateList.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.cbUpdateList.AllowDrop = true;
            this.cbUpdateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateList.Enabled = false;
            this.cbUpdateList.FormattingEnabled = true;
            this.cbUpdateList.Location = new System.Drawing.Point(192, 14);
            this.cbUpdateList.Margin = new System.Windows.Forms.Padding(1);
            this.cbUpdateList.Name = "cbUpdateList";
            this.cbUpdateList.Size = new System.Drawing.Size(188, 21);
            this.cbUpdateList.TabIndex = 0;
            this.cbUpdateList.SelectedIndexChanged += new System.EventHandler(this.cbUpdateList_SelectedIndexChanged);
            this.cbUpdateList.Click += new System.EventHandler(this.cbUpdateList_Click);
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(6, 113);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(1);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(54, 17);
            this.rdoOther.TabIndex = 6;
            this.rdoOther.Text = "Other:";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
            // 
            // rdoFlashFlood
            // 
            this.rdoFlashFlood.AutoSize = true;
            this.rdoFlashFlood.Location = new System.Drawing.Point(6, 94);
            this.rdoFlashFlood.Margin = new System.Windows.Forms.Padding(1);
            this.rdoFlashFlood.Name = "rdoFlashFlood";
            this.rdoFlashFlood.Size = new System.Drawing.Size(122, 17);
            this.rdoFlashFlood.TabIndex = 5;
            this.rdoFlashFlood.TabStop = true;
            this.rdoFlashFlood.Text = "Flash Flood Warning";
            this.rdoFlashFlood.UseVisualStyleBackColor = true;
            this.rdoFlashFlood.CheckedChanged += new System.EventHandler(this.rdoFlashFlood_CheckedChanged);
            // 
            // rdoSpecialWx
            // 
            this.rdoSpecialWx.AutoSize = true;
            this.rdoSpecialWx.Location = new System.Drawing.Point(6, 75);
            this.rdoSpecialWx.Margin = new System.Windows.Forms.Padding(1);
            this.rdoSpecialWx.Name = "rdoSpecialWx";
            this.rdoSpecialWx.Size = new System.Drawing.Size(155, 17);
            this.rdoSpecialWx.TabIndex = 4;
            this.rdoSpecialWx.TabStop = true;
            this.rdoSpecialWx.Text = "Special Weather Statement";
            this.rdoSpecialWx.UseVisualStyleBackColor = true;
            this.rdoSpecialWx.CheckedChanged += new System.EventHandler(this.rdoSpecialWx_CheckedChanged);
            // 
            // rdoSevereWx
            // 
            this.rdoSevereWx.AutoSize = true;
            this.rdoSevereWx.Location = new System.Drawing.Point(6, 56);
            this.rdoSevereWx.Margin = new System.Windows.Forms.Padding(1);
            this.rdoSevereWx.Name = "rdoSevereWx";
            this.rdoSevereWx.Size = new System.Drawing.Size(154, 17);
            this.rdoSevereWx.TabIndex = 3;
            this.rdoSevereWx.Text = "Severe Weather Statement";
            this.rdoSevereWx.UseVisualStyleBackColor = true;
            this.rdoSevereWx.CheckedChanged += new System.EventHandler(this.rdoSevereWx_CheckedChanged);
            // 
            // ddOther
            // 
            this.ddOther.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.ddOther.AllowDrop = true;
            this.ddOther.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddOther.FormattingEnabled = true;
            this.ddOther.Items.AddRange(new object[] {
            "Flash Flood Statement",
            "Non-Convective FFW (incl. Dam Break)",
            "Non-Convective Flash Flood Statement",
            "Areal Flood Warning",
            "Areal Flood Warning Followup",
            "Areal Flood Advisory",
            "Areal Flood Advisory Followup",
            "Snow Squall Warning",
            "Snow Squall Warning Follow-up",
            "Blowing Dust Advisory",
            "Blowing Dust Advisory Follow-up",
            "Dust Storm Warning",
            "Dust Storm Warning Follow-up",
            "Airport Weather Warning",
            "Extreme Wind Warning",
            "Extreme Wind Warning Follow-up",
            "Special Marine Warning",
            "Special Marine Warning Follow-up",
            "Marine Weather Statement",
            "Marine Weather Statement for Ashfall",
            "Short Term Forecast",
            "Watch County Notification",
            "Watch County Notification Follow-up"});
            this.ddOther.Location = new System.Drawing.Point(153, 113);
            this.ddOther.Margin = new System.Windows.Forms.Padding(1);
            this.ddOther.Name = "ddOther";
            this.ddOther.Size = new System.Drawing.Size(227, 21);
            this.ddOther.TabIndex = 7;
            this.ddOther.SelectedIndexChanged += new System.EventHandler(this.ddOther_SelectedIndexChanged);
            // 
            // rdoSevereTstm
            // 
            this.rdoSevereTstm.AutoSize = true;
            this.rdoSevereTstm.Checked = true;
            this.rdoSevereTstm.Location = new System.Drawing.Point(6, 37);
            this.rdoSevereTstm.Margin = new System.Windows.Forms.Padding(1);
            this.rdoSevereTstm.Name = "rdoSevereTstm";
            this.rdoSevereTstm.Size = new System.Drawing.Size(127, 17);
            this.rdoSevereTstm.TabIndex = 2;
            this.rdoSevereTstm.TabStop = true;
            this.rdoSevereTstm.Text = "Severe Thunderstorm";
            this.rdoSevereTstm.UseVisualStyleBackColor = true;
            this.rdoSevereTstm.CheckedChanged += new System.EventHandler(this.rdoSevereTstm_CheckedChanged);
            // 
            // rdoTornado
            // 
            this.rdoTornado.AutoSize = true;
            this.rdoTornado.Location = new System.Drawing.Point(6, 18);
            this.rdoTornado.Margin = new System.Windows.Forms.Padding(1);
            this.rdoTornado.Name = "rdoTornado";
            this.rdoTornado.Size = new System.Drawing.Size(65, 17);
            this.rdoTornado.TabIndex = 1;
            this.rdoTornado.TabStop = true;
            this.rdoTornado.Text = "Tornado";
            this.rdoTornado.UseVisualStyleBackColor = true;
            this.rdoTornado.CheckedChanged += new System.EventHandler(this.rdoTornado_CheckedChanged);
            // 
            // boxTimeRange
            // 
            this.boxTimeRange.Controls.Add(this.lblDuration);
            this.boxTimeRange.Controls.Add(this.ddDuration);
            this.boxTimeRange.Controls.Add(this.label2);
            this.boxTimeRange.Location = new System.Drawing.Point(12, 365);
            this.boxTimeRange.Margin = new System.Windows.Forms.Padding(1);
            this.boxTimeRange.Name = "boxTimeRange";
            this.boxTimeRange.Size = new System.Drawing.Size(384, 47);
            this.boxTimeRange.TabIndex = 6;
            this.boxTimeRange.TabStop = false;
            this.boxTimeRange.Text = "Time Range";
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
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(100, 569);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Text";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(204, 569);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbSelections
            // 
            this.lbSelections.FormattingEnabled = true;
            this.lbSelections.Location = new System.Drawing.Point(12, 414);
            this.lbSelections.Margin = new System.Windows.Forms.Padding(1);
            this.lbSelections.Name = "lbSelections";
            this.lbSelections.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSelections.Size = new System.Drawing.Size(384, 147);
            this.lbSelections.TabIndex = 7;
            this.lbSelections.SelectedIndexChanged += new System.EventHandler(this.lbSelections_SelectedIndexChanged);
            // 
            // WarnGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 602);
            this.Controls.Add(this.lbSelections);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.boxTimeRange);
            this.Controls.Add(this.boxProductType);
            this.Controls.Add(this.boxRedraw);
            this.Controls.Add(this.boxInstructions);
            this.Controls.Add(this.boxEdit);
            this.Controls.Add(this.boxTrackType);
            this.Controls.Add(this.boxResetTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WarnGen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WarnGen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxResetTracking.ResumeLayout(false);
            this.boxTrackType.ResumeLayout(false);
            this.boxTrackType.PerformLayout();
            this.boxEdit.ResumeLayout(false);
            this.boxEdit.PerformLayout();
            this.boxInstructions.ResumeLayout(false);
            this.boxInstructions.PerformLayout();
            this.boxRedraw.ResumeLayout(false);
            this.boxRedraw.PerformLayout();
            this.boxProductType.ResumeLayout(false);
            this.boxProductType.PerformLayout();
            this.boxTimeRange.ResumeLayout(false);
            this.boxTimeRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdoSingleStm;
        private System.Windows.Forms.GroupBox boxResetTracking;
        private System.Windows.Forms.GroupBox boxTrackType;
        private System.Windows.Forms.GroupBox boxEdit;
        private System.Windows.Forms.GroupBox boxInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.GroupBox boxRedraw;
        private System.Windows.Forms.CheckBox chkWarnedArea;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.GroupBox boxProductType;
        private System.Windows.Forms.ComboBox ddOther;
        private System.Windows.Forms.RadioButton rdoLineStm;
        private System.Windows.Forms.Button btnPresetThrt;
        private System.Windows.Forms.Button btnWarnedHatched;
        private System.Windows.Forms.RadioButton rdoBoxTrack;
        private System.Windows.Forms.RadioButton rdoTrack;
        private System.Windows.Forms.RadioButton rdoBox;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFlashFlood;
        private System.Windows.Forms.RadioButton rdoSpecialWx;
        private System.Windows.Forms.RadioButton rdoSevereWx;
        private System.Windows.Forms.RadioButton rdoSevereTstm;
        private System.Windows.Forms.RadioButton rdoTornado;
        private System.Windows.Forms.GroupBox boxTimeRange;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ComboBox ddDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbSelections;
        private System.Windows.Forms.ComboBox cbUpdateList;
    }
}

