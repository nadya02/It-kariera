using Journey.Model;
using Journey.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Journey.Controllers
{
    class Controller
    {
        private Display display;
        private Journey_model journey;
        public Controller()
        {
            display = new Display();
            journey = new Journey_model(display.Budget, display.season);
            display.result = journey.GetJourney();
            display.ShowResult();
        }
    }
}
