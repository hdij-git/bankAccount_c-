using System;
using System.Collections.Generic;
using System.Text;

namespace bankAccount_c_
{
    internal class accountMethods
    {
        //Fields(Encapsulation: private)
        private string Owner;
        private double Balance;
        private string AccountNumber;

        //constructor
        public accountMethods(string owner, string accountNumber, double inialBalance)
        {
            Owner = owner;
            AccountNumber= accountNumber;
            Balance = inialBalance;
        }
        // deposit
        public void deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{Owner} deposited {amount}. New Balance: {Balance}");
        }
        public void withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{Owner} withdraw {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"{Owner} does not have enough balance.");
            }

        }
        public void transfer(accountMethods targetAccount, double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Transfer failed. Not enough balance.");
                return;
            }
            this.Balance -= amount;
            targetAccount.Balance += amount;

            Console.WriteLine($"{amount} transferred from {this.AccountNumber} to {targetAccount.AccountNumber}");
        }
        public void ShowBalance()
        {
            Console.WriteLine($"{Owner}'s Balance: {Balance}");
        }
    }
}
