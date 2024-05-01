using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC455_ProjectCalculator
{
    public partial class AdvancedCalc : Form
    {

        public string selectedCalculation;

        public AdvancedCalc()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Circle Perimeter
        private void circlePerim_Click(object sender, EventArgs e)
        {
            selectedCalculation = "circlePerim";
            label1.Text = "Enter positive value for diameter d";
        }
        private double calcCirclePerim(double d)
        {
            return Math.PI * d;
        }
        #endregion

        #region Triangle Perimeter

        private void trianglePerim_Click(object sender, EventArgs e)
        {
            selectedCalculation = "trianglePerim";
            label1.Text = "Enter positive vals for a,b,c separated by a space";
        }
        private double calcTrianglePerim(double a, double b, double c)
        {
            return a + b + c;
        }

        #endregion

        #region
        private void rectPerim_Click(object sender, EventArgs e)
        {

        }

        private void circleArea_Click(object sender, EventArgs e)
        {

        }

        private void triangleArea_Click(object sender, EventArgs e)
        {

        }

        private void rectArea_Click(object sender, EventArgs e)
        {

        }

        private void dotProd_Click(object sender, EventArgs e)
        {

        }

        private void crossProd_Click(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

        }
        private void CalculateAverage(double x, double y)
        {

        }
        #endregion

        #region Clear & Calculate Buttons
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Get text from textBox1
            string inputText = textBox1.Text.Trim();

            // Exit early if no input
            if (string.IsNullOrEmpty(inputText))
            {
                label1.Text = "Error: No input";
                return;
            }

            // Split numbers using space as delimiter
            string[] inputs = inputText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            // Create list for parsed doubles and add them to list
            List<double> numbers = new List<double>();

            foreach(string input in inputs)
            {
                double number;

                // Add if number is a valid double
                if (double .TryParse(input, out number))
                { 
                    numbers.Add(number); 
                }
                else 
                {
                    label1.Text = "Invalid input. Enter numbers separated by spaces";
                }
            }

            switch (selectedCalculation)
            {
                case "circlePerim":

                    double d = numbers[0];

                    if (d > 0 && numbers.Count == 1)
                    {
                        double perimeter = calcCirclePerim(d);
                        textBox1.Text = perimeter.ToString("N2"); // Format to 2 decimal places
                    }
                    else
                    {
                        MessageBox.Show("Please enter a single, positive number for diameter");
                        textBox1.Text = ""; // Clear textbox for new input
                    }

                    break;
            }
        }
        #endregion

        private void AdvancedCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
