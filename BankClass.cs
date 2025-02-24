using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    public class Bank
    {
        public static double InterestRate { get; private set; }

        public string BankName { get; set; }
        public double AccountBalance { get; set; }

        public Bank(string bankName, double accountBalance)
        {
            BankName = bankName;
            AccountBalance = accountBalance;
        }

        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Bank: {BankName}, Balance: {AccountBalance}, Interest Rate: {InterestRate}%");
        }
    }
}
