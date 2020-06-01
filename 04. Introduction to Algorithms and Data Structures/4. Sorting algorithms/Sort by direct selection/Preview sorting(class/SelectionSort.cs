using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preview_sorting
{
    class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Less(array[j], array[min_index]))
                    {
                        min_index = j;
                    }
                }
                Swap(array, i, min_index);
            }
        }

        private static void Swap<T>(T[] array, int from, int to)
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
            Console.WriteLine($"Swaping {from} and {to}");
            T[] swaped_array = array;
            Console.WriteLine(string.Join(" ",swaped_array));
        }

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
