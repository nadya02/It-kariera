using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace re_inovoicing_the_code
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, volume = 0,height;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            volume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
