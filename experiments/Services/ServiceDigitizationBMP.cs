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
        private static string[] _listFiles;
        private static string _newDir;
        private static string _currentDirectory;
        private static int[] _centerPxl = new int[2];

        public static void run(string path, int[] centerPxl)
        {
            _pathOriginal = path + @"Original\";
            _pathDigitization = path + @"Digitization\";
            _centerPxl = centerPxl;

            if (_modelDirectory.EmptyDirectory(_pathOriginal))
            {
                _listDirectoryes = _modelDirectory.GetListDirectory(_pathOriginal);

                foreach (string directory in _listDirectoryes)
                {
                    makePathNewDir(directory);
                    _modelDirectory.CreateDirectory(_newDir);
                    
                    _listFiles = _modelDirectory.GetFiles(_pathOriginal, directory);
                    int i = 0;
                    int countNeedFiles = _listFiles.Length;
                    foreach (string file in _listFiles)
                    {
                        var nameFile = makePathNewFile(file);
                        if (nameFile[0] == "Thumbs" || nameFile.Length > 2)
                        {
                            countNeedFiles--;
                        }
                    }

                    ModelBMP.arrayInt = new int[countNeedFiles][];
                    foreach (string file in _listFiles)
                    {
                        var nameFile = makePathNewFile(file);
                        string newFile = _newDir + nameFile[0];

                        if (nameFile[0] == "Thumbs" || nameFile.Length > 2)
                        {
                            continue;
                        }
                        digitizationBMP(i, file);
                        _modelBMP.saveArrayFloatInFile(i, newFile);
                        float power = _calculatePower(ModelBMP.arrayFloat);
                        _modelBMP.savePowerInFile(power, _pathDigitization + _currentDirectory + "Power");
                        ModelBMP.isArray = false;
                        i++;
                    }

                    _modelBMP.centerPxl = _centerPxl;
                    _modelBMP.saveArrayIntInFile(_pathDigitization + _currentDirectory.TrimEnd('m', 'k', 's') + "Line");
                }
            }
            else
            {
                _newDir = _pathDigitization;
                _listFiles = _modelDirectory.GetFiles(_pathOriginal);
                //digitizationBMP();
            }
        }

        private static void digitizationBMP(int i, string file)
        {
            var bitmap = new Bitmap(file);
            ModelBMP.arrayFloat = GetBrightnessArray(bitmap);
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
        
        private static void makePathNewDir(string directory) {
            string[] folders = directory.Split('\\');
            _currentDirectory = folders[folders.Length - 1];
            _newDir = _pathDigitization + folders[folders.Length - 1] + @"\";
        }

        private static string[] makePathNewFile(string file)
        {
            var k = file.Split('\\');
            return k[k.Length - 1].Split('.');
        }
    }
}