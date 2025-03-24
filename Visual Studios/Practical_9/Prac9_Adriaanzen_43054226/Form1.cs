using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Mariska Adriaanzen
 * 43054226
 * Practical 9
 */

namespace Prac9_Adriaanzen_43054226
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBookFac_Click(object sender, EventArgs e)
        {
            //Making the groupbox visible
            groupBox2.Visible = true;
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            //Clearing the form
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;

            rdoAll.Checked = false;
            rdoIndoor.Checked = false;
            rdoOutdoor.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exiting the form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Hiding the groupbox
            groupBox2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hiding the groupbox again
            groupBox2.Visible=false;
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            //Sports.txt
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        lstOutput.Items.Add("We offer the following facilities:");
                        //Reads INTO file
                        while(!reader.EndOfStream)
                        {
                            lstOutput.Items.Add(reader.ReadLine());
                        }
                        
                    }

                    MessageBox.Show("File read successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //Creating a new text file
            string name = txtName.Text;
            string email = txtEmail.Text;
            string facility = "";
            string outputMessage = "";

            if (rdoAll.Checked)
            {
                facility = rdoAll.Text;
                outputMessage = "Out-door and In-door";
            }
            else if (rdoIndoor.Checked)
            {
                facility = rdoIndoor.Text;
                outputMessage = "In-door";
            }
            else if (rdoOutdoor.Checked)
            {
                facility = rdoOutdoor.Text;
                outputMessage = "Out-door";
            }
            else 
            {
                MessageBox.Show("Please choose a facility you would like to book.");
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Checks if the user clicked OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Can use a if instead of using
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        //Writes INTO file
                        writer.Write(name + "_" + email + "_" + "_" + facility);
                    }

                    MessageBox.Show("Hi "+ name + "! You have successfully booked " + outputMessage + " facility.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }
    }
}
