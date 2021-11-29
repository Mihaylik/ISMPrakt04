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
    public partial class While3 : Form
    {
        public While3()
        {
            InitializeComponent();
        }

        private void solveRes_Click(object sender, EventArgs e)
        {
            double resultVallDays, resultVallDistance;
            WholeConsole3 f = new WholeConsole3();
            int p = 0;
            try
            {
                p = int.Parse(inputP.Text);
                if (p <= 0) Clear("Число повинне бути більше 0");
            }
            catch
            {
                Clear("Числа введені не коректно");
            }
            resultVallDays = f.Solve(p)[0];
            resultVallDistance = Math.Round(f.Solve(p)[1], 3);
            result.Text = $"Спортсмен біг {resultVallDays} дн. Всього пробіг {resultVallDistance} км.";
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            inputP.Text = null;
        }
    }
}
