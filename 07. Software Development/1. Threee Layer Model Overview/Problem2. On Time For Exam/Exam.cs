using System;
using System.Collections.Generic;
using System.Text;

namespace On_Time_For_Exam.Model
{
    class Exam
    {
        private int examHour;
        private int examMinute;
        private int arrivalHour;
        private int arrivalMinute;

        public int ArrivalMinute
        {
            get { return arrivalMinute; }
            set { arrivalMinute = value; }
        }
        public int ArrivalHour
        {
            get { return arrivalHour; }
            set { arrivalHour = value; }
        }
        public int ExamMinute
        {
            get { return examMinute; }
            set { examMinute = value; }
        }
        public int ExamHour
        {
            get { return examHour; }
            set { examHour = value; }
        }
        public Exam(int ExamHour, int ExamMinute, int ArrivalHour, int ArrivalMinute)
        {
            this.ExamHour = ExamHour;
            this.ExamMinute = ExamMinute;
            this.ArrivalHour = ArrivalHour;
            this.ArrivalMinute = ArrivalMinute;
        }

        public string CalculateTimeDifference(int exHour, int exMinute, int arriveHour, int arriveMinute)
        {
            int timeExam = exHour*60 + exMinute;
            int timeArrival = arriveHour*60 + arriveMinute;
            string result = "";

            if(timeExam < timeArrival)
            {
                result += "Late" + Environment.NewLine;
                if((timeArrival - timeExam) < 60)
                {
                    result += $"{timeArrival - timeExam} minutes after the start";
                }
                else
                {
                    int hours = (timeArrival - timeExam) / 60;
                    int minutes = (timeArrival - timeExam) % 60;
                    if (minutes < 10)
                    {
                        result += $"{hours}:0{minutes} hours after the start";
                    }
                    else
                    {
                        result += $"{hours}:{minutes} hours after the start";
                    }
                }
            }
            else if ((timeExam - timeArrival) > 30)
            {
                result += "Early" + Environment.NewLine;
                if ((timeExam - timeArrival) < 60)
                {
                    result += $"{timeExam - timeArrival} minutes before the start";
                }
                else
                {
                    int hours = (timeExam - timeArrival) / 60;
                    int minutes = (timeExam - timeArrival) % 60;
                    if(minutes < 10)
                    {
                        result += $"{hours}:0{minutes} hours before the start";
                    }
                    else
                    {
                        result += $"{hours}:{minutes} hours before the start";
                    }
                }
            }
            else
            {
                result += "On time" + Environment.NewLine;
                if((timeExam - timeArrival) != 0)
                {
                    int minutes = (timeExam - timeArrival) % 60;
                    result += $"{minutes} minutes before the start";
                }
            }
            return result;
        }
    }
}
