using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_with_T
{
    class BoxWithT
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(5);
            box.Add(3);
            box.Add(15);
            Console.WriteLine(box.Remove());
            box.Add(45);
            box.Add(17);
            Console.WriteLine(box.Remove());
        }
    }
}
