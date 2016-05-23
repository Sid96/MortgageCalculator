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
    public enum Frequency
    {
        Weekly = 52,
        BiWeekly=26,
        SemiMonthly=24,
        Monthly=12
    }

    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            paymentFreqBox.Items.Add(Frequency.Weekly);
            paymentFreqBox.Items.Add(Frequency.BiWeekly);
            paymentFreqBox.Items.Add(Frequency.SemiMonthly);
            paymentFreqBox.Items.Add(Frequency.Monthly);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //we have principal, yearly interest rate, and years of amortization
            //we also have the rate of payments --> if it's monthly, rate is 12         
            //let p = principal
            //    r = yearly interest rate/100/rate of payments
            //    n = total number of payments = years of amortization * rate of payments


            // weekly = 52/year
            // 
            //var rateOfPayments = Convert.ToInt32(paymentFreqBox.Text);                                                   
            var rateOfPayments = (int)Enum.Parse(typeof(Frequency), paymentFreqBox.Text);
            var principal = Convert.ToDouble(principalBox.Text);                    
            var interestRate = Convert.ToDouble(interestRateBox.Text)/rateOfPayments/100;
            var numberOfPayments = Convert.ToInt32(amortPdBox.Text)*rateOfPayments;
            var totalIntervalPayment = Math.Round((interestRate * principal) / (1 - (Math.Pow(1+ interestRate,-numberOfPayments))),2);  
            output.Text = totalIntervalPayment.ToString();
            using (StreamWriter sw = new StreamWriter("paymentSchedule.txt"))
            {
                var week = 1;
                while (principal > 0)
                {
                    var principalWithoutInterest = principal;
                    var interestPaid = Math.Round(principal * interestRate,2);
                    principal = Math.Round(principal * (1 + interestRate) - totalIntervalPayment,2);
                    string output;
                    if (principal >= 0)
                    {
                        output = string.Format("Period {0} Amount before interest: {1:C2}, Interest Paid: {2:C2}, Principal Paid: {3:C2}, Amount after interest: {4:C2}"
                            , week, principalWithoutInterest, interestPaid, totalIntervalPayment - interestPaid, principal);
                    }
                    else
                    {
                        output = string.Format("Period {0} Amount before interest: {1:C2}, Interest Paid: {2:C2}, Principal Paid: {3:C2}, Amount after interest: {4:C2}"
                             , week, principalWithoutInterest, interestPaid, principalWithoutInterest - interestPaid, 0);
                    }
                    sw.WriteLine(output);           
                    week++;
                }                    
            }

        }
    }
}
