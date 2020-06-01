using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_MinAndMax
{
    class List_MinAndMax
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int min = a[0];
            int max = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] < min) min = a[i];
                if (a[i] > max) max = a[i];
            }
            a.Sort();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == min) Console.WriteLine(a[i]);
                if (a[i] == max) Console.WriteLine(a[i]);
            }           
        }
    }
}
