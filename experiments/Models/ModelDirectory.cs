using System.Collections.Generic;
using System.IO;

namespace experiments.Models
{
    public class ModelDirectory
    {
        public string pathToDirectory;
        public static List<string> _pathForFile = new List<string>();

        public void CreateDirectory(string pathToDirectory)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathToDirectory);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

        public string[] GetListDirectory(string pathToDirectory = "")
        {
            return Directory.GetDirectories(pathToDirectory);
        }

        public bool EmptyDirectory(string pathToDirectory)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathToDirectory);
            int dirCount = dirInfo.GetDirectories().Length;
            return dirCount == 0;
        }
        
        public string[] GetFiles(string pathToOriginalDirectory, string pathToDirectory = "")
        {
            return Directory.GetFiles(pathToDirectory == "" ? pathToOriginalDirectory : pathToDirectory);
        }
        
        private static void MakeTreeDirectories(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            int dirCount = dirInfo.GetDirectories().Length;
            int filesCount = dirInfo.GetFiles().Length;
            
            if (filesCount > 0)
            {
                string[] listFiles = Directory.GetFiles(path);
                foreach (var file in listFiles)
                {
                    string pathToFile = file.Replace("Original", "Digitization");
                    DirectoryInfo dirInfoNew = new DirectoryInfo(path.Replace("Original", "Digitization"));
                    if (!dirInfoNew.Exists)
                    {
                        dirInfoNew.Create();
                    }
                    StreamWriter digitizationFile = new StreamWriter(pathToFile);
                    digitizationFile.WriteLine("ok");
                    digitizationFile.Close();
                    _pathForFile.Add(file);
                }
            }
            
            if (dirCount > 0)
            {
                string[] listDirectories = Directory.GetDirectories(path);
                foreach (var directory in listDirectories)
                {
                    MakeTreeDirectories(directory);
                }
            }
        }
    }
}