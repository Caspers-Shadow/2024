using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_interest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInitial.Text, out int initial) || !int.TryParse(txtInterest.Text, out int interest) || !int.TryParse(txtYears.Text, out int year))
            {
                MessageBox.Show("Please enter numbers.");
                return;
            }

            double rate = interest / 100;

            for (int i = 1; i <= year; i++)
            {
                double total = initial * Math.Pow(1 + rate, i);
                lstOutput.Items.Add("After " + i + " years the amount is: " + total.ToString("C2"));
            }
        }
    }
}
