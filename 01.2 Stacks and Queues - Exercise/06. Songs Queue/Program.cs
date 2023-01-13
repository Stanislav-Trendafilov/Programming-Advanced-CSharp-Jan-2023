using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count > 0)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string song = string.Empty;
                    for (int i = 1; i < command.Length; i++)
                    {
                        if(i== command.Length - 1)
                        { song += command[i]; }
                        else
                        { song += command[i] + " "; }
                       
                    }
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else { songs.Enqueue(song); }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
