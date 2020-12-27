using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void Test_Square()
        {
            MethodTest myTest = new MethodTest();
            int result = myTest.Square(6);
            Assert.AreEqual(36, result);
        }

        public int Square(int nValue)
        {
            return nValue * nValue;
        }

        [TestMethod]
        public void Test_Static_Square()
        {
            int result = MathHelper.Static_Square(6);
            Assert.AreEqual(36, result);
        }


        [TestMethod]
        public void Test_Named_Parameters()
        {
            int sum11 = MathHelper.AddNumber(5, 6);

            int sum12 = MathHelper.AddNumber(number1: 6, number2: 6);

            int number = 5;
            int sum13 = MathHelper.AddNumber(number, number2: 8);
        }

        [TestMethod]
        public void Test_Optional_Parameters()
        {
            int sum10 = MathHelper.AddNumber(0);

            int sum12 = MathHelper.AddNumber(2);

            int sum15 = MathHelper.AddNumber();

            int sum13 = MathHelper.AddNumber(number2: 5);
        }

    }
}
