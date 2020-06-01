using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_inversions
{
    class NumberOfInversions
    {
        public static int br_inversion = 0;

        static void Main(string[] args)
        { 
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(br_inversion);
        }

        private static void MergeSort<T>(T[] array, int left, int right) where T : IComparable
        {
            if (right <= left)
            {
                return;
            }
            int mid = (left + right) / 2;
            //разделяне
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            //сливане
            T[] temp = new T[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (Less(array[i], array[j]))
                {
                    temp[k] = array[i];//temp[k++] = array[i++];
                    k++;
                    i++;
                }
                else
                {
                    temp[k++] = array[j++];
                    br_inversion = br_inversion + (mid - i + 1);
                }
            }
            while (i <= mid)
            {
                temp[k++] = array[i++];
            }
            while (j <= right)
            {
                temp[k++] = array[j++];
            }
            for (i = left; i <= right; i++)
            {
                array[i] = temp[i - left];
            }
        }

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        private static void Shuffle<T>(T[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int r = i + rnd.Next(array.Length - i - 1);
                Swap(array, i, r);
            }
        }

        private static void Swap<T>(T[] array, int from, int to)
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }
    }
}
