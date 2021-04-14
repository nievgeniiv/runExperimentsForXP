using System;
using System.Collections.Generic;
using System.IO;
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
        private static int _position = 0;

        private ServiceCCDCamera _serviceCCDCamera;
        private readonly int _countPhoto;
        public PresentHandExperiments(IViewHandExperiments IView)
        {
            _IView = IView;
            _countPhoto = _modelSettings.getCountPhoto();
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
            if (_position % 4 == 0)
            {
                ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_FORWARD);
                ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_SECTOR_FORWARD);
            }
            else
            {
                ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_FORWARD);
            }
            
            _position++;
            if (_position == 16)
            {
                _position = 0;
            }
        }
        
        private void _prevCombinationPolarizationElements(object sender, EventArgs e)
        {
            if (_position % 4 == 0)
            {
                ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_FORWARD);
                ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_SECTOR_FORWARD);
            }
            else
            {
                ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_FORWARD);
            }
            
            _position--;
            if (_position == 0)
            {
                _position = 16;
            }
        }
        
        private void _nextPolarizationElementsInTransmitter(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_FORWARD);
        }
        
        private void _prevPolarizationElementsInTransmitter(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_BACK);
        }
        
        private void _nextPolarizationElementsInReceiver(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_SECTOR_FORWARD);
        }
        
        private void _prevPolarizationElementsInReceiver(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_SECTOR_BACK);
        }
        
        private void _takePhoto(object sender, EventArgs e)
        {
            _serviceCCDCamera.makePhoto(_countPhoto);

            string path = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(path + "/testsData/tmp/");
            string date = DateTime.Now.ToString("dd.MM.yyyy");

            if (!Directory.Exists(path + "/testsData/Results/" + date))
            {
                Directory.CreateDirectory(path + "/testsData/Results/" + date + "/Original");
            }

            foreach (var file in files)
            {
                string newPath = file.Replace("tmp", "Results/" + date + "/Original/");
                File.Move(file, newPath);
            }
        }

    }
}
