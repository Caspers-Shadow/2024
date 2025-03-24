namespace Math_Squares
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
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txtUpper);
            this.groupBox1.Controls.Add(this.txtLower);
            this.groupBox1.Controls.Add(this.lblUpper);
            this.groupBox1.Controls.Add(this.lblLower);
            this.groupBox1.Location = new System.Drawing.Point(24, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Random number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDisplay);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.lblDisplay);
            this.groupBox2.Location = new System.Drawing.Point(525, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Squares";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(43, 63);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(91, 20);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "Lower limit";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(43, 107);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(90, 20);
            this.lblUpper.TabIndex = 1;
            this.lblUpper.Text = "Upper limit";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.Location = new System.Drawing.Point(36, 12);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(115, 29);
            this.lblRandom.TabIndex = 2;
            this.lblRandom.Text = "Random";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(23, 41);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(65, 20);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "Display";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(140, 63);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(180, 26);
            this.txtLower.TabIndex = 3;
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(140, 107);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(180, 26);
            this.txtUpper.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(80, 199);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(197, 63);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate random number";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(214, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 63);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 63);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 20;
            this.lstDisplay.Location = new System.Drawing.Point(27, 75);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(348, 264);
            this.lstDisplay.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblRandom);
            this.panel1.Location = new System.Drawing.Point(80, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 55);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Math Squares";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}

