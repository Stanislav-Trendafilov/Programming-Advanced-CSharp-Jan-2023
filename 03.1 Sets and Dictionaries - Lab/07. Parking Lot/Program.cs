using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            while (true)
            {
                string command=Console.ReadLine();
                if(command=="END")
                {
                    break;
                }
                string[]cmdArg= command.Split(", ");
                if (cmdArg[0] == "IN" ) 
                {
                    set.Add(cmdArg[1]);
                }
                else
                {
                    set.Remove(cmdArg[1]);
                }

            }
            if (set.Count > 0)
            {
                foreach (var car in set)
                {
                    Console.WriteLine(car);
                }
            }
            else
            { Console.WriteLine("Parking Lot is Empty"); }
        }
    }
}
