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
    public partial class ViewLaserSettings : Form, IViewLaserSettings
    {
        private float _powerLaser;

        public ViewLaserSettings()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> setSettingsLaser;

        private void ComplitePowerLaserButton_Click(object sender, EventArgs e)
        {
            _powerLaser = float.Parse(this.PowerLaserTextBox.Text);
            setSettingsLaser(this, EventArgs.Empty);
            Close();
        }

        public float getPowerLaser()
        {
            return _powerLaser;
        }

        public void setPowerLaser(float powerLaser)
        {
            _powerLaser = powerLaser;
            this.PowerLaserTextBox.Text = _powerLaser.ToString();
        }
    }
}
