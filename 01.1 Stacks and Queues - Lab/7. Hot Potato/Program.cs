using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(" ");
            Queue<string> queue = new Queue<string>(children);
            int n = int.Parse(Console.ReadLine());
            while(queue.Count>1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    string name = queue.Dequeue();
                    queue.Enqueue(name);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
