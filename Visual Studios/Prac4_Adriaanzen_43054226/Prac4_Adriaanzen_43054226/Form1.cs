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
 * Practical 4
 */

namespace Prac4_Adriaanzen_43054226
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing all relevant controls and setting the focus to the textbox
            txtRadius.Clear();
            txtRadius.Focus();

            lblArea.Text = "Area:";
            lblCircumference.Text = "Circumference:";
            lblVolume.Text = "Volume:";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Seeing that the right tyoe of value is entered to the radius textbox
            try
            {
                //Variables
                double radius = double.Parse(txtRadius.Text);
                double circleArea, circleCircum, sphereVol;

                //Calculations
                circleArea = Math.PI * Math.Pow(radius, 2);
                circleCircum = 2 * Math.Pow(radius, 2) * radius;
                sphereVol = (4 / 3) * Math.PI * Math.Pow(radius, 3);

                //Output
                lblArea.Text = "Area: " + circleArea.ToString("n2");
                lblCircumference.Text = "Circumference: " + circleCircum.ToString("n2");
                lblVolume.Text = "Volume: " + sphereVol.ToString("n2");
            }
            catch 
            {
                //If the incorrect datatype is entered to radius
                MessageBox.Show("Please enter a valid number for the radius.");
                txtRadius.Focus();
            }

        }
    }
}
