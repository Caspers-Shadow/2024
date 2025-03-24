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
    Practical 2
 */

namespace Prac2_Adriaanzen_43054226
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //All image on click events to show their respected messages:
        private void imgSpringbok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect, try again.This is South Africa's national animal");
        }

        private void imgCrane_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect, try again.This is South Africa's national bird");
        }

        private void imgGaljoen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect, try again.This is South Africa's national fish");
        }

        private void imgLion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Making all the images and the label invisible when the form loads up
            imgCrane.Visible = false;
            imgGaljoen.Visible = false;
            imgLion.Visible = false;
            imgSpringbok.Visible = false;

            lblChoose.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Making the images and label visible to the user
            imgCrane.Visible = true;
            imgGaljoen.Visible = true;
            imgLion.Visible = true;
            imgSpringbok.Visible = true;

            lblChoose.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }
    }
}
