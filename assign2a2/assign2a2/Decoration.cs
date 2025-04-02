using System;

namespace CollegeFestEventHandling
{
    public class Decoration
    {
        // Event handler for decoration charges
        public void OnFestEventHandler(object sender, int numPeople)
        {
            // Logic for handling decoration charges based on number of people
            int decorationCharge = 10000 + (numPeople * 10);
            Console.WriteLine($"Decoration charge for {numPeople} people: Rs {decorationCharge}");
        }
    }
}
