using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_an_array
{
    class SumОfАnАrray
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Sum(array, 0));
        }

        private static int Sum(int[] array, int index)
        {
            if(index == array.Length - 1)
            {
                return array[index];
            }
            return array[index] + Sum(array, index + 1);
        }
    }
}
