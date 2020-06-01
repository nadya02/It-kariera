using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оdd__еncounters
{
    class Odd_encounters
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            var input = Console.ReadLine().ToLower().Split().ToArray();
            foreach(var item in input)
            {
                if (dic.ContainsKey(item)) dic[item]++;
                else dic[item] = 1;
            }
            List<string> result = new List<string>();
            foreach(var item in dic)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }           
            }
            Console.WriteLine(String.Join(", ",result));
        }
    }
}
