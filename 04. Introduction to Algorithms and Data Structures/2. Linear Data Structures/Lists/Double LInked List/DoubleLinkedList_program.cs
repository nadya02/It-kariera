using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    class DoubleLinkedList_program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(5);
            dll.AddFirst(4);
            dll.AddFirst(7);
            dll.AddLast(2);
            dll.AddLast(11);
            dll.ForEach(Console.WriteLine);
            dll.RemoveFirst();
            Console.WriteLine(String.Join(" ", dll.ToArray()));
            dll.RemoveLast();
            Console.WriteLine(String.Join(" ", dll.ToArray()));
        }
    }
}
