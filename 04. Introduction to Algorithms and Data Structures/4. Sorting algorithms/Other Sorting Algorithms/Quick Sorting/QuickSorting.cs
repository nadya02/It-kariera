using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sorting
{
    class QuickSorting
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            Shuffle(array);
            Console.WriteLine(string.Join(" ", array));
            QuickSort(array, 0, n - 1);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void QuickSort<T>(T[] array, int left, int right) where T : IComparable
        {
            int i = left;
            int j = right;
            int midInd = (left + right) / 2;
            T mid = array[midInd];
            while (i <= j)
            {
                while (Less(array[i], mid)) i++;
                while (Less(mid, array[j])) j--;
                if (i <= j)
                {
                    Swap(array, i, j);
                    i++;
                    j--;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
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

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
