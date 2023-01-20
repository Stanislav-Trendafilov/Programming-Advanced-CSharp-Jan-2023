using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string,int>();
            Dictionary<string, int> courses = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();
                if(command== "exam finished") 
                {
                    break;
                }
                string[] cmdArg=command.Split('-');
                string username = cmdArg[0];
                string cmdType = cmdArg[1];
                int points = 0;
                if (cmdArg.Length > 2)
                {
                    points = int.Parse(cmdArg[2]);
                }
                if(cmdType=="banned")
                {
                    if (students.ContainsKey(username))
                    {
                        students.Remove(username);
                    }
                }
                else
                {
                    if (!students.ContainsKey(username))
                    {
                        students[username] = points;
                    }
                    else
                    {
                        if (students[username] < points) 
                        {
                            students[username] = points;
                        }
                    }
                    if (!courses.ContainsKey(cmdType))
                    {
                        courses[cmdType]=0;
                    }
                    courses[cmdType]++;
                }
            }
            Console.WriteLine("Results:");
            foreach (var student in students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var course in courses.OrderByDescending(x=>x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{course.Key} - {course.Value}");
            }
        }
    }
}
