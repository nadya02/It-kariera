using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classification_of_reception
{
    class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int max_index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (!Less(array[j], array[max_index]))
                    {
                        max_index = j;
                    }
                }
                Swap(array, i, max_index);
            }
        }

        private static void Swap<T>(T[] array, int from, int to)
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
