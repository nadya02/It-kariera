using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Price.Model
{
    public abstract class Vehicle
    {
        private decimal dayRate;
        private decimal nightRate;

        public decimal NightRate
        {
            get { return nightRate; }
            set { nightRate = value; }
        }
        public decimal DayRate
        {
            get { return dayRate; }
            set { dayRate = value; }
        }
        public Vehicle(decimal dayRate, decimal nightRate)
        {
            this.DayRate = dayRate;
            this.NightRate = nightRate;
        }

        public virtual decimal CalculatePrice(decimal distance, string DayorNight)
        {
            decimal price = 0;
            if(DayorNight == "day")
            {
                price = distance * dayRate;
            }
            else
            {
                if(DayorNight == "night")
                {
                    price = distance * nightRate;
                }
            }
            return price;
        }
    }
}
