namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                byte[] bytes = reader.ReadToEnd().Split('\n').Select(byte.Parse).ToArray();
                using (FileStream image = new FileStream(binaryFilePath, FileMode.Open))
                {
                    List<byte> specialBytes = new List<byte>();
                    byte[] buffer2 = new byte[image.Length];
                    image.Read(buffer2, 0, buffer2.Length);
                    foreach (var item in buffer2)
                    {
                        if (bytes.Contains(item))
                        {
                            specialBytes.Add(item);
                        }
                    }

                    using (FileStream outputFile = new FileStream(outputPath, FileMode.OpenOrCreate))
                    {
                        outputFile.Write(specialBytes.ToArray(), 0, specialBytes.Count);
                    }
                }
            }
        }

    }
}
