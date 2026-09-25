namespace AWIPS
{
    partial class SPCIssuancePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPCIssuancePanel));
            this.gbResetTracking = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.cbUpdateList = new System.Windows.Forms.ComboBox();
            this.rbWeatherWatch = new System.Windows.Forms.RadioButton();
            this.rbSevereThunderstorm = new System.Windows.Forms.RadioButton();
            this.rbTornadoWatch = new System.Windows.Forms.RadioButton();
            this.rbMesoscale = new System.Windows.Forms.RadioButton();
            this.lbSelections = new System.Windows.Forms.ListBox();
            this.boxTimeRange = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.ddDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbResetTracking.SuspendLayout();
            this.gbProducts.SuspendLayout();
            this.boxTimeRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResetTracking
            // 
            this.gbResetTracking.Controls.Add(this.button2);
            this.gbResetTracking.Controls.Add(this.button1);
            this.gbResetTracking.Location = new System.Drawing.Point(12, 12);
            this.gbResetTracking.Name = "gbResetTracking";
            this.gbResetTracking.Size = new System.Drawing.Size(356, 50);
            this.gbResetTracking.TabIndex = 0;
            this.gbResetTracking.TabStop = false;
            this.gbResetTracking.Text = "Reset Tracking";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Track";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.cbUpdateList);
            this.gbProducts.Controls.Add(this.rbWeatherWatch);
            this.gbProducts.Controls.Add(this.rbSevereThunderstorm);
            this.gbProducts.Controls.Add(this.rbTornadoWatch);
            this.gbProducts.Controls.Add(this.rbMesoscale);
            this.gbProducts.Location = new System.Drawing.Point(12, 68);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(356, 117);
            this.gbProducts.TabIndex = 1;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Products";
            this.gbProducts.Enter += new System.EventHandler(this.gbProducts_Enter);
            // 
            // cbUpdateList
            // 
            this.cbUpdateList.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.cbUpdateList.AllowDrop = true;
            this.cbUpdateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateList.Enabled = false;
            this.cbUpdateList.FormattingEnabled = true;
            this.cbUpdateList.Location = new System.Drawing.Point(162, 15);
            this.cbUpdateList.Margin = new System.Windows.Forms.Padding(1);
            this.cbUpdateList.Name = "cbUpdateList";
            this.cbUpdateList.Size = new System.Drawing.Size(188, 21);
            this.cbUpdateList.TabIndex = 4;
            this.cbUpdateList.SelectedIndexChanged += new System.EventHandler(this.cbUpdateList_SelectedIndexChanged);
            this.cbUpdateList.Click += new System.EventHandler(this.cbUpdateList_Click);
            // 
            // rbWeatherWatch
            // 
            this.rbWeatherWatch.AutoSize = true;
            this.rbWeatherWatch.Location = new System.Drawing.Point(6, 88);
            this.rbWeatherWatch.Margin = new System.Windows.Forms.Padding(1);
            this.rbWeatherWatch.Name = "rbWeatherWatch";
            this.rbWeatherWatch.Size = new System.Drawing.Size(162, 17);
            this.rbWeatherWatch.TabIndex = 3;
            this.rbWeatherWatch.Text = "Weather Watch Cancellation";
            this.rbWeatherWatch.UseVisualStyleBackColor = true;
            this.rbWeatherWatch.CheckedChanged += new System.EventHandler(this.rbWeatherWatch_CheckedChanged);
            // 
            // rbSevereThunderstorm
            // 
            this.rbSevereThunderstorm.AutoSize = true;
            this.rbSevereThunderstorm.Location = new System.Drawing.Point(6, 65);
            this.rbSevereThunderstorm.Margin = new System.Windows.Forms.Padding(1);
            this.rbSevereThunderstorm.Name = "rbSevereThunderstorm";
            this.rbSevereThunderstorm.Size = new System.Drawing.Size(162, 17);
            this.rbSevereThunderstorm.TabIndex = 2;
            this.rbSevereThunderstorm.Text = "Severe Thunderstorm Watch";
            this.rbSevereThunderstorm.UseVisualStyleBackColor = true;
            this.rbSevereThunderstorm.CheckedChanged += new System.EventHandler(this.rbSevereThunderstorm_CheckedChanged);
            // 
            // rbTornadoWatch
            // 
            this.rbTornadoWatch.AutoSize = true;
            this.rbTornadoWatch.Location = new System.Drawing.Point(6, 42);
            this.rbTornadoWatch.Margin = new System.Windows.Forms.Padding(1);
            this.rbTornadoWatch.Name = "rbTornadoWatch";
            this.rbTornadoWatch.Size = new System.Drawing.Size(100, 17);
            this.rbTornadoWatch.TabIndex = 1;
            this.rbTornadoWatch.Text = "Tornado Watch";
            this.rbTornadoWatch.UseVisualStyleBackColor = true;
            this.rbTornadoWatch.CheckedChanged += new System.EventHandler(this.rbTornadoWatch_CheckedChanged);
            // 
            // rbMesoscale
            // 
            this.rbMesoscale.AutoSize = true;
            this.rbMesoscale.Checked = true;
            this.rbMesoscale.Location = new System.Drawing.Point(6, 19);
            this.rbMesoscale.Margin = new System.Windows.Forms.Padding(1);
            this.rbMesoscale.Name = "rbMesoscale";
            this.rbMesoscale.Size = new System.Drawing.Size(130, 17);
            this.rbMesoscale.TabIndex = 0;
            this.rbMesoscale.TabStop = true;
            this.rbMesoscale.Text = "Mesoscale Discussion";
            this.rbMesoscale.UseVisualStyleBackColor = true;
            this.rbMesoscale.CheckedChanged += new System.EventHandler(this.rbMesoscale_CheckedChanged);
            // 
            // lbSelections
            // 
            this.lbSelections.FormattingEnabled = true;
            this.lbSelections.Location = new System.Drawing.Point(12, 238);
            this.lbSelections.Margin = new System.Windows.Forms.Padding(1);
            this.lbSelections.Name = "lbSelections";
            this.lbSelections.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSelections.Size = new System.Drawing.Size(356, 225);
            this.lbSelections.TabIndex = 9;
            this.lbSelections.SelectedIndexChanged += new System.EventHandler(this.lbSelections_SelectedIndexChanged);
            // 
            // boxTimeRange
            // 
            this.boxTimeRange.Controls.Add(this.lblDuration);
            this.boxTimeRange.Controls.Add(this.ddDuration);
            this.boxTimeRange.Controls.Add(this.label2);
            this.boxTimeRange.Location = new System.Drawing.Point(12, 189);
            this.boxTimeRange.Margin = new System.Windows.Forms.Padding(1);
            this.boxTimeRange.Name = "boxTimeRange";
            this.boxTimeRange.Size = new System.Drawing.Size(356, 47);
            this.boxTimeRange.TabIndex = 8;
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
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(191, 469);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 469);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create Text";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // SPCIssuancePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbSelections);
            this.Controls.Add(this.boxTimeRange);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.gbResetTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SPCIssuancePanel";
            this.Text = "SPC Issuance Panel";
            this.gbResetTracking.ResumeLayout(false);
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.boxTimeRange.ResumeLayout(false);
            this.boxTimeRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResetTracking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.RadioButton rbWeatherWatch;
        private System.Windows.Forms.RadioButton rbSevereThunderstorm;
        private System.Windows.Forms.RadioButton rbTornadoWatch;
        private System.Windows.Forms.RadioButton rbMesoscale;
        private System.Windows.Forms.ListBox lbSelections;
        private System.Windows.Forms.GroupBox boxTimeRange;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ComboBox ddDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbUpdateList;
        private System.Windows.Forms.Button button2;
    }
}