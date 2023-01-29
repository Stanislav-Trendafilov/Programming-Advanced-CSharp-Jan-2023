namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string line1 = reader1.ReadLine();
                        string line2 = reader2.ReadLine();
                        while (true)
                        {
                            if(line1 != null)
                            {
                                writer.WriteLine(line1);
                            }
                            else
                            {
                                break;
                            }
                            line1 = reader1.ReadLine();
                            if (line2 != null)
                            {
                                writer.WriteLine(line2);
                            }
                            else
                            {
                                break;
                            }
                            line2 = reader2.ReadLine();
                        }
                        line1 = reader1.ReadLine();
                        if (line1!=null)
                        {
                            while(line1!=null)
                            {
                                writer.WriteLine(line1);
                                line1 = reader1.ReadLine();
                            }
                        }
                        line2 = reader2.ReadLine();
                        if (line2 != null)
                        {
                            while (line2 != null)
                            {
                                writer.WriteLine(line2);
                                line2 = reader1.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
