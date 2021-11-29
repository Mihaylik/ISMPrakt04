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
        private void solveRes_Click(object sender, EventArgs e)
        {
            double result;
            res.Text = "Результат: ";
            ForConsole1 f = new ForConsole1();
            int a = 0, b = 0;
            try
            {
                a = int.Parse(inputA.Text);
                b = int.Parse(inputB.Text);
                if (a >= b) Clear("A повинне бути меньше B");
            }
            catch
            {
                Clear("Введене не вірне значення");
            }
            result = f.Solve(a, b);
            res.Text += result;

        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            inputA.Text = null;
            inputB.Text = null;
        }
    }
}
