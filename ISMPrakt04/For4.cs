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
    public partial class For4 : Form
    {
        public For4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void For4_Load(object sender, EventArgs e)
        {

        }

        private void solveRes_Click(object sender, EventArgs e)
        {
            double resultVall;
            res.Text = "Результат: ";
            ForConsole4 f = new ForConsole4();
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
            resultVall = f.Solve(a, b);
            res.Text += resultVall;
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            inputA.Text = null;
            inputB.Text = null;
        }

    }
}
