using Generator_for_Dump_Passwords.Model;
using Generator_for_Dump_Passwords.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generator_for_Dump_Passwords.Controllers
{
    class Controller
    {
        private Display display = new Display();
        private Generator generator = new Generator();

        public void Start()
        {
            generator.N = display.N;
            generator.L = display.L;
            generator.GeneratePasswords();
            display.passwords = generator.passwords;
            display.Show();
        }
    }
}
