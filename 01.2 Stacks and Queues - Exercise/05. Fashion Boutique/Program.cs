using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int>clothes= new Stack<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse));
            int rackSize=int.Parse(Console.ReadLine());
            int currentRackSize = rackSize;
            int numRacks = 1;
            while(clothes.Count > 0)
            {
                currentRackSize-=clothes.Peek();
                if (currentRackSize < 0)
                {
                    currentRackSize = rackSize;
                    numRacks++;
                    continue;
                }
                clothes.Pop();
            }
            Console.WriteLine(numRacks);
        }
    }
}
