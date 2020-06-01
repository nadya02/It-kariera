using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preview_the_bubble_sorting_method
{
    class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (Less(array[j + 1], array[j]))
                    {
                        Swap(array, j + 1, j);
                    }
                }
            }
        }

        private static void Swap<T>(T[] array, int from, int to)
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
            Console.WriteLine($"Swaping {from} and {to}");
            T[] swaped_array = array;
            Console.WriteLine(string.Join(" ", swaped_array));
        }

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
