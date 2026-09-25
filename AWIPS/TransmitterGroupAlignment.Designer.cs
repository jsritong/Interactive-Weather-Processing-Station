namespace AWIPS
{
    partial class TransmitterGroupAlignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransmitterGroupAlignment));
            this.gbTransmitters = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbTransmitterSelect = new System.Windows.Forms.ListBox();
            this.cbTransmitterGroup = new System.Windows.Forms.CheckBox();
            this.gbTransmitterGroupStatus = new System.Windows.Forms.GroupBox();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.lblTransmitterGroup = new System.Windows.Forms.Label();
            this.gbTransmitterGroupVolume = new System.Windows.Forms.GroupBox();
            this.lbl2400Value = new System.Windows.Forms.Label();
            this.btnAudioDown = new System.Windows.Forms.Button();
            this.btnAudioUp = new System.Windows.Forms.Button();
            this.lblAudioValue = new System.Windows.Forms.Label();
            this.btnSameDown = new System.Windows.Forms.Button();
            this.btnSameUp = new System.Windows.Forms.Button();
            this.lblSameValue = new System.Windows.Forms.Label();
            this.btnAlertDown = new System.Windows.Forms.Button();
            this.btnAlertUp = new System.Windows.Forms.Button();
            this.lblAlertValue = new System.Windows.Forms.Label();
            this.btn1800Down = new System.Windows.Forms.Button();
            this.btn1800Up = new System.Windows.Forms.Button();
            this.lbl1800Value = new System.Windows.Forms.Label();
            this.btn2400Down = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn2400Up = new System.Windows.Forms.Button();
            this.lbl2400 = new System.Windows.Forms.Label();
            this.tb2400 = new System.Windows.Forms.TrackBar();
            this.lbl1800 = new System.Windows.Forms.Label();
            this.tb1800 = new System.Windows.Forms.TrackBar();
            this.tbAudio = new System.Windows.Forms.TrackBar();
            this.tbSame = new System.Windows.Forms.TrackBar();
            this.lblSame = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblAudio = new System.Windows.Forms.Label();
            this.tbAlert = new System.Windows.Forms.TrackBar();
            this.gbLevelTest = new System.Windows.Forms.GroupBox();
            this.btnDurationDown = new System.Windows.Forms.Button();
            this.btnDurationUp = new System.Windows.Forms.Button();
            this.tbDuration = new System.Windows.Forms.TrackBar();
            this.lblDurationDisplay = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.rb2400 = new System.Windows.Forms.RadioButton();
            this.rb1800 = new System.Windows.Forms.RadioButton();
            this.rbAlert = new System.Windows.Forms.RadioButton();
            this.rbSame = new System.Windows.Forms.RadioButton();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.gbTransmitters.SuspendLayout();
            this.gbTransmitterGroupStatus.SuspendLayout();
            this.gbTransmitterGroupVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb2400)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1800)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlert)).BeginInit();
            this.gbLevelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTransmitters
            // 
            this.gbTransmitters.Controls.Add(this.btnRefresh);
            this.gbTransmitters.Controls.Add(this.lbTransmitterSelect);
            this.gbTransmitters.Controls.Add(this.cbTransmitterGroup);
            this.gbTransmitters.Location = new System.Drawing.Point(12, 12);
            this.gbTransmitters.Name = "gbTransmitters";
            this.gbTransmitters.Size = new System.Drawing.Size(132, 500);
            this.gbTransmitters.TabIndex = 0;
            this.gbTransmitters.TabStop = false;
            this.gbTransmitters.Text = "Transmitters";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 471);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbTransmitterSelect
            // 
            this.lbTransmitterSelect.FormattingEnabled = true;
            this.lbTransmitterSelect.Location = new System.Drawing.Point(6, 42);
            this.lbTransmitterSelect.Name = "lbTransmitterSelect";
            this.lbTransmitterSelect.Size = new System.Drawing.Size(120, 420);
            this.lbTransmitterSelect.TabIndex = 1;
            this.lbTransmitterSelect.SelectedIndexChanged += new System.EventHandler(this.lbTransmitterSelect_SelectedIndexChanged);
            // 
            // cbTransmitterGroup
            // 
            this.cbTransmitterGroup.AutoSize = true;
            this.cbTransmitterGroup.Checked = true;
            this.cbTransmitterGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTransmitterGroup.Enabled = false;
            this.cbTransmitterGroup.Location = new System.Drawing.Point(6, 19);
            this.cbTransmitterGroup.Name = "cbTransmitterGroup";
            this.cbTransmitterGroup.Size = new System.Drawing.Size(110, 17);
            this.cbTransmitterGroup.TabIndex = 0;
            this.cbTransmitterGroup.Text = "Transmitter Group";
            this.cbTransmitterGroup.UseVisualStyleBackColor = true;
            // 
            // gbTransmitterGroupStatus
            // 
            this.gbTransmitterGroupStatus.Controls.Add(this.btnDisable);
            this.gbTransmitterGroupStatus.Controls.Add(this.btnEnable);
            this.gbTransmitterGroupStatus.Controls.Add(this.btnMaintenance);
            this.gbTransmitterGroupStatus.Controls.Add(this.lblTransmitterGroup);
            this.gbTransmitterGroupStatus.Location = new System.Drawing.Point(150, 12);
            this.gbTransmitterGroupStatus.Name = "gbTransmitterGroupStatus";
            this.gbTransmitterGroupStatus.Size = new System.Drawing.Size(405, 73);
            this.gbTransmitterGroupStatus.TabIndex = 1;
            this.gbTransmitterGroupStatus.TabStop = false;
            this.gbTransmitterGroupStatus.Text = "Transmitter Group Status";
            // 
            // btnDisable
            // 
            this.btnDisable.Enabled = false;
            this.btnDisable.Location = new System.Drawing.Point(270, 42);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(120, 23);
            this.btnDisable.TabIndex = 3;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(144, 42);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(120, 23);
            this.btnEnable.TabIndex = 2;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Enabled = false;
            this.btnMaintenance.Location = new System.Drawing.Point(18, 42);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(120, 23);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // lblTransmitterGroup
            // 
            this.lblTransmitterGroup.Location = new System.Drawing.Point(6, 16);
            this.lblTransmitterGroup.Name = "lblTransmitterGroup";
            this.lblTransmitterGroup.Size = new System.Drawing.Size(393, 23);
            this.lblTransmitterGroup.TabIndex = 0;
            // 
            // gbTransmitterGroupVolume
            // 
            this.gbTransmitterGroupVolume.Controls.Add(this.lbl2400Value);
            this.gbTransmitterGroupVolume.Controls.Add(this.btnAudioDown);
            this.gbTransmitterGroupVolume.Controls.Add(this.btnAudioUp);
            this.gbTransmitterGroupVolume.Controls.Add(this.lblAudioValue);
            this.gbTransmitterGroupVolume.Controls.Add(this.btnSameDown);
            this.gbTransmitterGroupVolume.Controls.Add(this.btnSameUp);
            this.gbTransmitterGroupVolume.Controls.Add(this.lblSameValue);
            this.gbTransmitterGroupVolume.Controls.Add(this.btnAlertDown);
            this.gbTransmitterGroupVolume.Controls.Add(this.btnAlertUp);
            this.gbTransmitterGroupVolume.Controls.Add(this.lblAlertValue);
            this.gbTransmitterGroupVolume.Controls.Add(this.btn1800Down);
            this.gbTransmitterGroupVolume.Controls.Add(this.btn1800Up);
            this.gbTransmitterGroupVolume.Controls.Add(this.lbl1800Value);
            this.gbTransmitterGroupVolume.Controls.Add(this.btn2400Down);
            this.gbTransmitterGroupVolume.Controls.Add(this.btnSave);
            this.gbTransmitterGroupVolume.Controls.Add(this.btn2400Up);
            this.gbTransmitterGroupVolume.Controls.Add(this.lbl2400);
            this.gbTransmitterGroupVolume.Controls.Add(this.tb2400);
            this.gbTransmitterGroupVolume.Controls.Add(this.lbl1800);
            this.gbTransmitterGroupVolume.Controls.Add(this.tb1800);
            this.gbTransmitterGroupVolume.Controls.Add(this.tbAudio);
            this.gbTransmitterGroupVolume.Controls.Add(this.tbSame);
            this.gbTransmitterGroupVolume.Controls.Add(this.lblSame);
            this.gbTransmitterGroupVolume.Controls.Add(this.lblAlert);
            this.gbTransmitterGroupVolume.Controls.Add(this.lblAudio);
            this.gbTransmitterGroupVolume.Controls.Add(this.tbAlert);
            this.gbTransmitterGroupVolume.Location = new System.Drawing.Point(150, 91);
            this.gbTransmitterGroupVolume.Name = "gbTransmitterGroupVolume";
            this.gbTransmitterGroupVolume.Size = new System.Drawing.Size(405, 259);
            this.gbTransmitterGroupVolume.TabIndex = 2;
            this.gbTransmitterGroupVolume.TabStop = false;
            this.gbTransmitterGroupVolume.Text = "Transmitter Group Volume";
            this.gbTransmitterGroupVolume.Enter += new System.EventHandler(this.gbTransmitterGroupVolume_Enter);
            // 
            // lbl2400Value
            // 
            this.lbl2400Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2400Value.Location = new System.Drawing.Point(319, 196);
            this.lbl2400Value.Name = "lbl2400Value";
            this.lbl2400Value.Size = new System.Drawing.Size(35, 15);
            this.lbl2400Value.TabIndex = 22;
            this.lbl2400Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2400Value.Click += new System.EventHandler(this.lbl2400Value_Click);
            // 
            // btnAudioDown
            // 
            this.btnAudioDown.Enabled = false;
            this.btnAudioDown.Location = new System.Drawing.Point(358, 12);
            this.btnAudioDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnAudioDown.Name = "btnAudioDown";
            this.btnAudioDown.Size = new System.Drawing.Size(21, 23);
            this.btnAudioDown.TabIndex = 3;
            this.btnAudioDown.Text = "-";
            this.btnAudioDown.UseVisualStyleBackColor = true;
            this.btnAudioDown.Click += new System.EventHandler(this.btnAudioDown_Click);
            // 
            // btnAudioUp
            // 
            this.btnAudioUp.Enabled = false;
            this.btnAudioUp.Location = new System.Drawing.Point(379, 12);
            this.btnAudioUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnAudioUp.Name = "btnAudioUp";
            this.btnAudioUp.Size = new System.Drawing.Size(21, 23);
            this.btnAudioUp.TabIndex = 4;
            this.btnAudioUp.Text = "+";
            this.btnAudioUp.UseVisualStyleBackColor = true;
            this.btnAudioUp.Click += new System.EventHandler(this.btnAudioUp_Click);
            // 
            // lblAudioValue
            // 
            this.lblAudioValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAudioValue.Location = new System.Drawing.Point(319, 16);
            this.lblAudioValue.Name = "lblAudioValue";
            this.lblAudioValue.Size = new System.Drawing.Size(35, 15);
            this.lblAudioValue.TabIndex = 2;
            this.lblAudioValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAudioValue.Click += new System.EventHandler(this.lblAudioValue_Click);
            // 
            // btnSameDown
            // 
            this.btnSameDown.Enabled = false;
            this.btnSameDown.Location = new System.Drawing.Point(358, 57);
            this.btnSameDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnSameDown.Name = "btnSameDown";
            this.btnSameDown.Size = new System.Drawing.Size(21, 23);
            this.btnSameDown.TabIndex = 8;
            this.btnSameDown.Text = "-";
            this.btnSameDown.UseVisualStyleBackColor = true;
            this.btnSameDown.Click += new System.EventHandler(this.btnSameDown_Click);
            // 
            // btnSameUp
            // 
            this.btnSameUp.Enabled = false;
            this.btnSameUp.Location = new System.Drawing.Point(379, 57);
            this.btnSameUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnSameUp.Name = "btnSameUp";
            this.btnSameUp.Size = new System.Drawing.Size(21, 23);
            this.btnSameUp.TabIndex = 9;
            this.btnSameUp.Text = "+";
            this.btnSameUp.UseVisualStyleBackColor = true;
            this.btnSameUp.Click += new System.EventHandler(this.btnSameUp_Click);
            // 
            // lblSameValue
            // 
            this.lblSameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSameValue.Location = new System.Drawing.Point(319, 61);
            this.lblSameValue.Name = "lblSameValue";
            this.lblSameValue.Size = new System.Drawing.Size(35, 15);
            this.lblSameValue.TabIndex = 7;
            this.lblSameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlertDown
            // 
            this.btnAlertDown.Enabled = false;
            this.btnAlertDown.Location = new System.Drawing.Point(358, 102);
            this.btnAlertDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlertDown.Name = "btnAlertDown";
            this.btnAlertDown.Size = new System.Drawing.Size(21, 23);
            this.btnAlertDown.TabIndex = 13;
            this.btnAlertDown.Text = "-";
            this.btnAlertDown.UseVisualStyleBackColor = true;
            this.btnAlertDown.Click += new System.EventHandler(this.btnAlertDown_Click);
            // 
            // btnAlertUp
            // 
            this.btnAlertUp.Enabled = false;
            this.btnAlertUp.Location = new System.Drawing.Point(379, 102);
            this.btnAlertUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlertUp.Name = "btnAlertUp";
            this.btnAlertUp.Size = new System.Drawing.Size(21, 23);
            this.btnAlertUp.TabIndex = 14;
            this.btnAlertUp.Text = "+";
            this.btnAlertUp.UseVisualStyleBackColor = true;
            this.btnAlertUp.Click += new System.EventHandler(this.btnAlertUp_Click);
            // 
            // lblAlertValue
            // 
            this.lblAlertValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlertValue.Location = new System.Drawing.Point(319, 106);
            this.lblAlertValue.Name = "lblAlertValue";
            this.lblAlertValue.Size = new System.Drawing.Size(35, 15);
            this.lblAlertValue.TabIndex = 12;
            this.lblAlertValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1800Down
            // 
            this.btn1800Down.Enabled = false;
            this.btn1800Down.Location = new System.Drawing.Point(358, 147);
            this.btn1800Down.Margin = new System.Windows.Forms.Padding(0);
            this.btn1800Down.Name = "btn1800Down";
            this.btn1800Down.Size = new System.Drawing.Size(21, 23);
            this.btn1800Down.TabIndex = 18;
            this.btn1800Down.Text = "-";
            this.btn1800Down.UseVisualStyleBackColor = true;
            this.btn1800Down.Click += new System.EventHandler(this.btn1800Down_Click);
            // 
            // btn1800Up
            // 
            this.btn1800Up.Enabled = false;
            this.btn1800Up.Location = new System.Drawing.Point(379, 147);
            this.btn1800Up.Margin = new System.Windows.Forms.Padding(0);
            this.btn1800Up.Name = "btn1800Up";
            this.btn1800Up.Size = new System.Drawing.Size(21, 23);
            this.btn1800Up.TabIndex = 19;
            this.btn1800Up.Text = "+";
            this.btn1800Up.UseVisualStyleBackColor = true;
            this.btn1800Up.Click += new System.EventHandler(this.btn1800Up_Click);
            // 
            // lbl1800Value
            // 
            this.lbl1800Value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1800Value.Location = new System.Drawing.Point(319, 151);
            this.lbl1800Value.Name = "lbl1800Value";
            this.lbl1800Value.Size = new System.Drawing.Size(35, 15);
            this.lbl1800Value.TabIndex = 17;
            this.lbl1800Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2400Down
            // 
            this.btn2400Down.Enabled = false;
            this.btn2400Down.Location = new System.Drawing.Point(358, 192);
            this.btn2400Down.Margin = new System.Windows.Forms.Padding(0);
            this.btn2400Down.Name = "btn2400Down";
            this.btn2400Down.Size = new System.Drawing.Size(21, 23);
            this.btn2400Down.TabIndex = 23;
            this.btn2400Down.Text = "-";
            this.btn2400Down.UseVisualStyleBackColor = true;
            this.btn2400Down.Click += new System.EventHandler(this.btn2400Down_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(168, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn2400Up
            // 
            this.btn2400Up.Enabled = false;
            this.btn2400Up.Location = new System.Drawing.Point(379, 192);
            this.btn2400Up.Margin = new System.Windows.Forms.Padding(0);
            this.btn2400Up.Name = "btn2400Up";
            this.btn2400Up.Size = new System.Drawing.Size(21, 23);
            this.btn2400Up.TabIndex = 24;
            this.btn2400Up.Text = "+";
            this.btn2400Up.UseVisualStyleBackColor = true;
            this.btn2400Up.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl2400
            // 
            this.lbl2400.AutoSize = true;
            this.lbl2400.Location = new System.Drawing.Point(7, 196);
            this.lbl2400.Name = "lbl2400";
            this.lbl2400.Size = new System.Drawing.Size(80, 13);
            this.lbl2400.TabIndex = 20;
            this.lbl2400.Text = "2400hz Volume";
            // 
            // tb2400
            // 
            this.tb2400.Enabled = false;
            this.tb2400.Location = new System.Drawing.Point(84, 196);
            this.tb2400.Margin = new System.Windows.Forms.Padding(0);
            this.tb2400.Maximum = 100;
            this.tb2400.Name = "tb2400";
            this.tb2400.Size = new System.Drawing.Size(232, 45);
            this.tb2400.TabIndex = 21;
            this.tb2400.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb2400.Scroll += new System.EventHandler(this.tb2400_Scroll);
            // 
            // lbl1800
            // 
            this.lbl1800.AutoSize = true;
            this.lbl1800.Location = new System.Drawing.Point(7, 151);
            this.lbl1800.Name = "lbl1800";
            this.lbl1800.Size = new System.Drawing.Size(80, 13);
            this.lbl1800.TabIndex = 15;
            this.lbl1800.Text = "1800hz Volume";
            this.lbl1800.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb1800
            // 
            this.tb1800.Enabled = false;
            this.tb1800.Location = new System.Drawing.Point(84, 151);
            this.tb1800.Margin = new System.Windows.Forms.Padding(0);
            this.tb1800.Maximum = 100;
            this.tb1800.Name = "tb1800";
            this.tb1800.Size = new System.Drawing.Size(232, 45);
            this.tb1800.TabIndex = 16;
            this.tb1800.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb1800.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // tbAudio
            // 
            this.tbAudio.Enabled = false;
            this.tbAudio.Location = new System.Drawing.Point(84, 16);
            this.tbAudio.Margin = new System.Windows.Forms.Padding(0);
            this.tbAudio.Maximum = 100;
            this.tbAudio.Name = "tbAudio";
            this.tbAudio.Size = new System.Drawing.Size(232, 45);
            this.tbAudio.TabIndex = 1;
            this.tbAudio.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudio.Scroll += new System.EventHandler(this.tbAudio_Scroll);
            // 
            // tbSame
            // 
            this.tbSame.Enabled = false;
            this.tbSame.Location = new System.Drawing.Point(84, 61);
            this.tbSame.Margin = new System.Windows.Forms.Padding(0);
            this.tbSame.Maximum = 100;
            this.tbSame.Name = "tbSame";
            this.tbSame.Size = new System.Drawing.Size(232, 45);
            this.tbSame.TabIndex = 6;
            this.tbSame.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSame.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lblSame
            // 
            this.lblSame.AutoSize = true;
            this.lblSame.Location = new System.Drawing.Point(12, 61);
            this.lblSame.Name = "lblSame";
            this.lblSame.Size = new System.Drawing.Size(75, 13);
            this.lblSame.TabIndex = 5;
            this.lblSame.Text = "SAME Volume";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(21, 106);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(66, 13);
            this.lblAlert.TabIndex = 10;
            this.lblAlert.Text = "Alert Volume";
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Location = new System.Drawing.Point(15, 16);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(72, 13);
            this.lblAudio.TabIndex = 0;
            this.lblAudio.Text = "Audio Volume";
            // 
            // tbAlert
            // 
            this.tbAlert.Enabled = false;
            this.tbAlert.Location = new System.Drawing.Point(84, 106);
            this.tbAlert.Margin = new System.Windows.Forms.Padding(0);
            this.tbAlert.Maximum = 100;
            this.tbAlert.Name = "tbAlert";
            this.tbAlert.Size = new System.Drawing.Size(232, 45);
            this.tbAlert.TabIndex = 11;
            this.tbAlert.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAlert.Scroll += new System.EventHandler(this.tbAlert_Scroll);
            // 
            // gbLevelTest
            // 
            this.gbLevelTest.Controls.Add(this.btnDurationDown);
            this.gbLevelTest.Controls.Add(this.btnDurationUp);
            this.gbLevelTest.Controls.Add(this.tbDuration);
            this.gbLevelTest.Controls.Add(this.lblDurationDisplay);
            this.gbLevelTest.Controls.Add(this.lblDuration);
            this.gbLevelTest.Controls.Add(this.btnRunTest);
            this.gbLevelTest.Controls.Add(this.rb2400);
            this.gbLevelTest.Controls.Add(this.rb1800);
            this.gbLevelTest.Controls.Add(this.rbAlert);
            this.gbLevelTest.Controls.Add(this.rbSame);
            this.gbLevelTest.Controls.Add(this.rbAudio);
            this.gbLevelTest.Location = new System.Drawing.Point(150, 356);
            this.gbLevelTest.Name = "gbLevelTest";
            this.gbLevelTest.Size = new System.Drawing.Size(405, 156);
            this.gbLevelTest.TabIndex = 3;
            this.gbLevelTest.TabStop = false;
            this.gbLevelTest.Text = "Level Test";
            // 
            // btnDurationDown
            // 
            this.btnDurationDown.Enabled = false;
            this.btnDurationDown.Location = new System.Drawing.Point(358, 59);
            this.btnDurationDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnDurationDown.Name = "btnDurationDown";
            this.btnDurationDown.Size = new System.Drawing.Size(21, 23);
            this.btnDurationDown.TabIndex = 8;
            this.btnDurationDown.Text = "-";
            this.btnDurationDown.UseVisualStyleBackColor = true;
            this.btnDurationDown.Click += new System.EventHandler(this.btnDurationDown_Click);
            // 
            // btnDurationUp
            // 
            this.btnDurationUp.Enabled = false;
            this.btnDurationUp.Location = new System.Drawing.Point(379, 59);
            this.btnDurationUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnDurationUp.Name = "btnDurationUp";
            this.btnDurationUp.Size = new System.Drawing.Size(21, 23);
            this.btnDurationUp.TabIndex = 9;
            this.btnDurationUp.Text = "+";
            this.btnDurationUp.UseVisualStyleBackColor = true;
            this.btnDurationUp.Click += new System.EventHandler(this.btnDurationUp_Click);
            // 
            // tbDuration
            // 
            this.tbDuration.Enabled = false;
            this.tbDuration.Location = new System.Drawing.Point(195, 60);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(0);
            this.tbDuration.Maximum = 30;
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDuration.Size = new System.Drawing.Size(121, 45);
            this.tbDuration.TabIndex = 6;
            this.tbDuration.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDuration.Value = 3;
            this.tbDuration.Scroll += new System.EventHandler(this.tbDuration_Scroll);
            // 
            // lblDurationDisplay
            // 
            this.lblDurationDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDurationDisplay.Location = new System.Drawing.Point(319, 63);
            this.lblDurationDisplay.Name = "lblDurationDisplay";
            this.lblDurationDisplay.Size = new System.Drawing.Size(35, 15);
            this.lblDurationDisplay.TabIndex = 7;
            this.lblDurationDisplay.Text = "10";
            this.lblDurationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(192, 41);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(96, 13);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration (seconds)";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // btnRunTest
            // 
            this.btnRunTest.Enabled = false;
            this.btnRunTest.Location = new System.Drawing.Point(168, 127);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(75, 23);
            this.btnRunTest.TabIndex = 10;
            this.btnRunTest.Text = "Run Test";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // rb2400
            // 
            this.rb2400.AutoSize = true;
            this.rb2400.Enabled = false;
            this.rb2400.Location = new System.Drawing.Point(6, 111);
            this.rb2400.Name = "rb2400";
            this.rb2400.Size = new System.Drawing.Size(102, 17);
            this.rb2400.TabIndex = 4;
            this.rb2400.Text = "Transfer 2400hz";
            this.rb2400.UseVisualStyleBackColor = true;
            // 
            // rb1800
            // 
            this.rb1800.AutoSize = true;
            this.rb1800.Enabled = false;
            this.rb1800.Location = new System.Drawing.Point(6, 88);
            this.rb1800.Name = "rb1800";
            this.rb1800.Size = new System.Drawing.Size(102, 17);
            this.rb1800.TabIndex = 3;
            this.rb1800.Text = "Transfer 1800hz";
            this.rb1800.UseVisualStyleBackColor = true;
            // 
            // rbAlert
            // 
            this.rbAlert.AutoSize = true;
            this.rbAlert.Enabled = false;
            this.rbAlert.Location = new System.Drawing.Point(6, 65);
            this.rbAlert.Name = "rbAlert";
            this.rbAlert.Size = new System.Drawing.Size(46, 17);
            this.rbAlert.TabIndex = 2;
            this.rbAlert.Text = "Alert";
            this.rbAlert.UseVisualStyleBackColor = true;
            // 
            // rbSame
            // 
            this.rbSame.AutoSize = true;
            this.rbSame.Enabled = false;
            this.rbSame.Location = new System.Drawing.Point(6, 42);
            this.rbSame.Name = "rbSame";
            this.rbSame.Size = new System.Drawing.Size(55, 17);
            this.rbSame.TabIndex = 1;
            this.rbSame.Text = "SAME";
            this.rbSame.UseVisualStyleBackColor = true;
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Checked = true;
            this.rbAudio.Enabled = false;
            this.rbAudio.Location = new System.Drawing.Point(6, 19);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(52, 17);
            this.rbAudio.TabIndex = 0;
            this.rbAudio.TabStop = true;
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            // 
            // TransmitterGroupAlignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 524);
            this.Controls.Add(this.gbLevelTest);
            this.Controls.Add(this.gbTransmitterGroupVolume);
            this.Controls.Add(this.gbTransmitterGroupStatus);
            this.Controls.Add(this.gbTransmitters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransmitterGroupAlignment";
            this.Text = "Transmitter Group Alignment";
            this.Load += new System.EventHandler(this.TransmitterGroupAlignment_Load);
            this.gbTransmitters.ResumeLayout(false);
            this.gbTransmitters.PerformLayout();
            this.gbTransmitterGroupStatus.ResumeLayout(false);
            this.gbTransmitterGroupVolume.ResumeLayout(false);
            this.gbTransmitterGroupVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb2400)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1800)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlert)).EndInit();
            this.gbLevelTest.ResumeLayout(false);
            this.gbLevelTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransmitters;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lbTransmitterSelect;
        private System.Windows.Forms.CheckBox cbTransmitterGroup;
        private System.Windows.Forms.GroupBox gbTransmitterGroupStatus;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label lblTransmitterGroup;
        private System.Windows.Forms.GroupBox gbTransmitterGroupVolume;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.TrackBar tbSame;
        private System.Windows.Forms.Label lblSame;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lbl1800;
        private System.Windows.Forms.TrackBar tb1800;
        private System.Windows.Forms.TrackBar tbAudio;
        private System.Windows.Forms.TrackBar tbAlert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl2400;
        private System.Windows.Forms.TrackBar tb2400;
        private System.Windows.Forms.Button btn2400Up;
        private System.Windows.Forms.Button btn2400Down;
        private System.Windows.Forms.Button btnAudioDown;
        private System.Windows.Forms.Button btnAudioUp;
        private System.Windows.Forms.Label lblAudioValue;
        private System.Windows.Forms.Button btnSameDown;
        private System.Windows.Forms.Button btnSameUp;
        private System.Windows.Forms.Label lblSameValue;
        private System.Windows.Forms.Button btnAlertDown;
        private System.Windows.Forms.Button btnAlertUp;
        private System.Windows.Forms.Label lblAlertValue;
        private System.Windows.Forms.Button btn1800Down;
        private System.Windows.Forms.Button btn1800Up;
        private System.Windows.Forms.Label lbl1800Value;
        private System.Windows.Forms.GroupBox gbLevelTest;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.RadioButton rb2400;
        private System.Windows.Forms.RadioButton rb1800;
        private System.Windows.Forms.RadioButton rbAlert;
        private System.Windows.Forms.RadioButton rbSame;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.TrackBar tbDuration;
        private System.Windows.Forms.Button btnDurationDown;
        private System.Windows.Forms.Button btnDurationUp;
        private System.Windows.Forms.Label lblDurationDisplay;
        private System.Windows.Forms.Label lbl2400Value;
    }
}