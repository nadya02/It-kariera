using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class ArrayStack<T>
    {
        private T[] elements;
        private const int InitialCapacity = 16;
        
        public int Count
        {
            get;
            private set;
        }

        public ArrayStack(int capacity = InitialCapacity)
        {
            elements = new T[capacity];
        }
        
        public void Push(T element)
        {
            if(Count == elements.Length)
            {
                Grow();
            }
            else
            {
                elements[Count] = element;
                Count++;
            }
        }

        public T Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                T element = elements[Count - 1];
                Count--;
                return element;
            }
        }

        public T[] ToArray()
        {
            var newElements = new T[Count];
            Array.Copy(elements, newElements, Count);
            newElements = newElements.Reverse().ToArray();
            return newElements;
        }

        private void Grow()
        {
            Array.Resize(ref elements, elements.Length * 2);
        }
    }
}
