namespace Prac9_Adriaanzen_43054226
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBookFac = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFacilitieSelect = new System.Windows.Forms.Label();
            this.rdoIndoor = new System.Windows.Forms.RadioButton();
            this.rdoOutdoor = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSports = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(23, 110);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(349, 244);
            this.lstOutput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSports);
            this.groupBox1.Controls.Add(this.btnBookFac);
            this.groupBox1.Controls.Add(this.lstOutput);
            this.groupBox1.Location = new System.Drawing.Point(35, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 423);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sport Facilities";
            // 
            // btnBookFac
            // 
            this.btnBookFac.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookFac.Location = new System.Drawing.Point(61, 360);
            this.btnBookFac.Name = "btnBookFac";
            this.btnBookFac.Size = new System.Drawing.Size(261, 43);
            this.btnBookFac.TabIndex = 1;
            this.btnBookFac.Text = "Book facilities";
            this.btnBookFac.UseVisualStyleBackColor = false;
            this.btnBookFac.Click += new System.EventHandler(this.btnBookFac_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(844, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Controls.Add(this.rdoAll);
            this.groupBox2.Controls.Add(this.rdoOutdoor);
            this.groupBox2.Controls.Add(this.rdoIndoor);
            this.groupBox2.Controls.Add(this.lblFacilitieSelect);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnNewBook);
            this.groupBox2.Location = new System.Drawing.Point(465, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 423);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facility Booking";
            // 
            // btnNewBook
            // 
            this.btnNewBook.Location = new System.Drawing.Point(23, 360);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(127, 43);
            this.btnNewBook.TabIndex = 1;
            this.btnNewBook.Text = "New Booking";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(258, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 43);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblFacilitieSelect
            // 
            this.lblFacilitieSelect.AutoSize = true;
            this.lblFacilitieSelect.Location = new System.Drawing.Point(23, 172);
            this.lblFacilitieSelect.Name = "lblFacilitieSelect";
            this.lblFacilitieSelect.Size = new System.Drawing.Size(320, 20);
            this.lblFacilitieSelect.TabIndex = 5;
            this.lblFacilitieSelect.Text = "Select the facility you want to book below:";
            // 
            // rdoIndoor
            // 
            this.rdoIndoor.AutoSize = true;
            this.rdoIndoor.Location = new System.Drawing.Point(27, 217);
            this.rdoIndoor.Name = "rdoIndoor";
            this.rdoIndoor.Size = new System.Drawing.Size(76, 24);
            this.rdoIndoor.TabIndex = 6;
            this.rdoIndoor.TabStop = true;
            this.rdoIndoor.Text = "Indoor";
            this.rdoIndoor.UseVisualStyleBackColor = true;
            // 
            // rdoOutdoor
            // 
            this.rdoOutdoor.AutoSize = true;
            this.rdoOutdoor.Location = new System.Drawing.Point(159, 217);
            this.rdoOutdoor.Name = "rdoOutdoor";
            this.rdoOutdoor.Size = new System.Drawing.Size(90, 24);
            this.rdoOutdoor.TabIndex = 7;
            this.rdoOutdoor.TabStop = true;
            this.rdoOutdoor.Text = "Outdoor";
            this.rdoOutdoor.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(309, 217);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(49, 24);
            this.rdoAll.TabIndex = 8;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBook.Location = new System.Drawing.Point(137, 282);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(127, 41);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 26);
            this.txtName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // btnSports
            // 
            this.btnSports.Location = new System.Drawing.Point(23, 38);
            this.btnSports.Name = "btnSports";
            this.btnSports.Size = new System.Drawing.Size(349, 58);
            this.btnSports.TabIndex = 2;
            this.btnSports.Text = "Click here to view offered sport facilities";
            this.btnSports.UseVisualStyleBackColor = true;
            this.btnSports.Click += new System.EventHandler(this.btnSports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prac9_Adriaanzen_43054226.Properties.Resources.Prac9_BGImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DBN Sports Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBookFac;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoOutdoor;
        private System.Windows.Forms.RadioButton rdoIndoor;
        private System.Windows.Forms.Label lblFacilitieSelect;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSports;
    }
}

