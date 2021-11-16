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
    public partial class For3 : Form
    {
        public For3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Результат: ";
            ForConsole3 f = new ForConsole3();
            double a = 0;
            int n = 0;
            try
            {
                a = double.Parse(textBox1.Text);
                n = int.Parse(textBox2.Text);
                if (n <= 0) Clear("Число N повинне бути більше 0");
            }
            catch
            {
                Clear("Введене не вірне значення");
            }
            result.Text += Math.Round(f.Solve(n, a), 3);
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            textBox1.Text = null;
            textBox2.Text = null;
        }
    }
}
