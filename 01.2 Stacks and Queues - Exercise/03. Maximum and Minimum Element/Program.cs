using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[]cmdArg=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int cmdType = cmdArg[0];
                if(cmdType== 1)
                {
                    int number = cmdArg[1];
                    numbers.Push(number);
                }
                else if(cmdType== 2)
                {
                    if(numbers.Count > 0)
                    {
                        numbers.Pop();
                    }
                }
                else if(cmdType==3) 
                { 
                    if(numbers.Count > 0) 
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if(cmdType== 4)
                {
                    if(numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
