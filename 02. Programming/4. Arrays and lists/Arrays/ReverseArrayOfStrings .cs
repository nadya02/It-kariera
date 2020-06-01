using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < (a.Length)/2; i++)
            {
                string temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(" ",a));
        }
    }
}
