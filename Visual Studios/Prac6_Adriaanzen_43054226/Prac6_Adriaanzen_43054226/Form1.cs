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
 * Practical 6
 */

namespace Prac6_Adriaanzen_43054226
{
    public partial class Form1 : Form
    {

        public bool returnTrip = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDestination.Items.Add("Durban");
            lstDestination.Items.Add("Centurion");
            lstDestination.Items.Add("Bloemfontein");
            lstDestination.Items.Add("Capetown");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int basicFeePick = 0;
            decimal totalLiftFare = 0;
            decimal liftFare= 0;

            //Checking that the txt is filled in
            if (!int.TryParse(txtTickets.Text, out int numTickets) || numTickets <= 0)
            {
                MessageBox.Show("Enter the correct amount of tickets");
                return;
            }

            //Setting basic fees
            if (rdoIkageng.Checked)
                basicFeePick = 250;
            else if (rdoMohadin.Checked)
                basicFeePick = 220;
            else if (rdoPromosa.Checked)
                basicFeePick = 270;
            else
                basicFeePick = 200;

            

            //Setting lift fare prices
            switch (lstDestination.SelectedIndex)
            {
                case 0:
                    liftFare = basicFeePick + 200m;
                    break;
                case 1:
                    liftFare = basicFeePick + 250m;
                    break;
                case 2:
                    liftFare = basicFeePick + 150m;
                    break;
                case 3:
                    liftFare = basicFeePick + 600m;
                    break;
                case 4:
                    liftFare = basicFeePick + 250m;
                    break;
                case 5:
                    liftFare = basicFeePick + 400m;
                    break;
                case 6:
                    liftFare = basicFeePick + 900m;
                    break;
                default:
                    MessageBox.Show("Please choose a destination from the list");
                    break;

            }
            
            //Discount if applicable
            if (returnTrip)
            {
                totalLiftFare = totalLiftFare * 0.8m * 2m;
            }

            //Number of tickets taken into account
            totalLiftFare = liftFare * numTickets;

            MessageBox.Show("Your " + numTickets + " tickets have been booked to " + lstDestination.SelectedItem.ToString() + " is booked\nTotal payable is: " + totalLiftFare.ToString("c"));
        }

        private void cbReturn_CheckedChanged(object sender, EventArgs e)
        {
            returnTrip = cbReturn.Checked;

            if (returnTrip)
            {
                MessageBox.Show("We will book you a return ticket, if this box is checked you will recieve a 20% discount");
            }
        }
    }
}
