﻿using System;
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
    public partial class Pi4 : Form
    {
        public Pi4()
        {
            InitializeComponent();
        }

        private void Pi4_Load(object sender, EventArgs e)
        {

            constPi.Text += Math.PI;
        }

        private void solveRes_Click(object sender, EventArgs e)
        {
            double resultVall;
            result.Text = "Результат (pi): ";
            Pi4Console pi = new Pi4Console();
            int k = 0;
            try
            {
                k = int.Parse(inputIter.Text);
            }
            catch { MessageBox.Show("Некоректне значення"); inputIter.Text = null; }
            resultVall = pi.Solve(k);
            result.Text += resultVall;        }
    }
}
