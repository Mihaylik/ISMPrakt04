using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISMPrakt04ClassLib;

namespace ISMPrakt04
{
    public partial class Pi3 : Form
    {
        public Pi3()
        {
            InitializeComponent();
        }

        private void Pi3_Load(object sender, EventArgs e)
        {

            constPi.Text += Math.PI;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Результат (pi): ";
            Pi3Console pi = new Pi3Console();
            int k = 0;
            try
            {
                k = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Некоректне значення");
                textBox3.Text = null;
            }
            result.Text += pi.Solve(k);
        }

        private void constPi_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
