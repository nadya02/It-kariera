using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n/2; i++)
            {
                int temp = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = temp;

            }
            Console.WriteLine(String.Join(" ",a));
        }
    }
}
