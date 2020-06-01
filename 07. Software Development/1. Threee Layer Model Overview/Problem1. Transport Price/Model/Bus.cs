using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Price.Model
{
    public class Bus : Vehicle
    {
        private const decimal rate = 0.09m;
        public Bus() : base(rate, rate)
        {
        }
    }
}
