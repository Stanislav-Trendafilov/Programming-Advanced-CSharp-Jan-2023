using System;
using System.Collections.Generic;
using System.Drawing;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            Queue<string> queue = new Queue<string>();  
            while(command!="End")
            {
                if (command != "Paid")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    while(queue.Count > 0) 
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                command= Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
