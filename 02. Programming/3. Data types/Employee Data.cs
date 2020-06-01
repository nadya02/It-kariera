using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            string EGN = Console.ReadLine();
            string uniqueID = Console.ReadLine();
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(sex);
            Console.WriteLine(EGN);
            Console.WriteLine(uniqueID);
        }
    }
}
