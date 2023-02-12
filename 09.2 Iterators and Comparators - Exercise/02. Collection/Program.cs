using System.Collections.Generic;

namespace Collection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(" ")
                .Skip(1)
                .ToList();
            ListyIterator<string> list1= new(list);
            Iterator<string> listIterator = new(list);

            string command =string.Empty;
            while((command=Console.ReadLine())!="END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listIterator.Move());
                        break;
                    case "Print":
                        if(list.Count > 0)
                        {
                            Console.WriteLine(listIterator.Current); ;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                        break;                        
                    case "HasNext":
                        Console.WriteLine(listIterator.HasNext());
                        break;
                    case "PrintAll":
                        foreach (var item in list1)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}