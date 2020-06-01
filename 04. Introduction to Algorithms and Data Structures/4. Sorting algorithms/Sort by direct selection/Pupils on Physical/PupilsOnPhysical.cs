using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupils_on_Physical
{
    class PupilsOnPhysical
    {
        static void Main(string[] args)
        {
            var heights = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var positions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int student1_position = positions[0];
            int student2_position = positions[1];
            SelectionSort.Sort(heights);
            Console.WriteLine(string.Join(" ", heights));
            int student1_height = 0, student2_height = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (i == student1_position - 1)
                {
                    student1_height = heights[i];
                }
                if(i == student2_position - 1)
                {
                    student2_height = heights[i];
                }
            }
            Console.WriteLine(student1_height + " " + student2_height);
        }
    }
}
