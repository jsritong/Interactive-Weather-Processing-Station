namespace AWIPS
{
    partial class AWIPSHeaderBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AWIPSHeaderBlock));
            this.tbTTAAii = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbCCCC = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.ddBBBVer = new System.Windows.Forms.ComboBox();
            this.box1 = new System.Windows.Forms.GroupBox();
            this.ddBBB = new System.Windows.Forms.ComboBox();
            this.box2 = new System.Windows.Forms.GroupBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.ddProductOrg = new System.Windows.Forms.ComboBox();
            this.tbWSFOID = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbProductCat = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.tbProductDes = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbSAME = new System.Windows.Forms.CheckBox();
            this.cb1050 = new System.Windows.Forms.CheckBox();
            this.cbInterrupt = new System.Windows.Forms.CheckBox();
            this.box3 = new System.Windows.Forms.GroupBox();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.box4 = new System.Windows.Forms.GroupBox();
            this.tbFIPS = new System.Windows.Forms.TextBox();
            this.box5 = new System.Windows.Forms.GroupBox();
            this.tbVTECHeader = new System.Windows.Forms.TextBox();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box3.SuspendLayout();
            this.box4.SuspendLayout();
            this.box5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTTAAii
            // 
            this.tbTTAAii.Location = new System.Drawing.Point(4, 17);
            this.tbTTAAii.Margin = new System.Windows.Forms.Padding(1);
            this.tbTTAAii.Name = "tbTTAAii";
            this.tbTTAAii.Size = new System.Drawing.Size(69, 20);
            this.tbTTAAii.TabIndex = 0;
            this.tbTTAAii.TextChanged += new System.EventHandler(this.tbTTAAii_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(75, 20);
            this.lbl1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "TTAAii";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(75, 42);
            this.lbl2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "CCCC";
            // 
            // tbCCCC
            // 
            this.tbCCCC.Location = new System.Drawing.Point(4, 39);
            this.tbCCCC.Margin = new System.Windows.Forms.Padding(1);
            this.tbCCCC.Name = "tbCCCC";
            this.tbCCCC.Size = new System.Drawing.Size(69, 20);
            this.tbCCCC.TabIndex = 2;
            this.tbCCCC.TextChanged += new System.EventHandler(this.tbCCCC_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(75, 64);
            this.lbl3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(28, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "BBB";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(75, 86);
            this.lbl4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(66, 13);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "BBB Version";
            // 
            // ddBBBVer
            // 
            this.ddBBBVer.FormattingEnabled = true;
            this.ddBBBVer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ddBBBVer.Location = new System.Drawing.Point(4, 83);
            this.ddBBBVer.Margin = new System.Windows.Forms.Padding(1);
            this.ddBBBVer.Name = "ddBBBVer";
            this.ddBBBVer.Size = new System.Drawing.Size(69, 21);
            this.ddBBBVer.TabIndex = 6;
            this.ddBBBVer.Text = "A";
            this.ddBBBVer.SelectedIndexChanged += new System.EventHandler(this.ddBBBVer_SelectedIndexChanged);
            // 
            // box1
            // 
            this.box1.Controls.Add(this.ddBBB);
            this.box1.Controls.Add(this.tbTTAAii);
            this.box1.Controls.Add(this.ddBBBVer);
            this.box1.Controls.Add(this.lbl1);
            this.box1.Controls.Add(this.lbl4);
            this.box1.Controls.Add(this.tbCCCC);
            this.box1.Controls.Add(this.lbl3);
            this.box1.Controls.Add(this.lbl2);
            this.box1.Location = new System.Drawing.Point(12, 1);
            this.box1.Name = "box1";
            this.box1.Padding = new System.Windows.Forms.Padding(1);
            this.box1.Size = new System.Drawing.Size(200, 111);
            this.box1.TabIndex = 0;
            this.box1.TabStop = false;
            // 
            // ddBBB
            // 
            this.ddBBB.FormattingEnabled = true;
            this.ddBBB.Items.AddRange(new object[] {
            "NOR",
            "RR",
            "CC",
            "RTD"});
            this.ddBBB.Location = new System.Drawing.Point(4, 60);
            this.ddBBB.Margin = new System.Windows.Forms.Padding(1);
            this.ddBBB.Name = "ddBBB";
            this.ddBBB.Size = new System.Drawing.Size(69, 21);
            this.ddBBB.TabIndex = 8;
            this.ddBBB.Text = "NOR";
            this.ddBBB.SelectedIndexChanged += new System.EventHandler(this.ddBBB_SelectedIndexChanged);
            // 
            // box2
            // 
            this.box2.Controls.Add(this.lbl8);
            this.box2.Controls.Add(this.ddProductOrg);
            this.box2.Controls.Add(this.tbWSFOID);
            this.box2.Controls.Add(this.lbl5);
            this.box2.Controls.Add(this.tbProductCat);
            this.box2.Controls.Add(this.lbl7);
            this.box2.Controls.Add(this.lbl6);
            this.box2.Controls.Add(this.tbProductDes);
            this.box2.Location = new System.Drawing.Point(12, 109);
            this.box2.Name = "box2";
            this.box2.Padding = new System.Windows.Forms.Padding(1);
            this.box2.Size = new System.Drawing.Size(200, 111);
            this.box2.TabIndex = 1;
            this.box2.TabStop = false;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(73, 84);
            this.lbl8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(92, 13);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "Product Originator";
            // 
            // ddProductOrg
            // 
            this.ddProductOrg.FormattingEnabled = true;
            this.ddProductOrg.Items.AddRange(new object[] {
            "WXR",
            "CIV",
            "EAS",
            "PEP"});
            this.ddProductOrg.Location = new System.Drawing.Point(4, 83);
            this.ddProductOrg.Margin = new System.Windows.Forms.Padding(1);
            this.ddProductOrg.Name = "ddProductOrg";
            this.ddProductOrg.Size = new System.Drawing.Size(69, 21);
            this.ddProductOrg.TabIndex = 6;
            this.ddProductOrg.Text = "WXR";
            this.ddProductOrg.SelectedIndexChanged += new System.EventHandler(this.ddProductOrg_SelectedIndexChanged);
            // 
            // tbWSFOID
            // 
            this.tbWSFOID.Location = new System.Drawing.Point(4, 17);
            this.tbWSFOID.Margin = new System.Windows.Forms.Padding(1);
            this.tbWSFOID.Name = "tbWSFOID";
            this.tbWSFOID.Size = new System.Drawing.Size(69, 20);
            this.tbWSFOID.TabIndex = 0;
            this.tbWSFOID.TextChanged += new System.EventHandler(this.tbWSFOID_TextChanged);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(73, 18);
            this.lbl5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(101, 13);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "WSFO ID (Optional)";
            // 
            // tbProductCat
            // 
            this.tbProductCat.Location = new System.Drawing.Point(4, 39);
            this.tbProductCat.Margin = new System.Windows.Forms.Padding(1);
            this.tbProductCat.Name = "tbProductCat";
            this.tbProductCat.Size = new System.Drawing.Size(69, 20);
            this.tbProductCat.TabIndex = 2;
            this.tbProductCat.TextChanged += new System.EventHandler(this.tbProductCat_TextChanged);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(73, 62);
            this.lbl7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(98, 13);
            this.lbl7.TabIndex = 5;
            this.lbl7.Text = "Product Designator";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(73, 40);
            this.lbl6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(89, 13);
            this.lbl6.TabIndex = 3;
            this.lbl6.Text = "Product Category";
            // 
            // tbProductDes
            // 
            this.tbProductDes.Location = new System.Drawing.Point(4, 61);
            this.tbProductDes.Margin = new System.Windows.Forms.Padding(1);
            this.tbProductDes.Name = "tbProductDes";
            this.tbProductDes.Size = new System.Drawing.Size(69, 20);
            this.tbProductDes.TabIndex = 4;
            this.tbProductDes.TextChanged += new System.EventHandler(this.tbProductDes_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(36, 366);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(1);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 366);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbSAME
            // 
            this.cbSAME.AutoSize = true;
            this.cbSAME.Location = new System.Drawing.Point(9, 17);
            this.cbSAME.Margin = new System.Windows.Forms.Padding(1);
            this.cbSAME.Name = "cbSAME";
            this.cbSAME.Size = new System.Drawing.Size(85, 17);
            this.cbSAME.TabIndex = 0;
            this.cbSAME.Text = "SAME Alarm";
            this.cbSAME.UseVisualStyleBackColor = true;
            this.cbSAME.CheckedChanged += new System.EventHandler(this.cbSAME_CheckedChanged);
            // 
            // cb1050
            // 
            this.cb1050.AutoSize = true;
            this.cb1050.Location = new System.Drawing.Point(9, 36);
            this.cb1050.Margin = new System.Windows.Forms.Padding(1);
            this.cb1050.Name = "cb1050";
            this.cb1050.Size = new System.Drawing.Size(79, 17);
            this.cb1050.TabIndex = 2;
            this.cb1050.Text = "1050 Alarm";
            this.cb1050.UseVisualStyleBackColor = true;
            this.cb1050.CheckedChanged += new System.EventHandler(this.cb1050_CheckedChanged);
            // 
            // cbInterrupt
            // 
            this.cbInterrupt.AutoSize = true;
            this.cbInterrupt.Location = new System.Drawing.Point(111, 17);
            this.cbInterrupt.Margin = new System.Windows.Forms.Padding(1);
            this.cbInterrupt.Name = "cbInterrupt";
            this.cbInterrupt.Size = new System.Drawing.Size(65, 17);
            this.cbInterrupt.TabIndex = 1;
            this.cbInterrupt.Text = "Interrupt";
            this.cbInterrupt.UseVisualStyleBackColor = true;
            this.cbInterrupt.CheckedChanged += new System.EventHandler(this.cbInterrupt_CheckedChanged);
            // 
            // box3
            // 
            this.box3.Controls.Add(this.cbRepeat);
            this.box3.Controls.Add(this.cbSAME);
            this.box3.Controls.Add(this.cbInterrupt);
            this.box3.Controls.Add(this.cb1050);
            this.box3.Location = new System.Drawing.Point(12, 303);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(200, 59);
            this.box3.TabIndex = 4;
            this.box3.TabStop = false;
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Location = new System.Drawing.Point(111, 36);
            this.cbRepeat.Margin = new System.Windows.Forms.Padding(1);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(61, 17);
            this.cbRepeat.TabIndex = 3;
            this.cbRepeat.Text = "Repeat";
            this.cbRepeat.UseVisualStyleBackColor = true;
            this.cbRepeat.CheckedChanged += new System.EventHandler(this.cbRepeat_CheckedChanged);
            // 
            // box4
            // 
            this.box4.Controls.Add(this.tbFIPS);
            this.box4.Location = new System.Drawing.Point(12, 217);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(200, 45);
            this.box4.TabIndex = 2;
            this.box4.TabStop = false;
            this.box4.Text = "FIPS Codes";
            this.box4.Enter += new System.EventHandler(this.box4_Enter);
            // 
            // tbFIPS
            // 
            this.tbFIPS.Location = new System.Drawing.Point(4, 17);
            this.tbFIPS.Margin = new System.Windows.Forms.Padding(1);
            this.tbFIPS.Name = "tbFIPS";
            this.tbFIPS.Size = new System.Drawing.Size(192, 20);
            this.tbFIPS.TabIndex = 0;
            this.tbFIPS.TextChanged += new System.EventHandler(this.tbFIPS_TextChanged);
            // 
            // box5
            // 
            this.box5.Controls.Add(this.tbVTECHeader);
            this.box5.Location = new System.Drawing.Point(12, 262);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(200, 45);
            this.box5.TabIndex = 3;
            this.box5.TabStop = false;
            this.box5.Text = "VTEC Header";
            // 
            // tbVTECHeader
            // 
            this.tbVTECHeader.Location = new System.Drawing.Point(4, 17);
            this.tbVTECHeader.Margin = new System.Windows.Forms.Padding(1);
            this.tbVTECHeader.Name = "tbVTECHeader";
            this.tbVTECHeader.Size = new System.Drawing.Size(192, 20);
            this.tbVTECHeader.TabIndex = 0;
            this.tbVTECHeader.TextChanged += new System.EventHandler(this.tbVTECHeader_TextChanged);
            // 
            // AWIPSHeaderBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 395);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AWIPSHeaderBlock";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AWIPS Header Block";
            this.Load += new System.EventHandler(this.AWIPSHeaderBlock_Load);
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbTTAAii;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbCCCC;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox ddBBBVer;
        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.GroupBox box2;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.ComboBox ddProductOrg;
        private System.Windows.Forms.TextBox tbWSFOID;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox tbProductCat;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox tbProductDes;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbSAME;
        private System.Windows.Forms.CheckBox cb1050;
        private System.Windows.Forms.CheckBox cbInterrupt;
        private System.Windows.Forms.GroupBox box3;
        private System.Windows.Forms.GroupBox box4;
        private System.Windows.Forms.TextBox tbFIPS;
        private System.Windows.Forms.GroupBox box5;
        private System.Windows.Forms.TextBox tbVTECHeader;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.ComboBox ddBBB;
    }
}