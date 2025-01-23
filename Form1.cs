using System.Diagnostics;
using System.Reflection;
using CryptoCalculator.Components;
using Newtonsoft.Json.Linq;

namespace CryptoCalculator
{
    public partial class Form1 : Form
    {
        // adding a timer and boolean to pulse the update button
        private System.Windows.Forms.Timer pulseTimer;
        private bool isButtonBright = true;

        // adding getters and setters for the textboxes in Average Calculator
        public TextBox FirstPosition => firstPosition;
        public TextBox SecondPosition => secondPosition;
        public TextBox FirstEntry => firstEntry;
        public TextBox SecondEntry => secondEntry;
        public TextBox NewAverage => newAverage;

        // adding an instance of positions class
        private Positions positions;


        // adding getters and setters for the textboxes in Order Calculator
        public TextBox TxtEntryPrice => txtEntryPrice;
        public TextBox TxtLeverage => txtLeverage;
        public TextBox TxtRR => txtRR;
        public TextBox TxtAmountInvested => txtAmountInvested;
        public TextBox TxtTPPercentage => txtTPPercentage;
        public TextBox TxtSLPercentage => txtSLPercentage;

        public TextBox LblCoinAmount => lblCoinAmount;
        public TextBox LblPositionSize => lblPositionSize;
        public TextBox LblSLPrice => lblSLPrice;
        public TextBox LblTPPrice => lblTPPrice;
        public TextBox LblGain => lblGain;
        public TextBox LblLoss => lblLoss;


        // adding an instance of TpSlCalculator class
        private TpSlCalculator tpSlCalculator;


        public TextBox LblOrderEntry => lblOrderEntry;
        public TextBox LblOrderMaxLoss => lblOrderMaxLoss;
        public TextBox LblOrderLeverage => lblOrderLeverage;
        public TextBox LblOrderSLPrice => lblOrderSLPrice;

        public TextBox TxtOrderByValue => txtOrderByValue;
        public TextBox TxtOrderMargin => txtOrderMargin;

        // Declare instance of OrderByValue
        private OrderByValue orderByValue; 

        public Form1()
        {
            InitializeComponent();
            firstPosition.Text = String.Empty;
            secondPosition.Text = String.Empty;
            firstEntry.Text = String.Empty;
            secondEntry.Text = String.Empty;

            // check for updates
            CheckForUpdates();

            // get version number
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            // display version number
            lblVersion.Text = "v" + version.Major.ToString() + "." + version.Minor.ToString() + "." + version.Build.ToString();


            // initialize component classes
            positions = new Positions(this);
            tpSlCalculator = new TpSlCalculator(this);
            orderByValue = new OrderByValue(this);

        }

        private void calculateBtn_Click_1(object sender, EventArgs e)
        {
            positions.calculateBtn_Click_1(sender, e);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tpSlCalculator.btnCalculate_Click(sender, e);
        }

        private void calculateBtnOrder_Click(object sender, EventArgs e)
        {
            orderByValue.calculateBtnOrder_Click(sender, e);
        }

        // check for updates
        public async void CheckForUpdates()
        {
            string versionCheckUrl = "https://api.github.com/repos/Skaikru0518/CryptoCalculator/releases/latest";
            string currentVersionString = GetCurrentVersion(); // Get current version from Assembly

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "CryptoCalculator-Updater");

                    // Step 1: Get latest version from GitHub API
                    HttpResponseMessage response = await client.GetAsync(versionCheckUrl);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Failed to check for updates. HTTP Status: {response.StatusCode}");
                        return;
                    }

                    string json = await response.Content.ReadAsStringAsync();
                    string latestVersion = ExtractVersionFromJson(json);

                    // Step 2: Compare current version with latest release
                    if (latestVersion == currentVersionString)
                    {
                        btnUpdate.Text = "No Updates";
                        btnUpdate.Enabled = false; // Disable button
                        btnUpdate.BackColor = Color.Gray;
                        pulseTimer?.Stop(); // Stop pulsing effect
                        return;
                    }

                    // Step 3: If new update is available, enable the button
                    btnUpdate.Text = "Update Available";
                    btnUpdate.Enabled = true;
                    btnUpdate.ForeColor = Color.White;
                    btnUpdate.FlatStyle = FlatStyle.Flat;
                    btnUpdate.BackColor = Color.Red;

                    pulseTimer?.Start(); // Start pulsing effect
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update check failed: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Extracts version number from GitHub API JSON response
        private string ExtractVersionFromJson(string json)
        {
            try
            {
                var parsedJson = JObject.Parse(json);
                return parsedJson["tag_name"]?.ToString() ?? "v1.0.0";
            }
            catch
            {
                return "v1.0.0"; // Default if parsing fails
            }
        }

        // Get the current version of the application
        private string GetCurrentVersion()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version ?? new Version(1, 0, 0);
            return $"v{version.Major}.{version.Minor}.{version.Build}";
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string updaterPath = Path.Combine(Application.StartupPath, "Updater.exe");

            if (File.Exists(updaterPath))
            {
                Console.WriteLine("Updater already exists. Running it now...");
                Process.Start(updaterPath);
                Application.Exit();
                return;
            }

            string updateUrl = "https://github.com/Skaikru0518/Updater/releases/latest/download/Updater.exe";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "CryptoCalculator-Updater");

                    HttpResponseMessage response = await client.GetAsync(updateUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Downloading Updater...");
                        byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                        await File.WriteAllBytesAsync(updaterPath, fileBytes);

                        Process.Start(updaterPath);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show($"Download failed. HTTP Status: {response.StatusCode}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
