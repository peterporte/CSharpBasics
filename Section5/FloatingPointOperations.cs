using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class FloatingPointOperations
    {
        static double num1;
        static double num2;

        [TestInitialize]
        public void IntegerInitialize()
        {
            num1 = 10.5;
            num2 = 5;

        }
        [TestMethod]
        public void Test_Addition()
        {
            double sum = num1 + num2;
            Console.Write(sum);
            Assert.AreEqual(sum, 15.5);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            double difference = num1 - num2;
            Assert.AreEqual(difference, 5.5);

        }

        [TestMethod]
        public void Test_Multiplication()
        {
            double product = num1 * num2;
            Assert.AreEqual(product, 52.5);

        }

        [TestMethod]
        public void Test_Division()
        {
            double quotient = num1 / num2;
            Assert.AreEqual(quotient, 2.1);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            double remainder = num1 % num2;
            Assert.AreEqual(remainder, 0.5);
        }
    }
}
