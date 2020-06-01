using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
    class MergeLists
    {
        static void Main(string[] args)
        {
            List<string> a = Console.ReadLine().Split('|').ToList();
            a.Reverse();
            var b = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                var temp = a[i].Split(' ').ToList();
                for (int j = 0; j < temp.Count; j++)
                {
                    if (temp[j] != "") b.Add(int.Parse(temp[j]));
                }
            }
            for (int i = 0; i < b.Count; i++)
            {
                Console.Write(b[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
