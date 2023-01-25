using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> filter = s => char.IsUpper(s[0]);
            string[]text=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Where(s=>filter(s)).ToArray();
            Console.WriteLine(string.Join("\n",text));
        }
    }
}
