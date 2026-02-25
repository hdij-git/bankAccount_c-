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

        //constructor
        public accountMethods(string owner, double inialBalance)
        {
            Owner = owner;
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
        public void ShowBalance()
        {
            Console.WriteLine($"{Owner}'s Balance: {Balance}");
        }
    }
}
