using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using experiments.InterfacesViews;
using experiments.Presents;
using experiments.Views;

namespace experiments
{
    public partial class ViewMainForm : Form, IViewMainForm
    {

        private string _pathDirectory;
        private string _typeExperiments;
        private float _concentration;
        private string _errorNotConcentration = "Не введена концентрация вещества!";
        private string _errorNotTypeExperiments = "Не выбран тип эксперимента!";

        public event EventHandler<EventArgs> runExperimetns;
        public event EventHandler<EventArgs> openDirectory;

        public ViewMainForm()
        {
            InitializeComponent();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAboutForm view = new ViewAboutForm();
            PresentAboutProgram present = new PresentAboutProgram(view);
            view.Show();
        }

        private void CommonSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCommonSettings view = new ViewCommonSettings();
            PresentCommonSettings present = new PresentCommonSettings(view);
            view.Show();
        }

        private void SettingsLaserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLaserSettings view = new ViewLaserSettings();
            PresentLaserSettings present = new PresentLaserSettings(view);
            view.Show();
        }

        private void SettingsCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCameraSettings view = new ViewCameraSettings();
            PresentCameraSettings present = new PresentCameraSettings(view);
            view.Show();
        }

        private void SettingsStepMotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStepMotorSettings view = new ViewStepMotorSettings();
            PresentStepMotorSettings present = new PresentStepMotorSettings(view);
            view.Show();
        }

        private void RunExperimentsButton_Click(object sender, EventArgs e)
        {
            if (!_checkData())
            {
                return;
            }
            _concentration = float.Parse(this.ConcentrationTextBox.Text);
            runExperimetns(this, EventArgs.Empty);
        }

        private bool _checkData()
        {
            if (this.ConcentrationTextBox.Text == "")
            {
                MessageBox.Show(_errorNotConcentration);
                return false;
            }
            if (_typeExperiments == null)
            {
                MessageBox.Show(_errorNotTypeExperiments);
                return false;
            }
            return true;
        }

        public string getTypeExperiments()
        {
            return _typeExperiments;
        }

        public float getConcentration()
        {
            return _concentration;
        }

        private void ForwardTypeExperimentsButton_Click(object sender, EventArgs e)
        {
            _typeExperiments = "forward";
            this.BackTypeExperimentsButton.BackColor = Color.FromArgb(224,224,224);
            this.ForwardTypeExperimentsButton.BackColor = Color.Green;
        }

        private void BackTypeExperimentsButton_Click(object sender, EventArgs e)
        {
            _typeExperiments = "back";
            this.ForwardTypeExperimentsButton.BackColor = Color.FromArgb(224, 224, 224);
            this.BackTypeExperimentsButton.BackColor = Color.Green;
        }

        public void clearConcentration()
        {
            _concentration = 0;
            this.ConcentrationTextBox.Text = "";
        }

        public string getPathDirectory()
        {
            return _pathDirectory;
        }
        

        private void openFolder_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
            
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _pathDirectory = fbd.SelectedPath;
                    openDirectory(this, EventArgs.Empty);
                }
            }
            openDirectory(this, EventArgs.Empty);
            MessageBox.Show("Digilization is complite");
        }
    }
}
