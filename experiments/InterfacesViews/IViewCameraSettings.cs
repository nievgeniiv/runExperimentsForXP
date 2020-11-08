using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.InterfacesViews
{
    interface IViewCameraSettings
    {
        event EventHandler<EventArgs> setSettings;

        int getCountPhoto();
        void setCountPhoto(int countPhoto);
    }
}
