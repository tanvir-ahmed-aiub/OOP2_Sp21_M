using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            /*a1.ShowInfo();
            a2.ShowInfo();
            a1.Withdraw(500);
            a1.Transfer(a2, 10000);
            Console.WriteLine("*********************");
            a1.ShowInfo();
            a2.ShowInfo();*/

            Account a1 = new SavingsAccount("Tanvir Ahmed","145",50000);
            Account a2 = new CurrentAccount("Tanvir Ahmed","146", 50000);
            Account a3 = new SavingsAccount("Tanvir Ahmed Sabbir Ahmed", "147", 5000);
            Account a4 = new FixedAccount("Tanvir Ahmed", "148", 100000, 5, 2014);

            Customer c = new Customer();
            c.AddAccount(a1,a2,a3,a4);
            var acc = c.GetAccount("146");
            acc.Withdraw(49600);
            //c.ShowAccDetails();
            


        }
    }
}
