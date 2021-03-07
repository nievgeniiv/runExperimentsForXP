using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using experiments.Models;


namespace experiments.Services
{
    public class ServiceDigitizationBMP
    {

        private static ModelBMP _modelBMP = new ModelBMP();
        private static ModelDirectory _modelDirectory = new ModelDirectory();
        private static string _pathOriginal;
        private static int[] _centerPxl = new int[2];

        public static void run(string path, int[] centerPxl)
        {
            _pathOriginal = path + @"Original\";
            _centerPxl = centerPxl;

            _modelDirectory.MakeTreeDirectories(path);

            foreach (var pathToDir in _modelDirectory.pathForDir)
            {
                MessageBox.Show(pathToDir);
                // TODO: Не работает когда открывает вторую дату. Почему-то создается файл DigitizationLine.dat в этой папке
                _modelDirectory.GetFiles(pathToDir);

                int i = 0;
                int countNeedFiles = _modelDirectory.listFiles.Count;
                ModelBMP.arrayInt = new int[countNeedFiles][];

                foreach (string file in _modelDirectory.listFiles)
                {
                    var nameFile = makePathNewFile(file);
                    string newFile = pathToDir.Replace("Original", "Digitization") + "\\" + nameFile[0];

                    digitizationBMP(file);
                    _modelBMP.saveArrayFloatInFile(i, newFile);
                    float power = _calculatePower(ModelBMP.arrayFloat);
                    _modelBMP.savePowerInFile(power, newFile + "Power");
                    ModelBMP.isArray = false;
                    i++;
                }
                
                _modelBMP.centerPxl = _centerPxl;
                string pathSave = pathToDir.Replace("Original", "Digitization");
                _modelBMP.saveArrayIntInFile(pathSave.TrimEnd('m', 'k', 's') + "Line");
            }
        }
        
        private static void digitizationBMP(string file)
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

        private static string[] makePathNewFile(string file)
        {
            var k = file.Split('\\');
            return k[k.Length - 1].Split('.');
        }
    }
}