using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();

                person.Name = tokens[0];
                person.Age = int.Parse(tokens[1]);
                list.Add(person);
            }

            
            foreach(Person p in list.OrderBy(p => p.Name))
            {
                if (p.Age > 30)
                {
                    Console.WriteLine($"{p.Name} - {p.Age}");
                }
            }
        }
    }

}
