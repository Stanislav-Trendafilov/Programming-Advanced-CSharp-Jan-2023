namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string,int>words= new Dictionary<string,int>();
            using(StreamReader reader= new StreamReader(wordsFilePath))
            {
                string lineInfo = reader.ReadLine();
                while (lineInfo!=null)
                {
                    string[]wordsPerLine=lineInfo.Split(' ');
                    foreach (var word in wordsPerLine)
                    {
                        if (!words.ContainsKey(word.ToLower()))
                        {
                            words.Add(word.ToLower(), 1);
                        }
                    }
                    lineInfo = reader.ReadLine();
                }
                using (StreamReader reader2 = new StreamReader(textFilePath))
                {
                     string line2= reader2.ReadLine();
                    while (line2 != null)
                    {
                        string[] text = line2.Split(" ");
                        foreach (var word in text)
                        {
                            if (words.ContainsKey(word.ToLower()))
                            {
                                words[word.ToLower()]++;
                            }
                        }
                        line2 = reader2.ReadLine();
                    }
                }
                using(StreamWriter writer=new StreamWriter(outputFilePath))
                {
                    foreach (var word in words.OrderByDescending(x=>x.Value))
                    {
                        writer.WriteLine($"{word.Key.ToLower()} - {word.Value}");
                    }
                }
            }
        }
    }
}
