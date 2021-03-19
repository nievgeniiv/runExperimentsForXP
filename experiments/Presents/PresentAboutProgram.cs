using experiments.InterfacesViews;
using experiments.Models;

namespace experiments.Presents
{
    class PresentAboutProgram
    {
        private IViewAboutForm _IView;
        private static ModelSettings _modelSettings = new ModelSettings();

        public PresentAboutProgram(IViewAboutForm IView)
        {
            _IView = IView;
            string version = _modelSettings.version;
            string nameProgram = _modelSettings.nameProgram;
            string aboutProgram = _modelSettings.aboutProgram;
            _IView.setData(version, nameProgram, aboutProgram);
        }
    }
}
