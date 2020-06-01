using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class Square : ColoredFigures_class
    {
        public Square(string color, double size) : base(color, size) { }

        public override double GetArea()
        {
            return Size * Size;
        }

        public override string GetName()
        {
            return "Square: ";
        }
    }
}
