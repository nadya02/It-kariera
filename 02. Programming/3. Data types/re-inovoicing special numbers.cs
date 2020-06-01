using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace re_inovoicing_special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int x = i;
                while (x > 0)
                {
                    sum += x % 10;
                    x = x / 10;
                }
                bool condition = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {condition}");
            }

        }
    }
}
