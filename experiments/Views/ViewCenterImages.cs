using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using experiments.InterfacesViews;

namespace experiments.Views
{
    public partial class ViewCenterImages : Form, IViewCenterImages
    {
        
        private string _pathDirectory;
        private int[] _centerPxl = new int[2];
        
        public ViewCenterImages()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _centerPxl[0] = Convert.ToInt32(textBox1.Text);
            _centerPxl[1] = Convert.ToInt32(textBox2.Text);
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
            
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _pathDirectory = fbd.SelectedPath;
                    openDirectory(this, EventArgs.Empty);
                    
                }
            }
            //openDirectory(this, EventArgs.Empty);
            MessageBox.Show("Digilization is complite");
        }

        public event EventHandler<EventArgs> openDirectory;
        
        public string getPathDirectory()
        {
            return _pathDirectory;
        }

        public void setPathDirectory(string path)
        {
            _pathDirectory = path;
        }

        public int[] getCenterPxl()
        {
            return _centerPxl;
        }
    }
}