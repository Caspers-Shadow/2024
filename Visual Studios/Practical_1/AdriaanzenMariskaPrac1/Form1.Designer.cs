namespace AdriaanzenMariskaPrac1
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
            this.btnSetswana = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnAfrikaans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetswana
            // 
            this.btnSetswana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetswana.ForeColor = System.Drawing.Color.Red;
            this.btnSetswana.Location = new System.Drawing.Point(38, 74);
            this.btnSetswana.Name = "btnSetswana";
            this.btnSetswana.Size = new System.Drawing.Size(224, 80);
            this.btnSetswana.TabIndex = 0;
            this.btnSetswana.Text = "Setswana";
            this.btnSetswana.UseVisualStyleBackColor = true;
            this.btnSetswana.Click += new System.EventHandler(this.btnSetswana_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.Lime;
            this.btnEnglish.Location = new System.Drawing.Point(279, 74);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(224, 80);
            this.btnEnglish.TabIndex = 1;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnAfrikaans
            // 
            this.btnAfrikaans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfrikaans.ForeColor = System.Drawing.Color.Blue;
            this.btnAfrikaans.Location = new System.Drawing.Point(512, 74);
            this.btnAfrikaans.Name = "btnAfrikaans";
            this.btnAfrikaans.Size = new System.Drawing.Size(224, 80);
            this.btnAfrikaans.TabIndex = 2;
            this.btnAfrikaans.Text = "Afrikaans";
            this.btnAfrikaans.UseVisualStyleBackColor = true;
            this.btnAfrikaans.Click += new System.EventHandler(this.btnAfrikaans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.btnAfrikaans);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnSetswana);
            this.Name = "Form1";
            this.Text = "Multilingual Greetings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetswana;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnAfrikaans;
    }
}

