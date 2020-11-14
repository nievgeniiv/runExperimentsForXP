﻿using System.IO;

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
            DirectoryInfo dirInfo = new DirectoryInfo(pathToDirectory);
            int dirCount = dirInfo.GetDirectories().Length;
            if (dirCount == 0)
            {
                return false;
            }

            return true;
        }
        
        public string[] GetFiles(string pathToOriginalDirectory, string pathToDirectory = "")
        {
            if (pathToDirectory == "")
            {
                return Directory.GetFiles(pathToOriginalDirectory);    
            }
            return Directory.GetFiles(pathToDirectory);
        } 
    }
}