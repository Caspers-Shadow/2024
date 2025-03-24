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
 Mariska Adriaanzen
43054226
Practical 3
 */

namespace Prac3_Adriaanzen_43054226
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            double speed = double.Parse(txtSpeed.Text);
            double fuelEfficiency = double.Parse(txtFuel.Text);
            double fuelPrice = double.Parse(txtPrice.Text);

            double fuelCost = (distance / fuelEfficiency) * fuelPrice;
            double travelTime = distance / speed;

            lblOutput.Text = "The estimate fuel cost is "+ fuelCost.ToString("C") + " and the estimate travel time is "+ travelTime.ToString("n2") +" hours.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistance.Text = string.Empty;   
            txtFuel.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtSpeed.Text = string.Empty;

            lblOutput.Text = string.Empty;
        }
    }
}
