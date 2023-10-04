using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            string tekst;

            tekst = "Odabrali ste: ";

            if (radioButtonAvion.Checked)
            {
                textBox1.Text = tekst + radioButtonAvion.Text;
            }

            if (radioButtonAutobus.Checked)
            {
                textBox1.Text = tekst + radioButtonAutobus.Text;
            }

            if (radioButtonVlastiti.Checked)
            {
                textBox1.Text = tekst + radioButtonVlastiti.Text;
            }
        }
    }
}
