using System.Diagnostics;
using System.Drawing;
using experiments.Models;


namespace experiments.Services
{
    public static class ServiceDigitizationBMP
    {

        private static readonly ModelBMP _modelBMP = new ModelBMP();
        private static readonly ModelDirectory _modelDirectory = new ModelDirectory();
        private static int[] _centerPxl = new int[2];

        public static void run(string path, int[] centerPxl)
        {
            _centerPxl = centerPxl;

            _modelDirectory.MakeTreeDirectories(path);
            foreach (var pathToDir in _modelDirectory.pathForDir)
            {
                _modelDirectory.GetFiles(pathToDir);

                var i = 0;
                var countNeedFiles = _modelDirectory.listFiles.Count;
                ModelBMP.arrayInt = new int[countNeedFiles][];

                foreach (var file in _modelDirectory.listFiles)
                {
                    var nameFile = makePathNewFile(file);
                    var newFile = pathToDir.Replace("Original", "Digitization") + "\\" + nameFile[0];

                    digitizationBMP(file);
                    _modelBMP.saveArrayFloatInFile(i, newFile);
                    var power = _calculatePower(ModelBMP.arrayFloat);
                    _modelBMP.savePowerInFile(power, newFile + "Power");
                    ModelBMP.isArray = false;
                    i++;
                }
                
                _modelBMP.centerPxl = _centerPxl;
                var pathSave = pathToDir.Replace("Original", "Digitization");
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