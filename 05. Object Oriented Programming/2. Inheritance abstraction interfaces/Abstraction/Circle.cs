using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class Circle : ColoredFigures_class
    {
        public Circle(string color, double size) : base(color, size) { }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Size, 2);
        }

        public override string GetName()
        {
            return "Circle: ";
        }
    }
}
