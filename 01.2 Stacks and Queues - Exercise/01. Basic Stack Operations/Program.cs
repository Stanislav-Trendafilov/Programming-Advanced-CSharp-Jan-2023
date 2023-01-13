using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]input=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[]numbers= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack=new Stack<int>(numbers);
            int S = input[1];
            int X = input[2];
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }
            
            if(stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
