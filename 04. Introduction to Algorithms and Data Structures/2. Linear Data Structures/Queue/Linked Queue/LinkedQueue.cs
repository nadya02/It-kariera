using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LinkedQueue<T>
{
    private QueueNode<T> head;
    private QueueNode<T> tail;

    public int Count
    {
        get;
        private set;
    }

    public void Eneque(T element)
    {
        if (this.Count == 0)
        {
            this.head = new QueueNode<T>(element);
            this.tail = this.head;
        }
        else
        {
            var newTail = new QueueNode<T>(element);
            tail.nextNode = newTail;
            newTail.prevNode = tail;
            this.tail = newTail;
        }
        this.Count++;
    }

    public T Deque()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("List empty");
        }

        var firstElement = head.Value;

        if (Count == 1)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.nextNode;
            head.prevNode = null;
        }
        Count--;
        return firstElement;
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];
        int index = 0;
        QueueNode<T> current = head;
        while (current != null)
        {
            array[index] = current.Value;
            index++;
            current = current.nextNode;
        }
        return array;
    }

    private class QueueNode<T>
    {
        public T Value
        {
            get;
            private set;
        }

        public QueueNode<T> nextNode { get; set; }
        public QueueNode<T> prevNode { get; set; }

        public QueueNode(T value)
        {
            this.Value = value;
        }
    }
}

