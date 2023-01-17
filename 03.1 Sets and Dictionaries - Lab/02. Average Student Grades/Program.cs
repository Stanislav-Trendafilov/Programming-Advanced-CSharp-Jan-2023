using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>>students=new Dictionary<string,List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[]cmdArg=Console.ReadLine().Split(' ');   
                string student = cmdArg[0];
               decimal grade = decimal.Parse(cmdArg[1]);
                if(!students.ContainsKey(student))
                {
                    students[student]=new List<decimal>();
                }
                students[student].Add(grade);
            }
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x=>$"{x:f2}"))} (avg: {item.Value.Average():f2})");     
            }
        }
    }
}
