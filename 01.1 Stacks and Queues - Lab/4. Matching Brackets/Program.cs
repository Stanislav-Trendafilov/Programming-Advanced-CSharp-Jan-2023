using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int>stack=new Stack<int>(); 
            string command=Console.ReadLine();
            for(int i=0; i<command.Length;i++)
            {
                if (command[i] =='(')
                {
                    stack.Push(i);
                }
                else if (command[i] ==')') 
                {
                   int startIndex=stack.Pop();
                    for (int j = startIndex; j <= i; j++)
                    {
                        Console.Write(command[j]);
                    }
                    Console.WriteLine( " ");
                }
            }
        }
    }
}
