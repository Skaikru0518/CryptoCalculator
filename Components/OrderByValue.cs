using System;
using System.Windows.Forms;

namespace CryptoCalculator.Components
{
    internal class OrderByValue
    {
        private Form1 _form; // Reference to Form1

        public OrderByValue(Form1 form)
        {
            _form = form; // Assign Form1 reference
        }

        public void calculateBtnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user inputs
                decimal entryPrice = Convert.ToDecimal(_form.LblOrderEntry.Text);
                decimal maxLoss = Convert.ToDecimal(_form.LblOrderMaxLoss.Text);
                decimal orderLeverage = Convert.ToDecimal(_form.LblOrderLeverage.Text);
                decimal stopLossPrice = Convert.ToDecimal(_form.LblOrderSLPrice.Text);

                // Calculate per unit loss
                decimal perUnitLoss = entryPrice - stopLossPrice;

                // Ensure no division by zero
                if (perUnitLoss == 0)
                {
                    MessageBox.Show("Invalid input: Stop-loss price cannot be equal to the entry price.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate position size
                decimal positionSize = maxLoss / perUnitLoss; // position size in units (coins)

                // Calculate order by value
                decimal orderValue = Math.Round(positionSize * entryPrice, 2); // order value in USDT

                // Calculate margin required
                decimal marginRequired = Math.Round(orderValue / orderLeverage, 2); // margin required in USDT

                // Update UI labels with results
                _form.TxtOrderByValue.Text = orderValue.ToString();
                _form.TxtOrderMargin.Text = marginRequired.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
