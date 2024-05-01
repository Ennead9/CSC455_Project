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
            textBox1.Text = "Enter positive value for diameter d";
            
        }
        private double calcCirclePerim(double d)
        {
            return Math.PI * d;
        }
        #endregion

        #region
        private void trianglePerim_Click(object sender, EventArgs e)
        {

        }

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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch (selectedCalculation)
            {
                case "circlePerim":

                    double d;
                    if (double.TryParse(textBox1.Text, out d) && d > 0)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void AdvancedCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
