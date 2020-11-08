using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;
using experiments.Common;

namespace experiments.Models
{
    class ModelSettings
    {
        private static Settings1 _settings;
        public string version { get; }
        public string nameProgram { get; }
        public string aboutProgram { get; }
        private string _pathSaveResult;
        private int _countPhoto;
        private float _powerLaser;
        private int _speedConnectComPort;

        public ModelSettings()
        {
            if (_settings == null)
            {
                _settings = new Settings1();
            }
            version = _settings.Version;
            nameProgram = _settings.NameProgram;
            aboutProgram = _settings.AboutProgram;
            _pathSaveResult = _settings.PathSaveResult;
            _countPhoto = _settings.CountPhoto;
            _powerLaser = _settings.PowerLaser;
            _speedConnectComPort = _settings.SpeedConnectComPort;
        }

        public string getPathSaveResult()
        {
            return _pathSaveResult;
        }
        public void setPathSaveResult(string pathSaveResult)
        {
            _pathSaveResult = pathSaveResult;
            _settings.PathSaveResult = _pathSaveResult;
            //MessageBox.Show(_settings.PathSaveResult);
        }

        public int getCountPhoto()
        {
            return _countPhoto;
        }

        public void setCountPhoto(int countPhoto)
        {
            _countPhoto = countPhoto;
            _settings.CountPhoto = _countPhoto;
            //MessageBox.Show(_settings.CountPhoto.ToString());
        }

        public float getPowerLaser()
        {
            return _powerLaser;
        }

        public void setPowerLaser(float powerLaser)
        {
            _powerLaser = powerLaser;
            _settings.PowerLaser = _powerLaser;
            //MessageBox.Show(_settings.PowerLaser.ToString());
        }

        public int getSpeedConnectComPort()
        {
            return _speedConnectComPort;
        }
    }
}
