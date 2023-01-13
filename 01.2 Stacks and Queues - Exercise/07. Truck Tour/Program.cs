using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<string>queue= new Queue<string>();
            for (int i = 0; i < petrolPumps; i++)
            {
                string pumpInfo = Console.ReadLine();
                queue.Enqueue(pumpInfo);
            }
            int br = -1;
            bool ready = false;
            while(true)
            {
                int br2 = 0;
                br++;
                int tankCapacity = 0;                
                int currentBr = br;
                while (queue.Count > 0)
                {
                    int[] info1 = queue.Peek().Split(" ").Select(int.Parse).ToArray();
                    tankCapacity += info1[0];

                    if (tankCapacity >= info1[1])
                    {
                        tankCapacity -= info1[1];
                        queue.Enqueue(queue.Dequeue());
                        br++;
                        br2++;
                        if(br2==queue.Count())
                        {
                            ready= true;
                            br = currentBr;
                            break;
                        }
                    }
                    else
                    {                     
                        break;
                    }
                }
                queue.Enqueue(queue.Dequeue());
                if (ready)
                {
                    break;
                }
               
            }
            Console.WriteLine(br);
        }
    }
}
