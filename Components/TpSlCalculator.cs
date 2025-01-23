using System;
using System.Windows.Forms;

namespace CryptoCalculator.Components
{
    internal class TpSlCalculator
    {
        private Form1 _form; // Reference to Form1

        public TpSlCalculator(Form1 form)
        {
            _form = form; // Assign Form1 reference
        }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input values
                decimal entryPrice = Convert.ToDecimal(_form.TxtEntryPrice.Text);
                decimal leverage = Convert.ToDecimal(_form.TxtLeverage.Text);
                decimal rrRatio = Convert.ToDecimal(_form.TxtRR.Text);
                decimal amountInvested = Convert.ToDecimal(_form.TxtAmountInvested.Text);

                // Read TP% and SL% (nullable if empty)
                decimal? tpPercentage = string.IsNullOrWhiteSpace(_form.TxtTPPercentage.Text) ? null : Convert.ToDecimal(_form.TxtTPPercentage.Text);
                decimal? slPercentage = string.IsNullOrWhiteSpace(_form.TxtSLPercentage.Text) ? null : Convert.ToDecimal(_form.TxtSLPercentage.Text);

                // Calculate the number of coins bought
                decimal coinQuantity = amountInvested / entryPrice;

                // If TP% is not given, calculate from RR and SL%
                if (!tpPercentage.HasValue && slPercentage.HasValue)
                {
                    tpPercentage = slPercentage.Value * rrRatio;
                    _form.TxtTPPercentage.Text = tpPercentage.ToString(); // Update label with calculated TP%
                }

                // If SL% is not given, calculate from RR and TP%
                if (!slPercentage.HasValue && tpPercentage.HasValue)
                {
                    slPercentage = tpPercentage.Value / rrRatio;
                    _form.TxtSLPercentage.Text = slPercentage.ToString(); // Update label with calculated SL%
                }

                // Stop Loss Calculation
                decimal stopLossPrice = entryPrice - entryPrice * (slPercentage.Value / 100);
                decimal stopLossLoss = (entryPrice - stopLossPrice) * coinQuantity * leverage;

                // Take Profit Calculation (Using TP %)
                decimal takeProfitPrice = entryPrice + entryPrice * (tpPercentage.Value / 100);
                decimal takeProfitGain = (takeProfitPrice - entryPrice) * coinQuantity * leverage;

                // Calculate total position size (effective position size with leverage)
                decimal effectivePositionSize = coinQuantity * entryPrice * leverage;

                // Update UI Labels with results
                _form.LblCoinAmount.Text = $"{coinQuantity:F2}";
                _form.LblPositionSize.Text = $"{effectivePositionSize:F2}";
                _form.LblSLPrice.Text = $"{stopLossPrice:F2}";
                _form.LblTPPrice.Text = $"{takeProfitPrice:F2}";
                _form.LblGain.Text = $"{takeProfitGain:F2}";
                _form.LblLoss.Text = $"{stopLossLoss:F2}";

                MessageBox.Show(
                    $"Stop Loss Loss: {stopLossLoss:F2} USDT\n" +
                    $"Take Profit Gain: {takeProfitGain:F2} USDT",
                    "Risk-Reward Calculation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
