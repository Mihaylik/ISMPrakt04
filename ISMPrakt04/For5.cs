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
    public partial class For5 : Form
    {
        public For5()
        {
            InitializeComponent();
        }

        private void solveRes_Click(object sender, EventArgs e)
        {
            double resultVall;
            result.Text = "Результат: ";
            ForConsole5 f = new ForConsole5();
            int n = 0;
            try
            {
                n = int.Parse(inputN.Text);
                if (n <= 0) Clear("Число повинне бути більше 0");
            }
            catch
            {
                Clear("Числа введені не коректно");
            }
            resultVall = f.Solve(n);
            result.Text += resultVall;
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            inputN.Text = null;
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
