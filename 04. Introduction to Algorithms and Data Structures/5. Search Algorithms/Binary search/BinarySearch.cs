using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(array);
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(BinarySearchRecursive(array, key, 0, array.Length - 1));
        }

        private static int BinarySearchRecursive(int[] array, int key, int left, int right)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            if (key < array[mid]) return BinarySearchRecursive(array, key, left, mid - 1);
            if (key > array[mid]) return BinarySearchRecursive(array, key, mid + 1, right);
            return mid;
        }
    }
}
