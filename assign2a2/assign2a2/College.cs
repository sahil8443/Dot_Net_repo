using System;

namespace CollegeFestEventHandling
{
    public class College
    {
        // Declare the event using EventHandler
        public event EventHandler<int> OnFestEvent;

        // Method to raise the event
        public void RaiseFestEvent(int numPeople)
        {
            // Check if any subscribers are present, then invoke the event
            OnFestEvent?.Invoke(this, numPeople);
        }
    }
}
