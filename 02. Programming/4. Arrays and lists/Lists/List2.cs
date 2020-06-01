using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 10, 20, 30, 40, 50, 60 };
            num.RemoveAt(2);//премахва елемента на втора позиция
            num.Add(100);
            num.Insert(0, -100);//на нулева позиция добавя -100
            Console.WriteLine(String.Join(" ",num));
        }
    }
}
