using bankAccount_c_;
using System;

class Program
{
    static void Main()
    {



        accountMethods accountM = new accountMethods("Hadi", "ACC1001", 1500);
       accountMethods acc2 = new accountMethods("Ali", "ACC1002", 2000);
        accountM.deposit(500);
        accountM.withdraw(1000);
        accountM.withdraw(2000);
        accountM.ShowBalance();
       accountM.transfer(acc2, 200);

        accountM.ShowBalance();
        acc2.ShowBalance();
    }

}