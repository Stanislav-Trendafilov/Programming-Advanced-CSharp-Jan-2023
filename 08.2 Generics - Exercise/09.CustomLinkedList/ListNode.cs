using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class ListNode<T>
    {
        public ListNode(T value, ListNode<T> next = null, ListNode<T> previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public T Value { get; set; }

        public ListNode<T> Next { get; set; }

        public ListNode<T> Previous { get; set; }
    }
}