using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankAccount_program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdraw(5);
            Console.WriteLine(acc.ToString());
        }
    }
}
