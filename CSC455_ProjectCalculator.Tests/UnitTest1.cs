using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC455_ProjectCalculator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management.Instrumentation;
using System.Windows.Markup;

namespace CSC455_ProjectCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private AdvancedCalc _advancedCalc;
        private CalculatorLogic _calculator;
        
        [TestInitialize]
        public void Initialize()
        {
            _advancedCalc = new AdvancedCalc();
            _calculator = new CalculatorLogic();
        }

        // Test to parse input
        [TestMethod]
        public void ParseInput_ValidInput_ReturnsCorrectList()
        {
            // Arrange
            var input = "3.2 4.5 5";
            var expected = new List<double> { 3.2, 4.5, 5 };

            // Act
            var result = _advancedCalc.ParseInput(input);

            // Assert
            CollectionAssert.AreEqual(expected, result, "Parsed doubles do not match expected values");
        }
        [TestMethod]
        public void ParseInput_InvalidInput_ReturnsNull()
        {
            // Arrange
            var input = "3.5 three 5";

            // Act
            var result = _advancedCalc.ParseInput(input);

            // Assert
            Assert.IsNull(result, "Expected result to be null due to invalid input 'three'");
        }
        [TestMethod]
        public void ParseInput_EmptyString_ReturnsEmptyList()
        {
            // Arrange
            var input = "";

            // Act
            var result = _advancedCalc.ParseInput(input);

            // Assert
            Assert.IsNotNull(result, "Expected non-null list for empty input");
            Assert.AreEqual(0, result.Count, "Expected empty list for empty input.");
        }



        //Test method to test circle perimeter
        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 3)]
        public void CirclePerimeter_Returns_Correct_Value(params int[] values) 
        {
            // Arrange
            var input = (values[0]/Math.PI);

            // Act
            var result = _calculator.CalcCirclePerimeter(input);

            //Assert
            Assert.AreEqual(values[1], result, "Expected integer of 1 for result");
        }
        //Test method to test circle perimeter *will fail
        [TestMethod]
        [DataRow(1, 3)]
        [DataRow(2, 4)]
        [DataRow(3, 1)]
        public void CirclePerimeter_Returns_Incorrect_Value(params int[] values)
        {
            // Arrange
            var input = (values[0] / Math.PI);

            // Act
            var result = _calculator.CalcCirclePerimeter(input);

            //Assert
            Assert.AreNotEqual(values[1], result, "Expected integer of 1 for result");
        }

        [TestMethod]
        [DataRow(1, 2, 3, 6)]
        [DataRow(4, 5, 6, 15)]
        [DataRow(10, 11, 12, 33)]
        public void TrianglePerimeter_ReturnsCorrectValue(params int[] values)
        {
            //Arrange
            var input1 = values[0];
            var input2 = values[1];
            var input3 = values[2];

            //Act
            var result = _calculator.CalcTrianglePerimeter(input1, input2, input3);

            // Assert
            Assert.AreEqual(values[3], result, "Expected integer" + values[3] + "as result");

        }

        [TestMethod]
        [DataRow(1, 2, 3, 12)]
        [DataRow(4, 5, 6, 17)]
        [DataRow(10, 11, 12, 31)]
        public void TrianglePerimeter_ReturnsIncorrectValue(params int[] values)
        {
            //Arrange
            var input1 = values[0];
            var input2 = values[1];
            var input3 = values[2];

            //Act
            var result = _calculator.CalcTrianglePerimeter(input1, input2, input3);

            // Assert
            Assert.AreNotEqual(values[3], result, "Result should not equal" + values[3]);

        }

        [TestMethod]
        [DataRow(1, 2, 6)]
        [DataRow(2, 4, 12)]
        public void RectanglePerimeter_ReturnsCorrectValue(params int[] values)
        {
            //Arrange
            var input1 = values[0];
            var input2 = values[1];

            //Act
            var result = _calculator.CalcRectanglePerimeter(input1, input2);

            //Assert
            Assert.AreEqual(values[2], result, "Expected integer" + values[2] + "as result");
        }

        [TestMethod]
        [DataRow(1, 2, 10)]
        [DataRow(2, 4, 15)]
        public void RectanglePerimeter_ReturnsIncorrectValue(params int[] values)
        {
            //Arrange
            var input1 = values[0];
            var input2 = values[1];

            //Act
            var result = _calculator.CalcRectanglePerimeter(input1, input2);

            //Assert
            Assert.AreNotEqual(values[2], result, "Result should not equal " + values[2]);
        }


        // CalcCircleArea Tests
        [TestMethod]
        public void CircleArea_ReturnsCorrectValue()
        {
            //Arrange
            var radius = 2;
            var sol = (radius * radius) * Math.PI;

            //Act
            var result = _calculator.CalcCircleArea(radius);

            //Assert
            Assert.AreEqual(sol, result, "Expected integer" + sol + "as result");
        }
        [TestMethod]
        [DataRow(2)]
        public void CircleArea_ReturnsIncorrectValue(params int[] values)
        {
            //Arrange
            var radius = values[0];
            var sol = (radius * radius) * Math.PI + 1;

            //Act
            var result = _calculator.CalcCircleArea(radius);

            //Assert
            Assert.AreNotEqual(sol, result, "Result should not equal " + sol);
        }
        [TestMethod]
        [DataRow(-5)]
        [ExpectedException(typeof(ArgumentException), "Value must be positive")]
        public void CircleArea_ThrowsArgumentException(params int[] values)
        {
            // Arrange
            double r = values[0];

            // Act
            _calculator.CalcCircleArea(r);
        }

        // CalcTriangleArea Tests
        [TestMethod]
        [DataRow(6, 10, 30)]
        [DataRow(8, 15, 60)]
        [DataRow(10, 12, 60)]
        public void TriangleArea_ReturnsCorrectValue(params int[] values)
        {
            // Arrange
            double b = values[0];
            double h = values[1];

            // Act
            var result = _calculator.CalcTriangleArea(b, h);

            // Assert
            Assert.AreEqual(values[2], result, "Expected area of " + values[2] + " for result.");
        }
        [TestMethod]
        [DataRow(6, 10, 29)]
        [DataRow(8, 15, 66)]
        [DataRow(10, 12, 14)]
        public void TriangleArea_ReturnsIncorrectValue(params int[] values)
        {
            // Arrange
            double b = values[0];
            double h = values[1];

            // Act
            var result = _calculator.CalcTriangleArea(b, h);

            // Assert
            Assert.AreNotEqual(values[2], result, "Result should not equal " + values[2]);

        }
        [TestMethod]
        [DataRow(-1, 2)]
        [DataRow(-5, 3)]
        [DataRow(-6, 4)]
        [ExpectedException(typeof(ArgumentException), "Values must be positive")]
        public void TriangleArea_ThrowsArgumentException(params int[] values)
        {
            // Arrange
            double b = values[0];
            double h = values[1];

            // Act
            _calculator.CalcTriangleArea(b, h);
        }

        // CalcRectangleArea Tests
        [TestMethod]
        [DataRow(5, 3, 15)]
        [DataRow(10, 4, 40)]
        [DataRow(6, 2, 12)]
        public void RectangleArea_ReturnsCorrectValue(params int[] values)
        {
            // Arrange
            double l = values[0];
            double w = values[1];

            // Act
            var result = _calculator.CalcRectangleArea(l, w);

            // Assert
            Assert.AreEqual(values[2], result, "Expected area of " + values[2] + " for result.");
        }
        [TestMethod]
        [DataRow(1, 1, 5)]
        [DataRow(2, 2, 99)]
        public void RectangleArea_ReturnsIncorrectValue(params int[] values)
        {
            // Arrange
            double l = values[0];
            double w = values[1];

            // Act
            var result = _calculator.CalcRectangleArea(l, w);

            // Assert
            Assert.AreNotEqual(values[2], result, "Result should not equal " + values[2] + ".");
        }
        [TestMethod]
        [DataRow(-1, 2)]
        [DataRow(-5, 3)]
        [DataRow(-6, 4)]
        [ExpectedException(typeof(ArgumentException), "Values must be positive")]
        public void RectangleArea_ThrowsArgumentException(params int[] values)
        {
            // Arrange
            double l = values[0];
            double w = values[1];

            // Act
            _calculator.CalcRectangleArea(l, w);
        }

        
        // CalcAverage Tests
        [TestMethod]
        public void Average_ReturnsCorrectValue()
        {
            // Arrange
            List<double> input = new List<double> { 1,2,3,4,5};

            // Act
            var result = _calculator.CalcAverage(input);

            // Assert
            Assert.AreEqual(3, result, "Expected average of 3");
        }

        // CalcQuadRoot Tests
        [TestMethod]
        [DataRow(1, 1, -2, 1, -2)]
        [DataRow(1, -8, 15, 5, 3)]
        [DataRow(1, 4, 3, -1, -3)]
        public void QuadRoot_ReturnsCorrectRoots(params int[] values)
        {
            // Arrange
            var expectedRoot1 = values[3];
            var expectedRoot2 = values[4];
            
            // Act
            (double actualRoot1, double actualRoot2) = _calculator.CalcQuadRoot(values[0], values[1], values[2]);

            // Assert
            Assert.AreEqual(expectedRoot1, actualRoot1, "Root 1 is not correct.");
            Assert.AreEqual(expectedRoot2, actualRoot2, "Root 2 is not correct.");
        }
        [TestMethod]
        [DataRow(1, 2, 5)]
        [DataRow(1, 0, 4)]
        public void QuadRoot_NonRealRoots(params int[] values)
        {
            // Arrange
            double a = values[0];
            double b = values[1];
            double c = values[2];

            // Act
            (double root1, double root2) = _calculator.CalcQuadRoot(a, b, c);

            // Assert
            Assert.IsTrue(double.IsNaN(root1), "Non-real result for root1 should be indicated by being NaN.");
            Assert.IsTrue(double.IsNaN(root2), "Non-real result for root1 should be indicated by being NaN.");
        }

        [TestMethod]
        [DataRow(1, 2, 3, 1, 2, 3, 14)]
        [DataRow(2, 4, 6, 1, 4, 5, 48)]
        public void DotProd_ReturnsCorrectValue(params int[] values)
        {
            //Arrange
            var input1 = values[0];
            var input2 = values[1];
            var input3 = values[2];
            var input4 = values[3];
            var input5 = values[4];
            var input6 = values[5];

            //Act
            var result = _calculator.CalcDotProduct(input1, input2, input3, input4, input5, input6);

            //Assert
            Assert.AreEqual(values[6], result, "Expected value of " + values[6]);
        }

        [TestMethod]
        [DataRow(1, 2, 3, 1, 2, 3, 0, 0, 0)]
        [DataRow(2, 4, 6, 1, 4, 5, -4,-4, 4)]
        public void CrossProd_ReturnsCorrectValue(params int[] values)
        {
            //Arrange
            var input1 = values[0];
            var input2 = values[1];
            var input3 = values[2];
            var input4 = values[3];
            var input5 = values[4];
            var input6 = values[5];

            //Act
            (double resulti, double resultj, double resultk) = _calculator.CalcCrossProduct(input1, input2, input3, input4, input5, input6);

            //Assert
            Assert.AreEqual(values[6], resulti, "Expected value of " + values[6] + "i");
            Assert.AreEqual(values[7], resultj, "Expected value of " + values[7] + "j");
            Assert.AreEqual(values[8], resultk, "Expected value of " + values[8] + "i");
        }
    }
}
