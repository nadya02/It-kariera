using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preview_the_insertion_sorting
{
    class PreviewTheInsertionSorting
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            InsertionSort(array);           
        }

        private static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && Less(array[j], array[j - 1]))
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

        static void Swap<T>(T[] array, int from, int to)
        {

            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
            Console.WriteLine($"Swaping {from} and {to}");
            T[] swaped_array = array;
            Console.WriteLine(string.Join(" ", swaped_array));
        }
    }
}

