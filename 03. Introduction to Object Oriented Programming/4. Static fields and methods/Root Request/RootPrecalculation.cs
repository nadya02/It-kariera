using System;
using System.Collections.Generic;
using System.Text;

namespace Root_Request
{
    public static class RootPrecalculation
    {
        private const int MaxValue = 10000;
        private static double[] sqrtValues = new double[MaxValue + 1];

        static RootPrecalculation()
        {
            for (int i = 0; i < MaxValue; i++)
            {
                sqrtValues[i] = Math.Sqrt(i);
            }
        }

        public static double GetSqrt(int x)
        {
            return sqrtValues[x];
        }
    }
}
