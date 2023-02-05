using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingQueue
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            items = new int[InitialCapacity];
            count = 0;
        }

        public int Count { get { return count; } }
        public void Push(int item)
        {
            if(items.Length==Count)
            {
                Resize();
            }
            items[Count]=item;
            count++;

        }
        public int Pop()
        {
            if(items.Length==0 )
            {
                throw new InvalidOperationException("Stack is empty");
            } 
            int removedItem = items[count-1];
            count--;

            return removedItem;
        }
        public int Peek()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int removedItem = items[count - 1];
            return removedItem;
        }
        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentItem = items[i];
                action(currentItem);
            }
        }
        private void Resize()
        {
            int[] copy = new int[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
