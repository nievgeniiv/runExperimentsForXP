using System.IO;

namespace experiments.Models
{
    public class ModelDirectory
    {
        public string pathToDirectory;
        
        public void CreateDirectory(string pathToDirectory)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathToDirectory);
        }

        public string[] GetListDirectory(string pathToDirectory = "")
        {
            return Directory.GetDirectories(pathToDirectory);
        }

        public bool EmptyDirectory(string pathToDirectory)
        {
            return Directory.GetDirectories(pathToDirectory).Length == 0;
        }
        
        private static string[] GetFiles(string pathToDirectory = "")
        {
            return Directory.GetFiles(pathToDirectory);
        } 
    }
}