namespace AWIPS
{
    partial class GeneratingProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratingProduct));
            this.lblGeneratingProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGeneratingProduct
            // 
            this.lblGeneratingProduct.AutoSize = true;
            this.lblGeneratingProduct.Location = new System.Drawing.Point(91, 60);
            this.lblGeneratingProduct.Name = "lblGeneratingProduct";
            this.lblGeneratingProduct.Size = new System.Drawing.Size(107, 13);
            this.lblGeneratingProduct.TabIndex = 0;
            this.lblGeneratingProduct.Text = "Generating product...";
            this.lblGeneratingProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // GeneratingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 132);
            this.Controls.Add(this.lblGeneratingProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratingProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generating Product";
            this.Load += new System.EventHandler(this.GeneratingProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneratingProduct;
    }
}