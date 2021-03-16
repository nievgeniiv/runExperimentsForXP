using System;
using System.Collections.Generic;
using System.Text;
using experiments.InterfacesViews;
using experiments.Models;
using experiments.Services;

namespace experiments.Presents
{
    class PresentStepMotorSettings
    {
        private IViewStepMotorSettings _IView;
        private ModelSettings _modelSettings = new ModelSettings();

        private string[] _listComPort;
        private string _selectedComPort;
        public PresentStepMotorSettings(IViewStepMotorSettings IView)
        {
            _IView = IView;
            _changeTextButton();
            _IView.getListComPorts += new EventHandler<EventArgs>(_getListComPort);
            _IView.connectAndDisconnectComPort += new EventHandler<EventArgs>(_connectAndDisconnectComPort);
            _IView.transmitterStepForward += new EventHandler<EventArgs>(_transmitterStepForward);
            _IView.transmitterStepBack += new EventHandler<EventArgs>(_transmitterStepBack);
            _IView.receiverStepForward += new EventHandler<EventArgs>(_receiverStepForward);
            _IView.receiverStepBack += new EventHandler<EventArgs>(_receiverStepBack);
            _IView.transmitterSectorForward += new EventHandler<EventArgs>(_transmitterSectorForward);
            _IView.transmitterSectorBack += new EventHandler<EventArgs>(_transmitterSectorBack);
            _IView.receiverSectorForward += new EventHandler<EventArgs>(_receiverSectorForward);
            _IView.receiverSectorBack += new EventHandler<EventArgs>(_receiverSectorBack);
        }

        private void _getListComPort(object sender, EventArgs e)
        {
            _listComPort = ServiceStepMotor.getAllComPort();
            _IView.setListComPort(_listComPort);
        }

        private void _connectAndDisconnectComPort(object sender, EventArgs e)
        {
            _selectedComPort = _IView.getNameComPort();
            if (!ServiceStepMotor.isConnectComPort())
            {
                int speedConnectComPort = _modelSettings.getSpeedConnectComPort();
                ServiceStepMotor.connectWithComPort(_selectedComPort, speedConnectComPort);
            }
            else
            {
                ServiceStepMotor.disconnectWithComPort();
            }
            _changeTextButton(); 
        }

        private void _transmitterStepForward(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_STEP_FORWARD);
        }

        private void _transmitterStepBack(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_STEP_BACK);
        }

        private void _receiverStepForward(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_STEP_FORWARD);
        }

        private void _receiverStepBack(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_STEP_BACK);
        }
        
        private void _transmitterSectorForward(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_FORWARD);
        }

        private void _transmitterSectorBack(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.TRANSMITTER_SECTOR_BACK);
        }

        private void _receiverSectorForward(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_SECTOR_FORWARD);
        }

        private void _receiverSectorBack(object sender, EventArgs e)
        {
            ServiceStepMotor.stepMotorGo(ServiceStepMotor.RECEIVER_SECTOR_BACK);
        }

        private void _changeTextButton()
        {
            string textButton = "";
            if (!ServiceStepMotor.isConnectComPort())
            {
                textButton = "Соединится с COM-портом";
            }
            else
            {
                textButton = "Отключиться от COM-порта";
                _listComPort = ServiceStepMotor.getAllComPort();
                _selectedComPort = ServiceStepMotor.getSelectedComPort();
                _IView.setListComPort(_listComPort, _selectedComPort);
            }
            _IView.setTextButtonForConnectAndDisconnectComPort(textButton);
        }
    }
}
