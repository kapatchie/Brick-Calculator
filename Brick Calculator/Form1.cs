using System;
using System.Windows.Forms;

namespace Brick_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultLabel.Text = "0 Bricks";
        }
        
        private void HeightTxtBox_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void LenghtTxtBox_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void WidthTxtBox_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            float fHeight = CheckConversion(HeightTxtBox.Text);
            float fWitdh = CheckConversion(WidthTxtBox.Text);
            float fLenght = CheckConversion(LenghtTxtBox.Text);

            float bricksPerMeter = radHallow.Checked ? 20 : 40;

            float result = ((fLenght * fWitdh) * fHeight) * bricksPerMeter;

            resultLabel.Text = result + "  Bricks";
        }
        private float CheckConversion(string value)
        {
            float fValue = float.TryParse(value, out fValue) ? fValue : 1f;
            if (fValue <= 0) { fValue = 1; }
            return fValue;
        }

        private void radMaxi_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void radHallow_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
