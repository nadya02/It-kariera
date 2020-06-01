using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Price.Model
{
    public class Taxi : Vehicle
    {
        private const decimal dayRate = 0.79m;
        private const decimal nightRate = 0.90m;
        private const decimal startRate = 0.70m;
        public Taxi() : base(dayRate, nightRate)
        {
        }
        public override decimal CalculatePrice(decimal distance, string DayorNight)
        {
            return base.CalculatePrice(distance, DayorNight) + startRate;
        }
    }
}
