using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_order
{
    class FasterОrder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            Stopwatch timer;
            timer = new Stopwatch();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            timer.Start();
            MergeSort(array, 0, n - 1);//сортиране чрез сливане
            timer.Stop();
            Console.WriteLine("Time of Merge Sorting = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            timer.Start();
            QuickSort(array, 0, n - 1);//бързо сортиране
            timer.Stop();
            Console.WriteLine("Time of Quick Sorting = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            timer.Start();
            SelectionSort(array);//пряка селекция
            timer.Stop();
            Console.WriteLine("Time of Direct Selection Sorting = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            timer.Start();
            InsertionSort(array);//сортиране чрез вмъкване
            timer.Stop();
            Console.WriteLine("Time of Insertion Sorting = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            timer.Start();
            BubbleSort(array);//сортиране чрез метод на мехурчето
            timer.Stop();
            Console.WriteLine("Time of Bubble Sorting = {0} ms\n", timer.Elapsed.TotalMilliseconds);
        }

        private static void BubbleSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (Less(array[j + 1], array[j]))
                    {
                        Swap(array, j + 1, j);
                    }
                }
            }
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
            //   Console.WriteLine(string.Join(" ", array));
        }

        private static void Swap<T>(T[] array, int from, int to)
        {
            T temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }
    }
}
