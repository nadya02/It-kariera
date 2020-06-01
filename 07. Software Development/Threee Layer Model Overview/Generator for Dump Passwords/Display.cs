using System;
using System.Collections.Generic;
using System.Text;

namespace Generator_for_Dump_Passwords.Views
{
    class Display
    {
        public int N { get; set; }
        public int L { get; set; }

        public List<string> passwords;
        public Display()
        {
            GetValues();
        }

        private void GetValues()
        {
            N = int.Parse(Console.ReadLine());
            L = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine(String.Join(' ', passwords));
        }
    }
}
