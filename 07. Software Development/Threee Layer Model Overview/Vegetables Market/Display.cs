using System;
using System.Collections.Generic;
using System.Text;

namespace Vegetable_market.Views
{
    class Display
    {
        public decimal FruitPrice { get; set; }
        public decimal VegetablePrice { get; set; }

        public int FruitKilograms { get; set; }
        public int VegetableKilograms { get; set; }
        public decimal Profit { get; set; }

        public Display()
        {
            GetValues();
        }

        private void GetValues()
        {
            Console.Write("Enter vegetables price: ");
            VegetablePrice = decimal.Parse(Console.ReadLine());
            Console.Write("Enter fruits price: ");
            FruitPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Enter vegetables kilograms: ");
            VegetableKilograms = int.Parse(Console.ReadLine());
            Console.Write("Enter fruits kilograms: ");
            FruitKilograms = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine($"Profit: {Profit}");
        }
    }
}
