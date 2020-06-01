using System;
using System.Collections.Generic;
using System.Text;

namespace Transport_Price.Views
{
    public class Display
    {
        public int Distance { get; set; }
        public string Tariff { get; set; }
        public decimal Price { get; set; }

        public Display()
        {
            GetValues();
        }
        private void GetValues()
        {
            Console.Write("Enter distance: ");
            Distance = int.Parse(Console.ReadLine());
            Console.Write("Enter tariff: ");
            Tariff = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine($"Your price: {Price:C}");
        }
    }
}
