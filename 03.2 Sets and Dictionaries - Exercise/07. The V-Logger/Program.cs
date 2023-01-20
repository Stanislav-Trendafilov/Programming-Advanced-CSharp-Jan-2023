using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string,List<string>>vlogers=new Dictionary<string, List<string>>();
            string command=Console.ReadLine();
            while(command!= "Statistics")
            {
                string[]cmdArg=command.Split(' ');
                string cmdType = cmdArg[1];
                string vloger = cmdArg[0];
                if(cmdType== "joined")
                {
                    if (!vlogers.ContainsKey(vloger))
                    {
                        vlogers[vloger] = new List<string>();
                        vlogers[vloger].Add("0");
                    }
                }
                else if(cmdType== "followed")
                {
                    string vloger2 = cmdArg[2];
                    if (vlogers.ContainsKey(vloger) && vlogers.ContainsKey(vloger2))
                    {
                        if (!vlogers[vloger2].Contains(vloger) && vloger2 != vloger)
                        {
                            vlogers[vloger2].Add(vloger);
                            int following = int.Parse(vlogers[vloger][0]) + 1;
                            vlogers[vloger][0] = following.ToString();
                        }
                    }
                    
                }

                command= Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            int number = 1;
            foreach (var vloger in vlogers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{number}. {vloger.Key} : {vloger.Value.Count - 1} followers, {vloger.Value[0]} following");
                if (number == 1)
                {
                    foreach (var followers in vloger.Value.Skip(1).OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }
                number++;
            }
        }
    }
}
