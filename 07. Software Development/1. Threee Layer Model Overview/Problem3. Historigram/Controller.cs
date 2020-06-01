using Histogram.Model;
using Histogram.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Histogram.Controllers
{
    class Controller
    {
        private Display display;
        private Historigram historigram;
        public Controller()
        {
            display = new Display();
            historigram = new Historigram(display.Numbers);
            display.Percents = historigram.CalculatePercent();
            display.Show();
        }
    }
}
