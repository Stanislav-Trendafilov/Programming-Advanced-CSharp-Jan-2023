using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {//Blue -> dress,jeans,hat
                string[] cmdArg=Console.ReadLine().Split(" -> ");

                string colour = cmdArg[0];
                string[]dresses= cmdArg[1].Split(",");

                if(!clothes.ContainsKey(colour))
                {
                    clothes[colour] = new Dictionary<string, int>();
                }
                for (int j = 0; j < dresses.Length; j++)
                {
                    if (!clothes[colour].ContainsKey(dresses[j]))
                    {
                        clothes[colour][dresses[j]] = 0;
                    }
                    clothes[colour][dresses[j]]++;
                }        
            }
            string[] colorAndClothing=Console.ReadLine().Split(" ");
            foreach (var clothe in clothes)
            {
                Console.WriteLine($"{clothe.Key} clothes:");
                foreach (var dress in clothe.Value)
                {
                    Console.Write($"* {dress.Key} - {dress.Value}");
                    if (clothe.Key == colorAndClothing[0] && dress.Key == colorAndClothing[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
