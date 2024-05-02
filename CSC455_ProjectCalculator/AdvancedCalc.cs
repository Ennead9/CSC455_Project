using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC455_ProjectCalculator
{
    public partial class AdvancedCalc : Form
    {
        public string selectedCalculation;
        public bool geometryCalculation = false;

        public AdvancedCalc()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Button Click Handlers
        private void setupStuff(string selectedCalc, bool geometryCalc, string label1Text)
        {
            selectedCalculation = selectedCalc;
            geometryCalculation = geometryCalc;
            label1.Text = label1Text;
        }
        private void btnQuadRoot_Click(object sender, EventArgs e)
        {
            setupStuff("quadRoot", false, "Enter a,b,c for form of ax^2+bx+c separated by a space");
        }
        private void triangleArea_Click(object sender, EventArgs e)
        {
            setupStuff("areaTriangle", true, "Enter positive vals for base b and height h");
        }
        private void rectArea_Click(object sender, EventArgs e)
        {
            setupStuff("rectangleArea", true, "Enter postive values for length and width separated by a space");
        }
        private void circleArea_Click(object sender, EventArgs e)
        {
            setupStuff("areaCircle", true, "Enter a positive value for radius r");
        }
        private void rectPerim_Click(object sender, EventArgs e)
        {
            setupStuff("rectanglePerim", true, "Enter positive vals for length and width separated by a space");
        }
        private void circlePerim_Click(object sender, EventArgs e)
        {
            setupStuff("circlePerim", true, "Enter positive value for diameter d");
        }
        private void trianglePerim_Click(object sender, EventArgs e)
        {
            setupStuff("trianglePerim", true, "Enter vals for a, b, & c, separated by a space");
        }
        private void btnAverage_Click(object sender, EventArgs e)
        {
            setupStuff("calcAverage", false, "Enter vals separated by a space");
        }
        private void dotProd_Click(object sender, EventArgs e)
        {
            setupStuff("dotProduct", false, "Enter values for first vector, then second vector, separated by a space");
        }

        private void crossProd_Click(object sender, EventArgs e)
        {
            setupStuff("crossProduct", false, "Enter values for first vector, then second vector, separated by a space");
        }
        #endregion

        #region Calculation Functions

        private (double, double) calcQuadRoot(double a, double b, double c)
        {
            double root1, root2;
            double det = b * b - 4 * a * c;
            if(det < 0)
            {
                label1.Text = "Error: No real roots";
            }
            root1 = (-1 * b + Math.Sqrt(det)) / 2 * a;
            root2 = (-1 * b - Math.Sqrt(det)) / 2 * a;

            return (root1, root2);
        }

        #endregion

        #region Clear & Calculate Buttons
        private void btnClear_Click(object sender, EventArgs e)
        {
            geometryCalculation = false;
            textBox1.Text = "";
            labelResult.Text = "";
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
                } else {
                    label1.Text = "Invalid input. Enter numbers separated by spaces";
                }
            }
            
            // Switch statements to handle proper calculation
            switch (selectedCalculation)
            {
                case "circlePerim":
                    double d = numbers[0];
                    if (d > 0 && numbers.Count == 1)
                    {
                        double perimeter = Math.PI * d;
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
                        double perimeter = a + b + c;
                        labelResult.Text = perimeter.ToString("N2");
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
                        double perimeter = l + w;
                        labelResult.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for length l and width w");
                    }
                    break;

                case "areaCircle":

                    double r = numbers[0];
                    if(r > 0)
                    {
                        double area = Math.PI * (r*r);
                        labelResult.Text = area.ToString("N2");
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
                        labelResult.Text = perimeter.ToString("N2");
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
                        labelResult.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for length l and width w");
                    }
                    break;

                case "calcAverage":
                    double total = 0;
                    foreach(double num in numbers)
                    {
                        total += num;
                    }
                    double avg = total / numbers.Count;
                    labelResult.Text = avg.ToString("N2");

                    break;

                case "dotProduct":
                    if (numbers.Count == 6)
                    {
                        double ax = numbers[0];
                        double ay = numbers[1];
                        double az = numbers[2];
                        double bx = numbers[3];
                        double by = numbers[4];
                        double bz = numbers[5];
                        double solution1 = ax*bx + ay*by + az*bz;
                        labelResult.Text = solution1.ToString();

                    }
                    else { MessageBox.Show("Please enter 6 numbers. If a value is not present type 0 in its place"); }
                    break;

                case "crossProduct":
                    if (numbers.Count == 6)
                    {
                        double ax = numbers[0];
                        double ay = numbers[1];
                        double az = numbers[2];
                        double bx = numbers[3];
                        double by = numbers[4];
                        double bz = numbers[5];
                        double solution1 = ay * bz - az * by;
                        double solution2 = az * bx - ax * bz;
                        double solution3 = ax * by - ay * bx;
                        labelResult.Text = solution1.ToString() + ", " + solution2.ToString() + ", " + solution3.ToString();

                    } else { MessageBox.Show("Please enter 6 numbers. If a value is not present type 0 in its place"); }

                    break;

                case "quadRoot":
                    if(numbers.Count == 3)
                    {
                        double a2 = numbers[0];
                        double b2 = numbers[1];
                        double c2 = numbers[2];

                        (double root1, double root2) = calcQuadRoot(a2, b2, c2);
                        textBox1.Text = $"x = {root1}, {root2}";
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
