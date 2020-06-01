using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_from_10_to_N
{
    class Transfer_from_10_to_N
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = a[0];
            int number = a[1];
            string newNumber = "";
            while(number!=0)
            {
                newNumber = number % n + newNumber ;
                number = number / n;
            }
            Console.WriteLine(newNumber);
        }
    }
}
