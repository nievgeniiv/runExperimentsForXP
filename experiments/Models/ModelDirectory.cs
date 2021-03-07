using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace experiments.Models
{
    public class ModelDirectory
    {
        public readonly List<string> pathForDir = new List<string>();
        public List<string> listFiles;

        public void CreateDirectory(string pathToDirectory)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathToDirectory);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

        public void GetFiles(string pathToOriginalDirectory, string pathToDirectory = "")
        {
            listFiles = new List<string>();
            string[] list = Directory.GetFiles(pathToDirectory == "" ? pathToOriginalDirectory : pathToDirectory);
            Regex regex = new Regex(@".\.txt|.\.db");
            foreach (var file in list)
            {
                MatchCollection matches = regex.Matches(file);
                if (matches.Count > 0)
                {
                    continue;
                }
                listFiles.Add(file);
            }
        }
        
        public void MakeTreeDirectories(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            int dirCount = dirInfo.GetDirectories().Length;
            int filesCount = dirInfo.GetFiles().Length;
            
            if (filesCount > 0)
            {
                CreateDirectory(path.Replace("Original", "Digitization"));
                pathForDir.Add(path);
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