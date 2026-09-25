namespace AWIPS
{
    partial class NWRWaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWRWaves));
            this.NWRWavesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nWRWavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTransmissionStatus = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbSent = new System.Windows.Forms.ListBox();
            this.lblSent = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnPurge = new System.Windows.Forms.Button();
            this.chkHideIndefinite = new System.Windows.Forms.CheckBox();
            this.NWRWavesMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NWRWavesMenuStrip
            // 
            this.NWRWavesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.nWRWavesToolStripMenuItem});
            this.NWRWavesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NWRWavesMenuStrip.Name = "NWRWavesMenuStrip";
            this.NWRWavesMenuStrip.Size = new System.Drawing.Size(643, 24);
            this.NWRWavesMenuStrip.TabIndex = 0;
            this.NWRWavesMenuStrip.Text = "menuStrip1";
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
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // nWRWavesToolStripMenuItem
            // 
            this.nWRWavesToolStripMenuItem.Name = "nWRWavesToolStripMenuItem";
            this.nWRWavesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.nWRWavesToolStripMenuItem.Text = "NWRWaves";
            // 
            // lbTransmissionStatus
            // 
            this.lbTransmissionStatus.AutoSize = true;
            this.lbTransmissionStatus.Location = new System.Drawing.Point(252, 36);
            this.lbTransmissionStatus.Name = "lbTransmissionStatus";
            this.lbTransmissionStatus.Size = new System.Drawing.Size(139, 13);
            this.lbTransmissionStatus.TabIndex = 1;
            this.lbTransmissionStatus.Text = "Transmission Status Of Files";
            // 
            // lbDateTime
            // 
            this.lbDateTime.Location = new System.Drawing.Point(209, 49);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(225, 38);
            this.lbDateTime.TabIndex = 2;
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSent
            // 
            this.lbSent.FormattingEnabled = true;
            this.lbSent.Location = new System.Drawing.Point(93, 109);
            this.lbSent.Name = "lbSent";
            this.lbSent.Size = new System.Drawing.Size(538, 498);
            this.lbSent.TabIndex = 11;
            this.lbSent.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.lbSent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSent_KeyDown);
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.Location = new System.Drawing.Point(330, 93);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(65, 13);
            this.lblSent.TabIndex = 4;
            this.lblSent.Text = "In Database";
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(12, 109);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 138);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(12, 167);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(12, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Lime;
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(12, 225);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // btnPurge
            // 
            this.btnPurge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPurge.Enabled = false;
            this.btnPurge.Location = new System.Drawing.Point(12, 254);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(75, 23);
            this.btnPurge.TabIndex = 10;
            this.btnPurge.Text = "Purge";
            this.btnPurge.UseVisualStyleBackColor = false;
            // 
            // chkHideIndefinite
            // 
            this.chkHideIndefinite.AutoSize = true;
            this.chkHideIndefinite.Location = new System.Drawing.Point(93, 86);
            this.chkHideIndefinite.Name = "chkHideIndefinite";
            this.chkHideIndefinite.Size = new System.Drawing.Size(144, 17);
            this.chkHideIndefinite.TabIndex = 3;
            this.chkHideIndefinite.Text = "Show Indefinite Products";
            this.chkHideIndefinite.UseVisualStyleBackColor = true;
            this.chkHideIndefinite.CheckedChanged += new System.EventHandler(this.chkHideIndefinite_CheckedChanged);
            // 
            // NWRWaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(643, 619);
            this.Controls.Add(this.chkHideIndefinite);
            this.Controls.Add(this.btnPurge);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblSent);
            this.Controls.Add(this.lbSent);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.lbTransmissionStatus);
            this.Controls.Add(this.NWRWavesMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.NWRWavesMenuStrip;
            this.MaximizeBox = false;
            this.Name = "NWRWaves";
            this.Text = "NWRWaves Browser";
            this.Load += new System.EventHandler(this.NWRWaves_Load);
            this.NWRWavesMenuStrip.ResumeLayout(false);
            this.NWRWavesMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NWRWavesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nWRWavesToolStripMenuItem;
        private System.Windows.Forms.Label lbTransmissionStatus;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.ListBox lbSent;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnPurge;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox chkHideIndefinite;
    }
}