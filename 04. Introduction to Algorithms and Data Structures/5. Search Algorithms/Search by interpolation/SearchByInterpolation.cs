using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_by_interpolation
{
    class SearchByInterpolation
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(InterpolationSearch(array, key));
        }

        private static int InterpolationSearch(int[] array, int key)
        {
            int left = 0, right = array.Length - 1;
            while(left < right)
            {
                int mid = left + (key - array[left]) * (right - left) / (array[right] - array[left]);
                if (key < array[mid]) right = mid - 1;
                else if (key > array[mid]) left = mid + 1;
                else return mid;
            }
            return -1;
        }
    }
}
