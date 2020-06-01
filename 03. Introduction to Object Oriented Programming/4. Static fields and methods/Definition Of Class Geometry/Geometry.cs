using System;
using System.Collections.Generic;
using System.Text;

namespace Definition_Of_Class_Geometry
{
    static class Geometry
    {
        public static double SquarePerimeter(double side)
        {
            return 4 * side;
        }
        
        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectanglePerimeter(double a, double b)
        {
            return a * 2 + b * 2;
        }

        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        public static double CircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}
