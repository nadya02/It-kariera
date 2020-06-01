using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxList_Of_SameNumbers
{
    class MaxList_Of_SameNumbers
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int br=1;
            int maxbr=0;
            int number=a[0];
            for (int i = 0; i < a.Count - 1; i++)
            {
                if(a[i]==a[i+1])
                {
                    br++;
                }
                else
                {
                    if(br > maxbr)
                    {
                        maxbr = br;
                        number = a[i];
                    }
                    br = 1;
                }
            }
            if (br > maxbr)
            {
                maxbr = br;
                number = a[a.Count-1];
            }
            for (int i = 0; i < maxbr; i++)
                Console.Write(number+" ");
            Console.WriteLine();
        }
    }
}
