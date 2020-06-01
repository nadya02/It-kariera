using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteTheNegativeNumbers
{
    class DeleteTheNegativeNumbers
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = a.Count - 1; i >= 0; i--)
            {
                if (a[i]<0)
                {
                    a.RemoveAt(i);
                }
            }
            Console.WriteLine(String.Join(" ", a));
        }
    }
}
