using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace experiments.Services
{
    public class ServiceDigitizationBMP
    {
        private static string _pathOriginal;
        private static string _pathDigitization;
        private static string[] _listDirectoryes;
        private static DirectoryInfo _dirInfo;
        private static string[] _listFiles;
        private static string _newDir;
        private static string _currentDirectory;
        private static int[][] _line = new int[10][];

        private static int[] _checkPxl = new int [10]
        {
            70, 140, 210, 280, 350, 420, 490, 560, 630, 700
        };
        
        public static void run(string path)
        {
            _pathOriginal = path + @"Original\";
            _pathDigitization = path + @"Digitization\";
            if (isDirectory())
            {
                 _listDirectoryes = getListDirectory();
                 
                 foreach (string directory in _listDirectoryes)
                 {
                     string[] folders = directory.Split('\\');
                     _currentDirectory = folders[folders.Length - 1];
                     _newDir = _pathDigitization + folders[folders.Length - 1] + @"\";
                     var dirInfo = new DirectoryInfo(_newDir);
                     if (!dirInfo.Exists)
                     {
                         dirInfo.Create();
                     }
                     _listFiles = getFiles(directory);
                     digitizationBMP();
                 }
            } else
            {
                _newDir = _pathDigitization;
                _listFiles = getFiles();
                digitizationBMP();
            }
        }

        private static void digitizationBMP()
        {
            int i = 0;
            foreach (string file in _listFiles)
            {
                var k = file.Split('\\');
                var nameFile = k[k.Length - 1].Split('.');
                var newFile = _newDir + nameFile[0];
                var newFilePower = _newDir + nameFile[0];
                
                if (nameFile[0] == "Thumbs" || nameFile.Length > 2)
                {
                    continue;
                }
                var bitmap = new Bitmap(file);
                var brightnessArray = GetBrightnessArray(bitmap);
                
                float power = _calculatePower(brightnessArray);
                saveFile(brightnessArray, power, newFile, nameFile[0], i);
                i++;
            }
            // StreamWriter swLine =
            //     new StreamWriter(_pathDigitization + _currentDirectory.TrimEnd('m', 'k', 's') + "Line.dat",
            //         true);
            // foreach (var arrayPxl in _line)
            // {
            //     foreach (var value in arrayPxl)
            //     {
            //         swLine.Write(value + "   ");
            //     }
            // }
            // swLine.WriteLine();
            // swLine.Close();
        }

        private static float _calculatePower(float[][] brightnessArray)
        {
            float power = 0;
            foreach (var h in brightnessArray)
            {
                foreach (var w in h)
                {
                   power += w;
                }
            }
            return power;
        }

        private static void saveFile(float[][] brightnessArray, float power, string filePath, string nameFile, int numbPower)
        {
            
            StreamWriter sw = new StreamWriter(filePath + ".dat");
            
            
            int i = 0;
            int k = 0;
            foreach (var height in brightnessArray)
            {
                while (i < height.Length - 1)
                {
                   // if (_checkPxl.Contains(i) && _checkPxl.Contains(k) && i == k)
                    // if (_checkPxl.Contains(k) && i == k)
                    // {
                    //     StreamWriter swCheckPxl =
                    //         new StreamWriter(_pathDigitization + _currentDirectory.TrimEnd('m', 'k', 's') + "ChekcPxl(" + i.ToString() + ").dat",
                    //             true);
                    //     //swCheckPxl.Write(_currentDirectory.TrimEnd('m', 'k', 's') + "   ");
                    //     swCheckPxl.WriteLine(height[i]);
                    //     swCheckPxl.Close();
                    // }

                    if (i == 339)
                    {
                        StreamWriter swLine =
                            new StreamWriter(_pathDigitization + _currentDirectory.TrimEnd('m', 'k', 's') + nameFile + "Line.dat",
                                true);
                        //swCheckPxl.Write(_currentDirectory.TrimEnd('m', 'k', 's') + "   ");
                        swLine.WriteLine(height[i]);
                        //_line[numbPower][k] = ToInt32(height[i]);
                        swLine.Close();
                    
                    }
                    sw.Write(height[i] + "   ");
                    i++;
                }

                if (i == height.Length - 1)
                {
                    sw.WriteLine(height[i]);
                    i = 0;
                }

                k++;
            }
            
            sw.Close();
            StreamWriter swPower = new StreamWriter(_pathDigitization + _currentDirectory + "Power.dat", true);
            swPower.WriteLine(power);
            swPower.Close();
        }

        private static float[][] GetBrightnessArray(Bitmap srcImage)
        {
            Debug.Assert(srcImage != null);

            var result = new float[srcImage.Height][];
            for (var y = 0; y < srcImage.Height; y++)
            {
                result[y] = new float[srcImage.Width];
                for (var x = 0; x < srcImage.Width; x++)
                {
                    var srcPixel = srcImage.GetPixel(x, y);
                    result[y][x] = srcPixel.GetBrightness() * 255;
                }
            }
            return result;
        }

        private static string[] getListDirectory()
        {
            return Directory.GetDirectories(_pathOriginal);
        }

        private static bool isDirectory()
        {
            _dirInfo = new DirectoryInfo(_pathOriginal);
            int dirCount = _dirInfo.GetDirectories().Length;
            if (dirCount == 0)
            {
                return false;
            }
            return true;
        }

        private static string[] getFiles(string directory = "")
        {
            if (directory == "")
            {
                return Directory.GetFiles(_pathOriginal);    
            }
            return Directory.GetFiles(directory);
        } 
    }
}