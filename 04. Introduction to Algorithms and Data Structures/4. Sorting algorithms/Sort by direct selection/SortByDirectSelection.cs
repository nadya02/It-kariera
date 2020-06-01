using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_by_direct_selection
{
    class SortByDirectSelection
    {
        
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SelectionSort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index_min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Less(array[j], array[index_min]))
                    {
                        index_min = j;
                    }
                }
                Swap(array, i, index_min);
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

