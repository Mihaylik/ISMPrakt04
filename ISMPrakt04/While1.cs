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
    public partial class While1 : Form
    {
        public While1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Результат: ";
            WhileConsole1 f = new WhileConsole1();
            double n = 0;
            try
            {
                n = int.Parse(textBox1.Text);
                if (n <= 0) Clear("Число повинне бути більше 0");
            }
            catch
            {
                Clear("Числа введені не коректно");
            }
            result.Text += f.Solve(n);
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            textBox1.Text = null;
        }
    }
}
