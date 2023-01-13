using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            StringBuilder stringBuilder= new StringBuilder();
            Stack<string> operations = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] commandArg = Console.ReadLine().Split(" ").ToArray();
                string cmdType = commandArg[0];
                if(cmdType=="1")
                {
                    string someText = commandArg[1];
                    operations.Push(stringBuilder.ToString());
                    stringBuilder.Append(someText);
                }
                else if(cmdType=="2")
                {
                    int count = int.Parse(commandArg[1]);
                    string textBeforeOperation=stringBuilder.ToString();
                    operations.Push(textBeforeOperation);
                    stringBuilder = stringBuilder.Remove(stringBuilder.Length - count, count);
                }
                else if(cmdType=="3")
                {
                    int index = int.Parse(commandArg[1]);
                    Console.WriteLine(stringBuilder[index-1]);
                }
                else if(cmdType=="4")
                {
                    
                    stringBuilder.Remove(0,stringBuilder.Length);
                    stringBuilder.Append(operations.Peek().ToString());
                    operations.Pop();
                }
            }
        }
    }
}
