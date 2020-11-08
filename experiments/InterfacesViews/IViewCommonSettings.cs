using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.InterfacesViews
{
    interface IViewCommonSettings
    {

        event EventHandler<EventArgs> setCommonSettings;
        string getPathSaveResult();
    }
}
