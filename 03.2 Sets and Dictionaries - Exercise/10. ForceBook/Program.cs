using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>>sideMembers= new Dictionary<string,List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                if(command== "Lumpawaroo")
                {
                    break;
                }
                string[] tokens2 = command.Split(new string[] { " -> "," | " }, StringSplitOptions.RemoveEmptyEntries);
                if (command.Contains("|"))
                {
                    string forceSide = tokens2[0];
                    string forceUser = tokens2[1];

                    if (!sideMembers.ContainsKey(forceSide))
                    {
                        sideMembers[forceSide] = new List<string>();
                    }
                    if (!sideMembers[forceSide].Contains(forceUser))
                    {
                        bool contains = false;
                        string side = string.Empty;
                        foreach (var item in sideMembers)
                        {
                            if(item.Value.Contains(forceUser))
                            {
                                contains=true;
                            }
                        }
                        if (!contains)
                        {
                            sideMembers[forceSide].Add(forceUser);
                        }
                    }
                }
                else
                {
                    string forceUser = tokens2[0];
                    string forceSide = tokens2[1];

                    if (!sideMembers.ContainsKey(forceSide))
                    {
                        sideMembers[forceSide] = new List<string>();                     
                    }
                    if (sideMembers.ContainsKey(forceSide))
                    {
                        bool contains = false;
                        string side = string.Empty;
                        foreach (var item in sideMembers)
                        {
                            if (item.Value.Contains(forceUser))
                            {
                                side = item.Key;
                                contains = true;
                            }
                        }                  
                        if (contains)
                        {
                            sideMembers[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                            sideMembers[side].Remove(forceUser);
                        }
                        else
                        {
                            sideMembers[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }
                }
            }
            foreach (var item in sideMembers.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    foreach (var member in item.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}
