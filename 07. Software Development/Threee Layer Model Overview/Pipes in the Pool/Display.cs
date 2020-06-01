using System;
using System.Collections.Generic;
using System.Text;

namespace Pipes_in_the_Pool.Views
{
    class Display
    {
        public double Volume { get; set; }
        public double FlowRate1 { get; set; }
        public double FlowRate2 { get; set; }
        public double WorkingHours { get; set; }
        public string Result { get; set; }
        public Display()
        {
            GetValues();
        }
        private void GetValues()
        {
            Console.Write("Enter pool volume: ");
            Volume = double.Parse(Console.ReadLine());
            Console.Write("Enter flow rate for pipe 1: ");
            FlowRate1 = double.Parse(Console.ReadLine());
            Console.Write("Enter flow rate for pipe 2: ");
            FlowRate2 = double.Parse(Console.ReadLine());
            Console.Write("Enter pipes working hours: ");
            WorkingHours = double.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine(Result);
        }
    }
}
