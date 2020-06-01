using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_by_bubble_method_class
{
    class SortByBubbleMethod_class
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            BubbleSort.Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
