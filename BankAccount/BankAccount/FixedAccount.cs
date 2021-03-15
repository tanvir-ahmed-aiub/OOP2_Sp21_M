using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class FixedAccount:Account
    {
        public int TenureYear { get; set; }
        public int OpeningYear { get; set; }
        public FixedAccount() { }
        public FixedAccount(string accName, string accNo, double balance, int tenureYear, int opYear) : base(accName, accNo, balance) {

        }
        public override void Withdraw(double amount)
        {
            int crYear = DateTime.Now.Year;
            if (crYear - OpeningYear > TenureYear) {

            }
        }
    }
}
