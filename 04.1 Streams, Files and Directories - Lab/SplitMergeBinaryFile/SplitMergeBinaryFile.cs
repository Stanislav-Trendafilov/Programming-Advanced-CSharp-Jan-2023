namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream fileStream = new FileStream(sourceFilePath, FileMode.Open))
            {
                long size = 0;
                if (fileStream.Length % 2 == 0)
                {
                    size = fileStream.Length / 2;
                }
                else
                {
                    size = fileStream.Length / 2 + 1;
                }
                using (FileStream newFiles = new FileStream(partOneFilePath, FileMode.OpenOrCreate))
                {
                    byte[] buffer = new byte[size];
                    fileStream.Read(buffer, 0, (int)size);
                    newFiles.Write(buffer, 0, buffer.Length);
                }
                if (size % 2 != 0)
                {
                    size--;
                }
                using (FileStream newFiles = new FileStream(partTwoFilePath, FileMode.OpenOrCreate))
                {
                    byte[] buffer = new byte[size];
                    fileStream.Read(buffer, 0, (int)size);
                    newFiles.Write(buffer, 0, buffer.Length);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream filestream = new FileStream(joinedFilePath, FileMode.OpenOrCreate))
            {
                using (FileStream first = new FileStream(partOneFilePath, FileMode.Open))
                {
                    byte[] buffer1 = new byte[first.Length];
                    first.Read(buffer1, 0, buffer1.Length);
                    using (FileStream second = new FileStream(partTwoFilePath, FileMode.Open))
                    {
                        byte[] buffer2 = new byte[second.Length];
                        second.Read(buffer2, 0, buffer2.Length);
                        filestream.Write(buffer1, 0, buffer1.Length);
                        filestream.Write(buffer2, 0, buffer2.Length);
                    }
                }
            }
        }
    }
}