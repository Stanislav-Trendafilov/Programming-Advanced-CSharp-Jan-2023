using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class LinkedListSoftuni
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Count { get; set; }
        public void AddFirst(int value)
        {
            Node node = new Node(value);
            Count++;
            if (Head==null)
            {
                Head = node;
                Tail= node;
                return;
            }
            node.Next = Head;
            Head = node;
            node.Next.Previous = node;
        }
        public void AddLast(int value)
        {
            Node node = new Node(value);
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
        public void RemoveFirst()
        {
            Node currentHead = Head;
            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
                Count = 0;
                return;
            }
            Head=currentHead.Next;
            currentHead.Next = null;
            Head.Previous = null;
            Count--;
        }
        public void RemoveLast()
        {
            Node currentTail = Tail;
            if (Tail.Previous== null)
            {
                Head = null;
                Tail = null;
                Count=0;
                return;
            }
            Tail=currentTail.Previous;
            currentTail.Previous = null;
            Tail.Next = null;
            Count--;
        }
        public void ForEach(Action<int>callback)
        {
            Node currentNode=Head;
            while (currentNode != null)
            {
                callback(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public int[] ToArray()
        {
            int[]array = new int[Count];
            int ind = 0;
            ForEach(e => array[ind++] = e);
            return array;
        }
    }
}
