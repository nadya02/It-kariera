using System;
using System.Collections.Generic;
using System.Text;

namespace Circular_Queue
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;
        private T[] elements;
        private int startIndex = 0;
        private int endIndex = 0;

        public int Count
        {
            get;
            private set;
        }

        public CircularQueue()
        {
            elements = new T[16];
        }

        public CircularQueue(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if(Count == elements.Length)
            {
                Grow();
            }
            elements[endIndex] = element;
            endIndex = (endIndex + 1) % elements.Length;
            /*endIndex++;
             * if(endIndex == Count)endIndex = 0;
             */
            Count++;
        }

        private void Grow()
        {
            T[] new_elements = new T[elements.Length * 2];
            CopyAllElementsTo(new_elements);
            elements = new_elements;
            startIndex = 0;
            endIndex = Count;
        }

        private void CopyAllElementsTo(T[] new_elements)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                new_elements[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }

        public T Dequeue()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }
            T result = elements[startIndex];
            startIndex = (startIndex + 1) % elements.Length;
            Count--;
            return result;
        }

        public T[] ToArray()
        {
            var resultArr = new T[Count];
            CopyAllElementsTo(resultArr);
            return resultArr;
        }
    }
}
