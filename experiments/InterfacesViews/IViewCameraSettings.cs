using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.InterfacesViews
{
    interface IViewCameraSettings
    {
        event EventHandler<EventArgs> setSettings;
        event EventHandler<EventArgs> getPhotos;

        int getCountPhoto();
        void setCountPhoto(int countPhoto);

        string getMode();
    }
}
