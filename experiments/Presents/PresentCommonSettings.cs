using System;
using experiments.InterfacesViews;
using experiments.Models;

namespace experiments.Presents
{
    class PresentCommonSettings
    {
        private IViewCommonSettings _IView;
        private ModelSettings _modelSettings = new ModelSettings();

        private string pathSaveResult;
        public PresentCommonSettings(IViewCommonSettings IView)
        {
            _IView = IView;
            _IView.setCommonSettings += new EventHandler<EventArgs>(setPathSaveResultInSettings);

        }

        private void setPathSaveResultInSettings(object sender, EventArgs e)
        {
            pathSaveResult = _IView.getPathSaveResult();
            _modelSettings.setPathSaveResult(pathSaveResult);
        }
    }
}
