using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section
{
    class Section
    {
        static void Main(string[] args)
        {
            List<int> l1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> l2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> intersection = new List<int>();
            for (int i = 0; i < l2.Count; i++)
            {
                if (l1.Contains(l2[i]))
                {
                    intersection.Add(l2[i]);
                }
            }
            Console.WriteLine("{" + String.Join(" ", intersection) + "}");
        }
    }
}
