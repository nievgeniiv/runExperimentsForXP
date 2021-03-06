﻿using System;
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
        
        private string _typeExperiments;
        private float _concentration;

        public PresentMainForm(IViewMainForm IVew)
        {
            _IView = IVew;
            _IView.runExperimetns += new EventHandler<EventArgs>(_runExperiments);
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
