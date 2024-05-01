using System;

namespace CSC455_ProjectCalculator
{
    public class BasicCalc
    {
        // Add two numbers
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Subtracts the second number from the first
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Multiply two numbers
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        // Divide the first number by the second
        public double Divide(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException("Division by zero not allowed!");
            }
            return num1 / num2;
        }
    }
}