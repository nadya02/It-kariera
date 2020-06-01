using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount <= this.balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient amount");
            }
        }

        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }
    }
}
