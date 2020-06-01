using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Transfer__from_N_to_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split().ToArray();
            int n = int.Parse(a[0]);
            string number = a[1];
            BigInteger ConvertedNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                ConvertedNumber = ConvertedNumber * n + (number[i] - '0');
            }
            Console.WriteLine(ConvertedNumber);
        }
    }
}
