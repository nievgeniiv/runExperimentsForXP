using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using experiments.Models;


namespace experiments.Services
{
    public class ServiceDigitizationBMP
    {

        private static ModelBMP _modelBMP = new ModelBMP();
        private static ModelDirectory _modelDirectory = new ModelDirectory();
        private static string _pathOriginal;
        private static string _pathDigitization;
        private static string[] _listDirectoryes;
        private static DirectoryInfo _dirInfo;
        private static string[] _listFiles;
        private static string _newDir;
        private static string _currentDirectory;
        private static int[][] _line;
        private static bool? _isArray = false;
        private static int _countPxl;

        private static int[] _checkPxl = new int [10]
        {
            70, 140, 210, 280, 350, 420, 490, 560, 630, 700
        };

        public static void run(string path)
        {
            _pathOriginal = path + @"Original\";
            _pathDigitization = path + @"Digitization\";
            
             if (_modelDirectory.EmptyDirectory(_pathOriginal))
             {
                 _listDirectoryes = _modelDirectory.GetListDirectory(_pathOriginal);
            
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
            
                    _listFiles = _modelDirectory.GetFiles(_pathOriginal, directory);
                    _line = new int[_listFiles.Length][];
                    digitizationBMP();
                }
            }
            else
            {
            //     _newDir = _pathDigitization;
            //     _listFiles = _modelDirectory.GetFiles(_pathOriginal);
            //     digitizationBMP();
            }
            //
            // _isArray = false;
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
                _modelBMP.arrayFloat = GetBrightnessArray(bitmap);
                _modelBMP.saveArrayFloatInFile(newFile);
                float power = _calculatePower(_modelBMP.arrayFloat);
                _modelBMP.savePowerInFile(power, _pathDigitization + _currentDirectory + "Power");
                _isArray = false;
                i++;
            }

            _modelBMP.saveArrayIntInFile(i,_pathDigitization + _currentDirectory.TrimEnd('m', 'k', 's') + "Line");
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

        private static void saveFile(float[][] brightnessArray, float power, string filePath, string nameFile,
            int numbPower)
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
                        if (_isArray == false)
                        {
                            _line[numbPower] = new int[brightnessArray.Length];
                            _isArray = true;
                        }

                        _line[numbPower][k] = Convert.ToInt32(height[i]);

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

        // private static string[] getFiles(string directory = "")
        // {
        //
        // }
    }
}