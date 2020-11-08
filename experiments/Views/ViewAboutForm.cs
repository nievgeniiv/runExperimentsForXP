using experiments.InterfacesViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace experiments.Views
{
    partial class ViewAboutForm : Form, IViewAboutForm
    {

        public ViewAboutForm()
        {
            InitializeComponent();
        }


        public void setData(string version, string nameProgram, string aboutProgram)
        {
            this.Text = String.Format("О программе {0}", nameProgram);
            this.labelProductName.Text = nameProgram;
            this.labelVersion.Text = String.Format("Версия {0}", version);
            this.textBoxDescription.Text = aboutProgram;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
