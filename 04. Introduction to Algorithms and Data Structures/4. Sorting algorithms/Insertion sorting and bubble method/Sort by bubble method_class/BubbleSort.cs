using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_by_bubble_method_class
{
    class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if(Less(array[j + 1], array[j]))
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
        }

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
