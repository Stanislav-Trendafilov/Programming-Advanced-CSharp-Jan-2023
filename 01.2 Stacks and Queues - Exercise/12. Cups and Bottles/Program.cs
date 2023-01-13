using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups= new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;
            int currentCup = 0;
            while(bottles.Any()&&cups.Any()) 
            {
                currentCup = cups.Peek();
                while (currentCup > 0&bottles.Any())
                {                    
                    if (bottles.Peek() >= currentCup)
                    {
                        wastedWater += bottles.Pop() - currentCup;
                        currentCup = 0;
                        cups.Dequeue();
                    }
                    else
                    {
                        currentCup-=bottles.Pop();
                    }
                }

                if(cups.Count()== 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }
                else if(bottles.Count()== 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }
                
            }
        }
    }
}
