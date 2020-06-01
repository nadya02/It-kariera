using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_template_method_for_counting_strings
{
    class TemplateMethodForCountingStrings
    {
        static void Main(string[] args)
        {
            List<string> boxes = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string box = Console.ReadLine();
                boxes.Add(box);
            }
            string compare = Console.ReadLine();
            Console.WriteLine(Comparer.CountBigger(boxes, compare));
        }
    }
}
