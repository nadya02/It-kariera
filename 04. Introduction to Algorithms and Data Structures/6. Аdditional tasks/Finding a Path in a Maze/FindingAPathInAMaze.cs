using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_a_Path_in_a_Maze
{
    class FindingAPathInAMaze
    {
        static void Main(string[] args)
        {
            lab = ReadLab();
            FindPaths(0, 0, 'S');//"S" добавяме защото ни трябва трети параметър
        }

        static List<char> path = new List<char>();
        static int n, m;
        static char[,] lab;
 

        private static void FindPaths(int row, int col, char direction)
        {
            if(!IsInBounds(row, col))
            {
                return;
            }
            path.Add(direction);
            if (IsExit(row, col))
            {
                PrintPath();
            }
            else if(!IsVisited(row, col) && IsFree(row, col))
            {
                Mark(row, col);
                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row - 1, col, 'U');
                Unmark(row, col);
            }
            path.RemoveAt(path.Count - 1);
        }

        private static bool IsInBounds(int row, int col)
        {
            return (row >= 0) && (col >= 0) &&
                   (row < n) && (col < m);
        }

        private static bool IsExit(int row, int col)
        {
            return lab[row, col] == 'e';
        }

        private static void PrintPath()
        {
            Console.WriteLine(string.Join("", path.Skip(1)));
        }

        private static bool IsFree(int row, int col)
        {
            return lab[row, col] == '-';
        }

        private static bool IsVisited(int row, int col)
        {
            return lab[row, col] == 'v';
        }

        private static void Unmark(int row, int col)
        {
            lab[row, col] = '-';
        }

        private static void Mark(int row, int col)
        {
            lab[row, col] = 'v';
        }

        private static char[,] ReadLab()
        {
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            lab = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().ToArray();
                for (int j = 0; j < m; j++)
                {
                    lab[i, j] = line[j];
                }
            }
            return lab;
        }
    }
}
