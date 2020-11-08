using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using experiments.InterfacesViews;
using experiments.Models;

namespace experiments.Presents
{
    class PresentMainForm
    {
        IViewMainForm _IView;
        private ModelDirectory _modelDirectory = new ModelDirectory();

        private string[] _path;
        private string _pathDirectory;
        private string _typeExperiments;
        private float _concentration;

        public PresentMainForm(IViewMainForm IVew)
        {
            _IView = IVew;
            _IView.runExperimetns += new EventHandler<EventArgs>(_runExperiments);
            _IView.openDirectory += new EventHandler<EventArgs>(_openDirectory);
        }

        private void _openDirectory(object sender, EventArgs e)
        {
            string _newPath = "";
            bool end = false;
            _pathDirectory = _IView.getPathDirectory();
            _path = _pathDirectory.Split('\\');
            foreach (string v in _path)
            {
                if (end)
                {
                    continue;
                }
                if (v == "Result")
                {
                    end = true;
                }
                _newPath = String.Concat(_newPath,  v + '\\');
            }
            DirectoryInfo dirInfo = new DirectoryInfo(_newPath + "Digitization");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Services.ServiceDigitizationBMP.run(_newPath);
        }

        private void _runExperiments(object sender, EventArgs e)
        {
            _concentration = _IView.getConcentration();
            _typeExperiments = _IView.getTypeExperiments();
            _IView.clearConcentration();
            MessageBox.Show("Эксперимент запущен!");
        }
    }
}
