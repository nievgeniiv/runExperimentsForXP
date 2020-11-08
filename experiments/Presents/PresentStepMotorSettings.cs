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
            ServiceStepMotor.transmitterStepForward();
        }

        private void _transmitterStepBack(object sender, EventArgs e)
        {
            ServiceStepMotor.transmitterStepBack();
        }

        private void _receiverStepForward(object sender, EventArgs e)
        {
            ServiceStepMotor.receiverStepForward();
        }

        private void _receiverStepBack(object sender, EventArgs e)
        {
            ServiceStepMotor.receiverStepBack();
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
