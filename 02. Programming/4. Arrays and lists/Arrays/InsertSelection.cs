using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_selection
{
    class InsertSelection
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, -5, 1, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                int swapVar = arr[i];
                int index = i;
                while (index > 0 && arr[index - 1] >= swapVar)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = swapVar;

            }
            Console.WriteLine(string.Join(" ", arr));
    }
}
}
