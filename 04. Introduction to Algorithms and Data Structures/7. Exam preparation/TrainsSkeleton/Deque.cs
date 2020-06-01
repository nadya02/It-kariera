using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Skeleton
{
    public class Deque<T>
    {
        public int Capacity; //показва капацитета
        public int Count; //показва броят елементи
        private const int defaultCapacity = 16;
        private T[] array;
        
        public Deque() : this(defaultCapacity)
        {
            array = new T[defaultCapacity];
            Capacity = defaultCapacity;
            //празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
        }

        public Deque(int capacity)
        {
            array = new T[capacity];
            this.Capacity = capacity;
           //създава дека с точно зададен капацитет
        }
        
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            array = collection.ToArray();
            this.Capacity = collection.Count();
            Count = collection.Count();
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
        }

        public void AddFront(T item)
        {
            if (Count == Capacity) Resize();
            for (int i = Count; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = item;
            Count++;
            //добавя елемент отпред
        }

        private void Resize()
        {
            Array.Resize(ref array, Capacity * 2);
            Capacity = Capacity * 2;
        }

        public void AddBack(T item)
        {
            if (Count == Capacity) Resize();
            array[Count] = item;
            Count++;
            //добавя елемент отзад
        }

        public T RemoveFront()
        {
            T item = array[0];
            for (int i = 0; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Count--;
            return item;
            //връща и премахва елемента отпред
        }

        public T RemoveBack()
        {
            T item = array[Count - 1];
            Count--;
            return item;
            //връща и премахва елемента отзад
        }

        public T GetFront()
        {
            return array[0];
            //връща, без да премахва, елемента отпред
        }

        public T GetBack()
        {
            return array[Count - 1];
            //връща, без да премахва, елемента отзад
        }

    }
}
