using System.IO;

namespace experiments.Models
{
    public class ModelDirectory
    {
        public string pathToDirectory;

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
    }
}