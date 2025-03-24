namespace Taxi_Mock_Test
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAdditional = new System.Windows.Forms.TextBox();
            this.lstRoute = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGPTA = new System.Windows.Forms.RadioButton();
            this.rdoITA = new System.Windows.Forms.RadioButton();
            this.rdoCATA = new System.Windows.Forms.RadioButton();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 42);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(537, 42);
            this.lblRoute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(94, 20);
            this.lblRoute.TabIndex = 1;
            this.lblRoute.Text = "Taxi Route:";
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.Location = new System.Drawing.Point(26, 191);
            this.lblAdditional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(206, 20);
            this.lblAdditional.TabIndex = 2;
            this.lblAdditional.Text = "Amount additional of Taxis";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(26, 114);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(76, 20);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(273, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(273, 108);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(220, 26);
            this.txtSurname.TabIndex = 5;
            // 
            // txtAdditional
            // 
            this.txtAdditional.Location = new System.Drawing.Point(273, 191);
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.Size = new System.Drawing.Size(220, 26);
            this.txtAdditional.TabIndex = 6;
            // 
            // lstRoute
            // 
            this.lstRoute.FormattingEnabled = true;
            this.lstRoute.ItemHeight = 20;
            this.lstRoute.Items.AddRange(new object[] {
            "Promosa",
            "Moadin",
            "Ikageng",
            "Industina"});
            this.lstRoute.Location = new System.Drawing.Point(654, 36);
            this.lstRoute.Name = "lstRoute";
            this.lstRoute.Size = new System.Drawing.Size(212, 164);
            this.lstRoute.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCATA);
            this.groupBox1.Controls.Add(this.rdoITA);
            this.groupBox1.Controls.Add(this.rdoGPTA);
            this.groupBox1.Location = new System.Drawing.Point(927, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 201);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taxi Association";
            // 
            // rdoGPTA
            // 
            this.rdoGPTA.AutoSize = true;
            this.rdoGPTA.Location = new System.Drawing.Point(23, 41);
            this.rdoGPTA.Name = "rdoGPTA";
            this.rdoGPTA.Size = new System.Drawing.Size(75, 24);
            this.rdoGPTA.TabIndex = 0;
            this.rdoGPTA.TabStop = true;
            this.rdoGPTA.Text = "GPTA";
            this.rdoGPTA.UseVisualStyleBackColor = true;
            // 
            // rdoITA
            // 
            this.rdoITA.AutoSize = true;
            this.rdoITA.Location = new System.Drawing.Point(23, 89);
            this.rdoITA.Name = "rdoITA";
            this.rdoITA.Size = new System.Drawing.Size(55, 24);
            this.rdoITA.TabIndex = 1;
            this.rdoITA.TabStop = true;
            this.rdoITA.Text = "ITA";
            this.rdoITA.UseVisualStyleBackColor = true;
            // 
            // rdoCATA
            // 
            this.rdoCATA.AutoSize = true;
            this.rdoCATA.Location = new System.Drawing.Point(23, 140);
            this.rdoCATA.Name = "rdoCATA";
            this.rdoCATA.Size = new System.Drawing.Size(74, 24);
            this.rdoCATA.TabIndex = 2;
            this.rdoCATA.TabStop = true;
            this.rdoCATA.Text = "CATA";
            this.rdoCATA.UseVisualStyleBackColor = true;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(30, 268);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(836, 204);
            this.lstOutput.TabIndex = 9;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(102, 508);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(130, 49);
            this.btnVerify.TabIndex = 10;
            this.btnVerify.Text = "Verify Taxis";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(644, 508);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 49);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next Operator";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 589);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstRoute);
            this.Controls.Add(this.txtAdditional);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblAdditional);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblName);
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

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAdditional;
        private System.Windows.Forms.ListBox lstRoute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCATA;
        private System.Windows.Forms.RadioButton rdoITA;
        private System.Windows.Forms.RadioButton rdoGPTA;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnNext;
    }
}

