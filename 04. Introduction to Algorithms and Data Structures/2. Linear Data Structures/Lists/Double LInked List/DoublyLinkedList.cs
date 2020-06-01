using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    class DoublyLinkedList<T>:IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count
        {
            get;
            private set;
        }

        public void AddFirst(T element)
        {
            if(this.Count == 0)
            {
                this.head = new ListNode<T>(element);
                this.tail = this.head;
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.nextNode = this.head;
                this.head.prevNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.nextNode;
            }
        }
        
        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = new ListNode<T>(element);
                this.tail= this.head;
            }
            else
            {
                var newTail = new ListNode<T>(element);
                tail.nextNode = newTail;
                newTail.prevNode = tail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public T RemoveFirst()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }

            var firstElement = head.Value;

            if(Count == 1)
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

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }

            var firstElement = tail.Value;

            if (Count == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prevNode;
                tail.nextNode = null;
            }
            Count--;
            return firstElement;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            int index = 0;
            ListNode<T> current = head;
            while(current != null)
            {
                array[index] = current.Value;
                index++;
                current = current.nextNode;
            }
            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = head;
            while(currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.nextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
