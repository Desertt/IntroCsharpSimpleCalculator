using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroCsharpSimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int x, y, resultCalc;

        private void buttonAdding_Click(object sender, EventArgs e)
        {
            Calculate sq = new Calculate();
            //x = Convert.ToInt32(textBoxNumberFirst.Text);
            //y = Convert.ToInt32(textBoxNumberSecond.Text);
            //labelResultCalc.Text = sq.AddingNumbers(x, y).ToString();

            labelResultCalc.Text = sq.AddingNumbersS(textBoxNumberFirst.Text, textBoxNumberSecond.Text);

        }

        private void buttonSubtracting_Click(object sender, EventArgs e)
        {
            Calculate sq = new Calculate();
            x = Convert.ToInt32(textBoxNumberFirst.Text);
            y = Convert.ToInt32(textBoxNumberSecond.Text);
            labelResultCalc.Text = sq.SubtractingNumbers(x, y).ToString();
        }


        private void buttonmultiplying_Click(object sender, EventArgs e)
        {
            Calculate sq = new Calculate();
            x = Convert.ToInt32(textBoxNumberFirst.Text);
            y = Convert.ToInt32(textBoxNumberSecond.Text);
            labelResultCalc.Text = sq.Multiplying(x, y).ToString();
        }

        private void textBoxNumberFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelShowPanel.Text = textBoxNumberFirst.Text;
        }

        private void textBoxNumberSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelShowPanel.Text = textBoxNumberSecond.Text;
        }

        private void buttonDividing_Click(object sender, EventArgs e)
        {
            Calculate sq = new Calculate();
            x = Convert.ToInt32(textBoxNumberFirst.Text);
            y = Convert.ToInt32(textBoxNumberSecond.Text);
            labelResultCalc.Text = sq.Dividing(x, y).ToString();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            Calculate sq = new Calculate();
            x = Convert.ToInt32(textBoxNumberFirst.Text);
            y = Convert.ToInt32(textBoxNumberSecond.Text);
            labelResultCalc.Text = sq.Mod(x, y).ToString();
        }
    }
}
