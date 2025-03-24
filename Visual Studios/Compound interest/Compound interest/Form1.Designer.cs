namespace Compound_interest
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
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(34, 41);
            this.lblInitial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(180, 20);
            this.lblInitial.TabIndex = 0;
            this.lblInitial.Text = "Initial amount invested:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(85, 96);
            this.lblYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(124, 20);
            this.lblYears.TabIndex = 1;
            this.lblYears.Text = "Years invested:";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(111, 145);
            this.lblInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(104, 20);
            this.lblInterest.TabIndex = 2;
            this.lblInterest.Text = "Interest rate:";
            this.lblInterest.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(236, 41);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(124, 26);
            this.txtInitial.TabIndex = 3;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(236, 96);
            this.txtYears.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(124, 26);
            this.txtYears.TabIndex = 4;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(236, 145);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(124, 26);
            this.txtInterest.TabIndex = 5;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(38, 210);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(323, 244);
            this.lstOutput.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 485);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 37);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(266, 485);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 562);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblInitial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

