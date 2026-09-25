namespace AWIPS
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aWIPSBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.tbAwipsId = new System.Windows.Forms.TextBox();
            this.tbWtc = new System.Windows.Forms.TextBox();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbAfos = new System.Windows.Forms.Label();
            this.tbHeaderFull = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnEditHeader = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnAFOS = new System.Windows.Forms.Button();
            this.btnLoadHistory = new System.Windows.Forms.Button();
            this.btnWMO = new System.Windows.Forms.Button();
            this.btnEnterEditor = new System.Windows.Forms.Button();
            this.cbAccum = new System.Windows.Forms.CheckBox();
            this.cbUpdObs = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbPrimary = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aWIPSBrowserToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.sendToolStripMenuItem1,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem1.Text = "AWIPS Browser";
            // 
            // aWIPSBrowserToolStripMenuItem
            // 
            this.aWIPSBrowserToolStripMenuItem.Enabled = false;
            this.aWIPSBrowserToolStripMenuItem.Name = "aWIPSBrowserToolStripMenuItem";
            this.aWIPSBrowserToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aWIPSBrowserToolStripMenuItem.Text = "Edit Header";
            this.aWIPSBrowserToolStripMenuItem.Click += new System.EventHandler(this.aWIPSBrowserToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // sendToolStripMenuItem1
            // 
            this.sendToolStripMenuItem1.Enabled = false;
            this.sendToolStripMenuItem1.Name = "sendToolStripMenuItem1";
            this.sendToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.sendToolStripMenuItem1.Text = "Send";
            this.sendToolStripMenuItem1.Click += new System.EventHandler(this.sendToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.fillToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fillToolStripMenuItem.Text = "Fill";
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Location = new System.Drawing.Point(12, 56);
            this.lblHeader1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(59, 13);
            this.lblHeader1.TabIndex = 0;
            this.lblHeader1.Text = "AWIPS ID:";
            // 
            // tbAwipsId
            // 
            this.tbAwipsId.Enabled = false;
            this.tbAwipsId.Location = new System.Drawing.Point(77, 53);
            this.tbAwipsId.Margin = new System.Windows.Forms.Padding(1);
            this.tbAwipsId.Name = "tbAwipsId";
            this.tbAwipsId.Size = new System.Drawing.Size(100, 20);
            this.tbAwipsId.TabIndex = 1;
            // 
            // tbWtc
            // 
            this.tbWtc.Enabled = false;
            this.tbWtc.Location = new System.Drawing.Point(293, 53);
            this.tbWtc.Margin = new System.Windows.Forms.Padding(1);
            this.tbWtc.Name = "tbWtc";
            this.tbWtc.Size = new System.Drawing.Size(100, 20);
            this.tbWtc.TabIndex = 3;
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Location = new System.Drawing.Point(183, 56);
            this.lblHeader2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(104, 13);
            this.lblHeader2.TabIndex = 2;
            this.lblHeader2.Text = "WMO TTAAii CCCC:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(467, 53);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // tbAfos
            // 
            this.tbAfos.AutoSize = true;
            this.tbAfos.Location = new System.Drawing.Point(399, 56);
            this.tbAfos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tbAfos.Name = "tbAfos";
            this.tbAfos.Size = new System.Drawing.Size(62, 13);
            this.tbAfos.TabIndex = 4;
            this.tbAfos.Text = "AFOS Cmd:";
            // 
            // tbHeaderFull
            // 
            this.tbHeaderFull.Enabled = false;
            this.tbHeaderFull.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderFull.Location = new System.Drawing.Point(12, 79);
            this.tbHeaderFull.Margin = new System.Windows.Forms.Padding(1);
            this.tbHeaderFull.Multiline = true;
            this.tbHeaderFull.Name = "tbHeaderFull";
            this.tbHeaderFull.Size = new System.Drawing.Size(723, 40);
            this.tbHeaderFull.TabIndex = 6;
            this.tbHeaderFull.TextChanged += new System.EventHandler(this.tbHeaderFull_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 125);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(73, 125);
            this.btnCut.Margin = new System.Windows.Forms.Padding(1);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(59, 23);
            this.btnCut.TabIndex = 8;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(195, 125);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(1);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(59, 23);
            this.btnPaste.TabIndex = 10;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(134, 125);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(1);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(59, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnEditHeader
            // 
            this.btnEditHeader.Location = new System.Drawing.Point(317, 125);
            this.btnEditHeader.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditHeader.Name = "btnEditHeader";
            this.btnEditHeader.Size = new System.Drawing.Size(99, 23);
            this.btnEditHeader.TabIndex = 12;
            this.btnEditHeader.Text = "Edit Header";
            this.btnEditHeader.UseVisualStyleBackColor = true;
            this.btnEditHeader.Click += new System.EventHandler(this.btnEditHeader_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(256, 125);
            this.btnFill.Margin = new System.Windows.Forms.Padding(1);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(59, 23);
            this.btnFill.TabIndex = 11;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(418, 125);
            this.btnSend.Margin = new System.Windows.Forms.Padding(1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(59, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(479, 125);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbMain
            // 
            this.tbMain.AcceptsReturn = true;
            this.tbMain.AllowDrop = true;
            this.tbMain.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMain.Location = new System.Drawing.Point(12, 152);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMain.Size = new System.Drawing.Size(723, 492);
            this.tbMain.TabIndex = 15;
            this.tbMain.TextChanged += new System.EventHandler(this.tbMain_TextChanged);
            // 
            // btnAFOS
            // 
            this.btnAFOS.Enabled = false;
            this.btnAFOS.Location = new System.Drawing.Point(10, 25);
            this.btnAFOS.Margin = new System.Windows.Forms.Padding(1);
            this.btnAFOS.Name = "btnAFOS";
            this.btnAFOS.Size = new System.Drawing.Size(95, 23);
            this.btnAFOS.TabIndex = 16;
            this.btnAFOS.Text = "AWIPS Browser";
            this.btnAFOS.UseVisualStyleBackColor = true;
            // 
            // btnLoadHistory
            // 
            this.btnLoadHistory.Enabled = false;
            this.btnLoadHistory.Location = new System.Drawing.Point(107, 25);
            this.btnLoadHistory.Margin = new System.Windows.Forms.Padding(1);
            this.btnLoadHistory.Name = "btnLoadHistory";
            this.btnLoadHistory.Size = new System.Drawing.Size(95, 23);
            this.btnLoadHistory.TabIndex = 17;
            this.btnLoadHistory.Text = "Load History";
            this.btnLoadHistory.UseVisualStyleBackColor = true;
            // 
            // btnWMO
            // 
            this.btnWMO.Enabled = false;
            this.btnWMO.Location = new System.Drawing.Point(204, 25);
            this.btnWMO.Margin = new System.Windows.Forms.Padding(1);
            this.btnWMO.Name = "btnWMO";
            this.btnWMO.Size = new System.Drawing.Size(95, 23);
            this.btnWMO.TabIndex = 18;
            this.btnWMO.Text = "WMO Search";
            this.btnWMO.UseVisualStyleBackColor = true;
            // 
            // btnEnterEditor
            // 
            this.btnEnterEditor.Location = new System.Drawing.Point(301, 25);
            this.btnEnterEditor.Margin = new System.Windows.Forms.Padding(1);
            this.btnEnterEditor.Name = "btnEnterEditor";
            this.btnEnterEditor.Size = new System.Drawing.Size(95, 23);
            this.btnEnterEditor.TabIndex = 19;
            this.btnEnterEditor.Text = "Enter Editor";
            this.btnEnterEditor.UseVisualStyleBackColor = true;
            this.btnEnterEditor.Click += new System.EventHandler(this.btnEnterEditor_Click);
            // 
            // cbAccum
            // 
            this.cbAccum.AutoSize = true;
            this.cbAccum.Enabled = false;
            this.cbAccum.Location = new System.Drawing.Point(400, 29);
            this.cbAccum.Name = "cbAccum";
            this.cbAccum.Size = new System.Drawing.Size(59, 17);
            this.cbAccum.TabIndex = 20;
            this.cbAccum.Text = "Accum";
            this.cbAccum.UseVisualStyleBackColor = true;
            // 
            // cbUpdObs
            // 
            this.cbUpdObs.AutoSize = true;
            this.cbUpdObs.Enabled = false;
            this.cbUpdObs.Location = new System.Drawing.Point(465, 29);
            this.cbUpdObs.Name = "cbUpdObs";
            this.cbUpdObs.Size = new System.Drawing.Size(83, 17);
            this.cbUpdObs.TabIndex = 21;
            this.cbUpdObs.Text = "Update Obs";
            this.cbUpdObs.UseVisualStyleBackColor = true;
            this.cbUpdObs.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(552, 25);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbPrimary
            // 
            this.tbPrimary.AcceptsReturn = true;
            this.tbPrimary.AllowDrop = true;
            this.tbPrimary.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrimary.Location = new System.Drawing.Point(12, 52);
            this.tbPrimary.Multiline = true;
            this.tbPrimary.Name = "tbPrimary";
            this.tbPrimary.ReadOnly = true;
            this.tbPrimary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPrimary.Size = new System.Drawing.Size(723, 592);
            this.tbPrimary.TabIndex = 23;
            this.tbPrimary.Visible = false;
            this.tbPrimary.TextChanged += new System.EventHandler(this.tbPrimary_TextChanged);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 656);
            this.Controls.Add(this.tbPrimary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbUpdObs);
            this.Controls.Add(this.cbAccum);
            this.Controls.Add(this.btnEnterEditor);
            this.Controls.Add(this.btnWMO);
            this.Controls.Add(this.btnLoadHistory);
            this.Controls.Add(this.btnAFOS);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnEditHeader);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbHeaderFull);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbAfos);
            this.Controls.Add(this.tbWtc);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.tbAwipsId);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TextEditor";
            this.Text = "Text Display";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aWIPSBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.TextBox tbAwipsId;
        private System.Windows.Forms.TextBox tbWtc;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label tbAfos;
        private System.Windows.Forms.TextBox tbHeaderFull;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnEditHeader;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnAFOS;
        private System.Windows.Forms.Button btnLoadHistory;
        private System.Windows.Forms.Button btnWMO;
        private System.Windows.Forms.Button btnEnterEditor;
        private System.Windows.Forms.CheckBox cbAccum;
        private System.Windows.Forms.CheckBox cbUpdObs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbPrimary;
    }
}