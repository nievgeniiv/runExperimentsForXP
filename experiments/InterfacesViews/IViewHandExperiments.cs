using System;

namespace experiments.InterfacesViews
{
    public interface IViewHandExperiments
    {
        event EventHandler<EventArgs> nextCombinationPolarizationElements;
        event EventHandler<EventArgs> prevCombinationPolarizationElements;
        event EventHandler<EventArgs> nextPolarizationElementsInTransmitter;
        event EventHandler<EventArgs> prevPolarizationElementsInTransmitter;
        event EventHandler<EventArgs> nextPolarizationElementsInReceiver;
        event EventHandler<EventArgs> prevPolarizationElementsInReceiver;
        event EventHandler<EventArgs> takePhotoWithCCD;
        int[] getCenter();
    }
}