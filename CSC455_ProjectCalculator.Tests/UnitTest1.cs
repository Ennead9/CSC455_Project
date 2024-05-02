using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSC455_ProjectCalculator;
using System;

namespace CSC455_ProjectCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new CSC455_ProjectCalculator.AdvancedCalc();
            Assert.IsNotNull(calculator);

            Assert.IsTrue(true);
        }
    }
}
