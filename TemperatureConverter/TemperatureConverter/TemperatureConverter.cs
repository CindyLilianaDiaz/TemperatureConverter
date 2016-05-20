using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TemperatureConverter
{
    /// <summary>
    /// This application lets you convert temperature from Celsius to Fahrenheit and vice versa.
    /// </summary>
    public partial class temperatureConverterForm : Form
    {
        // Global Variables
        private const int FREEZING_POINT_WATER = 32;
        private const double FAHRENHEIT_SCALE_DIFFERENCE = 1.8;

        public temperatureConverterForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Convert user input (temperature in Fahrenheit) to Celsius
        /// </summary>
        /// <param name="input">Temperature in Fahrenheit</param>
        private void convertToCelsius(double input)
        {
            temperatureCelsiusTextBox.Text = Math.Round(((input - FREEZING_POINT_WATER) / FAHRENHEIT_SCALE_DIFFERENCE), 2).ToString();
            temperatureFahrenheitTextBox.Text = temperatureTextBox.Text;
        }

        /// <summary>
        /// Convert the user input (temperature n Celsius) to Fahrenheit
        /// </summary>
        /// <param name="input">Temperature in Celsius</param>
        private void convertToFahrenheit(double input)
        {           
            temperatureFahrenheitTextBox.Text = Math.Round(((input * FAHRENHEIT_SCALE_DIFFERENCE) + FREEZING_POINT_WATER), 2).ToString();
            temperatureCelsiusTextBox.Text = temperatureTextBox.Text;                      
        }

        /// <summary>
        /// "Convert" button handler.  Checks the radio button that was checked and calls the proper method based on the selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            double input = 0;
            // Try and catch block to try convert String (user input) to a double
            try
            {
                input = Convert.ToDouble(temperatureTextBox.Text);

                if (celsiusRadioButton.Checked)
                {
                    convertToCelsius(input);
                }
                else if (fahrenheitRadioButton.Checked)
                {
                    convertToFahrenheit(input);
                }
                // If none of the radio buttons buttons was selected show appropiate message with instructions        
                else
                {
                    MessageBox.Show("You must select a conversion option first.", "Conversion option not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("You must enter a number in the temperature field.", "Invalid input - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Method to reset all the values to its initial form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            temperatureTextBox.Text = "0";
            celsiusRadioButton.Checked = false;
            fahrenheitRadioButton.Checked = false;
            temperatureCelsiusTextBox.Clear();
            temperatureFahrenheitTextBox.Clear();
        }

        /// <summary>
        /// "Exit" button handler. Terminates application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
