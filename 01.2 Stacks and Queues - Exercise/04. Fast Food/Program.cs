using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity=int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Console.WriteLine(queue.Max());
            while(queue.Count > 0)
            {
                quantity-=queue.Peek();
                if(quantity<0)
                {
                    break;
                }
                queue.Dequeue();
            }
            if(queue.Count == 0) 
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
            }

        }
    }
}
