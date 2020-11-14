﻿using System;
using System.IO;

namespace experiments.Models
{
    public class ModelBMP
    {
        public int[][] arrayInt { get; set; }
        public float[][] arrayFloat { get; set; }
        public bool? isArray { get; set; }

        public void saveArrayFloatInFile(string pathAndNameFile)
        {
            StreamWriter digitizationFile = new StreamWriter(pathAndNameFile + ".dat");

            int i = 0;
            int k = 0;
            foreach (var height in arrayFloat)
            {
                while (i < height.Length - 1)
                {
                    digitizationFile.Write(height[i] + "   ");
                    i++;
                }
                if (i == height.Length - 1)
                {
                    digitizationFile.WriteLine(height[i]);
                    i = 0;
                }
            }
            digitizationFile.Close();
        }

        public void savePowerInFile(float power, string pathAndNameFile)
        {
            StreamWriter swPower = new StreamWriter(pathAndNameFile + ".dat", true);
            swPower.WriteLine(power);
            swPower.Close();
        }

        public void saveArrayIntInFile(int currentPhoto, string pathAndNameFile)
        {
            int i = 0;
            int k = 0;
            foreach (var height in arrayFloat)
            {
                while (i < height.Length - 1)
                {
                    if (i == 339)
                    {
                        if (isArray == false)
                        {
                            arrayInt[currentPhoto] = new int[arrayFloat.Length];
                            isArray = true;
                        }

                        arrayInt[currentPhoto][k] = Convert.ToInt32(height[i]);
                    }
                    
                    i++;
                }
                
                k++;
            }
            
            StreamWriter swLine =
                new StreamWriter(pathAndNameFile + ".dat",
                    false);
            var j = 1;
            for (int m = 0; m <= arrayInt[0].Length - 1; m++)
            {
                swLine.Write(j + "   ");
                for (int n = 0; n <= arrayInt.Length - 1; n++)
                {
                    swLine.Write(arrayInt[n][m] + "   ");
                }
                
                swLine.WriteLine();
                j++;
            }
            
            swLine.Close();
        }
    }
}