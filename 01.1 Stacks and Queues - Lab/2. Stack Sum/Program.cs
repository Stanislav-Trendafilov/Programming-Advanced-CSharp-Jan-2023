using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(list);
            string command = Console.ReadLine().ToLower();
            while(command!="end")
            {
                string[]cmdArg = command.Split(" ").ToArray();
                if (cmdArg[0]=="add")
                {
                    int fN = int.Parse(cmdArg[1]);
                    int sN = int.Parse(cmdArg[2]);
                    stack.Push(fN);
                    stack.Push(sN);
                }
                else if (cmdArg[0] == "remove")
                {
                    int n = int.Parse(cmdArg[1]);
                    if (n < stack.Count())
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
