using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //we have principal, yearly interest rate, and years of amortization
            //we also have the rate of payments --> if it's monthly, rate is 12         
            //let p = principal
            //    r = yearly interest rate/100/rate of payments
            //    n = total number of payments = years of amortization * rate of payments

            var rateOfPayments = Convert.ToInt32(paymentFreqBox.Text);                                                   
            var p = Convert.ToDouble(principalBox.Text);                    
            var r = Convert.ToDouble(interestRateBox.Text)/rateOfPayments/100;
            var n = Convert.ToInt32(amortPdBox.Text)*rateOfPayments;
            var c = (r * p) / (1 - (Math.Pow(1+ r,-n)));
            output.Text = c.ToString();
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                var i = -1;
                while (p > 0)
                {
                    sw.WriteLine("Amount owed: " + p);
                    p = p * (1 + r) - c;
                    i++;
                }
                sw.WriteLine(i + 1);
            }

        }
    }
}
