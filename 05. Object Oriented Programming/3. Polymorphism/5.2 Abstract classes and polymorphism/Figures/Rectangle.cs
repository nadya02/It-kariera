using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Shape
    {
        private double sideB;
        private double sideA;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public override double CalculateArea()
        {
            return this.SideA * this.SideB;
        }


        public override double CalculatePerimeter()
        {
            return this.sideA * 2 + this.SideB * 2;
        }

        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
