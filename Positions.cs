using System;
using System.Windows.Forms;

namespace CryptoCalculator
{
    internal class Positions
    {
        private Form1 _form;

        public Positions(Form1 form)
        {
            _form = form;
        }

        public void calculateBtn_Click_1(object sender, EventArgs e)
        {
            if (float.TryParse(_form.FirstPosition.Text, out float myFirstPosition) &&
                float.TryParse(_form.SecondPosition.Text, out float mySecondPosition) &&
                float.TryParse(_form.FirstEntry.Text, out float myFirstEntry) &&
                float.TryParse(_form.SecondEntry.Text, out float mySecondEntry))
            {
                float a = myFirstEntry * myFirstPosition;
                float b = mySecondEntry * mySecondPosition;
                float c = myFirstPosition + mySecondPosition;

                if (c == 0)
                {
                    MessageBox.Show("Invalid input: Total position size cannot be zero.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float newAveragePrice = (a + b) / c;

                _form.NewAverage.Text = newAveragePrice.ToString(); // Update label in Form1
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
