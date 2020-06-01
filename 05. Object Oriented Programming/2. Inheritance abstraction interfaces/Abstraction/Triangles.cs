using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class Triangles : ColoredFigures_class
    {
        public Triangles(string color, double size) : base(color, size) { }

        public override double GetArea()
        {
            double s = Size * Size * Math.Sqrt(3) / 4;
            return s;
        }

        public override string GetName()
        {
            return "Triangle: ";
        }
    }
}
