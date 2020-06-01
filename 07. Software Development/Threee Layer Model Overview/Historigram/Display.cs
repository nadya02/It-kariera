using System;
using System.Collections.Generic;
using System.Text;

namespace Histogram.Views
{
    class Display
    {
        public int n { get; set; }
        public int[] Numbers { get; set; }

        public double[] Percents { get; set; }
        public Display()
        {
            GetValues();
        }

        private void GetValues()
        {
            n = int.Parse(Console.ReadLine());
            Numbers = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Show()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Percents[i]:f2}%");
            }
        }
    }
}
