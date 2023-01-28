namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int count = 1;
                    while(true)
                    {
                        string line = reader.ReadLine();    
                        if(line ==null)
                        {
                            break;
                        }
                        int punctuationMarks= FindPunctuationMarks(line);
                        int letters = FindLetters(line);
                        writer.WriteLine($"Line {count}: {line} ({letters})({punctuationMarks})");

                    }
                }
            }
        }

        private static int FindLetters(string line)
        {
            int count = 0;
            foreach (var ch in line)
            {
                if (char.IsLetter(ch))
                {
                    count++;
                }
            }
            return count;
        }

        private static int FindPunctuationMarks(string line)
        {
            int count = 0;
            foreach (var ch in line)
            {
                if(char.IsPunctuation(ch))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
