using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    abstract class ColoredFigures_class
    {
        public double Size{ get; set; }

        public string Color{ get; set; }

        protected ColoredFigures_class(string Color, double Size)
        {
            this.Color = Color;
            this.Size = Size;
        }

        public void Show()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Size: {Size}");
        }

        public abstract string GetName();
        public abstract double GetArea();

    }
}
