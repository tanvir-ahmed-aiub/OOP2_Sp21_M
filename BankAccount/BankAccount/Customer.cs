using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Customer
    {
        public string Name { get; set; }
        Account[] accounts;
        public int AccCount { get; set; }
        public Customer() {
            accounts = new Account[10];
        }
        public void AddAccount(params Account[] accounts) {
            foreach (Account acc in accounts) {
                this.accounts[AccCount++] = acc;
            }
        }
        public void ShowAccDetails() {
            for (int i = 0; i < AccCount; i++) {
                accounts[i].ShowInfo();
            }
        }
        public Account GetAccount(string accNo) {
            Account acc = null;
            for (int i = 0; i < AccCount; i++) {
                if (accNo.Equals(accounts[i].AccNo)) {
                    acc = accounts[i];
                    break;
                }
            }
            return acc;
        }
    }
}
