using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numsData=Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = numsData[0];
            int m = numsData[1];
            HashSet<double> nums=new HashSet<double>();
            HashSet<double> nums2 = new HashSet<double>();

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                nums.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                double num = double.Parse(Console.ReadLine());
                nums2.Add(num);
            }
             Console.WriteLine(string.Join(" ", nums.Intersect(nums2)));
        }
    }
}
