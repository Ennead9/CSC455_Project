using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC455_ProjectCalculator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management.Instrumentation;

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
            Assert.AreEqual(values[1], result, "Expected integer of 1 for result");
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
            Assert.AreEqual(values[3], result, "Expected integer" + values[3] + "as result");

        }

        [TestMethod]
        [DataRow(1, 2, 5)]
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
            Assert.AreEqual(values[2], result, "Expected integer" + values[2] + "as result");
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
        public void CircleArea_ReturnsIncorrectValue(params int[] values)
        {
            //Arrange
            var radius = 2;
            var sol = (radius * radius) * Math.PI + 1;

            //Act
            var result = _calculator.CalcCircleArea(radius);

            //Assert
            Assert.AreEqual(sol, result, "Expected integer" + sol + "as result");
        }
        [TestMethod]
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
        public void TriangleArea_ReturnsIncorrectValue(params int[] values)
        {

        }
        [TestMethod]
        [DataRow(-1, 2)]
        [DataRow(-5, 3)]
        [DataRow(-1.6, 4)]
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
        public void RectangleArea_ReturnsIncorrectValue(params int[] values)
        {

        }
        [TestMethod]
        [DataRow(-1, 2)]
        [DataRow(-5, 3)]
        [DataRow(-1.6, 4)]
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
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Average_EmptyList_ThrowsDivideByZeroException()
        {
            // Arrange
            var input = new List<double>();

            // Act
            _calculator.CalcAverage(input);
        }
    }
}
