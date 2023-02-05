using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class CustomTuple<T,V>
    {
        private T item1;
        private V item2;

        public T Item1 { get { return item1; } set { item1 = value; } }
        public V Item2 { get { return item2; } set { item2 = value; } }

        public CustomTuple()
        {
            this.item1 = item1;
            this.item2 = item2;
        }
        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
