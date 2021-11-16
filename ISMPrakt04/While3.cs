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

        private void button1_Click(object sender, EventArgs e)
        {
            WholeConsole3 f = new WholeConsole3();
            int p = 0;
            try
            {
                p = int.Parse(textBox1.Text);
                if (p <= 0) Clear("Число повинне бути більше 0");
            }
            catch
            {
                Clear("Числа введені не коректно");
            }
            result.Text = $"Спортсмен біг {f.Solve(p)[0]} дн. Всього пробіг {Math.Round(f.Solve(p)[1], 3)} км.";
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            textBox1.Text = null;
        }
    }
}
