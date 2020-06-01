using Division_without_residue.Model;
using Division_without_residue.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Division_without_residue.Controllers
{
    class Controller
    {
        private Display display;
        private Division division;
        public Controller()
        {
            display = new Display();
            division = new Division(display.Numbers);
            display.percents = division.GetPercents();
            display.ShowPercents();
        }
    }
}
