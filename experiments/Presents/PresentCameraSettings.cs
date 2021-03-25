using System;
using System.Collections.Generic;
using System.Text;
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
        }

        private void setCameraSettings(object sender, EventArgs e)
        {
            _countPhoto = _IView.getCountPhoto();
            _mode = _IView.getMode();
            _modelSettings.setCountPhoto(_countPhoto);
            _serviceCCDCamera = new ServiceCCDCamera("hand");
        }

        private void getPhoto()
        {
            _serviceCCDCamera.makePhoto(_countPhoto);
            
            // TODO: Копирование файлов из tmp в нужное место, оцифровка файлов, сохранение оцифрованных файлов
        }
    }
}
