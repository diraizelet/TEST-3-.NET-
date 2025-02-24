using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    class BankDetails
    {
        private decimal balance;

        public BankDetails(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }

            if (amount > balance)
            {
                return false; // Insufficient balance
            }

            balance -= amount;
            return true; // Withdrawal successful
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
