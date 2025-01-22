namespace CryptoCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            calculateBtn = new Button();
            newAverage = new TextBox();
            groupBox1 = new GroupBox();
            secondEntry = new TextBox();
            secondPosition = new TextBox();
            firstEntry = new TextBox();
            firstPosition = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            lblLoss = new TextBox();
            lblGain = new TextBox();
            label17 = new Label();
            label16 = new Label();
            lblPositionSize = new TextBox();
            lblCoinAmount = new TextBox();
            lblTPPrice = new TextBox();
            lblSLPrice = new TextBox();
            label15 = new Label();
            label13 = new Label();
            label14 = new Label();
            label8 = new Label();
            btnCalculate = new Button();
            txtTPPercentage = new TextBox();
            label12 = new Label();
            txtSLPercentage = new TextBox();
            label11 = new Label();
            txtLeverage = new TextBox();
            label10 = new Label();
            txtAmountInvested = new TextBox();
            label9 = new Label();
            txtRR = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtEntryPrice = new TextBox();
            tabPage3 = new TabPage();
            groupBox4 = new GroupBox();
            label24 = new Label();
            lblOrderMaxLoss = new TextBox();
            groupBox5 = new GroupBox();
            txtOrderByValue = new TextBox();
            label18 = new Label();
            txtOrderMargin = new TextBox();
            label20 = new Label();
            lblOrderSLPrice = new TextBox();
            label23 = new Label();
            calculateBtnOrder = new Button();
            lblOrderLeverage = new TextBox();
            label26 = new Label();
            label29 = new Label();
            lblOrderEntry = new TextBox();
            lblVersion = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(709, 440);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(45, 45, 48);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(calculateBtn);
            tabPage1.Controls.Add(newAverage);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(701, 414);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Positions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Fira Code", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(268, 318);
            label3.Name = "label3";
            label3.Size = new Size(225, 19);
            label3.TabIndex = 15;
            label3.Text = "New Average Entry Price:";
            // 
            // calculateBtn
            // 
            calculateBtn.FlatAppearance.BorderColor = Color.White;
            calculateBtn.FlatAppearance.BorderSize = 2;
            calculateBtn.FlatStyle = FlatStyle.Flat;
            calculateBtn.Font = new Font("Fira Code", 9F, FontStyle.Bold);
            calculateBtn.ForeColor = Color.White;
            calculateBtn.Location = new Point(73, 307);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(103, 43);
            calculateBtn.TabIndex = 16;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click_1;
            // 
            // newAverage
            // 
            newAverage.BackColor = Color.FromArgb(30, 30, 30);
            newAverage.ForeColor = Color.White;
            newAverage.Location = new Point(499, 318);
            newAverage.Name = "newAverage";
            newAverage.ReadOnly = true;
            newAverage.Size = new Size(100, 21);
            newAverage.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(45, 45, 48);
            groupBox1.Controls.Add(secondEntry);
            groupBox1.Controls.Add(secondPosition);
            groupBox1.Controls.Add(firstEntry);
            groupBox1.Controls.Add(firstPosition);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Fira Code", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(26, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 229);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // secondEntry
            // 
            secondEntry.BackColor = Color.FromArgb(30, 30, 30);
            secondEntry.ForeColor = Color.White;
            secondEntry.Location = new Point(393, 152);
            secondEntry.Name = "secondEntry";
            secondEntry.Size = new Size(100, 27);
            secondEntry.TabIndex = 9;
            secondEntry.TextAlign = HorizontalAlignment.Center;
            // 
            // secondPosition
            // 
            secondPosition.BackColor = Color.FromArgb(30, 30, 30);
            secondPosition.ForeColor = Color.White;
            secondPosition.Location = new Point(393, 79);
            secondPosition.Name = "secondPosition";
            secondPosition.Size = new Size(100, 27);
            secondPosition.TabIndex = 8;
            secondPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // firstEntry
            // 
            firstEntry.BackColor = Color.FromArgb(30, 30, 30);
            firstEntry.ForeColor = Color.White;
            firstEntry.Location = new Point(50, 152);
            firstEntry.Name = "firstEntry";
            firstEntry.Size = new Size(100, 27);
            firstEntry.TabIndex = 7;
            firstEntry.TextAlign = HorizontalAlignment.Center;
            // 
            // firstPosition
            // 
            firstPosition.BackColor = Color.FromArgb(30, 30, 30);
            firstPosition.ForeColor = Color.White;
            firstPosition.Location = new Point(50, 79);
            firstPosition.Name = "firstPosition";
            firstPosition.Size = new Size(100, 27);
            firstPosition.TabIndex = 6;
            firstPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Fira Code", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(390, 121);
            label5.Name = "label5";
            label5.Size = new Size(143, 17);
            label5.TabIndex = 5;
            label5.Text = "New Entry Price";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Fira Code", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 121);
            label4.Name = "label4";
            label4.Size = new Size(161, 17);
            label4.TabIndex = 4;
            label4.Text = "First Entry Price";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fira Code", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(390, 48);
            label2.Name = "label2";
            label2.Size = new Size(161, 17);
            label2.TabIndex = 1;
            label2.Text = "New Position Size";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fira Code", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(206, 17);
            label1.TabIndex = 0;
            label1.Text = "Current Positions Size";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(45, 45, 48);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(701, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "TP/SL Calculator";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(45, 45, 48);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btnCalculate);
            groupBox2.Controls.Add(txtTPPercentage);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSLPercentage);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtLeverage);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtAmountInvested);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtRR);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtEntryPrice);
            groupBox2.Font = new Font("Fira Code", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(6, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(689, 392);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.Font = new Font("Fira Code", 8F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(25, 266);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(119, 89);
            textBox1.TabIndex = 36;
            textBox1.Text = "If TP% or SL% is not given, it will be calculated based on the given RR ratio";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(45, 45, 48);
            groupBox3.Controls.Add(lblLoss);
            groupBox3.Controls.Add(lblGain);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(lblPositionSize);
            groupBox3.Controls.Add(lblCoinAmount);
            groupBox3.Controls.Add(lblTPPrice);
            groupBox3.Controls.Add(lblSLPrice);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label8);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(168, 178);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(515, 208);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Results";
            // 
            // lblLoss
            // 
            lblLoss.BackColor = Color.FromArgb(30, 30, 30);
            lblLoss.ForeColor = Color.White;
            lblLoss.Location = new Point(381, 150);
            lblLoss.Name = "lblLoss";
            lblLoss.ReadOnly = true;
            lblLoss.Size = new Size(128, 27);
            lblLoss.TabIndex = 35;
            // 
            // lblGain
            // 
            lblGain.BackColor = Color.FromArgb(30, 30, 30);
            lblGain.ForeColor = Color.White;
            lblGain.Location = new Point(246, 150);
            lblGain.Name = "lblGain";
            lblGain.ReadOnly = true;
            lblGain.Size = new Size(129, 27);
            lblGain.TabIndex = 34;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(381, 127);
            label17.Name = "label17";
            label17.Size = new Size(39, 20);
            label17.TabIndex = 33;
            label17.Text = "SL-";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(246, 127);
            label16.Name = "label16";
            label16.Size = new Size(49, 20);
            label16.TabIndex = 32;
            label16.Text = "TP +";
            // 
            // lblPositionSize
            // 
            lblPositionSize.BackColor = Color.FromArgb(30, 30, 30);
            lblPositionSize.ForeColor = Color.White;
            lblPositionSize.Location = new Point(66, 150);
            lblPositionSize.Name = "lblPositionSize";
            lblPositionSize.ReadOnly = true;
            lblPositionSize.Size = new Size(106, 27);
            lblPositionSize.TabIndex = 31;
            // 
            // lblCoinAmount
            // 
            lblCoinAmount.BackColor = Color.FromArgb(30, 30, 30);
            lblCoinAmount.ForeColor = Color.White;
            lblCoinAmount.Location = new Point(310, 64);
            lblCoinAmount.Name = "lblCoinAmount";
            lblCoinAmount.ReadOnly = true;
            lblCoinAmount.Size = new Size(119, 27);
            lblCoinAmount.TabIndex = 30;
            // 
            // lblTPPrice
            // 
            lblTPPrice.BackColor = Color.FromArgb(30, 30, 30);
            lblTPPrice.ForeColor = Color.White;
            lblTPPrice.Location = new Point(193, 64);
            lblTPPrice.Name = "lblTPPrice";
            lblTPPrice.ReadOnly = true;
            lblTPPrice.Size = new Size(102, 27);
            lblTPPrice.TabIndex = 29;
            // 
            // lblSLPrice
            // 
            lblSLPrice.BackColor = Color.FromArgb(30, 30, 30);
            lblSLPrice.ForeColor = Color.White;
            lblSLPrice.Location = new Point(66, 64);
            lblSLPrice.Name = "lblSLPrice";
            lblSLPrice.ReadOnly = true;
            lblSLPrice.Size = new Size(106, 27);
            lblSLPrice.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(66, 127);
            label15.Name = "label15";
            label15.Size = new Size(139, 20);
            label15.TabIndex = 27;
            label15.Text = "Position Size";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(310, 32);
            label13.Name = "label13";
            label13.Size = new Size(149, 20);
            label13.TabIndex = 26;
            label13.Text = "Coin Purchased";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(193, 32);
            label14.Name = "label14";
            label14.Size = new Size(89, 20);
            label14.TabIndex = 25;
            label14.Text = "TP Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 32);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 24;
            label8.Text = "SL Price";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(45, 45, 48);
            btnCalculate.FlatAppearance.BorderColor = Color.White;
            btnCalculate.FlatAppearance.BorderSize = 2;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(25, 188);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 42);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtTPPercentage
            // 
            txtTPPercentage.BackColor = Color.FromArgb(30, 30, 30);
            txtTPPercentage.ForeColor = Color.White;
            txtTPPercentage.Location = new Point(255, 129);
            txtTPPercentage.Name = "txtTPPercentage";
            txtTPPercentage.Size = new Size(119, 27);
            txtTPPercentage.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(255, 106);
            label12.Name = "label12";
            label12.Size = new Size(129, 20);
            label12.TabIndex = 12;
            label12.Text = "TakeProfit %";
            // 
            // txtSLPercentage
            // 
            txtSLPercentage.BackColor = Color.FromArgb(30, 30, 30);
            txtSLPercentage.ForeColor = Color.White;
            txtSLPercentage.Location = new Point(499, 129);
            txtSLPercentage.Name = "txtSLPercentage";
            txtSLPercentage.Size = new Size(119, 27);
            txtSLPercentage.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(499, 106);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 10;
            label11.Text = "StopLoss %";
            // 
            // txtLeverage
            // 
            txtLeverage.BackColor = Color.FromArgb(30, 30, 30);
            txtLeverage.ForeColor = Color.White;
            txtLeverage.Location = new Point(499, 63);
            txtLeverage.Name = "txtLeverage";
            txtLeverage.Size = new Size(119, 27);
            txtLeverage.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(499, 40);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 8;
            label10.Text = "Leverage";
            // 
            // txtAmountInvested
            // 
            txtAmountInvested.BackColor = Color.FromArgb(30, 30, 30);
            txtAmountInvested.ForeColor = Color.White;
            txtAmountInvested.Location = new Point(255, 63);
            txtAmountInvested.Name = "txtAmountInvested";
            txtAmountInvested.Size = new Size(119, 27);
            txtAmountInvested.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 40);
            label9.Name = "label9";
            label9.Size = new Size(229, 20);
            label9.TabIndex = 6;
            label9.Text = "Invested Amount (USDT)";
            // 
            // txtRR
            // 
            txtRR.BackColor = Color.FromArgb(30, 30, 30);
            txtRR.ForeColor = Color.White;
            txtRR.Location = new Point(25, 129);
            txtRR.Name = "txtRR";
            txtRR.Size = new Size(119, 27);
            txtRR.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 106);
            label7.Name = "label7";
            label7.Size = new Size(179, 20);
            label7.TabIndex = 2;
            label7.Text = "Risk/Reward Ratio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 40);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 1;
            label6.Text = "Entry Price";
            // 
            // txtEntryPrice
            // 
            txtEntryPrice.BackColor = Color.FromArgb(30, 30, 30);
            txtEntryPrice.ForeColor = Color.White;
            txtEntryPrice.Location = new Point(25, 63);
            txtEntryPrice.Name = "txtEntryPrice";
            txtEntryPrice.Size = new Size(119, 27);
            txtEntryPrice.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(45, 45, 48);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Location = new Point(4, 22);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(701, 414);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Order by Value";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(45, 45, 48);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(lblOrderMaxLoss);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(lblOrderSLPrice);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(calculateBtnOrder);
            groupBox4.Controls.Add(lblOrderLeverage);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(label29);
            groupBox4.Controls.Add(lblOrderEntry);
            groupBox4.Font = new Font("Fira Code", 12F, FontStyle.Bold);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(6, 11);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(689, 392);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Options";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(168, 40);
            label24.Name = "label24";
            label24.Size = new Size(89, 20);
            label24.TabIndex = 38;
            label24.Text = "Max Loss";
            // 
            // lblOrderMaxLoss
            // 
            lblOrderMaxLoss.BackColor = Color.FromArgb(30, 30, 30);
            lblOrderMaxLoss.ForeColor = Color.White;
            lblOrderMaxLoss.Location = new Point(168, 63);
            lblOrderMaxLoss.Name = "lblOrderMaxLoss";
            lblOrderMaxLoss.Size = new Size(119, 27);
            lblOrderMaxLoss.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(45, 45, 48);
            groupBox5.Controls.Add(txtOrderByValue);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(txtOrderMargin);
            groupBox5.Controls.Add(label20);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(25, 178);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(211, 208);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Results";
            // 
            // txtOrderByValue
            // 
            txtOrderByValue.BackColor = Color.FromArgb(30, 30, 30);
            txtOrderByValue.ForeColor = Color.White;
            txtOrderByValue.Location = new Point(21, 64);
            txtOrderByValue.Name = "txtOrderByValue";
            txtOrderByValue.ReadOnly = true;
            txtOrderByValue.Size = new Size(159, 27);
            txtOrderByValue.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(21, 41);
            label18.Name = "label18";
            label18.Size = new Size(149, 20);
            label18.TabIndex = 39;
            label18.Text = "Order by Value";
            // 
            // txtOrderMargin
            // 
            txtOrderMargin.BackColor = Color.FromArgb(30, 30, 30);
            txtOrderMargin.ForeColor = Color.White;
            txtOrderMargin.Location = new Point(21, 127);
            txtOrderMargin.Name = "txtOrderMargin";
            txtOrderMargin.ReadOnly = true;
            txtOrderMargin.Size = new Size(159, 27);
            txtOrderMargin.TabIndex = 31;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(21, 104);
            label20.Name = "label20";
            label20.Size = new Size(159, 20);
            label20.TabIndex = 27;
            label20.Text = "Margin Required";
            // 
            // lblOrderSLPrice
            // 
            lblOrderSLPrice.BackColor = Color.FromArgb(30, 30, 30);
            lblOrderSLPrice.ForeColor = Color.White;
            lblOrderSLPrice.Location = new Point(450, 63);
            lblOrderSLPrice.Name = "lblOrderSLPrice";
            lblOrderSLPrice.Size = new Size(139, 27);
            lblOrderSLPrice.TabIndex = 3;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(450, 40);
            label23.Name = "label23";
            label23.Size = new Size(89, 20);
            label23.TabIndex = 24;
            label23.Text = "SL Price";
            // 
            // calculateBtnOrder
            // 
            calculateBtnOrder.BackColor = Color.FromArgb(45, 45, 48);
            calculateBtnOrder.FlatAppearance.BorderColor = Color.White;
            calculateBtnOrder.FlatAppearance.BorderSize = 2;
            calculateBtnOrder.FlatStyle = FlatStyle.Flat;
            calculateBtnOrder.ForeColor = Color.White;
            calculateBtnOrder.Location = new Point(25, 119);
            calculateBtnOrder.Name = "calculateBtnOrder";
            calculateBtnOrder.Size = new Size(119, 42);
            calculateBtnOrder.TabIndex = 14;
            calculateBtnOrder.Text = "Calculate";
            calculateBtnOrder.UseVisualStyleBackColor = false;
            calculateBtnOrder.Click += calculateBtnOrder_Click;
            // 
            // lblOrderLeverage
            // 
            lblOrderLeverage.BackColor = Color.FromArgb(30, 30, 30);
            lblOrderLeverage.ForeColor = Color.White;
            lblOrderLeverage.Location = new Point(313, 63);
            lblOrderLeverage.Name = "lblOrderLeverage";
            lblOrderLeverage.Size = new Size(119, 27);
            lblOrderLeverage.TabIndex = 2;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(313, 40);
            label26.Name = "label26";
            label26.Size = new Size(89, 20);
            label26.TabIndex = 8;
            label26.Text = "Leverage";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(25, 40);
            label29.Name = "label29";
            label29.Size = new Size(119, 20);
            label29.TabIndex = 1;
            label29.Text = "Entry Price";
            // 
            // lblOrderEntry
            // 
            lblOrderEntry.BackColor = Color.FromArgb(30, 30, 30);
            lblOrderEntry.ForeColor = Color.White;
            lblOrderEntry.Location = new Point(25, 63);
            lblOrderEntry.Name = "lblOrderEntry";
            lblOrderEntry.Size = new Size(119, 27);
            lblOrderEntry.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(662, 11);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(56, 13);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "v 1.0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(733, 464);
            Controls.Add(lblVersion);
            Controls.Add(tabControl1);
            Font = new Font("Fira Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(689, 349);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Position Size Calculator | SKAIKRU";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Button calculateBtn;
        private TextBox newAverage;
        private GroupBox groupBox1;
        private TextBox secondEntry;
        private TextBox secondPosition;
        private TextBox firstEntry;
        private TextBox firstPosition;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private TextBox txtRR;
        private Label label7;
        private Label label6;
        private TextBox txtEntryPrice;
        private TextBox txtSLPercentage;
        private Label label11;
        private TextBox txtLeverage;
        private Label label10;
        private TextBox txtAmountInvested;
        private Label label9;
        private GroupBox groupBox3;
        private Button btnCalculate;
        private TextBox txtTPPercentage;
        private Label label12;
        private TextBox lblPositionSize;
        private TextBox lblCoinAmount;
        private TextBox lblTPPrice;
        private TextBox lblSLPrice;
        private Label label15;
        private Label label13;
        private Label label14;
        private Label label8;
        private TextBox lblLoss;
        private TextBox lblGain;
        private Label label17;
        private Label label16;
        private TextBox textBox1;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox txtOrderMargin;
        private TextBox lblOrderSLPrice;
        private Label label20;
        private Label label23;
        private Button calculateBtnOrder;
        private TextBox lblOrderLeverage;
        private Label label26;
        private Label label29;
        private TextBox lblOrderEntry;
        private Label label24;
        private TextBox lblOrderMaxLoss;
        private Label label18;
        private TextBox txtOrderByValue;
        private Label lblVersion;
    }
}
