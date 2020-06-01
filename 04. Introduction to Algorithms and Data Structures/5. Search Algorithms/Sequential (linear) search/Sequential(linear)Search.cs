using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequential__linear__search
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(LinearSearch(array, key));
        }

        private static int LinearSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == key)
                {
                    return i;
                }
                
            }
            return -1;
        }
    }
}
