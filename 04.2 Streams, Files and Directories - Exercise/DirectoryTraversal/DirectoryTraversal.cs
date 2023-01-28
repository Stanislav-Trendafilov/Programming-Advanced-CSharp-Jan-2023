namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string,List<FileInfo>>extensions= new Dictionary<string,List<FileInfo>>();

            string[]copyDirectory=Directory.GetFiles(inputFolderPath);

            foreach (var fileName in copyDirectory)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                if(!extensions.ContainsKey(fileInfo.Extension))
                {
                    extensions[fileInfo.Extension]=new List<FileInfo>();
                }
                extensions[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder stringBuilder= new StringBuilder();

            foreach (var extensionsFiles in extensions.OrderByDescending(ef=>ef.Value.Count).ThenBy(en=>en.Key))
            {
                stringBuilder.AppendLine(extensionsFiles.Key);
                foreach (var file in extensionsFiles.Value.OrderBy(x=>x.Length)) 
                { 
                    stringBuilder.AppendLine($"--{file.Name} - {(double)file.Length/1024:f3}kb");
                }
            }
            return stringBuilder.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath=Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(filePath, textContent);
        }
    }
}
