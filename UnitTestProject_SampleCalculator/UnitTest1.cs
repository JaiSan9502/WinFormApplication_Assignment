using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimpleCalculator;
namespace UnitTestProject_SampleCalculator
{
 
    [TestClass]
    public class OperationTests
    {
        Operation obj = new Operation();//Object of operatoin single responsibility class
        [TestMethod]
        public void testSubtraction()
        {
            Assert.AreEqual(obj.Sub(8,5),3);
        }

        [TestMethod]
        public void testAddition()
        {
            Assert.AreEqual(obj.Add(10, 20), 30);
        }

        [TestMethod]
        public void testMultiplication()
        {
            Assert.AreEqual(obj.Mul(8, 5), 40);
        }

        [TestMethod]
        public void testDivision()
        {
            Assert.AreEqual(obj.Div(8, 5), 1.6);
        }

    }
}
