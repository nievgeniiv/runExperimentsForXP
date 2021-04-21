using System;
using System.Windows.Forms;
using experiments.InterfacesViews;

namespace experiments.Views
{
    public partial class ViewHandExperiments : Form, IViewHandExperiments
    {
        private int[] _center = new int[2];

        public ViewHandExperiments()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> nextCombinationPolarizationElements;
        public event EventHandler<EventArgs> prevCombinationPolarizationElements;
        public event EventHandler<EventArgs> nextPolarizationElementsInTransmitter;
        public event EventHandler<EventArgs> prevPolarizationElementsInTransmitter;
        public event EventHandler<EventArgs> nextPolarizationElementsInReceiver;
        public event EventHandler<EventArgs> prevPolarizationElementsInReceiver;
        public event EventHandler<EventArgs> takePhotoWithCCD;

        private void nextCombination_Click(object sender, EventArgs e)
        {
            nextCombinationPolarizationElements(this, EventArgs.Empty);
        }

        private void prevCombination_Click(object sender, EventArgs e)
        {
            prevCombinationPolarizationElements(this, EventArgs.Empty);
        }

        private void nextElementTransmitter_Click(object sender, EventArgs e)
        {
            nextPolarizationElementsInTransmitter(this, EventArgs.Empty);
        }

        private void prevElementTransmitter_Click(object sender, EventArgs e)
        {
            prevPolarizationElementsInTransmitter(this, EventArgs.Empty);
        }

        private void nextElementReceiver_Click(object sender, EventArgs e)
        {
            nextPolarizationElementsInReceiver(this, EventArgs.Empty);
        }

        private void prevElementReceiver_Click(object sender, EventArgs e)
        {
            prevPolarizationElementsInReceiver(this, EventArgs.Empty);
        }

        private void takePhoto_Click(object sender, EventArgs e)
        {
            _center[0] = Int32.Parse(CenterX.Text);
            _center[1] = Int32.Parse(CenterY.Text);
            takePhotoWithCCD(this, EventArgs.Empty);
        }

        public int[] getCenter()
        {
            return _center;
        }
    }
}