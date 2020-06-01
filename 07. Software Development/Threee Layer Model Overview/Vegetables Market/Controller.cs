using System;
using System.Collections.Generic;
using System.Text;
using Vegetable_market.Model;
using Vegetable_market.Views;

namespace Vegetable_market.Controllers
{
    class Controller
    {
        private Display display;
        private Market market;
        public Controller()
        {
            display = new Display();
            market = new Market(display.VegetablePrice, display.FruitPrice, display.VegetableKilograms, display.FruitKilograms);
            display.Profit = market.CalculateProfit();
            display.Show();
        }
    }
}
