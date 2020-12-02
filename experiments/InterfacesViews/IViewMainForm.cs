using System;
using System.Collections.Generic;
using System.Text;

namespace experiments.InterfacesViews
{
    interface IViewMainForm
    {
        event EventHandler<EventArgs> runExperimetns;

        string getTypeExperiments();
        float getConcentration();
        void clearConcentration();
        
    }
}
