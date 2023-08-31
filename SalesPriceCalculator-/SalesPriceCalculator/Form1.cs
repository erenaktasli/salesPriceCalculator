using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPriceCalculator
{
    public partial class FormForecast : Form
    {
        public FormForecast()
        {
            InitializeComponent();


        }
        //MethodOne: In use with function  (20-52 Line)
        private void SalesYearlyCalculator()
        {
            double SalesQty2019;
            double SalesQty2020;
            double SalesQty2021;
            double SalesPrice2019;
            double SalesPrice2020;
            double SalesPrice2021;
            double SalesTotal2019;
            double SalesTotal2020;
            double SalesTotal2021;

            SalesQty2019 = Convert.ToDouble(textBoxQty2019.Text);
            SalesQty2020 = Convert.ToDouble(textBoxQty2020.Text);
            SalesQty2021 = Convert.ToDouble(textBoxQty2021.Text);

            SalesPrice2019 = Convert.ToDouble(textBoxPrice2019.Text);
            SalesPrice2020 = Convert.ToDouble(textBoxPrice2020.Text);
            SalesPrice2021 = Convert.ToDouble(textBoxPrice2021.Text);


            SalesTotal2019 = SalesQty2019 * SalesPrice2019;
            SalesTotal2020 = SalesQty2020 * SalesPrice2020;
            SalesTotal2021 = SalesQty2021 * SalesPrice2021;


            labelSales2019.Text = Convert.ToString(SalesTotal2019);
            labelSales2020.Text = Convert.ToString(SalesTotal2020);
            labelSales2021.Text = Convert.ToString(SalesTotal2021);


        }

        private void buttonCalculateTotal_Click(object sender, EventArgs e)
        {
            SalesYearlyCalculator();
        }

        private double RateCalculator(double SalesTotal2019, double SalesTotal2020, double SalesTotal2021)
            //(double SalesQty2019, double SalesQty2020, double SalesQty2021, double SalesPrice2019, double SalesPrice2020, double SalesPrice2021)
        {
            double PriceRate2020;
            double PriceRate2021;
            double PriceRateAvarage;
            SalesTotal2019 = Convert.ToDouble(labelSales2019.Text);
            SalesTotal2020 = Convert.ToDouble(labelSales2020.Text);
            SalesTotal2021 = Convert.ToDouble(labelSales2021.Text);


           PriceRate2020 = ( SalesTotal2020 / SalesTotal2019);
           PriceRate2021 = (SalesTotal2021 / SalesTotal2020);
           PriceRateAvarage = (PriceRate2020 + PriceRate2021) / 2;

            return PriceRateAvarage;
        }
        private void buttonCalculateRate_Click(object sender, EventArgs e)
        {
            double PriceRateAvarage;
            double SalesTotal2019;
            double SalesTotal2020;
            double SalesTotal2021;

            SalesTotal2019 = Convert.ToDouble(labelSales2019.Text);
            SalesTotal2020 = Convert.ToDouble(labelSales2020.Text);
            SalesTotal2021 = Convert.ToDouble(labelSales2021.Text);

            PriceRateAvarage = RateCalculator(SalesTotal2019, SalesTotal2020,SalesTotal2021);
            label3Rate2021.Text = Convert.ToString(PriceRateAvarage);


        }

        private double ForecastCalculate (double SalesPrice2021, double SalesPrice2020)

        {
            double SalesPrice2022;

           SalesPrice2021 = Convert.ToDouble(textBoxPrice2021.Text);
           SalesPrice2020 = Convert.ToDouble(textBoxPrice2020.Text);
           SalesPrice2022 = ((SalesPrice2021/SalesPrice2020) * SalesPrice2021);
           return SalesPrice2022;
        }

        private void buttonCalculate2022_Click(object sender, EventArgs e)
        {
            double SalesPrice2021;
            double SalesPrice2020;
            double SalesPrice2022;
            SalesPrice2021 = Convert.ToDouble(textBoxPrice2021.Text);
            SalesPrice2020 = Convert.ToDouble(textBoxPrice2020.Text);
            SalesPrice2022 = ForecastCalculate(SalesPrice2021, SalesPrice2020);
            labelPrice2022.Text = Convert.ToString(SalesPrice2022);
        }


        private double calculateRevenue2022(double PriceRateAvarage, double SalesTotal2021)
        {
            double SalesTotal2022;
            PriceRateAvarage = Convert.ToDouble(label3Rate2021.Text);
            SalesTotal2021 = Convert.ToDouble(labelSales2021.Text);
            SalesTotal2022 = (PriceRateAvarage * SalesTotal2021);
            return SalesTotal2022;

        }

        private void buttonCalculateRevenue_Click(object sender, EventArgs e)
        {
            double SalesTotal2022;
            double SalesTotal2021 = Convert.ToDouble(labelSales2021.Text);
            double PriceRateAvarage = Convert.ToDouble(label3Rate2021.Text);
            SalesTotal2022= calculateRevenue2022(PriceRateAvarage, SalesTotal2021);
            labelSalesTotal2022.Text = Convert.ToString(SalesTotal2022);
        }
    }
}
