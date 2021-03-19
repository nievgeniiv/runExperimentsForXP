using System;
using System.IO;

namespace experiments.Models
{
    public class ModelBMP
    {
        public int[] centerPxl = new int[2];
        public static int[][] arrayInt { get; set; }
        public static float[][] arrayFloat { get; set; }
        public static bool? isArray { get; set; }

        public ModelBMP()
        {
            isArray = false;
        } 

        public void saveArrayFloatInFile(int currentPhoto, string pathAndNameFile)
        {
            StreamWriter digitizationFile = new StreamWriter(pathAndNameFile + ".dat");

            int i = 0;
            int k = 0;
            foreach (var height in arrayFloat)
            {
                while (i < height.Length - 1)
                {
                    if (i == centerPxl[1])
                    {
                        if (isArray == false)
                        {
                            arrayInt[currentPhoto] = new int[arrayFloat.Length];
                            isArray = true;
                        }

                        arrayInt[currentPhoto][k] = Convert.ToInt32(height[i]);
                    }
                    
                    digitizationFile.Write(height[i] + "   ");
                    i++;
                }

                if (i == height.Length - 1)
                {
                    digitizationFile.WriteLine(height[i]);
                    i = 0;
                }

                k++;
            }
            digitizationFile.Close();
        }

        public void savePowerInFile(float power, string pathAndNameFile)
        {
            StreamWriter swPower = new StreamWriter(pathAndNameFile + ".dat", true);
            swPower.WriteLine(power);
            swPower.Close();
        }

        public void saveArrayIntInFile(string pathAndNameFile)
        {
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