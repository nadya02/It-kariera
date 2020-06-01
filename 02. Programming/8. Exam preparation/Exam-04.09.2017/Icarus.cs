using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Icarus
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int dimensionLength = dimension.Length;
            int initialIndex = int.Parse(Console.ReadLine());
            string input;
            int damage = 1;
            while ((input = Console.ReadLine()) != "Supernova")
            {
                var splitInput = input.Split();
                string directions = splitInput[0];
                int steps = int.Parse(splitInput[1]);
                if (directions == "left")
                {
                    for (int j = 1; j <= steps; j++)
                    {
                        initialIndex--;
                        if(initialIndex == -1)
                        {
                            initialIndex = dimensionLength - 1;
                            damage++;
                        }
                        dimension[initialIndex] = dimension[initialIndex] - damage;
                    }
                }
                if (directions == "right")
                {
                    for (int j = 1; j <= steps; j++)
                    {
                        initialIndex++;
                        if (initialIndex == dimensionLength)
                        {
                            initialIndex = 0;
                            damage++;
                        }
                        dimension[initialIndex] = dimension[initialIndex] - damage;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", dimension));
        }
    }
}
