using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> courses = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of contests")
                {
                    break;
                }
                string[] cmdArg = command.Split(":");
                string course = cmdArg[0];
                string password = cmdArg[1];
                courses[course] = password;
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of submissions")
                {
                    break;
                }
                string[] cmdArg = command.Split("=>");
                string course = cmdArg[0];
                string password = cmdArg[1];
                string student = cmdArg[2];
                int points = int.Parse(cmdArg[3]);

                if (courses.ContainsKey(course))
                {
                    if (courses[course] == password)
                    {
                        if (!people.ContainsKey(student))
                        {
                            people[student] = new Dictionary<string, int>();
                        }
                        if (!people[student].ContainsKey(course))
                        {
                            people[student][course] = points;
                        }
                        else
                        {
                            if (people[student][course] < points)
                            {
                                people[student][course] = points;
                            }
                        }

                    }
                }
            }
            int maxPoints = 0;
            string name = string.Empty;
            foreach (var user in people)
            {
                int suma = 0;
                foreach (var course in user.Value)
                {
                    suma += course.Value;
                }
                if (maxPoints < suma)
                {
                    maxPoints = suma;
                    name = user.Key;
                }
            }
            Console.WriteLine($"Best candidate is {name} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in people.OrderBy(x=>x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var course in user.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {course.Key} -> {course.Value}");
                }
            }
        }
    }
}
