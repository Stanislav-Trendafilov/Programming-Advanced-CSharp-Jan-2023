using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,int>symbols = new Dictionary<char,int>();
            string text=Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols[text[i]] = 0;
                }
                symbols[text[i]]++;
            }
            foreach (var symbol in symbols.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
