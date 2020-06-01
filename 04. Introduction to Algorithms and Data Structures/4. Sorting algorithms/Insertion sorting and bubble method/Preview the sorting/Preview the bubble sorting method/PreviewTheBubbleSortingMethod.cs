using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preview_the_bubble_sorting_method
{
    class PreviewTheBubbleSortingMethod
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            BubbleSort.Sort(array);
        }
    }
}
