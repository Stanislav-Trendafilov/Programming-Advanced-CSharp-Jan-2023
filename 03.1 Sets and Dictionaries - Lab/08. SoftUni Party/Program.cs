using System;
using System.Collections.Generic;
using System.Data;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> Vips = new HashSet<string>();
            while (true)
            {
                string command=Console.ReadLine();
                if(command=="PARTY")
                {
                    break;
                }
                if (char.IsDigit(command[0]))
                {
                    Vips.Add(command);
                }
                else
                {
                    regular.Add(command);
                }

            }
            while (true)
            {
                string command=Console.ReadLine();
                if(command=="END")
                {
                    break;
                }
                if(regular.Contains(command))
                {
                    regular.Remove(command);
                }
                else if(Vips.Contains(command))
                {
                    Vips.Remove(command);
                }

            }
            Console.WriteLine(Vips.Count+regular.Count);
            foreach (var person in Vips)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regular)
            {
                Console.WriteLine(person);
            }
        }
    }
}
