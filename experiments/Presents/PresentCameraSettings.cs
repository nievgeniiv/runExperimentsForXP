using System;
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
            _modelSettings.setCountPhoto(_countPhoto);
            ServiceCCDCamera _serviceCCDCamera = new ServiceCCDCamera();
        }
    }
}
