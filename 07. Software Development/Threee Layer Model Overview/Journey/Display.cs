using System;
using System.Collections.Generic;
using System.Text;

namespace Journey.Views
{
    class Display
    {
        public double Budget { get; set; }
        public string season { get; set; }
        public string[] result { get; set; }
        public Display()
        {
            GetValues();
        }
        private void GetValues()
        {
            Console.Write("Enter budget: ");
            Budget = double.Parse(Console.ReadLine());
            Console.Write("Enter season: ");
            season = Console.ReadLine();
        }

        public void ShowResult()
        {
            Console.WriteLine($"Somewhere in {result[0]}");
            Console.WriteLine($"{result[1]} - {result[2]}");
        }
    }
}
