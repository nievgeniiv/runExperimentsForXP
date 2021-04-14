using System;
using System.Collections.Generic;
using System.Text;
using experiments.InterfacesViews;
using experiments.Models;
using experiments.Services;

namespace experiments.Presents
{
    class PresentHandExperiments
    {
        private IViewHandExperiments _IView;
        private ModelSettings _modelSettings = new ModelSettings();

        private string[] _listComPort;
        private string _selectedComPort;
        public PresentHandExperiments(IViewHandExperiments IView)
        {
            _IView = IView;
            _IView.nextCombinationPolarizationElements += new EventHandler<EventArgs>(_nextCombinationPolarizationElements);
            _IView.prevCombinationPolarizationElements += new EventHandler<EventArgs>(_prevCombinationPolarizationElements);
            _IView.nextPolarizationElementsInTransmitter += new EventHandler<EventArgs>(_nextPolarizationElementsInTransmitter);
            _IView.prevPolarizationElementsInTransmitter += new EventHandler<EventArgs>(_prevPolarizationElementsInTransmitter);
            _IView.nextPolarizationElementsInReceiver += new EventHandler<EventArgs>(_nextPolarizationElementsInReceiver);
            _IView.prevPolarizationElementsInReceiver += new EventHandler<EventArgs>(_prevPolarizationElementsInReceiver);
            _IView.takePhotoWithCCD += new EventHandler<EventArgs>(_takePhoto);
        }

        private void _nextCombinationPolarizationElements(object sender, EventArgs e)
        {
            
        }
        
        private void _prevCombinationPolarizationElements(object sender, EventArgs e)
        {
            
        }
        
        private void _nextPolarizationElementsInTransmitter(object sender, EventArgs e)
        {
            
        }
        
        private void _prevPolarizationElementsInTransmitter(object sender, EventArgs e)
        {
            
        }
        
        private void _nextPolarizationElementsInReceiver(object sender, EventArgs e)
        {
            
        }
        
        private void _prevPolarizationElementsInReceiver(object sender, EventArgs e)
        {
            
        }
        
        private void _takePhoto(object sender, EventArgs e)
        {
            
        }

    }
}
