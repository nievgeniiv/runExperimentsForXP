using System;

namespace experiments.InterfacesViews
{
    public interface IViewCenterImages
    {
        event EventHandler<EventArgs> openDirectory;
        string getPathDirectory();
        void setPathDirectory(string path);
        int[] getCenterPxl();
    }
}