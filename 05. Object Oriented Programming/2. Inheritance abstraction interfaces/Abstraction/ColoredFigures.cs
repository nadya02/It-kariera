using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colored_Figures
{
    class ColoredFigures
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string type = input[0];
                string color = input[1];
                double size = double.Parse(input[2]);
                if(type == "Triangle")
                {
                    Triangles newTriangle = new Triangles(color, size);
                    Console.WriteLine(newTriangle.GetName());
                    newTriangle.Show();
                    Console.WriteLine($"Area: {newTriangle.GetArea():f2}");
                }
                if (type == "Circle")
                {
                    Circle newCircle = new Circle(color, size);
                    Console.WriteLine(newCircle.GetName());
                    newCircle.Show();
                    Console.WriteLine($"Area: {newCircle.GetArea():f2}");
                }
                if (type == "Square")
                {
                    Square newSquare = new Square(color, size);
                    Console.WriteLine(newSquare.GetName());
                    newSquare.Show();
                    Console.WriteLine($"Area: {newSquare.GetArea():f2}");
                }
            }
        }
    }
}
