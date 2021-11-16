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
    public partial class Pi2 : Form
    {
        public Pi2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pi2_Load(object sender, EventArgs e)
        {
            constPi.Text += Math.PI;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "Результат (pi): ";
            Pi2Console pi = new Pi2Console();
            int k = 0;
            try
            {
                k = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Некоректне значення");
                textBox3.Text = null;
            }
            result.Text += pi.Solve(k);
        }
    }
}
