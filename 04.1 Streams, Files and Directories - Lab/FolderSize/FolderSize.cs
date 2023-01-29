namespace FolderSize
{
    using System;
    using System.Drawing;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);

            double sum = folderSize(dir);

            sum = sum / 1024;
            File.WriteAllText(outputFilePath, $"{sum} KB");
        }
        static double folderSize(DirectoryInfo folder)
        {
            double totalSizeOfDir = 0;
            FileInfo[] allFiles = folder.GetFiles();

            foreach (FileInfo file in allFiles)
            {
                totalSizeOfDir += file.Length;
            }
            DirectoryInfo[] subFolders = folder.GetDirectories();

            foreach (DirectoryInfo dir in subFolders)
            {
                totalSizeOfDir += folderSize(dir);
            }
            return totalSizeOfDir;
        }
    }
}