namespace AWIPS
{
    partial class SendProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendProduct));
            this.box1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.box1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Controls.Add(this.lbl1);
            this.box1.Location = new System.Drawing.Point(12, 12);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(264, 62);
            this.box1.TabIndex = 0;
            this.box1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(252, 34);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Live Product";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(9, 226);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(267, 88);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "You are about to SEND a SVRFFC Severe Thunderstorm Warning.\r\n\r\nThe workstation is" +
    " in Operational mode. The product will be stored in the text database and will b" +
    "e sent on the WAN. replace\r\n";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(69, 336);
            this.btnSend.Margin = new System.Windows.Forms.Padding(1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Go Ahead!";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(146, 336);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(1);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.button2_Click);
            // 
            // picStop
            // 
            this.picStop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picStop.ErrorImage")));
            this.picStop.Image = ((System.Drawing.Image)(resources.GetObject("picStop.Image")));
            this.picStop.InitialImage = ((System.Drawing.Image)(resources.GetObject("picStop.InitialImage")));
            this.picStop.Location = new System.Drawing.Point(79, 80);
            this.picStop.Name = "picStop";
            this.picStop.Size = new System.Drawing.Size(131, 131);
            this.picStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStop.TabIndex = 4;
            this.picStop.TabStop = false;
            this.picStop.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SendProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 369);
            this.Controls.Add(this.picStop);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendProduct";
            this.ShowInTaskbar = false;
            this.Text = "Send Product";
            this.box1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.PictureBox picStop;
    }
}