using System;
using System.Collections.Generic;
using System.Text;
using experiments.InterfacesViews;
using experiments.Models;


namespace experiments.Presents
{
    class PresentLaserSettings
    {
        private IViewLaserSettings _IView;
        private ModelSettings _modelSettings = new ModelSettings();

        private float _powerLaser;

        public PresentLaserSettings(IViewLaserSettings IView)
        {
            _IView = IView;
            _powerLaser = _modelSettings.getPowerLaser();
            _IView.setPowerLaser(_powerLaser);
            _IView.setSettingsLaser += new EventHandler<EventArgs>(setLaserSettings);
        }

        private void setLaserSettings(object sender, EventArgs e)
        {
            _powerLaser = _IView.getPowerLaser();
            _modelSettings.setPowerLaser(_powerLaser);
        }
    }
}
