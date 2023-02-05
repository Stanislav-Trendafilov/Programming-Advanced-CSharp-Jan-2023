using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodIntegers
{
    public class GenericList<T>
    {
        private List<T> list;

        public GenericList()
        {
           this.list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }
        public void Swap(int index1,int index2) 
        { 
            T swap = list[index1];
            list[index1] = list[index2];
            list[index2] = swap;
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            foreach (T item in list) 
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }

    }
}
