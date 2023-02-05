using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingList
{
    internal class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] items;
        public CustomList()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get;  set; }
        public int this[int index] 
        {
            get 
            {
                ValidateIndex(index);
                return items[index];
            } 
            set 
            {
                ValidateIndex(index);
                items[index] = value; 
            } 
        
        }

       
        public void ForEach(string separator)
        {
            for (int i = 0; i < Count; i++)
            {
                if(i==Count-1)
                {
                    Console.Write(items[i]);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"{items[i]}{separator}");
                }
            }
        }
        public void Add(int item)
        {
            if(Count==items.Length)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }
        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int removedItem = items[index];
            ShiftLeft(index); 
            Count--;
            if(Count<=items.Length/4)
            {
                Shrink();
            }
            return removedItem;
        }
        public void Insert(int index,int item)
        {
            ValidateIndex(index);
            if(items.Length==Count)
            {
                Resize();
            }
            ShiftRight(index);
            items[index] = item;
            Count++;

        }
        public void Swap(int index1, int index2)
        {
            ValidateIndex(index1);
            ValidateIndex(index2);
            int swap = items[index1];
            items[index1] = items[index2];
            items[index2] = swap;
        }
        public bool Contains(int element)
        {
            if(items.Contains(element))
            { return true; }
            return false;
        }
        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        private void Resize()
        {
            int[]copy=new int[items.Length*2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items= copy;
        }
        private void ValidateIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count-1; i++)
            {
                items[i] = items[i + 1];
            }
        }
        private void ShiftRight(int index)
        {
            for (int i=Count- 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
        }
    }
}
