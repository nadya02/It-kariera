using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classification_of_reception
{
    class ClassificationOfReception
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SelectionSort.Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
