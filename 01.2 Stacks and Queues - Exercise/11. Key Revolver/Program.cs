using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());
            Stack<int>bullets=new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> locker = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int value=int.Parse(Console.ReadLine());

            int bulletsCount=bullets.Count;
            bool noMore = false;

            while(locker.Count > 0)
            {
                for (int i = 1; i <= sizeBarrel; i++)
                {
                    if(bullets.Peek()<=locker.Peek())
                    {
                        bullets.Pop();
                        locker.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                        bullets.Pop() ;
                    }
                    if(i==sizeBarrel&&bullets.Count>0)
                    { 
                        Console.WriteLine("Reloading!"); 
                    }
                    if (locker.Count == 0)
                    {
                        Console.WriteLine($"{bullets.Count} bullets left. Earned ${value - (bulletsCount - bullets.Count) * pricePerBullet}");
                        break;                                        
                    }
                    else if(bullets.Count==0)
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locker.Count}");
                        noMore= true;
                        break;
                    }
                }
                if(noMore) 
                { break; }           
            }

        }
    }
}
