using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private List<T> list;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }    
        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
    }

    public class Iterator<T> : IEnumerator<T>
    {
        private List<T> list;
        public Iterator(List<T> list)
        {
            this.list = list;
        }
        int index = 0;
        public T Current => list[index];

        object IEnumerator.Current => Current;

        public void Dispose() { }
        public bool MoveNext()
        {
            index++;
            return index < list.Count;
        }
        public void Reset()
        {
            index = -1;
        }
        public bool Move()
        {
            return MoveNext();
        }
        public void Print()
        {
            Console.WriteLine(Current);
        }
        public bool HasNext()
        {
            if (index < list.Count - 1)
            {
                return true;
            }
            return false;
        }
    }
}
