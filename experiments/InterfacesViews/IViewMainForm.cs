using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.InterfacesViews
{
    interface IViewMainForm
    {
        event EventHandler<EventArgs> runExperimetns;
        event EventHandler<EventArgs> openDirectory;

        string getTypeExperiments();
        float getConcentration();
        void clearConcentration();
        string getPathDirectory();
    }
}
