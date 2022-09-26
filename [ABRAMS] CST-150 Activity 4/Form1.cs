// Jared L. Abrams// CST-150// September 25, 2022// This is my own work

namespace _ABRAMS__CST_150_Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Convert input into seconds, minutes, days or hours
        private void readInputButton_Click(object sender, EventArgs e)
        {
            double timeElapsedInputDouble = double.Parse(timeElapsedInput.Text); // Parse input string into double
            double timeElapsedOutputDouble; // Time elapsed output
            String timeElapsedOutputString; // Time elapsed output converted back into string for textbox

            if (timeElapsedInputDouble >= 86400) // If input is more than one day worth of seconds
            {
                timeElapsedOutputDouble = timeElapsedInputDouble / 86400; // Divide input by one day worth of seconds
                timeElapsedOutputString = Convert.ToString(timeElapsedOutputDouble); // Convert output into string
                timeElapsedOutput.Text = timeElapsedOutputString + " day(s)"; // Output to user
            }
            else if (timeElapsedInputDouble >= 3600 && timeElapsedInputDouble < 86400) // If input is more than one hour worth of seconds
            {
                timeElapsedOutputDouble = timeElapsedInputDouble / 3600; // Divide input by one hour worth of seconds
                timeElapsedOutputString = Convert.ToString(timeElapsedOutputDouble); // Convert output into string
                timeElapsedOutput.Text = timeElapsedOutputString + " hour(s)"; // Output to user
            }
            else if (timeElapsedInputDouble >= 60 && timeElapsedInputDouble < 3600) // If input is more than one minute worth of seconds
            {
                timeElapsedOutputDouble = timeElapsedInputDouble / 60; // Divide input by one minute worth of seconds
                timeElapsedOutputString = Convert.ToString(timeElapsedOutputDouble); // Convert output into string
                timeElapsedOutput.Text = timeElapsedOutputString + " minute(s)"; // Output to user
            }
            else // If input is less than one minute worth of seconds
            {
                timeElapsedOutput.Text = timeElapsedInput.Text + " second(s)"; // Output to user
            }
        }
    }
}