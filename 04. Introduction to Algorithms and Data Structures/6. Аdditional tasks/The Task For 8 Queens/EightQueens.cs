using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_queens
{
    class EightQueens
    {
        const int Size = 8;
        static bool[,] chess_board = new bool[Size, Size];
        static HashSet<int> attacked_rows = new HashSet<int>();
        static HashSet<int> attacked_columns = new HashSet<int>();
        static HashSet<int> attacked_left_diagonals = new HashSet<int>();
        static HashSet<int> attacked_right_diagonals = new HashSet<int>();
        static int solution_found = 0;

        public static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPosition(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAtackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnmarkAllAtackedPositions(int row, int col)
        {
            attacked_rows.Remove(row);
            attacked_columns.Remove(col);
            attacked_left_diagonals.Remove(col - row);
            attacked_right_diagonals.Remove(row + col);
            chess_board[row, col] = false;
        }

        private static void MarkAllAttackedPosition(int row, int col)
        {
            attacked_rows.Add(row);
            attacked_columns.Add(col);
            attacked_left_diagonals.Add(col - row);
            attacked_right_diagonals.Add(row + col);
            chess_board[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var position_occupied = attacked_rows.Contains(row) ||
                                     attacked_columns.Contains(col) ||
                                     attacked_left_diagonals.Contains(col - row) ||
                                     attacked_right_diagonals.Contains(row + col);
            return !position_occupied;
        }

        private static void PrintSolution()
        {
            solution_found++;
            Console.WriteLine(solution_found);
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if(chess_board[row, col] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
