using System;
using System.Collections.Generic;

namespace _01._Reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var ch in str)
            {
                stack.Push(ch);
            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}
