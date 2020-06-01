using System;
using System.Collections.Generic;
using System.Text;

namespace Division_without_residue.Model
{
    class Division
    {
        private int[] numbers;
        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public Division(int[] numbers)
        {
            this.numbers = numbers;
        }

        public double[] GetPercents()
        {
            double[] percents = new double[3];
            int br2 = 0;
            int br3 = 0;
            int br4 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    br2++;
                }
                if(numbers[i] % 3 == 0)
                {
                    br3++;
                }
               if(numbers[i] % 4 == 0)
                {
                    br4++;
                }
            }
            percents[0] = (double)br2 / numbers.Length * 100;
            percents[1] = (double)br3 / numbers.Length * 100;
            percents[2] = (double)br4 / numbers.Length * 100;
            return percents;
        }
    }
}
