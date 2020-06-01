using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var times_first_day = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var times_second_day = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var times_both_days = times_first_day.Concat(times_second_day).ToArray();
            SelectionSort.Sort(times_both_days);
            Console.WriteLine(string.Join(" ", times_both_days));
        }
    }
}
