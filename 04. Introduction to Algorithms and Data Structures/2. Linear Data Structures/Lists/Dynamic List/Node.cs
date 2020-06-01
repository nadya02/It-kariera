using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_List
{
    public class DynamicList
    {
        class Node
        {
            private object element;
            private Node next;

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node(object element, Node prevNode)//добавя елементите от 2ри нататък
            {
                this.Element = element;
                Next = null;
                prevNode.Next = this; //this - новия елемент
            }

            public Node(object element)//добавя само първия елемент
            {
                this.Element = element;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public int Count
        {
            get { return count; }
        }


        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if(Count == 0)
            {
                Node node = new Node(item);
                head = node;
                tail = node;
            }
            else
            {
                Node node = new Node(item, tail);
                tail = node;
            }
            count++;
        }

        public object Remove(int index)//трие по индекс връща стойност
        {
            if(index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(index == 0)
            {
                head = (Node)head.Next;
            }
            int current_index = 0;
            Node current = head;
            Node prev = null;
            while(current_index < index)
            {
                current_index++;
                prev = current;
                current = (Node)current.Next;
            }
            object element = current.Element;
            if(index == 0)
            {
                head = (Node)head.Next;
            }
            else
            {
                prev.Next = current.Next;
            }
            count--;
            return element;
        }

        public int Remove(object item)//трие по стойност връща индекс на изтрития елемент
        {
            Node current = head;
            int index = 0;
            while (!current.Element.Equals(item) || current != null)//
            {
                current = (Node)current.Next;
                index++;
            }
            //при сравняване на референции трябва да използваме Equals, иначе не работи
            if(current == null)
            {
                return -1;
            }
            else
            {
                Remove(index);
                return index;
            }
        }

        public int IndexOf(object item)
        {
            Node current = head;
            int index = 0;
            while (current != null && !current.Element.Equals(item))//реда на условията не трябва да се сменя
            {
                current = current.Next;
                index++;
            }
            if (current == null)
            {
                return -1;
            }
            else
            {
                return index;
            }
        }

        public bool Constains(object item)
        {
            int index = IndexOf(item);
            if(index != -1)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public object this[int index]
        {
            get
            {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                int currentIndex = 0;
                Node current = head;
                while (currentIndex < index)
                {
                    currentIndex++;
                    current = current.Next;
                }
                return current.Element;
            }
            set
            {
                if (index >= Count || index < 0) throw new ArgumentOutOfRangeException();
                int currentIndex = 0;
                Node current = head;
                while (currentIndex < index)
                {
                    currentIndex++;
                    current = current.Next;
                }
                current.Element = value;
            }
        }
    }
}
