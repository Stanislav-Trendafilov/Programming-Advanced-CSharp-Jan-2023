using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string[]command=Console.ReadLine().Split(' ');
            Stack<string> stack = new Stack<string>(command.Reverse());
            int suma = int.Parse(stack.Pop());
            while(stack.Count > 0) 
            {//5+6+7
               if(stack.Peek()=="+")
               {
                    stack.Pop();
                    suma += int.Parse(stack.Pop());
               }
               else if(stack.Peek()=="-") 
               { 
                    stack.Pop();
                    suma -= int.Parse(stack.Pop());
               }
            }
            Console.WriteLine(suma);
        }
    }
}
