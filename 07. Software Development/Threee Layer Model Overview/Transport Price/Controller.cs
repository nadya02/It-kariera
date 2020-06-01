using System;
using System.Collections.Generic;
using System.Text;
using Transport_Price.Model;
using Transport_Price.Views;

namespace Transport_Price.Controllers
{
    public class Controller
    {
        private Vehicle vehicle;
        private Display display;

        public Controller()
        {
            display = new Display();
            if(display.Distance < 20)
            {
                vehicle = new Taxi();
            }
            else if(display.Distance < 100)
            {
                vehicle = new Bus();
            }
            else
            {
                vehicle = new Train();
            }
            display.Price = vehicle.CalculatePrice(display.Distance, display.Tariff);
            display.Show();
        }
    }
}
