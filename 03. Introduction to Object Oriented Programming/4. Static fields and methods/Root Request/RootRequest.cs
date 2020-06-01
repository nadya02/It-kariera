using System;

namespace Root_Request
{
    class RootRequest
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(RootPrecalculation.GetSqrt(int.Parse(Console.ReadLine())));
            }
        }
    }
}
