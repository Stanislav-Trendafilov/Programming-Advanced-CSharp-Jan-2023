using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            while(true)
            {
                string command=Console.ReadLine();
                if(command == "Revision")
                {
                    break;
                }
                string[]cmdArg= command.Split(", ");
                if (!shops.ContainsKey(cmdArg[0]))
                {
                    shops[cmdArg[0]]= new Dictionary<string, double>();
                }
                shops[cmdArg[0]][cmdArg[1]] = double.Parse(cmdArg[2]);
            }
            foreach (var item in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine($"Product: {item1.Key}, Price: {item1.Value}");
                }
            }
        }
    }
}
