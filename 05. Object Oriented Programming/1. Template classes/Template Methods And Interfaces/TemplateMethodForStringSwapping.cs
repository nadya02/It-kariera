using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_template_method_for_string_swapping
{
    class TemplateMethodForStringSwapping
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

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(boxes, indexes[0], indexes[1]);
            foreach(var item in boxes)
            {
                Console.WriteLine($"{item.GetType().FullName} : {item}");
            }
        }

        public static List<T> Swap<T>(List<T> boxes, int index1, int index2)
        {
            T temp = boxes[index1];
            boxes[index1] = boxes[index2];
            boxes[index2] = temp;
            return boxes;
        }
    }
}
