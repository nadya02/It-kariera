using System;
using System.Collections.Generic;
using System.Text;

namespace Vegetable_market.Model
{
    class Market
    {
        private decimal vegetablesPrice;
        private decimal fruitsPrice;
        private int vegetablesKilograms;
        private int fruitsKilograms;
        public int FruitsKilograms
        {
            get { return fruitsKilograms; }
            set { fruitsKilograms = value; }
        }
        public int VegetablesKilograms
        {
            get { return vegetablesKilograms; }
            set { vegetablesKilograms = value; }
        }
        public decimal FruitsPrice
        {
            get { return fruitsPrice; }
            set { fruitsPrice = value; }
        }
        public decimal VegetablesPrice
        {
            get { return vegetablesPrice; }
            set { vegetablesPrice = value; }
        }
        public Market(decimal vegetablesPrice, decimal fruitsPrice, int vegetablesKilograms, int fruitsKilograms)
        {
            this.vegetablesPrice = vegetablesPrice;
            this.fruitsPrice = fruitsPrice;
            this.vegetablesKilograms = vegetablesKilograms;
            this.fruitsKilograms = fruitsKilograms;
        }

        public decimal CalculateProfit()
        {
            decimal profit = FruitsPrice * FruitsKilograms + VegetablesPrice * VegetablesKilograms;
            return LvIntoEvro(profit);
        }

        private decimal LvIntoEvro(decimal profit)
        {
            return profit / 1.94m;
        }
    }
}
