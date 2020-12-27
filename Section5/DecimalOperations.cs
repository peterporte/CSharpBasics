using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class DecimalOperations
    {
        static decimal num1;
        static decimal num2;

        [TestInitialize]
        public void IntegerInitialize()
        {
            num1 = 10.5M;
            num2 = 5M;

        }
        [TestMethod]
        public void Test_Addition()
        {
            decimal sum = num1 + num2;
            Console.Write(sum);
            Assert.AreEqual(sum, 15.5M);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            decimal difference = num1 - num2;
            Assert.AreEqual(difference, 5.5M);

        }

        [TestMethod]
        public void Test_Multiplication()
        {
            decimal product = num1 * num2;
            Assert.AreEqual(product, 52.5M);

        }

        [TestMethod]
        public void Test_Division()
        {
            decimal quotient = num1 / num2;
            Assert.AreEqual(quotient, 2.1M);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            decimal remainder = num1 % num2;
            Assert.AreEqual(remainder, 0.5M);
        }
    }
}
