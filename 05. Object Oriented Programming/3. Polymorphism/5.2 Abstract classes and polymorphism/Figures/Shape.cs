using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Shape
    {
        private double perimeter;

        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }


        public virtual string Draw()
        {

        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
    }
}
