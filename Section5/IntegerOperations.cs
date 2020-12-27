using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class IntegerOperations
    {
        static int num1;
        static int num2;

        [TestInitialize]
        public void IntegerInitialize()
        {
            num1 = 10;
            num2 = 5;

        }
        [TestMethod]
        public void Test_Addition()
        {
            int sum = num1 + num2;
            Console.Write(sum);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            int difference = num1 - num2;
            Assert.AreEqual(difference, 5);

        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int product = num1 * num2;
            Assert.AreEqual(product, 50);

        }

        [TestMethod]
        public void Test_Division()
        {
            int quotient = num1 / num2;
            Assert.AreEqual(quotient, 2);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int remainder = num1 % num2;
            Assert.AreEqual(remainder, 0);
        }
    }
}
