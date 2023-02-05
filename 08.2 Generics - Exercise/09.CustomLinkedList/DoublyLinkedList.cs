using CustomDoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public int Count { get; set; }
        public void AddFirst(T value)
        {
            ListNode<T> node = new ListNode<T>(value);
            Count++;
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Next = Head;
            Head = node;
            node.Next.Previous = node;
        }
        public void AddLast(T value)
        {
            ListNode<T> node = new ListNode<T>(value);
            Count++;
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Previous = Tail;
            Tail = node;
            node.Previous.Next = node;

        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            ListNode<T> oldHead = Head;
            Head = oldHead.Next;
            if (Head != null)
            {
                Head.Previous = null;
            }
            else
            {
                Tail = null;
            }
            Count--;
            return oldHead.Value;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            ListNode<T> oldTail = Tail;
            Tail = oldTail.Previous;
            if (Tail != null)
            {
                Tail.Next = null;
            }
            else
            {
                Head = null;
            }
            Count--;
            return oldTail.Value;
        }
        public void ForEach(Action<T> callback)
        {
            ListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                callback(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            int ind = 0;
            ForEach(e => array[ind++] = e);
            return array;
        }
    }
}