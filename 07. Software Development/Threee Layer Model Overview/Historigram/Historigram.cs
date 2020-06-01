using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Histogram.Model
{
    class Historigram
    {
        public int[] Numbers { get; set; }

        public Historigram(int[] Numbers)
        {
            this.Numbers = Numbers;
        }
        public double[] CalculatePercent()
        {
            double[] percent = new double[5];
            int start = 0;
            for (int i = 0; i < 5; i++)
            {
                percent[i] = Numbers.Where(n => n >= start && n < start + 200).Count() * 100.0 / Numbers.Length;
                start += 200;
            }
            return percent;
        }
    }
}
