namespace Prac6_Adriaanzen_43054226
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
            this.lstDestination = new System.Windows.Forms.ListBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.rdoIkageng = new System.Windows.Forms.RadioButton();
            this.rdoPromosa = new System.Windows.Forms.RadioButton();
            this.rdoMohadin = new System.Windows.Forms.RadioButton();
            this.lblTickets = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoMohadin);
            this.groupBox1.Controls.Add(this.rdoPromosa);
            this.groupBox1.Controls.Add(this.rdoIkageng);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potchefstroom Pickup point";
            // 
            // lstDestination
            // 
            this.lstDestination.FormattingEnabled = true;
            this.lstDestination.ItemHeight = 16;
            this.lstDestination.Items.AddRange(new object[] {
            "Johannesburg",
            "Pretoria",
            "Randfontein"});
            this.lstDestination.Location = new System.Drawing.Point(28, 199);
            this.lstDestination.Name = "lstDestination";
            this.lstDestination.Size = new System.Drawing.Size(254, 100);
            this.lstDestination.TabIndex = 0;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(28, 180);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(77, 16);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination:";
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(28, 305);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(96, 20);
            this.cbReturn.TabIndex = 2;
            this.cbReturn.Text = "Return trip?";
            this.cbReturn.UseVisualStyleBackColor = true;
            this.cbReturn.CheckedChanged += new System.EventHandler(this.cbReturn_CheckedChanged);
            // 
            // rdoIkageng
            // 
            this.rdoIkageng.AutoSize = true;
            this.rdoIkageng.Location = new System.Drawing.Point(6, 36);
            this.rdoIkageng.Name = "rdoIkageng";
            this.rdoIkageng.Size = new System.Drawing.Size(166, 20);
            this.rdoIkageng.TabIndex = 0;
            this.rdoIkageng.TabStop = true;
            this.rdoIkageng.Text = "Potchefstroom Ikageng";
            this.rdoIkageng.UseVisualStyleBackColor = true;
            // 
            // rdoPromosa
            // 
            this.rdoPromosa.AutoSize = true;
            this.rdoPromosa.Location = new System.Drawing.Point(6, 76);
            this.rdoPromosa.Name = "rdoPromosa";
            this.rdoPromosa.Size = new System.Drawing.Size(172, 20);
            this.rdoPromosa.TabIndex = 1;
            this.rdoPromosa.TabStop = true;
            this.rdoPromosa.Text = "Potchefstroom Promosa";
            this.rdoPromosa.UseVisualStyleBackColor = true;
            // 
            // rdoMohadin
            // 
            this.rdoMohadin.AutoSize = true;
            this.rdoMohadin.Location = new System.Drawing.Point(6, 112);
            this.rdoMohadin.Name = "rdoMohadin";
            this.rdoMohadin.Size = new System.Drawing.Size(169, 20);
            this.rdoMohadin.TabIndex = 2;
            this.rdoMohadin.TabStop = true;
            this.rdoMohadin.Text = "Potchefstroom Mohadin";
            this.rdoMohadin.UseVisualStyleBackColor = true;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(25, 354);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(92, 16);
            this.lblTickets.TabIndex = 3;
            this.lblTickets.Text = "No. of Tickets:";
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(124, 354);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(158, 22);
            this.txtTickets.TabIndex = 4;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(31, 398);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(251, 59);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book lift";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 489);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.cbReturn);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lstDestination);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Abraham Lifts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDestination;
        private System.Windows.Forms.RadioButton rdoIkageng;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.CheckBox cbReturn;
        private System.Windows.Forms.RadioButton rdoMohadin;
        private System.Windows.Forms.RadioButton rdoPromosa;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Button btnBook;
    }
}

