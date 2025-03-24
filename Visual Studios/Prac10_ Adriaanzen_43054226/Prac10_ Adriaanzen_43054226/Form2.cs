using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

/**
 * Mariska Adriaanzen
 * Practical 10
 * 43054226
 */

namespace Prac10__Adriaanzen_43054226
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Going backl to the first form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
        }
    }
}
