using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_sorting
{
    class InsertionSorting
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            InsertionSort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && Less(array[j], array[j-1]))
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        static void Swap<T>(T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
        }
    }
}
