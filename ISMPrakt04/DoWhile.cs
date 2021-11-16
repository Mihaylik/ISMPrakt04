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
    public partial class DoWhile : Form
    {
        public DoWhile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        int i = 0;
        int[] values = new int[2483647];
        DoWhileConsole dw = new DoWhileConsole();

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    values[i] = int.Parse(textBox1.Lines[i]);
                    i++;
                }
                catch
                {
                    Clear("Числа введені не коректно");
                    for (int k = 0; k < i + 1; k++) values[k] = 0;
                    i = 0;
                }
            }
            else if (e.KeyCode == Keys.D0)
            {
                values[i] = 0;
                result.Text = "Результат: ";
                int[] tmp = new int[i+2];
                i = 0;
                while (values[i] >0)
                {
                    tmp[i] = values[i];
                    i++;
                }
                result.Text += dw.Solve(tmp);
            }
        }
        void Clear(string m)
        {
            MessageBox.Show(m);
            textBox1.Text = null;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = null;
            for (int k = 0; k < i + 1; k++) values[k] = 0;
            i = 0;
        }
    }
}
