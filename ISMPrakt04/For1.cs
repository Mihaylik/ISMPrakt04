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
    public partial class For1 : Form
    {
        public For1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            res.Text = "Результат: ";
            ForConsole1 f = new ForConsole1();
            int a = 0, b = 0;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                if (a >= b) Clear("A повинне бути меньше B");
            }
            catch
            {
                Clear("Введене не вірне значення");
            }
            res.Text += f.Solve(a, b);

        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void res_Click(object sender, EventArgs e)
        {

        }
    }
}
