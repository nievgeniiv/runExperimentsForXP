using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using experiments.InterfacesViews;

namespace experiments.Views
{
    public partial class ViewStepMotorSettings : Form, IViewStepMotorSettings
    {

        private string[] _listComPort;
        private string _nameComPort;
        public ViewStepMotorSettings()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> getListComPorts;
        public event EventHandler<EventArgs> connectAndDisconnectComPort;
        public event EventHandler<EventArgs> transmitterStepForward;
        public event EventHandler<EventArgs> transmitterStepBack;
        public event EventHandler<EventArgs> receiverStepForward;
        public event EventHandler<EventArgs> receiverStepBack;
        public event EventHandler<EventArgs> transmitterSectorForward;
        public event EventHandler<EventArgs> transmitterSectorBack;
        public event EventHandler<EventArgs> receiverSectorForward;
        public event EventHandler<EventArgs> receiverSectorBack;
        public event EventHandler<EventArgs> nextGroupStart;
        public event EventHandler<EventArgs> previousGroupStart;
        public event EventHandler<EventArgs> compliteStepMotorSettings;


        private void GetListComPortsButton_Click(object sender, EventArgs e)
        {
            getListComPorts(this, EventArgs.Empty);
        }

        public void setListComPort(string[] listComPort, string selectedComPort)
        {
            _listComPort = listComPort;
            foreach (string nameComPort in _listComPort)
            {
                this.ListComPortsComboBox.Items.Add(nameComPort);
                if (selectedComPort != null)
                {
                    this.ListComPortsComboBox.SelectedItem = selectedComPort;
                }
                else
                {
                    if (_listComPort[0] != null)
                    {
                        this.ListComPortsComboBox.SelectedItem = _listComPort[0];
                    }
                }
            }
        }

        public string getNameComPort()
        {
            return _nameComPort;
        }

        private void ConnectAndDisconnectComPortButton1_Click(object sender, EventArgs e)
        {
            _nameComPort = this.ListComPortsComboBox.GetItemText(this.ListComPortsComboBox.SelectedItem);
            connectAndDisconnectComPort(this, EventArgs.Empty);
        }

        public void setTextButtonForConnectAndDisconnectComPort(string nameButton)
        {
            this.ConnectAndDisconnectComPortButton1.Text = nameButton;
        }

        private void TransmitterStepForwardButton_Click(object sender, EventArgs e)
        {
            transmitterStepForward(this, EventArgs.Empty);
        }

        private void TransmitterStepBackButton1_Click(object sender, EventArgs e)
        {
            transmitterStepBack(this, EventArgs.Empty);
        }

        private void ReceiverStepForwardButton_Click(object sender, EventArgs e)
        {
            receiverStepForward(this, EventArgs.Empty);
        }

        private void ReceiverStepBackButton_Click(object sender, EventArgs e)
        {
            receiverStepBack(this, EventArgs.Empty);
        }

        private void CompliteStepMotorButton_Click(object sender, EventArgs e)
        {
            //compliteStepMotorSettings(this, EventArgs.Empty);
            Close();
        }

        private void TransmitterSectorForward_Click(object sender, EventArgs e)
        {
            transmitterSectorForward(this, EventArgs.Empty);
        }

        private void TransmitterSectorBack_Click(object sender, EventArgs e)
        {
            transmitterSectorBack(this, EventArgs.Empty);
        }

        private void ReceiverSectorForward_Click(object sender, EventArgs e)
        {
            receiverSectorForward(this, EventArgs.Empty);
        }

        private void ReceiverSectorBack_Click(object sender, EventArgs e)
        {
            receiverSectorBack(this, EventArgs.Empty);
        }

        private void nextGroup_Click(object sender, EventArgs e)
        {
            nextGroupStart(this, EventArgs.Empty);
        }

        private void previousGroup_Click(object sender, EventArgs e)
        {
            previousGroupStart(this, EventArgs.Empty);
        }
    }
}
