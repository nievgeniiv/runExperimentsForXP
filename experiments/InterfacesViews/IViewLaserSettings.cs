using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.InterfacesViews
{
    interface IViewLaserSettings
    {
        event EventHandler<EventArgs> setSettingsLaser;

        float getPowerLaser();
        void setPowerLaser(float powerLaser);
    }
}
