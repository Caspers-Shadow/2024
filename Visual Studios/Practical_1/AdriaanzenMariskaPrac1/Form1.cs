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
 Practical 1
 17/7/2024
 */

namespace AdriaanzenMariskaPrac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetswana_Click(object sender, EventArgs e)
        {
            //Message for Setswana
            MessageBox.Show("Dumelang Lefatshe");
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            //Message for English
            MessageBox.Show("Hello World");
        }

        private void btnAfrikaans_Click(object sender, EventArgs e)
        {
            //Message for Afrikaans
            MessageBox.Show("Hallo Wereld");
        }
    }
}
