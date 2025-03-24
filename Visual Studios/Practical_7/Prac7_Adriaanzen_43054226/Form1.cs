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
 * Practical 7
 */


namespace Prac7_Adriaanzen_43054226
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            //Try die string

            if (!int.TryParse(txtAdditional.Text, out int additional) || additional < 0 || additional > 10)
            {
                MessageBox.Show("Make sure this is a number!");
            }

            int numOption = 0;

            if (rdoBasic.Checked)
            {
                numOption = 1;
            }
            else if (rdoTrend.Checked)
            {
                numOption = 3;
            }
            else if (rdoLuxury.Checked)
            {
                numOption = 5;
            }
            else 
            {
                MessageBox.Show("Please chose a package option");
            }

            //Getting payment option

            if (lstPayment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment option.");
                return;
            }

            string payment = lstPayment.SelectedItem.ToString();

            lstOutput.Items.Clear();
            for (int j = 1; j <= numOption; j++)
            {
                lstOutput.Items.Add($"Menu option "+j+ " will be loaded and paid with "+payment+".");
            }


            //Discount
            int eventNum = 1;
            int discount = 0;
            do
            {
                discount = (eventNum - 1) * 10;
                lstOutput.Items.Add($"Event number {eventNum} will receive {discount}% discount.");
                eventNum++;

                if (discount == 100)
                {
                    lstOutput.Items.Add("Max discount reached.");
                    break;
                }
            }
            while (eventNum <= additional + 1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset everything
            rdoBasic.Checked = false;
            rdoLuxury.Checked = false;
            rdoTrend.Checked = false;

            lstPayment.ClearSelected();

            txtAdditional.Text = string.Empty;

            lstOutput.Items.Clear();
        }
    }
}
