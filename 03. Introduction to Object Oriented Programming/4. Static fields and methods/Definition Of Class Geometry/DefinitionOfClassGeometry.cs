using System;

namespace Definition_Of_Class_Geometry
{
    class DefinitionOfClassGeometry
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(Geometry.CircleArea(a));
            Console.WriteLine(Geometry.RectangleArea(a,b));
            Console.WriteLine(Geometry.SquareArea(a));
            Console.WriteLine(Geometry.RectanglePerimeter(a,b));
            Console.WriteLine(Geometry.SquarePerimeter(a));
        }
    }
}
