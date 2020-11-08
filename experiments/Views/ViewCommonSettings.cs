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
    public partial class ViewCommonSettings : Form, IViewCommonSettings
    {
        public string pathSaveResult;

        public ViewCommonSettings()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> setCommonSettings;

        public string getPathSaveResult()
        {
            return String.IsNullOrEmpty(pathSaveResult) ? pathSaveResult : System.IO.Directory.GetCurrentDirectory();
        }

        private void CompliteSaveCommonSettingsButton_Click(object sender, EventArgs e)
        {
            pathSaveResult = this.PathSaveResultTextBox.Text;
            setCommonSettings(this, EventArgs.Empty);
            Close();
        }

        private void ChangeSavePathResultButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathSaveResult = folderBrowserDialog.SelectedPath;
                PathSaveResultTextBox.Text = pathSaveResult;
            }
            else
            {
                MessageBox.Show("Не выбрана папка!");
            }

        }
    }
}
