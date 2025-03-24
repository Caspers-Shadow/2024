namespace Prac7_Adriaanzen_43054226
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBasic = new System.Windows.Forms.RadioButton();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstPayment = new System.Windows.Forms.ListBox();
            this.txtAdditional = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.rdoTrend = new System.Windows.Forms.RadioButton();
            this.rdoLuxury = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLuxury);
            this.groupBox1.Controls.Add(this.rdoTrend);
            this.groupBox1.Controls.Add(this.rdoBasic);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(250, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Options";
            // 
            // rdoBasic
            // 
            this.rdoBasic.AutoSize = true;
            this.rdoBasic.Location = new System.Drawing.Point(8, 39);
            this.rdoBasic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBasic.Name = "rdoBasic";
            this.rdoBasic.Size = new System.Drawing.Size(142, 24);
            this.rdoBasic.TabIndex = 0;
            this.rdoBasic.TabStop = true;
            this.rdoBasic.Text = "Basic Package";
            this.rdoBasic.UseVisualStyleBackColor = true;
            this.rdoBasic.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.Location = new System.Drawing.Point(21, 232);
            this.lblAdditional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(222, 20);
            this.lblAdditional.TabIndex = 1;
            this.lblAdditional.Text = "Number of additional events:";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(24, 292);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(242, 56);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Print Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 290);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(234, 58);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstPayment
            // 
            this.lstPayment.FormattingEnabled = true;
            this.lstPayment.ItemHeight = 20;
            this.lstPayment.Items.AddRange(new object[] {
            "How will you be paying?",
            "",
            "Voucher",
            "Cash",
            "EFT",
            "Internal Fianance",
            "Member points"});
            this.lstPayment.Location = new System.Drawing.Point(283, 27);
            this.lstPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPayment.Name = "lstPayment";
            this.lstPayment.Size = new System.Drawing.Size(234, 164);
            this.lstPayment.TabIndex = 4;
            // 
            // txtAdditional
            // 
            this.txtAdditional.Location = new System.Drawing.Point(283, 230);
            this.txtAdditional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.Size = new System.Drawing.Size(234, 26);
            this.txtAdditional.TabIndex = 5;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(25, 371);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(492, 164);
            this.lstOutput.TabIndex = 6;
            // 
            // rdoTrend
            // 
            this.rdoTrend.AutoSize = true;
            this.rdoTrend.Location = new System.Drawing.Point(9, 83);
            this.rdoTrend.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTrend.Name = "rdoTrend";
            this.rdoTrend.Size = new System.Drawing.Size(142, 24);
            this.rdoTrend.TabIndex = 1;
            this.rdoTrend.TabStop = true;
            this.rdoTrend.Text = "Trend Package";
            this.rdoTrend.UseVisualStyleBackColor = true;
            // 
            // rdoLuxury
            // 
            this.rdoLuxury.AutoSize = true;
            this.rdoLuxury.Location = new System.Drawing.Point(9, 133);
            this.rdoLuxury.Margin = new System.Windows.Forms.Padding(4);
            this.rdoLuxury.Name = "rdoLuxury";
            this.rdoLuxury.Size = new System.Drawing.Size(149, 24);
            this.rdoLuxury.TabIndex = 2;
            this.rdoLuxury.TabStop = true;
            this.rdoLuxury.Text = "Luxury Package";
            this.rdoLuxury.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 562);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtAdditional);
            this.Controls.Add(this.lstPayment);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lblAdditional);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBasic;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstPayment;
        private System.Windows.Forms.TextBox txtAdditional;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.RadioButton rdoLuxury;
        private System.Windows.Forms.RadioButton rdoTrend;
    }
}

