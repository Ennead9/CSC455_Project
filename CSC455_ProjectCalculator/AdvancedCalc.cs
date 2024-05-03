using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC455_ProjectCalculator
{
    #region AdvancedCalc
    public partial class AdvancedCalc : Form
    {

        private CalculatorLogic calculator = new CalculatorLogic();

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
            setupStuff("rectanglePerim", true, "Enter positive values for length and width separated by a space");
        }
        private void circlePerim_Click(object sender, EventArgs e)
        {
            setupStuff("circlePerim", true, "Enter a positive value for diameter d");
        }
        private void trianglePerim_Click(object sender, EventArgs e)
        {
            setupStuff("trianglePerim", true, "Enter values for a, b, & c, separated by space");
        }
        private void btnAverage_Click(object sender, EventArgs e)
        {
            setupStuff("calcAverage", false, "Enter as many values as desired, separated by spaces");
        }
        private void dotProd_Click(object sender, EventArgs e)
        {
            setupStuff("dotProduct", false, "Enter 3 values for first vector, then for the second vector, separated by spaces");
        }

        private void crossProd_Click(object sender, EventArgs e)
        {
            setupStuff("crossProduct", false, "Enter 3 values for first vector, then for the second vector, separated by spaces");
        }
        #endregion

        #region Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            geometryCalculation = false;
            label1.Text = "Please Select Your Calculation";
            textBox1.Text = "";
            labelResult.Text = "";
        }
        #endregion
        #region Parse Text
        // Parses text in textBox1 and converts to list of doubles, delimited by ' '
        public List<double> ParseInput(string inputText)
        {
            var numbers = new List<double>();
            var inputs = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var input in inputs)
            {
                // Add if number is a valid double
                if (double.TryParse(input, out double number))
                {
                    numbers.Add(number);
                } else {
                    label1.Text = "Invalid input. Enter numbers separated by spaces";
                    return null;
                }
            }
            return numbers;
        }
        #endregion

        public void PerformCalculations(List<double> numbers)
        {
            // Switch statements to handle proper calculation
            switch (selectedCalculation)
            {
                #region Perimeters
                case "circlePerim":
                    if (numbers.Count == 1) //if statement to ensure parameters are met
                    {
                        double perimeter = calculator.CalcCirclePerimeter(numbers[0]);
                        textBox1.Text = perimeter.ToString("N2"); // Format to 2 decimal places
                    } else {
                        MessageBox.Show("Please enter a single, positive number for diameter");
                        textBox1.Text = ""; // Clear textbox for new input
                    }
                    break;

                case "trianglePerim":
                    if (numbers.Count == 3)
                    {
                        double perimeter = calculator.CalcTrianglePerimeter(numbers[0], numbers[1], numbers[2]);
                        labelResult.Text = perimeter.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Please enter 3 single, positive numbers for side lengths");
                        textBox1.Text = "";
                    }
                    break;

                // Condense / Combine with area of rectangle?
                case "rectanglePerim":
                    if (numbers.Count == 2) //if statement to ensure parameters are met
                    {
                        double perimeter = calculator.CalcRectanglePerimeter(numbers[0], numbers[1]);
                        labelResult.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for length l and width w");
                    }
                    break;
                #endregion
                #region Areas
                case "areaCircle":
                    if (numbers.Count == 1) //if statement to ensure parameters are met
                    {
                        double area = calculator.CalcCircleArea(numbers[0]);
                        labelResult.Text = area.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter a postive value for radius r");
                    }
                    break;

                case "areaTriangle":
                    if (numbers.Count == 2) //if statement to ensure parameters are met
                    {
                        double perimeter = calculator.CalcTriangleArea(numbers[0], numbers[1]);
                        labelResult.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for base b and height h");
                    }
                    break;

                case "areaRectangle":
                    if (numbers.Count == 2) //if statement to ensure parameters are met
                    {
                        double perimeter = calculator.CalcRectangleArea(numbers[0], numbers[1]);
                        labelResult.Text = perimeter.ToString("N2");
                    } else {
                        MessageBox.Show("Please enter positive numbers for length l and width w");
                    }
                    break;
                #endregion

                case "calcAverage":
                    double avg = calculator.CalcAverage(numbers);
                    labelResult.Text = avg.ToString("N2");

                    break;

                case "dotProduct":
                    if (numbers.Count == 6) //if statement to ensure parameters are met
                    {
                        double dotProd = calculator.CalcDotProduct(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]);
                        labelResult.Text = dotProd.ToString(); //prints out solution as a string

                    }
                    else { MessageBox.Show("Please enter 6 numbers. If a value is not present type 0 in its place"); }
                    break;

                case "crossProduct":
                    if (numbers.Count == 6) //if statement to ensure parameters are met
                    {
                        (double sol1, double sol2, double sol3) = calculator.CalcCrossProduct(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]);
                        labelResult.Text = sol1.ToString() + "i, " + sol2.ToString() + "j, " + sol3.ToString() + "k"; //printing results for x, y, z values (i, j, k)

                    }
                    else { MessageBox.Show("Please enter 6 numbers. If a value is not present type 0 in its place"); }

                    break;

                case "quadRoot":
                    if (numbers.Count == 3)
                    {
                        (double root1, double root2) = calculator.CalcQuadRoot(numbers[0], numbers[1], numbers[2]);
                        if(double.IsNaN(root1) || double.IsNaN(root2))
                        {
                            MessageBox.Show("Error: One or more non-real roots.");
                            break;
                        }
                        labelResult.Text = $"x = {root1.ToString("N2")}, {root2.ToString("N2")}";
                    } else
                    {
                        MessageBox.Show("Please enter 3 numbers for coefficients a, b, c from form of ax^2+bx+c.");
                    }
                    break;
            }
        }
        #region Calculate Btn
        public void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get text from textBox1
            string inputText = textBox1.Text.Trim();

            // Exit early if no input
            if (string.IsNullOrEmpty(inputText))
            {
                label1.Text = "Error: No input";
                return;
            }
            var numbers = ParseInput(inputText);
            if (numbers == null) return;

            PerformCalculations(numbers);
          
        }

        private void AdvancedCalc_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
    #endregion

    public class CalculatorLogic
    {
        #region Perimeters
        public double CalcCirclePerimeter(double diameter)
        {
            if (diameter <= 0)
                throw new ArgumentException("Diameter must be a postive number.");
            return Math.PI * diameter;
        }
        public double CalcTrianglePerimeter(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Values must be positive");
            return a + b + c;
        }
        public double CalcRectanglePerimeter(double l, double w)
        {
            if (l <= 0 || w <= 0)
                throw new ArgumentException("Values must be positive");
            return 2 * l + 2 * w;
        }
        #endregion
        #region Areas
        public double CalcCircleArea(double r)
        {
            if (r <= 0)
                throw new ArgumentException("Value must be positive");
            return Math.PI * (r * r);
        }
        public double CalcTriangleArea(double b, double h)
        {
            if (b <= 0 || h <= 0)
                throw new ArgumentException("Values must be positive");
            return 0.5 * b * h;
        }
        public double CalcRectangleArea(double l, double w)
        {
            if ((l <= 0) || (w <= 0))
                throw new ArgumentException("Values must be positive");
            return l * w;
        }
        #endregion
        public double CalcAverage(List<double> numbers)
        {
            double total = 0;
            foreach (double num in numbers)
            {
                total += num;
            }
            return total / numbers.Count;
        }
        public double CalcDotProduct(double ax, double ay, double az, double bx, double by, double bz)
        {
            double solution1 = ax * bx + ay * by + az * bz; //dot product formula
            return solution1;
        }

        public (double, double, double) CalcCrossProduct(double ai, double aj, double ak, double bi, double bj, double bk)
        {
            double solution1 = aj * bk - ak * bj; //formula for x value
            double solution2 = ak * bi - ai * bk; //formula for y value
            double solution3 = ai * bj - aj * bi; //formula for z value 

            return (solution1, solution2, solution3);
        }

        public (double, double) CalcQuadRoot(double a, double b, double c)
        {
            double root1, root2;
            double det = b * b - 4 * a * c;
            if (det < 0)
            {
                return (double.NaN, double.NaN);
            }
            root1 = (-1 * b + Math.Sqrt(det)) / 2 * a;
            root2 = (-1 * b - Math.Sqrt(det)) / 2 * a;

            return (root1, root2);
        }
    }
}
