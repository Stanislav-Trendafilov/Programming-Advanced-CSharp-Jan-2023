using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class CustomTuple<T,T1,T2>
    {
        private T item1;
        private T1 item2;
        private T2 item3;
        public T Item1 { get { return item1; } set { item1 = value; } }
        public T1 Item2 { get { return item2; } set { item2 = value; } }
        public T2 Item3 { get { return item3; } set { item3 = value; } }

       
        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
