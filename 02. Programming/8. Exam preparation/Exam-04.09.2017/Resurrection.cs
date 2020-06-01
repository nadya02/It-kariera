using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal body_width;
            decimal years;
            int body_length;
            int wing_length;
            for (int i = 0; i < n; i++)
            {
                body_length = int.Parse(Console.ReadLine());
                body_width = decimal.Parse(Console.ReadLine());
                wing_length = int.Parse(Console.ReadLine());
                years = body_length * body_length * (body_width + 2 * wing_length);
                Console.WriteLine(years);
            }
        }
    }
}
