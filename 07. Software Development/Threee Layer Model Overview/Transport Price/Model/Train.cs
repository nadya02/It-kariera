using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Price.Model
{
    public class Train : Vehicle
    {
        private const decimal rate = 0.06m;
        public Train() : base(rate, rate)
        {
        }
    }
}
