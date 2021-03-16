using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.InterfacesViews
{
    interface IViewStepMotorSettings
    {
        event EventHandler<EventArgs> getListComPorts;
        event EventHandler<EventArgs> connectAndDisconnectComPort;
        event EventHandler<EventArgs> transmitterStepForward;
        event EventHandler<EventArgs> transmitterStepBack;
        event EventHandler<EventArgs> receiverStepForward;
        event EventHandler<EventArgs> receiverStepBack;
        event EventHandler<EventArgs> transmitterSectorForward;
        event EventHandler<EventArgs> transmitterSectorBack;
        event EventHandler<EventArgs> receiverSectorForward;
        event EventHandler<EventArgs> receiverSectorBack;
        event EventHandler<EventArgs> compliteStepMotorSettings;

        void setListComPort(string[] listComPort, string selectedComPort = null);
        string getNameComPort();

        void setTextButtonForConnectAndDisconnectComPort(string nameButton);
    }
}
