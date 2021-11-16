using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMPrakt04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void for1Buttton_Click(object sender, EventArgs e)
        {
            For1 for1Form = new For1();
            for1Form.Show();
        }

        private void for2Buttton_Click(object sender, EventArgs e)
        {
            For2 for2Form = new For2();
            for2Form.Show();
        }

        private void for3Buttton_Click(object sender, EventArgs e)
        {
            For3 for3Form = new For3();
            for3Form.Show();
        }

        private void for4Buttton_Click(object sender, EventArgs e)
        {
            For4 for4Form = new For4();
            for4Form.Show();
        }

        private void for5Buttton_Click(object sender, EventArgs e)
        {
            For5 for5Form = new For5();
            for5Form.Show();
        }

        private void while3Button_Click(object sender, EventArgs e)
        {
            While3 while3Form = new While3();
            while3Form.Show();
        }

        private void doWhile1Button_Click(object sender, EventArgs e)
        {
            DoWhile doWhileForm = new DoWhile();
            doWhileForm.Show();
        }

        private void while1Button_Click(object sender, EventArgs e)
        {
            While1 while1Form = new While1();
            while1Form.Show();
        }

        private void while2Button_Click(object sender, EventArgs e)
        {
            While2 while2Form = new While2();
            while2Form.Show();
        }

        private void pi1Button_Click(object sender, EventArgs e)
        {
            Pi1 pi1Form = new Pi1();
            pi1Form.Show();
        }

        private void pi2Button_Click(object sender, EventArgs e)
        {
            Pi2 pi2Form = new Pi2();
            pi2Form.Show();
        }

        private void pi3Button_Click(object sender, EventArgs e)
        {
            Pi3 pi3Form = new Pi3();
            pi3Form.Show();
        }

        private void pi4Button_Click(object sender, EventArgs e)
        {
            Pi4 pi4Form = new Pi4();
            pi4Form.Show();
        }
    }
}
