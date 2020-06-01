using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfReverseNumbers
{
    class SumOfReverseNumbers
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int b = 0;
                while(a[i]!=0)
                {
                    b = b * 10 + a[i] % 10;
                    a[i] = a[i] / 10;
                }
                sum = sum + b;
            }
            Console.WriteLine(sum);
        }
    }
}
