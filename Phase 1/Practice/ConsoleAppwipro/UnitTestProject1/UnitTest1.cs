using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            Calculator c1 = new Calculator();
            double res = c1.Add(10, 10);
            Assert.AreEqual(res,20);
        }
        [TestMethod]
        public void Test_AddMethodwithZero()
        {
            Calculator c1 = new Calculator();
            double res = c1.Add(10, 0);
            Assert.AreEqual(res, 10);
        }
        [TestMethod]
        public void Test_SubtractMethod()
        {
            Calculator c1 = new Calculator();
            double res = c1.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_SubtractMethodbyZero()
        {
            Calculator c1 = new Calculator();
            double res = c1.Subtract(10, 0);
            Assert.AreEqual(res, 10);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            Calculator c1 = new Calculator();
            double res = c1.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
        [TestMethod]
        public void Test_MultiplyMethodbyZero()
        {
            Calculator c1 = new Calculator();
            double res = c1.Multiply(10, 0);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            Calculator c1 = new Calculator();
            double res = c1.Divide(10, 10);
            Assert.AreEqual(res, 1);
        }
        [TestMethod]
        public void Test_DivideMethodbyZero()
        {
            Calculator c1 = new Calculator();
            double res = c1.Divide(10, 0);
        }

    }
}
