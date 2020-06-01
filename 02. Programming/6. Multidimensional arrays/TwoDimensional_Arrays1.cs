using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensional_Arrays1
{
    class TwoDimensional_Arrays1
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());//въвеждаме брой редове
            int cols = int.Parse(Console.ReadLine());//въвеждаме брой колони
            int[,] Matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Console.Write(Matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
