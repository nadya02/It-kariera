using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_scales
{
    class UniversalScales
    {
        static void Main(string[] args)
        {
            Scale<char> scale = new Scale<char>('a', 'h');
            Console.WriteLine(scale.GetHeavier());
        }
    }
}
