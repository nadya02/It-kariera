using System;

namespace Dynamic_List
{
    class DynamicList1
    {
        static void Main(string[] args)
        {
            DynamicList dl = new DynamicList();
            dl.Add(4);
            dl.Add(5);
            dl.Add(6);
            dl.Add(7);
            dl.Add(8);
            object t = 7;
            Console.WriteLine(dl.IndexOf(t));
           
            Console.WriteLine(dl.Remove(4));
        }
    }
}
