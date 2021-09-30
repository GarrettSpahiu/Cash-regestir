using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_regestir
{
    public partial class Form1 : Form
    {
        int Burger1 = 4;
        int Burger2 = 5;
        int Burger3 = 6;
        int PlainBox;
        int CheeseBox;
        int BaconCheeseBox;
        int PlainPrice;
        int CheesePrice;
        int BaconPrice;
        double subtotal = 0;
        double FinalCost;
        double taxRate = 0.13;
        double FinalTax;
        double change;
        int Payment;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tax_Click(object sender, EventArgs e)
        {

        }

        private void BuyItems_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch { }

        }

        private void Change_Click(object sender, EventArgs e)
        {

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                PlainBox = Convert.ToInt32(box1.Text);
                CheeseBox = Convert.ToInt32(box2.Text);
                BaconCheeseBox = Convert.ToInt32(box3.Text);

                PlainPrice = PlainBox * Burger1;
                CheesePrice = CheeseBox * Burger2;
                BaconPrice = BaconCheeseBox * Burger3;

                subtotal = PlainPrice + CheesePrice + BaconPrice;
                FinalTax = subtotal * taxRate;
                FinalCost = subtotal + FinalTax;

                subtotalOutput.Text = $"{subtotal.ToString("c")}";

                TaxLabel.Text = $"Tax {FinalTax.ToString("c")}";
                TotalPriceLabel.Text = $"Final Price {FinalCost.ToString("c")}";









            }
            catch
            {

            }
        }

        private void ChangeCalculator_Click(object sender, EventArgs e)
        {
            TotalPriceLabel.Text = $"Total Price {FinalCost.ToString("C")}";
            Payment = Convert.ToInt32(PayBox.Text);
            change = Payment - FinalCost;
            changeLabel.Text = $"Change {change.ToString("C")}";
        }
        
    }
}
