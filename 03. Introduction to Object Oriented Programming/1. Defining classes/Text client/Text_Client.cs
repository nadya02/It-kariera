using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Client
{
    class Text_Client
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                var split_input = input.Split();
                var command = split_input[0];
                switch(command)
                {
                    case "Create": Create(split_input, accounts);break;
                    case "Deposit": Deposit(split_input, accounts);break;
                    case "Withdraw": Withdraw(split_input, accounts);break;
                    case "Print": Print(split_input, accounts);break;
                }
            }
        }

        private static void Print(string[] split_input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(Console.ReadLine());
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exists");
            }
        }

        private static void Withdraw(string[] split_input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(split_input[1]);
            var amount = double.Parse(split_input[2]);
            if (accounts.ContainsKey(id))
            {
                accounts[id].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Account does not exists");
            }
        }

        private static void Deposit(string[] split_input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(split_input[1]);
            var amount = double.Parse(split_input[2]);
            if(accounts.ContainsKey(id))
            {
                accounts[id].Deposite(amount);
            }
            else
            {
                Console.WriteLine("Account does not exists");
            }
        }

        private static void Create(string[] split_input, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(split_input[1]);
            if(accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }
    }
    
}
