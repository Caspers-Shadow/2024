using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Squares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLower.Text, out int lowerLim) || !int.TryParse(txtUpper.Text, out int upperLim))
            {
                MessageBox.Show("Please enter a valid Integer.");
                return;
            }

            if (!(lowerLim >= 1 && lowerLim <= 50) || !(upperLim >= 1 && upperLim <= 50))
            {
                MessageBox.Show("Please enter valid integers between 1 and 50.");
                return; 
            }

            Random random = new Random();
            int num = random.Next(lowerLim,upperLim+1);

            lblRandom.Text = num.ToString();

            lblDisplay.Text = "The squares of number 1 to " + num +" will be displayed";
            
            lstDisplay.Items.Clear();
            for (int i = 1; i <= num; i++)
            {
                lstDisplay.Items.Add(i + " x " + i + " = " + (i*i));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLower.Text = string.Empty;
            txtUpper.Text = string.Empty;

            lstDisplay.Items.Clear();

            lblDisplay.Text= string.Empty;
            lblRandom.Text= string.Empty;

            txtLower.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
            lblRandom.Text = string.Empty;
        }
    }
}
