using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] br = new int[65536];
            for (int i = 0; i < a.Length; i++)
            {
                br[a[i]]++;
            }
            int maxbr = 0;
            int num = 0;
            for (int i = 0; i < br.Length; i++)
            {
                if (maxbr < br[i])
                {
                    maxbr = br[i];
                    num = i;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if(br[a[i]]==maxbr)
                {
                    num = a[i];
                    break;
                }
            }
            Console.WriteLine(num);

        }
    }
}
