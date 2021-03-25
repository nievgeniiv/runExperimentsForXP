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
    public partial class ViewCameraSettings : Form, IViewCameraSettings
    {

        public int countPhoto { get; set; }
        public string mode { get; set; }

        public ViewCameraSettings()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> setSettings;

        public void setCountPhoto(int countPhoto)
        {
            this.countPhoto = countPhoto;
            this.CountPhotoTextBox.Text = this.countPhoto.ToString();
        }

        public int getCountPhoto()
        {
            return countPhoto;
        }

        private void SaveCameraSettingsButton_Click(object sender, EventArgs e)
        {
            countPhoto = Convert.ToInt32(CountPhotoTextBox.Text);
            if (modeHand.Checked)
            {
                mode = "hand";
            }
            else
            {
                mode = "auto";
            }
            setSettings(this, EventArgs.Empty);
            Close();
        }

        public string getMode()
        {
            return mode;
        }
    }
}
