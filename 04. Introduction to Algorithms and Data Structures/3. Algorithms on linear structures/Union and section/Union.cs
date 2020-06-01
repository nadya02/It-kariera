using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_and_section_of_lists
{
    class Union
    {
        static void Main(string[] args)
        {
            List<int> l1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> l2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> union = new List<int>(l1);
            for (int i = 0; i < l2.Count; i++)
            {
                if(!union.Contains(l2[i]))
                {
                    union.Add(l2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", union));
        }
    }
}
