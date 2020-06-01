using System;
using System.Collections.Generic;
using System.Text;

namespace On_Time_For_Exam.Views
{
    class Display
    {
        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ArrivalHour { get; set; }
        public int ArrivalMinute { get; set; }

        public string TimeDifference { get; set; }
        public Display()
        {
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("Enter exam hour: ");
            ExamHour = int.Parse(Console.ReadLine());
            Console.Write("Enter exam minute: ");
            ExamMinute = int.Parse(Console.ReadLine());
            Console.Write("Enter arrival hour: ");
            ArrivalHour = int.Parse(Console.ReadLine());
            Console.Write("Enter arrival minute: ");
            ArrivalMinute = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine(TimeDifference);
        }
    }
}
