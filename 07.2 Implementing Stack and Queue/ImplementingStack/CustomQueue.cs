using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingQueue
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private int[] items;
        private int count;
        private const int FirstElementIndex = 0;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
            count = 0;
        }

        public int Count { get { return count; } }
        public void Enqueue(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;
            count++;

        }
        public int Dequeue()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            int removedItem = items[FirstElementIndex];
            ShiftLeft(FirstElementIndex);
            count--;
            return removedItem;
        }
        public int Peek()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            int removedItem = items[FirstElementIndex];

            return removedItem;
        }
        public void Clear()
        {
            items=new int[InitialCapacity];
            count = 0;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
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
        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count-1; i++)
            {
                items[i] = items[i + 1];
            }
        }
    }
}
