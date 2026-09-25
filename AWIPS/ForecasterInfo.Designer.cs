namespace AWIPS
{
    partial class ForecasterInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecasterInfo));
            this.lblForecaster = new System.Windows.Forms.Label();
            this.gbForecaster = new System.Windows.Forms.GroupBox();
            this.gbWfo = new System.Windows.Forms.GroupBox();
            this.lblWfo = new System.Windows.Forms.Label();
            this.chkAutofill = new System.Windows.Forms.CheckBox();
            this.chkPractice = new System.Windows.Forms.CheckBox();
            this.gbForecaster.SuspendLayout();
            this.gbWfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblForecaster
            // 
            this.lblForecaster.Location = new System.Drawing.Point(6, 16);
            this.lblForecaster.Name = "lblForecaster";
            this.lblForecaster.Size = new System.Drawing.Size(188, 81);
            this.lblForecaster.TabIndex = 0;
            this.lblForecaster.Text = "Forecaster details";
            // 
            // gbForecaster
            // 
            this.gbForecaster.Controls.Add(this.lblForecaster);
            this.gbForecaster.Location = new System.Drawing.Point(12, 12);
            this.gbForecaster.Name = "gbForecaster";
            this.gbForecaster.Size = new System.Drawing.Size(200, 100);
            this.gbForecaster.TabIndex = 3;
            this.gbForecaster.TabStop = false;
            this.gbForecaster.Text = "Forecaster";
            // 
            // gbWfo
            // 
            this.gbWfo.Controls.Add(this.lblWfo);
            this.gbWfo.Location = new System.Drawing.Point(12, 118);
            this.gbWfo.Name = "gbWfo";
            this.gbWfo.Size = new System.Drawing.Size(200, 100);
            this.gbWfo.TabIndex = 4;
            this.gbWfo.TabStop = false;
            this.gbWfo.Text = "WFO Details";
            // 
            // lblWfo
            // 
            this.lblWfo.Location = new System.Drawing.Point(6, 16);
            this.lblWfo.Name = "lblWfo";
            this.lblWfo.Size = new System.Drawing.Size(188, 81);
            this.lblWfo.TabIndex = 0;
            this.lblWfo.Text = "WFO details";
            // 
            // chkAutofill
            // 
            this.chkAutofill.AutoSize = true;
            this.chkAutofill.Location = new System.Drawing.Point(12, 224);
            this.chkAutofill.Name = "chkAutofill";
            this.chkAutofill.Size = new System.Drawing.Size(103, 17);
            this.chkAutofill.TabIndex = 5;
            this.chkAutofill.Text = "Autofill signature";
            this.chkAutofill.UseVisualStyleBackColor = true;
            this.chkAutofill.CheckedChanged += new System.EventHandler(this.chkAutofill_CheckedChanged);
            // 
            // chkPractice
            // 
            this.chkPractice.AutoSize = true;
            this.chkPractice.Location = new System.Drawing.Point(12, 241);
            this.chkPractice.Name = "chkPractice";
            this.chkPractice.Size = new System.Drawing.Size(121, 17);
            this.chkPractice.TabIndex = 6;
            this.chkPractice.Text = "Practice/Test Mode";
            this.chkPractice.UseVisualStyleBackColor = true;
            this.chkPractice.CheckedChanged += new System.EventHandler(this.chkPractice_CheckedChanged);
            // 
            // ForecasterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 265);
            this.Controls.Add(this.chkPractice);
            this.Controls.Add(this.chkAutofill);
            this.Controls.Add(this.gbWfo);
            this.Controls.Add(this.gbForecaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForecasterInfo";
            this.Text = "Forecaster Information";
            this.Load += new System.EventHandler(this.ForecasterInfo_Load);
            this.gbForecaster.ResumeLayout(false);
            this.gbWfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForecaster;
        private System.Windows.Forms.GroupBox gbForecaster;
        private System.Windows.Forms.GroupBox gbWfo;
        private System.Windows.Forms.Label lblWfo;
        private System.Windows.Forms.CheckBox chkAutofill;
        private System.Windows.Forms.CheckBox chkPractice;
    }
}