using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new SortedDictionary<double, int>();
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach(var item in input)
            {
                if (dic.ContainsKey(item)) dic[item]++;
                else dic[item] = 1;
            }
            foreach(var item in dic)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
