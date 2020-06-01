using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch_demo
{
    class StopWatch_demo
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                result.Append(Convert.ToString(i, 2));
            }
            Console.WriteLine(result.Length);
            Console.WriteLine(timer.Elapsed);
            // със string изпълнява програмата за 11сек
            //със StringBuilder е 10 пъти по-бързо
        }
    }
}
