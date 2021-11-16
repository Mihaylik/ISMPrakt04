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
    public partial class For2 : Form
    {
        public For2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Результат: ";
            ForConsole2 f = new ForConsole2();
            int n=0;
            try
            {
                n = int.Parse(textBox1.Text);
                if (n <= 0) Clear("Число повинне бути більше 0");
            }
            catch
            {
                Clear("Числа введені не коректно");
            }
            result.Text += Math.Round(f.Solve(n), 3);
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            textBox1.Text = null;
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
