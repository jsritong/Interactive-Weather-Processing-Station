namespace AWIPS
{
    partial class BMHMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMHMenu));
            this.gbTransmitters = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbTransmitterSelect = new System.Windows.Forms.ListBox();
            this.cbTransmitterGroup = new System.Windows.Forms.CheckBox();
            this.gbSelectedTransmitter = new System.Windows.Forms.GroupBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lbDAC = new System.Windows.Forms.Label();
            this.lbTimezone = new System.Windows.Forms.Label();
            this.cbMonitorInLine = new System.Windows.Forms.CheckBox();
            this.lbTransmitter = new System.Windows.Forms.Label();
            this.gbProgramSuite = new System.Windows.Forms.GroupBox();
            this.lblCycleDuration = new System.Windows.Forms.Label();
            this.btnChangeSuite = new System.Windows.Forms.Button();
            this.lblSuiteCategory = new System.Windows.Forms.Label();
            this.lblSuite = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblSuiteCategoryStatic = new System.Windows.Forms.Label();
            this.lblSuiteStatic = new System.Windows.Forms.Label();
            this.lblProgramStatic = new System.Windows.Forms.Label();
            this.gbTransmitTime = new System.Windows.Forms.GroupBox();
            this.lblPredicted = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.gbMessageType = new System.Windows.Forms.GroupBox();
            this.lblPeriodic = new System.Windows.Forms.Label();
            this.lblMRDMATReplace = new System.Windows.Forms.Label();
            this.lblInterrupt = new System.Windows.Forms.Label();
            this.gbMessageText = new System.Windows.Forms.GroupBox();
            this.tbMessageText = new System.Windows.Forms.RichTextBox();
            this.dgvTransmitter = new System.Windows.Forms.DataGridView();
            this.broadcastOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlyBroadcasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMessageDetails = new System.Windows.Forms.Button();
            this.btnPeriodicMessages = new System.Windows.Forms.Button();
            this.btnExpireDelete = new System.Windows.Forms.Button();
            this.BMHMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransmitterDetails = new System.Windows.Forms.Button();
            this.gbTransmitters.SuspendLayout();
            this.gbSelectedTransmitter.SuspendLayout();
            this.gbProgramSuite.SuspendLayout();
            this.gbTransmitTime.SuspendLayout();
            this.gbMessageType.SuspendLayout();
            this.gbMessageText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransmitter)).BeginInit();
            this.BMHMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTransmitters
            // 
            this.gbTransmitters.Controls.Add(this.btnRefresh);
            this.gbTransmitters.Controls.Add(this.lbTransmitterSelect);
            this.gbTransmitters.Controls.Add(this.cbTransmitterGroup);
            this.gbTransmitters.Location = new System.Drawing.Point(12, 27);
            this.gbTransmitters.Name = "gbTransmitters";
            this.gbTransmitters.Size = new System.Drawing.Size(132, 629);
            this.gbTransmitters.TabIndex = 0;
            this.gbTransmitters.TabStop = false;
            this.gbTransmitters.Text = "Transmitters";
            this.gbTransmitters.Enter += new System.EventHandler(this.gbTransmitters_Enter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 600);
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
            this.lbTransmitterSelect.Size = new System.Drawing.Size(120, 550);
            this.lbTransmitterSelect.TabIndex = 1;
            this.lbTransmitterSelect.Click += new System.EventHandler(this.lbTransmitterSelect_SelectedIndexChanged);
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
            this.cbTransmitterGroup.CheckedChanged += new System.EventHandler(this.cbTransmitterGroup_CheckedChanged);
            // 
            // gbSelectedTransmitter
            // 
            this.gbSelectedTransmitter.Controls.Add(this.lblPort);
            this.gbSelectedTransmitter.Controls.Add(this.lbDAC);
            this.gbSelectedTransmitter.Controls.Add(this.lbTimezone);
            this.gbSelectedTransmitter.Controls.Add(this.cbMonitorInLine);
            this.gbSelectedTransmitter.Controls.Add(this.lbTransmitter);
            this.gbSelectedTransmitter.Location = new System.Drawing.Point(150, 27);
            this.gbSelectedTransmitter.Name = "gbSelectedTransmitter";
            this.gbSelectedTransmitter.Size = new System.Drawing.Size(1070, 50);
            this.gbSelectedTransmitter.TabIndex = 1;
            this.gbSelectedTransmitter.TabStop = false;
            this.gbSelectedTransmitter.Text = "Selected Transmitter";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(950, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(45, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port #:  ";
            this.lblPort.Click += new System.EventHandler(this.lblPort_Click);
            // 
            // lbDAC
            // 
            this.lbDAC.AutoSize = true;
            this.lbDAC.Location = new System.Drawing.Point(780, 20);
            this.lbDAC.Name = "lbDAC";
            this.lbDAC.Size = new System.Drawing.Size(38, 13);
            this.lbDAC.TabIndex = 3;
            this.lbDAC.Text = "DAC:  ";
            this.lbDAC.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTimezone
            // 
            this.lbTimezone.AutoSize = true;
            this.lbTimezone.Location = new System.Drawing.Point(560, 20);
            this.lbTimezone.Name = "lbTimezone";
            this.lbTimezone.Size = new System.Drawing.Size(59, 13);
            this.lbTimezone.TabIndex = 2;
            this.lbTimezone.Text = "Timezone: ";
            // 
            // cbMonitorInLine
            // 
            this.cbMonitorInLine.AutoSize = true;
            this.cbMonitorInLine.Enabled = false;
            this.cbMonitorInLine.Location = new System.Drawing.Point(400, 19);
            this.cbMonitorInLine.Name = "cbMonitorInLine";
            this.cbMonitorInLine.Size = new System.Drawing.Size(92, 17);
            this.cbMonitorInLine.TabIndex = 1;
            this.cbMonitorInLine.Text = "Monitor In-line";
            this.cbMonitorInLine.UseVisualStyleBackColor = true;
            // 
            // lbTransmitter
            // 
            this.lbTransmitter.AutoSize = true;
            this.lbTransmitter.Location = new System.Drawing.Point(7, 20);
            this.lbTransmitter.Name = "lbTransmitter";
            this.lbTransmitter.Size = new System.Drawing.Size(68, 13);
            this.lbTransmitter.TabIndex = 0;
            this.lbTransmitter.Text = "Transmitter:  ";
            // 
            // gbProgramSuite
            // 
            this.gbProgramSuite.Controls.Add(this.lblCycleDuration);
            this.gbProgramSuite.Controls.Add(this.btnChangeSuite);
            this.gbProgramSuite.Controls.Add(this.lblSuiteCategory);
            this.gbProgramSuite.Controls.Add(this.lblSuite);
            this.gbProgramSuite.Controls.Add(this.lblProgram);
            this.gbProgramSuite.Controls.Add(this.lblSuiteCategoryStatic);
            this.gbProgramSuite.Controls.Add(this.lblSuiteStatic);
            this.gbProgramSuite.Controls.Add(this.lblProgramStatic);
            this.gbProgramSuite.Location = new System.Drawing.Point(150, 83);
            this.gbProgramSuite.Name = "gbProgramSuite";
            this.gbProgramSuite.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbProgramSuite.Size = new System.Drawing.Size(675, 95);
            this.gbProgramSuite.TabIndex = 2;
            this.gbProgramSuite.TabStop = false;
            this.gbProgramSuite.Text = "Program/Suite";
            this.gbProgramSuite.Enter += new System.EventHandler(this.gbProgramSuite_Enter);
            // 
            // lblCycleDuration
            // 
            this.lblCycleDuration.AutoSize = true;
            this.lblCycleDuration.Location = new System.Drawing.Point(521, 18);
            this.lblCycleDuration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblCycleDuration.Name = "lblCycleDuration";
            this.lblCycleDuration.Size = new System.Drawing.Size(82, 13);
            this.lblCycleDuration.TabIndex = 6;
            this.lblCycleDuration.Text = "Cycle Duration: ";
            // 
            // btnChangeSuite
            // 
            this.btnChangeSuite.Enabled = false;
            this.btnChangeSuite.Location = new System.Drawing.Point(524, 36);
            this.btnChangeSuite.Name = "btnChangeSuite";
            this.btnChangeSuite.Size = new System.Drawing.Size(96, 23);
            this.btnChangeSuite.TabIndex = 7;
            this.btnChangeSuite.Text = "Change Suite...";
            this.btnChangeSuite.UseVisualStyleBackColor = true;
            this.btnChangeSuite.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSuiteCategory
            // 
            this.lblSuiteCategory.AutoSize = true;
            this.lblSuiteCategory.Location = new System.Drawing.Point(92, 54);
            this.lblSuiteCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblSuiteCategory.Name = "lblSuiteCategory";
            this.lblSuiteCategory.Size = new System.Drawing.Size(0, 13);
            this.lblSuiteCategory.TabIndex = 5;
            // 
            // lblSuite
            // 
            this.lblSuite.AutoSize = true;
            this.lblSuite.Location = new System.Drawing.Point(92, 36);
            this.lblSuite.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblSuite.Name = "lblSuite";
            this.lblSuite.Size = new System.Drawing.Size(0, 13);
            this.lblSuite.TabIndex = 3;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(92, 18);
            this.lblProgram.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(0, 13);
            this.lblProgram.TabIndex = 1;
            // 
            // lblSuiteCategoryStatic
            // 
            this.lblSuiteCategoryStatic.AutoSize = true;
            this.lblSuiteCategoryStatic.Location = new System.Drawing.Point(7, 54);
            this.lblSuiteCategoryStatic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblSuiteCategoryStatic.Name = "lblSuiteCategoryStatic";
            this.lblSuiteCategoryStatic.Size = new System.Drawing.Size(79, 13);
            this.lblSuiteCategoryStatic.TabIndex = 4;
            this.lblSuiteCategoryStatic.Text = "Suite Category:";
            // 
            // lblSuiteStatic
            // 
            this.lblSuiteStatic.AutoSize = true;
            this.lblSuiteStatic.Location = new System.Drawing.Point(52, 36);
            this.lblSuiteStatic.Name = "lblSuiteStatic";
            this.lblSuiteStatic.Size = new System.Drawing.Size(34, 13);
            this.lblSuiteStatic.TabIndex = 2;
            this.lblSuiteStatic.Text = "Suite:";
            // 
            // lblProgramStatic
            // 
            this.lblProgramStatic.AutoSize = true;
            this.lblProgramStatic.Location = new System.Drawing.Point(37, 18);
            this.lblProgramStatic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblProgramStatic.Name = "lblProgramStatic";
            this.lblProgramStatic.Size = new System.Drawing.Size(49, 13);
            this.lblProgramStatic.TabIndex = 0;
            this.lblProgramStatic.Text = "Program:";
            // 
            // gbTransmitTime
            // 
            this.gbTransmitTime.Controls.Add(this.lblPredicted);
            this.gbTransmitTime.Controls.Add(this.lblActual);
            this.gbTransmitTime.Location = new System.Drawing.Point(831, 83);
            this.gbTransmitTime.Name = "gbTransmitTime";
            this.gbTransmitTime.Size = new System.Drawing.Size(161, 95);
            this.gbTransmitTime.TabIndex = 3;
            this.gbTransmitTime.TabStop = false;
            this.gbTransmitTime.Text = "Transmit Time";
            this.gbTransmitTime.Enter += new System.EventHandler(this.gbTransmitTime_Enter);
            // 
            // lblPredicted
            // 
            this.lblPredicted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.lblPredicted.Location = new System.Drawing.Point(6, 54);
            this.lblPredicted.Name = "lblPredicted";
            this.lblPredicted.Size = new System.Drawing.Size(149, 33);
            this.lblPredicted.TabIndex = 1;
            this.lblPredicted.Text = "Predicted";
            this.lblPredicted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPredicted.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblActual
            // 
            this.lblActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(220)))), ((int)(((byte)(94)))));
            this.lblActual.Location = new System.Drawing.Point(6, 16);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(149, 33);
            this.lblActual.TabIndex = 0;
            this.lblActual.Text = "Actual";
            this.lblActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMessageType
            // 
            this.gbMessageType.Controls.Add(this.lblPeriodic);
            this.gbMessageType.Controls.Add(this.lblMRDMATReplace);
            this.gbMessageType.Controls.Add(this.lblInterrupt);
            this.gbMessageType.Location = new System.Drawing.Point(998, 83);
            this.gbMessageType.Name = "gbMessageType";
            this.gbMessageType.Size = new System.Drawing.Size(222, 95);
            this.gbMessageType.TabIndex = 4;
            this.gbMessageType.TabStop = false;
            this.gbMessageType.Text = "Message Type";
            // 
            // lblPeriodic
            // 
            this.lblPeriodic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(52)))));
            this.lblPeriodic.Location = new System.Drawing.Point(114, 16);
            this.lblPeriodic.Name = "lblPeriodic";
            this.lblPeriodic.Size = new System.Drawing.Size(102, 33);
            this.lblPeriodic.TabIndex = 1;
            this.lblPeriodic.Text = "Periodic";
            this.lblPeriodic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMRDMATReplace
            // 
            this.lblMRDMATReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(169)))), ((int)(((byte)(193)))));
            this.lblMRDMATReplace.Location = new System.Drawing.Point(6, 54);
            this.lblMRDMATReplace.Name = "lblMRDMATReplace";
            this.lblMRDMATReplace.Size = new System.Drawing.Size(210, 33);
            this.lblMRDMATReplace.TabIndex = 2;
            this.lblMRDMATReplace.Text = "MRD/MAT Replace";
            this.lblMRDMATReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMRDMATReplace.Click += new System.EventHandler(this.lblMRDMATReplace_Click);
            // 
            // lblInterrupt
            // 
            this.lblInterrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            this.lblInterrupt.Location = new System.Drawing.Point(6, 16);
            this.lblInterrupt.Name = "lblInterrupt";
            this.lblInterrupt.Size = new System.Drawing.Size(102, 33);
            this.lblInterrupt.TabIndex = 0;
            this.lblInterrupt.Text = "Interrupt";
            this.lblInterrupt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMessageText
            // 
            this.gbMessageText.Controls.Add(this.tbMessageText);
            this.gbMessageText.Location = new System.Drawing.Point(150, 446);
            this.gbMessageText.Name = "gbMessageText";
            this.gbMessageText.Size = new System.Drawing.Size(1070, 181);
            this.gbMessageText.TabIndex = 6;
            this.gbMessageText.TabStop = false;
            this.gbMessageText.Text = "Message Text";
            // 
            // tbMessageText
            // 
            this.tbMessageText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbMessageText.Location = new System.Drawing.Point(6, 19);
            this.tbMessageText.Name = "tbMessageText";
            this.tbMessageText.ReadOnly = true;
            this.tbMessageText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbMessageText.Size = new System.Drawing.Size(1058, 171);
            this.tbMessageText.TabIndex = 0;
            this.tbMessageText.Text = "";
            // 
            // dgvTransmitter
            // 
            this.dgvTransmitter.AllowUserToAddRows = false;
            this.dgvTransmitter.AllowUserToDeleteRows = false;
            this.dgvTransmitter.AllowUserToResizeColumns = false;
            this.dgvTransmitter.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransmitter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransmitter.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransmitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransmitter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransmitter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransmitter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransmitter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.broadcastOrder,
            this.currentlyBroadcasting,
            this.transmitTime,
            this.messageid,
            this.messageTitle,
            this.messageName,
            this.MRD,
            this.expirationTime,
            this.Alert,
            this.SAME,
            this.playCount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransmitter.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransmitter.EnableHeadersVisualStyles = false;
            this.dgvTransmitter.Location = new System.Drawing.Point(150, 184);
            this.dgvTransmitter.MultiSelect = false;
            this.dgvTransmitter.Name = "dgvTransmitter";
            this.dgvTransmitter.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransmitter.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransmitter.RowHeadersVisible = false;
            this.dgvTransmitter.RowHeadersWidth = 5;
            this.dgvTransmitter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTransmitter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransmitter.Size = new System.Drawing.Size(1070, 256);
            this.dgvTransmitter.TabIndex = 5;
            this.dgvTransmitter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvTransmitter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // broadcastOrder
            // 
            this.broadcastOrder.HeaderText = "Order";
            this.broadcastOrder.Name = "broadcastOrder";
            this.broadcastOrder.ReadOnly = true;
            this.broadcastOrder.Width = 40;
            // 
            // currentlyBroadcasting
            // 
            this.currentlyBroadcasting.HeaderText = "Play";
            this.currentlyBroadcasting.Name = "currentlyBroadcasting";
            this.currentlyBroadcasting.ReadOnly = true;
            this.currentlyBroadcasting.Width = 35;
            // 
            // transmitTime
            // 
            this.transmitTime.HeaderText = "Transmit Time (UTC)";
            this.transmitTime.Name = "transmitTime";
            this.transmitTime.ReadOnly = true;
            this.transmitTime.Width = 158;
            // 
            // messageid
            // 
            this.messageid.HeaderText = "Message Id";
            this.messageid.Name = "messageid";
            this.messageid.ReadOnly = true;
            this.messageid.Width = 185;
            // 
            // messageTitle
            // 
            this.messageTitle.HeaderText = "Message Title";
            this.messageTitle.Name = "messageTitle";
            this.messageTitle.ReadOnly = true;
            this.messageTitle.Width = 130;
            // 
            // messageName
            // 
            this.messageName.HeaderText = "Message Name";
            this.messageName.Name = "messageName";
            this.messageName.ReadOnly = true;
            this.messageName.Width = 130;
            // 
            // MRD
            // 
            this.MRD.HeaderText = "MRD";
            this.MRD.Name = "MRD";
            this.MRD.ReadOnly = true;
            this.MRD.Width = 46;
            // 
            // expirationTime
            // 
            this.expirationTime.HeaderText = "Expiration Time (UTC)";
            this.expirationTime.Name = "expirationTime";
            this.expirationTime.ReadOnly = true;
            this.expirationTime.Width = 158;
            // 
            // Alert
            // 
            this.Alert.HeaderText = "Alert";
            this.Alert.Name = "Alert";
            this.Alert.ReadOnly = true;
            this.Alert.Width = 50;
            // 
            // SAME
            // 
            this.SAME.HeaderText = "SAME";
            this.SAME.Name = "SAME";
            this.SAME.ReadOnly = true;
            this.SAME.Width = 50;
            // 
            // playCount
            // 
            this.playCount.HeaderText = "Play Count";
            this.playCount.Name = "playCount";
            this.playCount.ReadOnly = true;
            this.playCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playCount.Width = 83;
            // 
            // btnMessageDetails
            // 
            this.btnMessageDetails.Enabled = false;
            this.btnMessageDetails.Location = new System.Drawing.Point(476, 633);
            this.btnMessageDetails.Name = "btnMessageDetails";
            this.btnMessageDetails.Size = new System.Drawing.Size(134, 23);
            this.btnMessageDetails.TabIndex = 7;
            this.btnMessageDetails.Text = "Message Details...";
            this.btnMessageDetails.UseVisualStyleBackColor = true;
            this.btnMessageDetails.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPeriodicMessages
            // 
            this.btnPeriodicMessages.Enabled = false;
            this.btnPeriodicMessages.Location = new System.Drawing.Point(616, 633);
            this.btnPeriodicMessages.Name = "btnPeriodicMessages";
            this.btnPeriodicMessages.Size = new System.Drawing.Size(134, 23);
            this.btnPeriodicMessages.TabIndex = 8;
            this.btnPeriodicMessages.Text = "Periodic Messages...";
            this.btnPeriodicMessages.UseVisualStyleBackColor = true;
            this.btnPeriodicMessages.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnExpireDelete
            // 
            this.btnExpireDelete.Enabled = false;
            this.btnExpireDelete.Location = new System.Drawing.Point(756, 633);
            this.btnExpireDelete.Name = "btnExpireDelete";
            this.btnExpireDelete.Size = new System.Drawing.Size(134, 23);
            this.btnExpireDelete.TabIndex = 9;
            this.btnExpireDelete.Text = "Expire/Delete";
            this.btnExpireDelete.UseVisualStyleBackColor = true;
            this.btnExpireDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // BMHMenuStrip
            // 
            this.BMHMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.BMHMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.BMHMenuStrip.Name = "BMHMenuStrip";
            this.BMHMenuStrip.Size = new System.Drawing.Size(1232, 24);
            this.BMHMenuStrip.TabIndex = 10;
            this.BMHMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnTransmitterDetails
            // 
            this.btnTransmitterDetails.Enabled = false;
            this.btnTransmitterDetails.Location = new System.Drawing.Point(150, 633);
            this.btnTransmitterDetails.Name = "btnTransmitterDetails";
            this.btnTransmitterDetails.Size = new System.Drawing.Size(134, 23);
            this.btnTransmitterDetails.TabIndex = 11;
            this.btnTransmitterDetails.Text = "Transmitter Details";
            this.btnTransmitterDetails.UseVisualStyleBackColor = true;
            this.btnTransmitterDetails.Click += new System.EventHandler(this.btnTransmitterDetails_Click);
            // 
            // BMHMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 668);
            this.Controls.Add(this.btnTransmitterDetails);
            this.Controls.Add(this.btnExpireDelete);
            this.Controls.Add(this.btnPeriodicMessages);
            this.Controls.Add(this.btnMessageDetails);
            this.Controls.Add(this.dgvTransmitter);
            this.Controls.Add(this.gbMessageText);
            this.Controls.Add(this.gbMessageType);
            this.Controls.Add(this.gbTransmitTime);
            this.Controls.Add(this.gbProgramSuite);
            this.Controls.Add(this.gbSelectedTransmitter);
            this.Controls.Add(this.gbTransmitters);
            this.Controls.Add(this.BMHMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.BMHMenuStrip;
            this.MaximizeBox = false;
            this.Name = "BMHMenu";
            this.Text = "Broadcast Cycle";
            this.Load += new System.EventHandler(this.BMHMenu_Load);
            this.gbTransmitters.ResumeLayout(false);
            this.gbTransmitters.PerformLayout();
            this.gbSelectedTransmitter.ResumeLayout(false);
            this.gbSelectedTransmitter.PerformLayout();
            this.gbProgramSuite.ResumeLayout(false);
            this.gbProgramSuite.PerformLayout();
            this.gbTransmitTime.ResumeLayout(false);
            this.gbMessageType.ResumeLayout(false);
            this.gbMessageText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransmitter)).EndInit();
            this.BMHMenuStrip.ResumeLayout(false);
            this.BMHMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransmitters;
        private System.Windows.Forms.CheckBox cbTransmitterGroup;
        private System.Windows.Forms.ListBox lbTransmitterSelect;
        private System.Windows.Forms.GroupBox gbSelectedTransmitter;
        private System.Windows.Forms.Label lbDAC;
        private System.Windows.Forms.Label lbTimezone;
        private System.Windows.Forms.CheckBox cbMonitorInLine;
        private System.Windows.Forms.Label lbTransmitter;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox gbProgramSuite;
        private System.Windows.Forms.Label lblSuiteCategoryStatic;
        private System.Windows.Forms.Label lblSuiteStatic;
        private System.Windows.Forms.Label lblProgramStatic;
        private System.Windows.Forms.Label lblCycleDuration;
        private System.Windows.Forms.Button btnChangeSuite;
        private System.Windows.Forms.Label lblSuiteCategory;
        private System.Windows.Forms.Label lblSuite;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.GroupBox gbTransmitTime;
        private System.Windows.Forms.GroupBox gbMessageType;
        private System.Windows.Forms.Label lblPredicted;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblPeriodic;
        private System.Windows.Forms.Label lblMRDMATReplace;
        private System.Windows.Forms.Label lblInterrupt;
        private System.Windows.Forms.GroupBox gbMessageText;
        private System.Windows.Forms.RichTextBox tbMessageText;
        private System.Windows.Forms.DataGridView dgvTransmitter;
        private System.Windows.Forms.Button btnMessageDetails;
        private System.Windows.Forms.Button btnPeriodicMessages;
        private System.Windows.Forms.Button btnExpireDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip BMHMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn broadcastOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentlyBroadcasting;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageid;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRD;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alert;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn playCount;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnTransmitterDetails;
    }
}