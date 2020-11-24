using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String name = "Wayne Gretzky is number ";
            infoLabel.Text = name;

            int Number = 99;
            infoLabel.Text += $"{Number}"; 

        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            Double Radius = 15;
            Double Pi = 3.14;
            Double Area = Radius * Pi;

            infoLabel.Text = $"Radius: {Radius}";
            infoLabel.Text += $"\nPi: {Pi}";
            infoLabel.Text += $"\nArea: {Area}";
        }

        private void CarpetButton_Click(object sender, EventArgs e)
        {
            Double Length = 8.5;
            Double Width = 6;
            Double CostPerMeter = 19.95;
            Double Area = Length * Width;
            Double TotalCost = Area * CostPerMeter;

                infoLabel.Text += $"Length: {Length}";
            infoLabel.Text = $"Width: {Width}";
            infoLabel.Text += $"\nCostPerMeter: {CostPerMeter}";
            infoLabel.Text += $"\nArea: {Area}";
            infoLabel.Text += $"\nTotalCost: {TotalCost}";
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            Double Shirt = 12.49;
            Double Taxes = 1.62;
            Double Bill = Shirt + Taxes;
            Double Change = 20 - Bill;

            infoLabel.Text = $"Shirt: {Shirt}";
            infoLabel.Text += $"\nTaxes: {Taxes}";
            infoLabel.Text += $"\nBill: {Bill}";
            infoLabel.Text += $"\nChange: {Change}";
        }
    }
}
