using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Array_List
{
    class RandomArrayList
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            var input = Console.ReadLine().Split();
            foreach (var item in input)
            {
                randomList.Add(item);
            }
            Console.WriteLine(randomList.Count);
            Console.WriteLine(randomList.RandomElement());
            Console.WriteLine(randomList.Count);
        }
    }
}
