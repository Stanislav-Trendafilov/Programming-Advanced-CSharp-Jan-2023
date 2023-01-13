using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '(' || command[i] == '{' || command[i]=='[') 
                {
                    stack.Push(command[i]);
                }
                else
                {
                    if(stack.Count == 0) { isBalanced = false;break; }
                    if ((command[i] == ']' && stack.Peek() != '[') || (command[i] == '}' && stack.Peek() != '{') || (command[i] == ')' && stack.Peek() != '('))
                    {
                        isBalanced = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if(isBalanced) { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }
        }
    }
}
