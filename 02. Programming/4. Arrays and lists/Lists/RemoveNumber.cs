using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNumber
{
    class RemoveNumber
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int nums = a[a.Count-1];
            for (int i = a.Count-1; i >=0 ; i--) 
            {
                if(a[i]==nums)
                {
                    a.RemoveAt(i);
                }
            }          
            Console.WriteLine(String.Join(" ",a));
        }
    }
}
