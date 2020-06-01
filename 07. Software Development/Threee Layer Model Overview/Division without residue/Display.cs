using System;
using System.Collections.Generic;
using System.Text;

namespace Division_without_residue.Views
{
    class Display
    {
        public int N { get; set; }
        public int[] Numbers { get; set; }
        public double[] percents { get; set; }
        public Display()
        {
            GetValues();
        }
        private void GetValues()
        {
            Console.Write("Enter numbers count: ");
            N = int.Parse(Console.ReadLine());
            Numbers = new int[N];
            Console.WriteLine("Enter numbers: ");
            for (int i = 0; i < N; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        public void ShowPercents()
        {
            Console.WriteLine($"{percents[0]:f2}%");
            Console.WriteLine($"{percents[1]:f2}%");
            Console.WriteLine($"{percents[2]:f2}%");
        }
    }
}
