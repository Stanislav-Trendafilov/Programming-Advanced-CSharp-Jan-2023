using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(arr);
            int br = 0;
            while(queue.Count > 0) 
            {
                if(queue.Peek()%2==0)
                {
                    if (br != 0)
                    { Console.Write($", {queue.Dequeue()}"); }
                    else
                    {
                        Console.Write($"{queue.Dequeue()}");
                        br++;
                    }
                }
                else
                {
                    queue.Dequeue() ;
                }

            }
        }
    }
}
