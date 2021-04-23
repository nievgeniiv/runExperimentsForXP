using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
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
        private int[] _center = new int[2];

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
            _center = _IView.getCenter();
            _serviceCCDCamera = new ServiceCCDCamera("hand");
            _serviceCCDCamera.makePhoto(_countPhoto);
            //_position = 1;
            var nameDir = _getNameDir();
            string path = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(path + "/testsData/tmp/");
            string date = DateTime.Now.ToString("dd.MM.yyyy");

            if (!Directory.Exists(path + "/testsData/Results/" + date + "/Original/" + nameDir))
            {
                Directory.CreateDirectory(path + "/testsData/Results/" + date + "/Original/" + nameDir);
            }

            string newPath = "";
            foreach (var file in files)
            {
                newPath = file.Replace("tmp", "Results/" + date + "/Original/"+ nameDir + "/");
                File.Move(file, newPath);
            }
            
            ServiceDigitizationBMP.run(path + "/testsData/Results/" + date + "/Original/" + nameDir + "/", _center);
        }

        private string _getNameDir()
        {
            switch (_position)
            {
                case 1:
                    return "0_0";
                case 2:
                    return "45_0";
                case 3:
                    return "90_0";
                case 4:
                    return "ц_0";
                case 5:
                    return "0_45";
                case 6:
                    return "45_45";
                case 7:
                    return "90_45";
                case 8:
                    return "ц_45";
                case 9:
                    return "0_90";
                case 10:
                    return "45_90";
                case 11:
                    return "90_90";
                case 12:
                    return "ц_90";
                case 13:
                    return "0_ц";
                case 14:
                    return "45_ц";
                case 15:
                    return "90_ц";
                case 16:
                    return "ц_ц";
            }

            return "";
        }

    }
}
