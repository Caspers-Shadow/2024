using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_Mock_Test
{
    public partial class Form1 : Form
    {
        private const int MAX_CAPACITY = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string surname = txtSurname.Text;

                if (!int.TryParse(txtAdditional.Text, out int additional))
                {
                    MessageBox.Show("Please enter a number for the amount of additional taxis.");
                    return;
                }

                if (additional < 0 || additional > 4)
                {
                    MessageBox.Show("No Taxi is aloud more than 4 additional taxis or less than 0 taxis.");
                    return;
                }

                int primaryTaxi = 1;

                decimal farePerSeat;
                decimal trip = 0;
                string routeTaken;

                if (rdoCATA.Checked)
                {
                    farePerSeat = 11m;
                    routeTaken = rdoCATA.Text;
                }
                else if (rdoGPTA.Checked)
                {
                    farePerSeat = 12m;
                    routeTaken = rdoGPTA.Text;
                }
                else if (rdoITA.Checked)
                {
                    farePerSeat = 13m;
                    routeTaken = rdoITA.Text;
                }
                else
                {
                    MessageBox.Show("Please chose an association.");
                    return;
                }

                trip = MAX_CAPACITY * farePerSeat;

                lstOutput.Items.Clear();
                lstOutput.Items.Add("Taxi for " + name + " " + surname + " on route: " + routeTaken + " is successfully verified @ " + trip.ToString("c") + " per trip");

                Random randomNum = new Random();
                int membershipNum = randomNum.Next(100000, 999999);


                for (int i = 1; i <= additional + 1; i++)
                {
                    lstOutput.Items.Add("A tottal of " + i + " Taxis have been verified for the honorable " + name + " " + surname + " with membership number: " + membershipNum);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtAdditional.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;

            txtName.Focus();

            lstRoute.SelectedIndex = -1;

            lstOutput.Items.Clear();
            rdoGPTA.Checked = true;
        }
    }
}
