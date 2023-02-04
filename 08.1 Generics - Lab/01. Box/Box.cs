using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private int count;
        private List<T> list;
        public Box()
        {
            list=new List<T>();
        }
        public int Count { get { return count; } }
         
        public void Add(T item)
        {
            list.Add(item);
            count++;
        }
        public T Remove() 
        {
            var removedItem = list.Last();
            list.RemoveAt(list.Count - 1);
            count--;
            return removedItem;
        }
    }
}
