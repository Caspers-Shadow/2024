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
 * Practical 10
 * 43054226
 */
namespace Prac10__Adriaanzen_43054226
{
    public partial class Form1 : Form
    {
        //Constant pricees

        const decimal dayHike = 100m;
        const decimal campHike = 300m;
        public Form1()
        {
            InitializeComponent();
        }

        //Booking ifo method
        public void BookingInfo(string name, string surname, string type, int days)
        {
            lstOutput.Items.Add("Hello " + name + " " + surname + ", You are booking a " + type + " for " + days + " days");
            
        }

        //Total cost calculator
        public decimal TotalCost(int days)
        {
            decimal total = 0m;

            if (rdoCamp.Checked)
            {
                for (int i = 1; i <= days; i++)
                {
                    if (i == 1)
                    {
                        total += campHike;  
                    }
                    else
                    {
                        total += campHike * 0.95m;  
                    }
                }
            }
            else if (rdoHike.Checked)
            {
                total = dayHike * days;  
            }

            return total;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //variables 
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string type = "";
            int days = int.Parse(txtDays.Text);

            //Getting the type
            if (rdoCamp.Checked)
            {
                type = rdoCamp.Text;

            }
            else if (rdoHike.Checked)
            {
                type = rdoHike.Text;                
            }
            else 
            {
                MessageBox.Show("Please choose a time period.");
            }


            //Calling booking info
            BookingInfo(name, surname, type, days);


            //determining the daily cost
            if (rdoCamp.Checked)
            {
                for (int i = 1; i <= days; i++)
                {
                    decimal dailyCost = (i == 1) ? campHike : campHike * 0.95m;
                    lstOutput.Items.Add("Day " + i + " : " + dailyCost.ToString("c"));
                }
            }
            else if (rdoHike.Checked)
            {
                lstOutput.Items.Add("Day hike price: " + (dayHike*days).ToString("c"));
            }



        }

        private void rdoCamp_CheckedChanged(object sender, EventArgs e)
        {

        }


        //Proceeding to form 2

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 proceedPay = new Form2();

           
            proceedPay.lblOut.Text = "Hi " + txtName.Text + ", Yours total Cost for this activity is: " 
                + TotalCost(int.Parse(txtDays.Text)).ToString("c") + " call the lodge for payment";
            proceedPay.ShowDialog();
            this.Hide();
        }

        //Clearing for a new entry
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDays.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;

            rdoCamp.Checked = false;
            rdoHike.Checked = false;

            lstOutput.Items.Clear();    
        }

        //Exiting
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
