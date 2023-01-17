using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]nums=Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            nums=nums.OrderByDescending(x => x)
                .Take(3)
                .ToArray();
            Console.WriteLine(string.Join(" ",nums));
            
        }
    }
}
