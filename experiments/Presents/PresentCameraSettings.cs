using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using experiments.InterfacesViews;
using experiments.Models;
using experiments.Services;

namespace experiments.Presents
{
    class PresentCameraSettings
    {
        private IViewCameraSettings _IView;
        private ModelSettings _modelSettings = new ModelSettings();

        private int _countPhoto;
        private string _mode;
        private ServiceCCDCamera _serviceCCDCamera;

        public PresentCameraSettings(IViewCameraSettings IView)
        {
            _IView = IView;
            _countPhoto = _modelSettings.getCountPhoto();
            _IView.setCountPhoto(_countPhoto);
            _IView.setSettings += new EventHandler<EventArgs>(setCameraSettings);
            _IView.getPhotos += new EventHandler<EventArgs>(getPhoto);
        }

        private void setCameraSettings(object sender, EventArgs e)
        {
            _countPhoto = _IView.getCountPhoto();
            _mode = _IView.getMode();
            _modelSettings.setCountPhoto(_countPhoto);
            _serviceCCDCamera = new ServiceCCDCamera(_mode);
        }

        private void getPhoto(object sender, EventArgs e)
        {
            _serviceCCDCamera.makePhoto(_countPhoto);
            
            if (_mode == "hand")
            {
                string path = Directory.GetCurrentDirectory();
                string[] files = Directory.GetFiles(path + "/testsData/tmp/");
                string date = DateTime.Now.ToString("dd.MM.yyyy");

                if (!Directory.Exists(path + "/testsData/Results/" + date))
                {
                    Directory.CreateDirectory(path + "/testsData/Results/" + date + "/Original");
                }
                
                foreach (var file in files)
                {
                    string newPath = file.Replace("tmp", "Results/" + date + "/Original/");
                    File.Move(file, newPath);
                }
            }

            // TODO: оцифровка файлов, сохранение оцифрованных файлов
        }
    }
}
