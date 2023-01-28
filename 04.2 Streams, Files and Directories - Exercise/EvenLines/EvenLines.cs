namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                int count = 0;
                StringBuilder sb= new StringBuilder();
                while (true) 
                { 
                    string line = reader.ReadLine();
                    if (line == null)
                    { break; }
                    string replacedSymbols = string.Empty;
                    if (count%2==0)
                    { 
                        foreach (var ch in line)
                        {
                            if(ch=='-'|| ch == ','|| ch == '.'||ch == '!'||ch == '?')
                            {
                                replacedSymbols += '@';
                            }
                            else
                            {
                                replacedSymbols += ch;
                            }
                        }
                        sb.AppendLine(string.Join(" ",replacedSymbols.Split().Reverse().ToArray()));

                    }
                    count++;
                }
                return sb.ToString();
            }


            
        }
    }
}
