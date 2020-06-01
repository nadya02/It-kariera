using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Client
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private List<BankAccount> accounts = new List<BankAccount>();

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public double GetBalance()
        {
            return this.accounts.Sum(x => x.Balance);
        }

    }
}