using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> stack;
        public CustomStack(List<T>list)
        {
            list.Reverse();
            this.stack = list;
        }

        public void Push(T item)
        {
            stack.Insert(0,item);
        }
        public void Pop()
        {
            if(stack.Count== 0)
            {
                Console.WriteLine("No elements");
                return;
            }
            stack.RemoveAt(0);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in stack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();      
    }
}
