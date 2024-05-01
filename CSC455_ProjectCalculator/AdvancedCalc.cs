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
        public bool geometryCalc = false;

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
            geometryCalc = true;

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
            geometryCalc = true;

            label1.Text = "Enter positive vals for a,b,c separated by a space";
        }
        private double calcTrianglePerim(double a, double b, double c)
        {
            return a + b + c;
        }

        #endregion

        #region Rectangle Perimeter
        private void rectPerim_Click(object sender, EventArgs e)
        {
            selectedCalculation = "rectanglePerim";
            geometryCalc = true;

            label1.Text = "Enter positive vals for length and width separated by a space";
        }
        private double calcRectanglePerim(double l, double w)
        {
            return 2*l + 2*w;
        }
        #endregion

        #region Area of Circle
        private void circleArea_Click(object sender, EventArgs e)
        {
            selectedCalculation = "areaCircle";
            geometryCalc= true;

            label1.Text = "Enter a positive value for radius r";
        }
        #endregion
        #region Area of Triangle
        private void triangleArea_Click(object sender, EventArgs e)
        {
            selectedCalculation = "areaTriangle";
            geometryCalc= true;

            label1.Text = "Enter positive vals for base b and height h";
        }
        #endregion
        #region Area of Rectangle
        private void rectArea_Click(object sender, EventArgs e)
        {
            selectedCalculation = "rectangleArea";
            geometryCalc= true;

            label1.Text = "Enter postive values for length and width separated by a space";
        }
        #endregion
        #region



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
            geometryCalc = false;
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
                    } else {
                        MessageBox.Show("Please enter a single, positive number for diameter");
                        textBox1.Text = ""; // Clear textbox for new input
                    }
                    break;

                case "trianglePerim":
                    double a = numbers[0];
                    double b = numbers[1];
                    double c = numbers[2];
                    if(a > 0 && b > 0 && c > 0)
                    {
                        double perimeter = calcTrianglePerim(a,b,c);
                        textBox1.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter 3 single, positive numbers for side lengths");
                        textBox1.Text = "";
                    }
                    break;

                // Condense / Combine with area of rectangle?
                case "rectanglePerim":
                    double l = numbers[0];
                    double w = numbers[1];
                    if(l > 0 && w > 0)
                    {
                        double perimeter = calcRectanglePerim(l, w);
                        textBox1.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for length l and width w");
                    }
                    break;

                case "areaCircle":

                    double r = numbers[0];
                    if(r > 0)
                    {
                        double area = Math.PI * (r*r);
                    } else {
                        MessageBox.Show("Please enter a postive value for radius r");
                    }
                    break;

                case "areaTriangle":

                    double ba = numbers[0];
                    double h = numbers[1];

                    if (ba > 0 && h > 0)
                    {
                        double perimeter = 0.5 * ba * h;
                        textBox1.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for base b and height h");
                    }
                    break;

                case "areaRectangle":

                    double l2 = numbers[0];
                    double w2 = numbers[1];
                    if (l2 > 0 && w2 > 0)
                    {
                        double perimeter = l2 * w2;
                        textBox1.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for length l and width w");
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
