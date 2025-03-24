namespace Prac3_Adriaanzen_43054226
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
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblFuelEfficiency = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pnlOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(21, 29);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(177, 16);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distance to be traveled (km):";
            // 
            // lblFuelEfficiency
            // 
            this.lblFuelEfficiency.AutoSize = true;
            this.lblFuelEfficiency.Location = new System.Drawing.Point(21, 82);
            this.lblFuelEfficiency.Name = "lblFuelEfficiency";
            this.lblFuelEfficiency.Size = new System.Drawing.Size(184, 16);
            this.lblFuelEfficiency.TabIndex = 1;
            this.lblFuelEfficiency.Text = "Vehicle\'s fuel efficiency (km/l):";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(21, 135);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(177, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Current fuel price per liter (R):";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(21, 189);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(91, 16);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Speed (km/h):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 39);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(228, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(444, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlOutput
            // 
            this.pnlOutput.Controls.Add(this.lblOutput);
            this.pnlOutput.Location = new System.Drawing.Point(28, 252);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(522, 42);
            this.pnlOutput.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(542, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(446, 23);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 22);
            this.txtDistance.TabIndex = 9;
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(446, 80);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(100, 22);
            this.txtFuel.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(446, 130);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(446, 184);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtSpeed.TabIndex = 12;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(15, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(28, 16);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "___";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 422);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFuelEfficiency);
            this.Controls.Add(this.lblDistance);
            this.Name = "Form1";
            this.Text = "Fuel Cost And Trvael Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblFuelEfficiency;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblOutput;
    }
}

