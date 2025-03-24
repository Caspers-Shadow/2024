namespace Prac8_Adriaanzen_43054226
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdoFactors = new System.Windows.Forms.RadioButton();
            this.rdoTable = new System.Windows.Forms.RadioButton();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblRandomOutput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRandomOutput);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txtUpper);
            this.groupBox1.Controls.Add(this.txtLower);
            this.groupBox1.Controls.Add(this.lblUpper);
            this.groupBox1.Controls.Add(this.lblLower);
            this.groupBox1.Location = new System.Drawing.Point(50, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(314, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random number generator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutput);
            this.groupBox2.Controls.Add(this.lstOutput);
            this.groupBox2.Controls.Add(this.rdoTable);
            this.groupBox2.Controls.Add(this.rdoFactors);
            this.groupBox2.Location = new System.Drawing.Point(431, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(324, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multiplivation Factors";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(7, 48);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(152, 20);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "Enetr Lower Limit: ";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(8, 113);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(151, 20);
            this.lblUpper.TabIndex = 1;
            this.lblUpper.Text = "Enetr Upper Limit: ";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(166, 48);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(130, 26);
            this.txtLower.TabIndex = 2;
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(166, 110);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(130, 26);
            this.txtUpper.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 179);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(135, 73);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Random";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(502, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(114, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdoFactors
            // 
            this.rdoFactors.AutoSize = true;
            this.rdoFactors.Location = new System.Drawing.Point(22, 299);
            this.rdoFactors.Name = "rdoFactors";
            this.rdoFactors.Size = new System.Drawing.Size(183, 24);
            this.rdoFactors.TabIndex = 0;
            this.rdoFactors.TabStop = true;
            this.rdoFactors.Text = "Display Factors only";
            this.rdoFactors.UseVisualStyleBackColor = true;
            this.rdoFactors.CheckedChanged += new System.EventHandler(this.rdoFactors_CheckedChanged);
            // 
            // rdoTable
            // 
            this.rdoTable.AutoSize = true;
            this.rdoTable.Location = new System.Drawing.Point(22, 258);
            this.rdoTable.Name = "rdoTable";
            this.rdoTable.Size = new System.Drawing.Size(265, 24);
            this.rdoTable.TabIndex = 1;
            this.rdoTable.TabStop = true;
            this.rdoTable.Text = "Display Multiplication table only";
            this.rdoTable.UseVisualStyleBackColor = true;
            this.rdoTable.CheckedChanged += new System.EventHandler(this.rdoTable_CheckedChanged);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(22, 63);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(282, 164);
            this.lstOutput.TabIndex = 2;
            // 
            // lblRandomOutput
            // 
            this.lblRandomOutput.AutoSize = true;
            this.lblRandomOutput.Location = new System.Drawing.Point(147, 298);
            this.lblRandomOutput.Name = "lblRandomOutput";
            this.lblRandomOutput.Size = new System.Drawing.Size(0, 20);
            this.lblRandomOutput.TabIndex = 5;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(22, 27);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 512);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Random Numbers and Loops";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.RadioButton rdoTable;
        private System.Windows.Forms.RadioButton rdoFactors;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRandomOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

