using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
 * Mariska Adriaanzen
 * 43054226
 * Practical 8
 */

namespace Prac8_Adriaanzen_43054226
{
    public partial class Form1 : Form
    {
        //The random number to be used throughout
        private int randNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Resetting all the values
            txtLower.Text = string.Empty;
            txtUpper.Text = string.Empty;   

            rdoFactors.Checked = false;
            rdoTable.Checked = false;

            lstOutput.Items.Clear();
            lstOutput.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On form activate visibility
            lstOutput.Visible=false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int lowerLim = 0;
            int upperLim = 0;

            //Checking to see if text is numbers
            if (!int.TryParse(txtLower.Text, out lowerLim) || !int.TryParse(txtUpper.Text, out upperLim))
            {
                MessageBox.Show("Hey the limit is supposed to be a number");
            }

            //Having the numbers be between values
            if ((lowerLim < 1 || upperLim < 1) || (lowerLim > 40 || upperLim > 40))
            {
                MessageBox.Show("Please enter the correct lower limit value");
                return;
            }

            //Getting a random number between the limits
            Random random = new Random();
            randNum = random.Next(lowerLim, upperLim + 1);

            lblRandomOutput.Text = ""+ randNum;
            lstOutput.Items.Clear();
            lstOutput.Visible = true;

            //Output
           lblOutput.Text = "The multiplication table and factors of " + randNum;
           for (int i = 1; i <= randNum; i++)
           {
                int multiplyE = randNum * i;
                lstOutput.Items.Add(randNum + " * " + i + " = " + multiplyE);
           }


           lstOutput.Items.Add("Factors of " + randNum);
           for (int i = 1; i <= randNum; i++)
           {
               if (randNum % i == 0)
               {
                   lstOutput.Items.Add(i.ToString());
               }
           }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exiting
            this.Close();
        }

        private void rdoTable_CheckedChanged(object sender, EventArgs e)
        {
            //Only Table
            lstOutput.Items.Clear();

            lblOutput.Text = "This shows multiplication table of " + randNum;
            for (int i = 1; i <= randNum; i++)
            {
                int multiplyE = randNum * i;
                lstOutput.Items.Add(randNum + " * " + i + " = " + multiplyE);
            }
        }

        private void rdoFactors_CheckedChanged(object sender, EventArgs e)
        {
            //Only Factors
            lstOutput.Items.Clear();
            lblOutput.Text = "This shows the factors of "+ randNum +" only";

            lstOutput.Items.Add("Factors of " + randNum);
            for (int i = 1; i <= randNum; i++)
            {
                if (randNum % i == 0)
                {
                    lstOutput.Items.Add(i.ToString());
                }
            }
        }
    }
}
