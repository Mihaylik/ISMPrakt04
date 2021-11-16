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
    public partial class Pi1 : Form
    {
        public Pi1()
        {
            InitializeComponent();
        }

        private void Pi1_Load(object sender, EventArgs e)
        {
            constPi.Text += Math.PI;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Результат (pi): ";
            Pi1Console pi = new Pi1Console();
            int k=0;
            try
            {
                k = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Некоректне значення");
                textBox1.Text = null;
            }
            result.Text += pi.Solve(k);
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
