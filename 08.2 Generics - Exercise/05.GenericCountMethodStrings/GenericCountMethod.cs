using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class GenericCountMethod<T>where T:IComparable<T>
    {
        private List<T> list;

        public GenericCountMethod()
        {
            list= new List<T>();
        }
        public int Compare(T value)
        {
            int count=0;
            foreach (T item in list)
            {
                if (item.CompareTo(value) == 1)
                { count++; }
            }
            return count;
        }
        public void Add(T value) 
        { 
            list.Add(value);
        }

    }
}
