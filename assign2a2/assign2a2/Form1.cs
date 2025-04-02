using System;
using System.Windows.Forms;

namespace CollegeFestEventHandling
{
    public partial class Form1 : Form
    {
        // Declare the College object (Publisher)
        private College college;

        // Declare the Catering and Decoration objects (Subscribers)
        private Catering catering;
        private Decoration decoration;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        // Form Load event handler
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the objects
            college = new College();
            catering = new Catering();
            decoration = new Decoration();

            // Subscribe to the event
            college.OnFestEvent += catering.OnFestEventHandler;
            college.OnFestEvent += decoration.OnFestEventHandler;
        }

        // Button click event handler
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int numPeople;

            // Try to parse the number of people from the textbox
            if (int.TryParse(txtNumPeople.Text, out numPeople))
            {
                try
                {
                    // Raise the event to notify subscribers
                    college.RaiseFestEvent(numPeople);

                    // Calculate the catering and decoration charges
                    int cateringCharge = numPeople * 200;
                    int decorationCharge = 10000 + (numPeople * 10);

                    // Display the results
                    lblResult.Text = $"Total Catering Charge: Rs {cateringCharge}{Environment.NewLine}Total Decoration Charge: Rs {decorationCharge}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
