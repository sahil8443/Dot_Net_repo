using System;

namespace CollegeFestEventHandling
{
    public class Catering
    {
        // Event handler for catering charges
        public void OnFestEventHandler(object sender, int numPeople)
        {
            // Logic for handling catering based on number of people
            int cateringCharge = numPeople * 200;
            Console.WriteLine($"Catering charge for {numPeople} people: Rs {cateringCharge}");
        }
    }
}
