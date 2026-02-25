using bankAccount_c_;
using System;

class Program
{
    static void Main()
    {



        accountMethods accountM = new accountMethods("Hadi", 1500);
        accountM.deposit(500);
        accountM.withdraw(1000);
        accountM.withdraw(2000);
        accountM.ShowBalance();
    }

}