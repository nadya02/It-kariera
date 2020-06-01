using System;
using System.Collections.Generic;
using System.Text;

namespace Pipes_in_the_Pool.Model
{
    class Pool
    {
        private double volume;
        private double flowRate1;
        private double flowRate2;
        private double workingHours;
        public double WorkingHours
        {
            get { return workingHours; }
            set { workingHours = value; }
        }
        public double FlowRate2
        {
            get { return flowRate2; }
            set { flowRate2 = value; }
        }
        public double FlowRate1
        {
            get { return flowRate1; }
            set { flowRate1 = value; }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        public Pool(double volume, double flowRate1, double flowRate2, double workingHours)
        {
            this.volume = volume;
            this.flowRate1 = flowRate1;
            this.flowRate2 = flowRate2;
            this.workingHours = workingHours;
        }

        public string GetResult()
        {
            string result = "";
            double volumePipe1 = FlowRate1 * WorkingHours;
            double volumePipe2 = FlowRate2 * WorkingHours;
            double sumPipe1_2 = volumePipe1 + volumePipe2;
            if (Volume > sumPipe1_2)
            {
                result += $"The pool is {CalculatePercents(sumPipe1_2, Volume)}% full.";
                result += $" Pipe 1: {CalculatePercents(volumePipe1, sumPipe1_2)}%. Pipe 2: {CalculatePercents(volumePipe2, sumPipe1_2)}%.";
            }
            else
            {
                result += $"For {WorkingHours} hours the pool overflows with {sumPipe1_2 - Volume} liters.";
            }
            return result;
        }

        private double CalculatePercents(double x, double v)
        {
            double y = x / v;
            return Math.Round(y * 100);
        }
    }
}
