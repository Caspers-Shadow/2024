namespace Prac2_Adriaanzen_43054226
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
            this.lblChoose = new System.Windows.Forms.Label();
            this.imgSpringbok = new System.Windows.Forms.PictureBox();
            this.imgCrane = new System.Windows.Forms.PictureBox();
            this.imgGaljoen = new System.Windows.Forms.PictureBox();
            this.imgLion = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpringbok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGaljoen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(54, 53);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(1112, 39);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Which one of the following is not one of South Africa\'s national Symbols?";
            // 
            // imgSpringbok
            // 
            this.imgSpringbok.Image = global::Prac2_Adriaanzen_43054226.Properties.Resources.springbok;
            this.imgSpringbok.Location = new System.Drawing.Point(43, 156);
            this.imgSpringbok.Name = "imgSpringbok";
            this.imgSpringbok.Size = new System.Drawing.Size(246, 249);
            this.imgSpringbok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSpringbok.TabIndex = 1;
            this.imgSpringbok.TabStop = false;
            this.imgSpringbok.Click += new System.EventHandler(this.imgSpringbok_Click);
            // 
            // imgCrane
            // 
            this.imgCrane.Image = global::Prac2_Adriaanzen_43054226.Properties.Resources.blue_crane;
            this.imgCrane.Location = new System.Drawing.Point(350, 156);
            this.imgCrane.Name = "imgCrane";
            this.imgCrane.Size = new System.Drawing.Size(246, 249);
            this.imgCrane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCrane.TabIndex = 2;
            this.imgCrane.TabStop = false;
            this.imgCrane.Click += new System.EventHandler(this.imgCrane_Click);
            // 
            // imgGaljoen
            // 
            this.imgGaljoen.Image = global::Prac2_Adriaanzen_43054226.Properties.Resources.galjoen;
            this.imgGaljoen.Location = new System.Drawing.Point(646, 156);
            this.imgGaljoen.Name = "imgGaljoen";
            this.imgGaljoen.Size = new System.Drawing.Size(246, 249);
            this.imgGaljoen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGaljoen.TabIndex = 3;
            this.imgGaljoen.TabStop = false;
            this.imgGaljoen.Click += new System.EventHandler(this.imgGaljoen_Click);
            // 
            // imgLion
            // 
            this.imgLion.Image = global::Prac2_Adriaanzen_43054226.Properties.Resources.lion;
            this.imgLion.Location = new System.Drawing.Point(946, 156);
            this.imgLion.Name = "imgLion";
            this.imgLion.Size = new System.Drawing.Size(246, 249);
            this.imgLion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLion.TabIndex = 4;
            this.imgLion.TabStop = false;
            this.imgLion.Click += new System.EventHandler(this.imgLion_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(61, 441);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 58);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(987, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 58);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 534);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.imgLion);
            this.Controls.Add(this.imgGaljoen);
            this.Controls.Add(this.imgCrane);
            this.Controls.Add(this.imgSpringbok);
            this.Controls.Add(this.lblChoose);
            this.Name = "Form1";
            this.Text = "Quiz 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSpringbok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGaljoen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.PictureBox imgSpringbok;
        private System.Windows.Forms.PictureBox imgCrane;
        private System.Windows.Forms.PictureBox imgGaljoen;
        private System.Windows.Forms.PictureBox imgLion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}

