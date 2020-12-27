using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Math_Square()
        {
            //double square = MathFunctions.SquareRoot(4);
            //Console.WriteLine(square);
            //Assert.AreEqual(2, square);
            Assert.AreEqual(2, MathFunctions.SquareRoot(12), 1);
        }

        [TestMethod]
        public void Test_Math_Sum_Int()
        {
            Assert.AreEqual(4, MathFunctions.Sum(2, 2));
        }

        [TestMethod]
        public void Test_Math_Sum_Double()
        {
            double sum = MathFunctions.Sum(2.5, 6);
            Console.WriteLine(sum);
            Assert.AreEqual(8.5, sum);
        }

        [TestMethod]
        public void Test_Math_Sum_Decimal()
        {
            decimal sum = MathFunctions.Sum(5.5M, 6M);
            Console.WriteLine(sum);
            Assert.AreEqual(11.5M, sum);
        }
    }
}
