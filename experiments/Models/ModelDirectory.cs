﻿using System.Collections.Generic;
using System.IO;

namespace experiments.Models
{
    public class ModelDirectory
    {
        public static List<string> pathForFile = new List<string>();

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
        
        public static void MakeTreeFiles(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            int dirCount = dirInfo.GetDirectories().Length;
            int filesCount = dirInfo.GetFiles().Length;
            
            if (filesCount > 0)
            {
                string[] listFiles = Directory.GetFiles(path);
                foreach (var file in listFiles)
                {
                    DirectoryInfo dirInfoNew = new DirectoryInfo(path.Replace("Original", "Digitization"));
                    if (!dirInfoNew.Exists)
                    {
                        dirInfoNew.Create();
                    }
                    
                    pathForFile.Add(file);
                }
            }
            
            if (dirCount > 0)
            {
                string[] listDirectories = Directory.GetDirectories(path);
                foreach (var directory in listDirectories)
                {
                    MakeTreeFiles(directory);
                }
            }
        }
    }
}