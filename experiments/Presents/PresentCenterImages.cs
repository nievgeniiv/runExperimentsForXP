using System;
using System.IO;
using experiments.InterfacesViews;

namespace experiments.Presents
{
    public class PresentCenterImages
    {
        IViewCenterImages _IView;
        private string _pathDirectory;
        private string[] _path;
        private int[] _centerPxl = new int[2];

        public PresentCenterImages(IViewCenterImages IVew)
        {
            _IView = IVew;
            _IView.openDirectory += new EventHandler<EventArgs>(_openDirectory);
        }
        
        private void _openDirectory(object sender, EventArgs e)
        {
            string _newPath = "";
            bool end = false;
            _pathDirectory = _IView.getPathDirectory();
            _path = _pathDirectory.Split('\\');
            foreach (string v in _path)
            {
                if (end)
                {
                    continue;
                }
                if (v == "Result")
                {
                    end = true;
                }
                _newPath = String.Concat(_newPath,  v + '\\');
            }
            DirectoryInfo dirInfo = new DirectoryInfo(_newPath + "Digitization");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            _centerPxl = _IView.getCenterPxl();
            Services.ServiceDigitizationBMP.run(_newPath, _centerPxl);
        }
    }
}