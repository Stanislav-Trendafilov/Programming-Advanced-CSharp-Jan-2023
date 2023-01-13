using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            int S = input[1];
            int X = input[2];
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            if(queue.Count == 0) 
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
