using System.Reflection;

namespace CryptoCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstPosition.Text = String.Empty;
            secondPosition.Text = String.Empty;
            firstEntry.Text = String.Empty;
            secondEntry.Text = String.Empty;

            // get version number
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            // display version number
            lblVersion.Text = "v" + version.Major.ToString() + "." + version.Minor.ToString() + "." + version.Build.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click_1(object sender, EventArgs e)
        {
            if (float.TryParse(firstPosition.Text, out float myFirstPosition) &&
                float.TryParse(secondPosition.Text, out float mySecondPosition) &&
                float.TryParse(firstEntry.Text, out float myFirstEntry) &&
                float.TryParse(secondEntry.Text, out float mySecondEntry))
            {
                float a = myFirstEntry * myFirstPosition;
                float b = mySecondEntry * mySecondPosition;
                float c = myFirstPosition + mySecondPosition;

                float newAveragePrice = (a + b) / c;

                newAverage.Text = newAveragePrice.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input values
                decimal entryPrice = Convert.ToDecimal(txtEntryPrice.Text);
                decimal leverage = Convert.ToDecimal(txtLeverage.Text);
                decimal rrRatio = Convert.ToDecimal(txtRR.Text);
                decimal amountInvested = Convert.ToDecimal(txtAmountInvested.Text);

                // Read TP% and SL% (nullable if empty)
                decimal? tpPercentage = string.IsNullOrWhiteSpace(txtTPPercentage.Text) ? (decimal?)null : Convert.ToDecimal(txtTPPercentage.Text);
                decimal? slPercentage = string.IsNullOrWhiteSpace(txtSLPercentage.Text) ? (decimal?)null : Convert.ToDecimal(txtSLPercentage.Text);

                // Calculate the number of coins bought
                decimal coinQuantity = amountInvested / entryPrice;

                // If TP% is not given, calculate from RR and SL%
                if (!tpPercentage.HasValue && slPercentage.HasValue)
                {
                    tpPercentage = slPercentage.Value * rrRatio;
                    txtTPPercentage.Text = tpPercentage.ToString(); // Update label with calculated TP%
                }

                // If SL% is not given, calculate from RR and TP%
                if (!slPercentage.HasValue && tpPercentage.HasValue)
                {
                    slPercentage = tpPercentage.Value / rrRatio;
                    txtSLPercentage.Text = slPercentage.ToString(); // Update label with calculated SL%
                }

                // Stop Loss Calculation
                decimal stopLossPrice = entryPrice - (entryPrice * (slPercentage.Value / 100));
                decimal stopLossLoss = (entryPrice - stopLossPrice) * coinQuantity * leverage;

                // Take Profit Calculation (Using TP %)
                decimal takeProfitPrice = entryPrice + (entryPrice * (tpPercentage.Value / 100));
                decimal takeProfitGain = (takeProfitPrice - entryPrice) * coinQuantity * leverage;

                // Calculate total position size (effective position size with leverage)
                decimal effectivePositionSize = coinQuantity * entryPrice * leverage;

                // Update UI Labels with results
                lblCoinAmount.Text = coinQuantity.ToString();
                lblPositionSize.Text = effectivePositionSize.ToString();
                lblSLPrice.Text = stopLossPrice.ToString();
                lblTPPrice.Text = takeProfitPrice.ToString();
                lblGain.Text = takeProfitGain.ToString() + " USDT";
                lblLoss.Text = stopLossLoss.ToString() + " USDT";

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

        private void calculateBtnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // get user inputs
                decimal entryPrice = Convert.ToDecimal(lblOrderEntry.Text);
                decimal maxLoss = Convert.ToDecimal(lblOrderMaxLoss.Text);
                decimal orderLeverage = Convert.ToDecimal(lblOrderLeverage.Text);
                decimal stopLossPrice = Convert.ToDecimal(lblOrderSLPrice.Text);


                // calculate per unit loss
                decimal perUnitLoss = entryPrice - stopLossPrice;

                // calculate position size
                decimal positionSize = maxLoss / perUnitLoss; // position size in units (coins)

                // calculate order by value
                decimal orderValue = Math.Round(positionSize * entryPrice, 2); // order value in USDT

                // calculate margin erquired
                decimal marginRequired = Math.Round(orderValue / orderLeverage, 2); // margin required in USDT


                //update UI labels with results
                txtOrderByValue.Text = orderValue.ToString();
                txtOrderMargin.Text = marginRequired.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
