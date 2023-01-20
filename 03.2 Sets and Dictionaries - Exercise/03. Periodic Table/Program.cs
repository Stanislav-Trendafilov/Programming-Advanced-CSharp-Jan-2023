using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> chemicals = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ');
                for (int j = 0; j < elements.Length; j++)
                {
                    chemicals.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ",chemicals.OrderBy(x=>x)));
        }
    }
}
