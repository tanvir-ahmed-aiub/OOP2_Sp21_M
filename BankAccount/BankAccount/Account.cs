using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance) {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void ShowInfo() {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }
        virtual public void Withdraw(double amount) {

        }
        virtual public void Transfer(Account acc, double amount) {

        }

    }
}
