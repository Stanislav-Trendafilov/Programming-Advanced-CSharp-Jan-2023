using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(' ');
                string continent = cmdArg[0];
                string country = cmdArg[1];
                string city = cmdArg[2];
                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new List<string>();
                }
                continents[continent][country].Add(city);
            }
            foreach (var item in continents)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine($"  {item1.Key} -> {string.Join(", ", item1.Value)}");
                }
            }
        }
    }
}
