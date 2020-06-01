using On_Time_For_Exam.Model;
using On_Time_For_Exam.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace On_Time_For_Exam.Controllers
{
    class Controller
    {
        private Display display;
        private Exam exam;
        public Controller()
        {
            display = new Display();
            exam = new Exam(display.ExamHour, display.ExamMinute, display.ArrivalHour, display.ArrivalMinute);
            display.TimeDifference = exam.CalculateTimeDifference(display.ExamHour, display.ExamMinute, display.ArrivalHour, display.ArrivalMinute);
            display.Show();
        }
    }
}
