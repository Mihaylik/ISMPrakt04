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

        private void solveRes_Click(object sender, EventArgs e)
        {
            double resultVall;
            result.Text = "Результат: ";
            ForConsole3 f = new ForConsole3();
            double a = 0;
            int n = 0;
            try
            {
                a = double.Parse(inputA.Text);
                n = int.Parse(inputB.Text);
                if (n <= 0) Clear("Число N повинне бути більше 0");
            }
            catch
            {
                Clear("Введене не вірне значення");
            }
            resultVall = Math.Round(f.Solve(n, a), 3);
            result.Text += resultVall;
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            inputA.Text = null;
            inputB.Text = null;
        }
    }
}
