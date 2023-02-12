using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake
    {
        private List<int> list;
        private List<int> even=new List<int>();
        private List<int> odd = new List<int>();
        public Lake(List<int> list)
        {
            this.list = list;
        }

        public void FindPath()
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(list[i]);
                }
                else
                {
                    odd.Add(list[i]);
                }
            }
            Console.Write(string.Join(", ", even));
            if (odd.Count > 0&&even.Count>0)
            {
                Console.Write(", ");
            }
            odd.Reverse();
            Console.Write(string.Join(", ", odd));
        }
    }
}
