using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> names = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                names[tokens[0]] = int.Parse(tokens[1]);
            }

            string condition = Console.ReadLine();
            int ageThresHold = int.Parse(Console.ReadLine());
            string Format = Console.ReadLine();

            Func<KeyValuePair<string,int>, string, int, bool> filter = (p, c, a) =>
            {
                if(c=="older")
                {
                    if (p.Value >= a)
                        return true;
                }
                else
                {
                    if (p.Value < a)
                        return true;
                }
                return false;
            };
            Func<KeyValuePair<string,int>, string, string> printer = (h,f) =>
            {
                if(f == "age")
                {
                    return h.Value.ToString();
                }

                else if (f == "name age")
                {
                    return $"{h.Key} - {h.Value}";
                }
                else
                {
                    return h.Key;
                }
            };
            Console.WriteLine(string.Join(Environment.NewLine, names.Where(n => filter(n, condition, ageThresHold)).Select(x => printer(x, Format))));
        }
    }
}
