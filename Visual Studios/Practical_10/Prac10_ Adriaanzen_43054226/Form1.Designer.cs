namespace Prac10__Adriaanzen_43054226
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.rdoHike = new System.Windows.Forms.RadioButton();
            this.rdoCamp = new System.Windows.Forms.RadioButton();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.txtDays);
            this.groupBox1.Controls.Add(this.rdoCamp);
            this.groupBox1.Controls.Add(this.rdoHike);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill in the form to book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specify number of days here:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(159, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(163, 26);
            this.txtSurname.TabIndex = 4;
            // 
            // rdoHike
            // 
            this.rdoHike.AutoSize = true;
            this.rdoHike.Location = new System.Drawing.Point(32, 137);
            this.rdoHike.Name = "rdoHike";
            this.rdoHike.Size = new System.Drawing.Size(99, 24);
            this.rdoHike.TabIndex = 5;
            this.rdoHike.TabStop = true;
            this.rdoHike.Text = "Day Hike";
            this.rdoHike.UseVisualStyleBackColor = true;
            // 
            // rdoCamp
            // 
            this.rdoCamp.AutoSize = true;
            this.rdoCamp.Location = new System.Drawing.Point(181, 137);
            this.rdoCamp.Name = "rdoCamp";
            this.rdoCamp.Size = new System.Drawing.Size(145, 24);
            this.rdoCamp.TabIndex = 6;
            this.rdoCamp.TabStop = true;
            this.rdoCamp.Text = "Hike and Camp";
            this.rdoCamp.UseVisualStyleBackColor = true;
            this.rdoCamp.CheckedChanged += new System.EventHandler(this.rdoCamp_CheckedChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(259, 194);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(74, 26);
            this.txtDays.TabIndex = 7;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBook.Location = new System.Drawing.Point(112, 243);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(121, 42);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(133, 372);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(151, 42);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New Booking";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(539, 77);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(344, 224);
            this.lstOutput.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Proceed to Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(828, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 42);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prac10__Adriaanzen_43054226.Properties.Resources.eaf8ae05a76fd1c639c22e924025326e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 456);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "BND Adventures";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCamp;
        private System.Windows.Forms.RadioButton rdoHike;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
    }
}

