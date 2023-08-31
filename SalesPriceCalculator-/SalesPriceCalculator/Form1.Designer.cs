namespace SalesPriceCalculator
{
    partial class FormForecast
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxQty2019 = new System.Windows.Forms.TextBox();
            this.textBoxQty2020 = new System.Windows.Forms.TextBox();
            this.textBoxPrice2019 = new System.Windows.Forms.TextBox();
            this.textBoxPrice2020 = new System.Windows.Forms.TextBox();
            this.textBoxPrice2021 = new System.Windows.Forms.TextBox();
            this.textBoxQty2021 = new System.Windows.Forms.TextBox();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label2022 = new System.Windows.Forms.Label();
            this.label2019 = new System.Windows.Forms.Label();
            this.label2020 = new System.Windows.Forms.Label();
            this.label2021 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSales2019 = new System.Windows.Forms.Label();
            this.labelSales2020 = new System.Windows.Forms.Label();
            this.labelSales2021 = new System.Windows.Forms.Label();
            this.labelPrice2022 = new System.Windows.Forms.Label();
            this.groupBoxYearlyTable = new System.Windows.Forms.GroupBox();
            this.buttonCalculateTotal = new System.Windows.Forms.Button();
            this.buttonCalculate2022 = new System.Windows.Forms.Button();
            this.buttonCalculateRate = new System.Windows.Forms.Button();
            this.label3Rate2021 = new System.Windows.Forms.Label();
            this.labelYearlyRate = new System.Windows.Forms.Label();
            this.groupBoxForecast = new System.Windows.Forms.GroupBox();
            this.groupBoxCalculateTotal = new System.Windows.Forms.GroupBox();
            this.buttonCalculateRevenue = new System.Windows.Forms.Button();
            this.labelSalesTotal2022 = new System.Windows.Forms.Label();
            this.groupBoxYearlyTable.SuspendLayout();
            this.groupBoxForecast.SuspendLayout();
            this.groupBoxCalculateTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQty2019
            // 
            this.textBoxQty2019.Location = new System.Drawing.Point(105, 24);
            this.textBoxQty2019.Name = "textBoxQty2019";
            this.textBoxQty2019.Size = new System.Drawing.Size(100, 20);
            this.textBoxQty2019.TabIndex = 0;
            // 
            // textBoxQty2020
            // 
            this.textBoxQty2020.Location = new System.Drawing.Point(211, 24);
            this.textBoxQty2020.Name = "textBoxQty2020";
            this.textBoxQty2020.Size = new System.Drawing.Size(100, 20);
            this.textBoxQty2020.TabIndex = 1;
            // 
            // textBoxPrice2019
            // 
            this.textBoxPrice2019.Location = new System.Drawing.Point(105, 50);
            this.textBoxPrice2019.Name = "textBoxPrice2019";
            this.textBoxPrice2019.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice2019.TabIndex = 4;
            // 
            // textBoxPrice2020
            // 
            this.textBoxPrice2020.Location = new System.Drawing.Point(211, 50);
            this.textBoxPrice2020.Name = "textBoxPrice2020";
            this.textBoxPrice2020.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice2020.TabIndex = 5;
            // 
            // textBoxPrice2021
            // 
            this.textBoxPrice2021.Location = new System.Drawing.Point(317, 49);
            this.textBoxPrice2021.Name = "textBoxPrice2021";
            this.textBoxPrice2021.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice2021.TabIndex = 8;
            // 
            // textBoxQty2021
            // 
            this.textBoxQty2021.Location = new System.Drawing.Point(317, 23);
            this.textBoxQty2021.Name = "textBoxQty2021";
            this.textBoxQty2021.Size = new System.Drawing.Size(100, 20);
            this.textBoxQty2021.TabIndex = 9;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(23, 30);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(23, 13);
            this.labelQty.TabIndex = 10;
            this.labelQty.Text = "Qty";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(23, 53);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            // 
            // label2022
            // 
            this.label2022.AutoSize = true;
            this.label2022.Location = new System.Drawing.Point(630, 80);
            this.label2022.Name = "label2022";
            this.label2022.Size = new System.Drawing.Size(75, 13);
            this.label2022.TabIndex = 12;
            this.label2022.Text = "2022 Forecast";
            // 
            // label2019
            // 
            this.label2019.AutoSize = true;
            this.label2019.Location = new System.Drawing.Point(139, 8);
            this.label2019.Name = "label2019";
            this.label2019.Size = new System.Drawing.Size(31, 13);
            this.label2019.TabIndex = 13;
            this.label2019.Text = "2019";
            // 
            // label2020
            // 
            this.label2020.AutoSize = true;
            this.label2020.Location = new System.Drawing.Point(244, 8);
            this.label2020.Name = "label2020";
            this.label2020.Size = new System.Drawing.Size(31, 13);
            this.label2020.TabIndex = 14;
            this.label2020.Text = "2020";
            // 
            // label2021
            // 
            this.label2021.AutoSize = true;
            this.label2021.Location = new System.Drawing.Point(355, 8);
            this.label2021.Name = "label2021";
            this.label2021.Size = new System.Drawing.Size(31, 13);
            this.label2021.TabIndex = 15;
            this.label2021.Text = "2021";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(27, 29);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 13);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "TOTAL Yearly";
            // 
            // labelSales2019
            // 
            this.labelSales2019.AutoSize = true;
            this.labelSales2019.Location = new System.Drawing.Point(143, 29);
            this.labelSales2019.Name = "labelSales2019";
            this.labelSales2019.Size = new System.Drawing.Size(22, 13);
            this.labelSales2019.TabIndex = 17;
            this.labelSales2019.Text = "0.0";
            // 
            // labelSales2020
            // 
            this.labelSales2020.AutoSize = true;
            this.labelSales2020.Location = new System.Drawing.Point(248, 29);
            this.labelSales2020.Name = "labelSales2020";
            this.labelSales2020.Size = new System.Drawing.Size(22, 13);
            this.labelSales2020.TabIndex = 18;
            this.labelSales2020.Text = "0.0";
            // 
            // labelSales2021
            // 
            this.labelSales2021.AutoSize = true;
            this.labelSales2021.Location = new System.Drawing.Point(359, 29);
            this.labelSales2021.Name = "labelSales2021";
            this.labelSales2021.Size = new System.Drawing.Size(22, 13);
            this.labelSales2021.TabIndex = 19;
            this.labelSales2021.Text = "0.0";
            // 
            // labelPrice2022
            // 
            this.labelPrice2022.AutoSize = true;
            this.labelPrice2022.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrice2022.ForeColor = System.Drawing.Color.Gold;
            this.labelPrice2022.Location = new System.Drawing.Point(68, 41);
            this.labelPrice2022.Name = "labelPrice2022";
            this.labelPrice2022.Size = new System.Drawing.Size(45, 29);
            this.labelPrice2022.TabIndex = 20;
            this.labelPrice2022.Text = "0.0";
            // 
            // groupBoxYearlyTable
            // 
            this.groupBoxYearlyTable.Controls.Add(this.label2021);
            this.groupBoxYearlyTable.Controls.Add(this.label2020);
            this.groupBoxYearlyTable.Controls.Add(this.label2019);
            this.groupBoxYearlyTable.Controls.Add(this.labelPrice);
            this.groupBoxYearlyTable.Controls.Add(this.labelQty);
            this.groupBoxYearlyTable.Controls.Add(this.textBoxQty2021);
            this.groupBoxYearlyTable.Controls.Add(this.textBoxPrice2021);
            this.groupBoxYearlyTable.Controls.Add(this.textBoxPrice2020);
            this.groupBoxYearlyTable.Controls.Add(this.textBoxPrice2019);
            this.groupBoxYearlyTable.Controls.Add(this.textBoxQty2020);
            this.groupBoxYearlyTable.Controls.Add(this.textBoxQty2019);
            this.groupBoxYearlyTable.Location = new System.Drawing.Point(103, 73);
            this.groupBoxYearlyTable.Name = "groupBoxYearlyTable";
            this.groupBoxYearlyTable.Size = new System.Drawing.Size(432, 103);
            this.groupBoxYearlyTable.TabIndex = 22;
            this.groupBoxYearlyTable.TabStop = false;
            this.groupBoxYearlyTable.Text = "Yearly Sales";
            // 
            // buttonCalculateTotal
            // 
            this.buttonCalculateTotal.Location = new System.Drawing.Point(109, 83);
            this.buttonCalculateTotal.Name = "buttonCalculateTotal";
            this.buttonCalculateTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateTotal.TabIndex = 23;
            this.buttonCalculateTotal.Text = "Total Sales";
            this.buttonCalculateTotal.UseVisualStyleBackColor = true;
            this.buttonCalculateTotal.Click += new System.EventHandler(this.buttonCalculateTotal_Click);
            // 
            // buttonCalculate2022
            // 
            this.buttonCalculate2022.Location = new System.Drawing.Point(70, 167);
            this.buttonCalculate2022.Name = "buttonCalculate2022";
            this.buttonCalculate2022.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate2022.TabIndex = 24;
            this.buttonCalculate2022.Text = "2022 Price";
            this.buttonCalculate2022.UseVisualStyleBackColor = true;
            this.buttonCalculate2022.Click += new System.EventHandler(this.buttonCalculate2022_Click);
            // 
            // buttonCalculateRate
            // 
            this.buttonCalculateRate.Location = new System.Drawing.Point(306, 83);
            this.buttonCalculateRate.Name = "buttonCalculateRate";
            this.buttonCalculateRate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateRate.TabIndex = 25;
            this.buttonCalculateRate.Text = "Yearly Rate";
            this.buttonCalculateRate.UseVisualStyleBackColor = true;
            this.buttonCalculateRate.Click += new System.EventHandler(this.buttonCalculateRate_Click);
            // 
            // label3Rate2021
            // 
            this.label3Rate2021.AutoSize = true;
            this.label3Rate2021.Location = new System.Drawing.Point(359, 57);
            this.label3Rate2021.Name = "label3Rate2021";
            this.label3Rate2021.Size = new System.Drawing.Size(22, 13);
            this.label3Rate2021.TabIndex = 32;
            this.label3Rate2021.Text = "0.0";
            // 
            // labelYearlyRate
            // 
            this.labelYearlyRate.AutoSize = true;
            this.labelYearlyRate.Location = new System.Drawing.Point(27, 57);
            this.labelYearlyRate.Name = "labelYearlyRate";
            this.labelYearlyRate.Size = new System.Drawing.Size(62, 13);
            this.labelYearlyRate.TabIndex = 33;
            this.labelYearlyRate.Text = "Yearly Rate";
            // 
            // groupBoxForecast
            // 
            this.groupBoxForecast.Controls.Add(this.labelSalesTotal2022);
            this.groupBoxForecast.Controls.Add(this.buttonCalculateRevenue);
            this.groupBoxForecast.Controls.Add(this.buttonCalculate2022);
            this.groupBoxForecast.Controls.Add(this.labelPrice2022);
            this.groupBoxForecast.Location = new System.Drawing.Point(560, 73);
            this.groupBoxForecast.Name = "groupBoxForecast";
            this.groupBoxForecast.Size = new System.Drawing.Size(200, 258);
            this.groupBoxForecast.TabIndex = 34;
            this.groupBoxForecast.TabStop = false;
            this.groupBoxForecast.Text = "Forecast";
            // 
            // groupBoxCalculateTotal
            // 
            this.groupBoxCalculateTotal.Controls.Add(this.labelYearlyRate);
            this.groupBoxCalculateTotal.Controls.Add(this.label3Rate2021);
            this.groupBoxCalculateTotal.Controls.Add(this.buttonCalculateRate);
            this.groupBoxCalculateTotal.Controls.Add(this.buttonCalculateTotal);
            this.groupBoxCalculateTotal.Controls.Add(this.labelSales2021);
            this.groupBoxCalculateTotal.Controls.Add(this.labelSales2020);
            this.groupBoxCalculateTotal.Controls.Add(this.labelSales2019);
            this.groupBoxCalculateTotal.Controls.Add(this.labelTotal);
            this.groupBoxCalculateTotal.Location = new System.Drawing.Point(99, 183);
            this.groupBoxCalculateTotal.Name = "groupBoxCalculateTotal";
            this.groupBoxCalculateTotal.Size = new System.Drawing.Size(435, 148);
            this.groupBoxCalculateTotal.TabIndex = 35;
            this.groupBoxCalculateTotal.TabStop = false;
            this.groupBoxCalculateTotal.Text = "TOTAL";
            // 
            // buttonCalculateRevenue
            // 
            this.buttonCalculateRevenue.Location = new System.Drawing.Point(70, 196);
            this.buttonCalculateRevenue.Name = "buttonCalculateRevenue";
            this.buttonCalculateRevenue.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateRevenue.TabIndex = 25;
            this.buttonCalculateRevenue.Text = "Forecast";
            this.buttonCalculateRevenue.UseVisualStyleBackColor = true;
            this.buttonCalculateRevenue.Click += new System.EventHandler(this.buttonCalculateRevenue_Click);
            // 
            // labelSalesTotal2022
            // 
            this.labelSalesTotal2022.AutoSize = true;
            this.labelSalesTotal2022.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalesTotal2022.ForeColor = System.Drawing.Color.Gold;
            this.labelSalesTotal2022.Location = new System.Drawing.Point(68, 83);
            this.labelSalesTotal2022.Name = "labelSalesTotal2022";
            this.labelSalesTotal2022.Size = new System.Drawing.Size(45, 29);
            this.labelSalesTotal2022.TabIndex = 26;
            this.labelSalesTotal2022.Text = "0.0";
            // 
            // FormForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCalculateTotal);
            this.Controls.Add(this.groupBoxYearlyTable);
            this.Controls.Add(this.label2022);
            this.Controls.Add(this.groupBoxForecast);
            this.Name = "FormForecast";
            this.Text = "Sales Forecast";
            this.groupBoxYearlyTable.ResumeLayout(false);
            this.groupBoxYearlyTable.PerformLayout();
            this.groupBoxForecast.ResumeLayout(false);
            this.groupBoxForecast.PerformLayout();
            this.groupBoxCalculateTotal.ResumeLayout(false);
            this.groupBoxCalculateTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQty2019;
        private System.Windows.Forms.TextBox textBoxQty2020;
        private System.Windows.Forms.TextBox textBoxPrice2019;
        private System.Windows.Forms.TextBox textBoxPrice2020;
        private System.Windows.Forms.TextBox textBoxPrice2021;
        private System.Windows.Forms.TextBox textBoxQty2021;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label2022;
        private System.Windows.Forms.Label label2019;
        private System.Windows.Forms.Label label2020;
        private System.Windows.Forms.Label label2021;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSales2019;
        private System.Windows.Forms.Label labelSales2020;
        private System.Windows.Forms.Label labelSales2021;
        private System.Windows.Forms.Label labelPrice2022;
        private System.Windows.Forms.GroupBox groupBoxYearlyTable;
        private System.Windows.Forms.Button buttonCalculateTotal;
        private System.Windows.Forms.Button buttonCalculate2022;
        private System.Windows.Forms.Button buttonCalculateRate;
        private System.Windows.Forms.Label label3Rate2021;
        public System.Windows.Forms.Label labelYearlyRate;
        private System.Windows.Forms.GroupBox groupBoxForecast;
        private System.Windows.Forms.GroupBox groupBoxCalculateTotal;
        private System.Windows.Forms.Button buttonCalculateRevenue;
        private System.Windows.Forms.Label labelSalesTotal2022;
    }
}

