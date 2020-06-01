using System;

namespace Circular_Queue
{
    class CircularQueue1
    {
        static void Main(string[] args)
        {
            CircularQueue<int> cq = new CircularQueue<int>();
            cq.Enqueue(4);
            cq.Enqueue(5);
            cq.Enqueue(6);
            cq.Enqueue(7);
            Console.WriteLine(cq.Count);
            Console.WriteLine(cq.Dequeue());
            Console.WriteLine(cq.Count);
            Console.WriteLine(String.Join(" ", cq.ToArray()));
        }
    }
}
