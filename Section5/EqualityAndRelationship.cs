using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class EqualityAndRelationship
    {
        static int num1;
        static int num2;

        [ClassInitialize]
        public static void InitializeEqualityAndRelationship(TestContext testContext)
        {
            num1 = 10;
            num2 = 5;

        }


        [TestMethod]
        public void Number1_Is_Equal_Number2()
        {        
                Assert.IsFalse(num1 == num2);           
        }

        [TestMethod]
        public void Number1_Is_Not_Equal_Number2()
        {
            if (num1 != num2)
            {
                Assert.IsTrue(num1 != num2);
            }
        }

        [TestMethod]
        public void Number1_Is_Greater_Than_Number2()
        {
            if (num1 > num2)
            {
                Assert.IsTrue(num1 > num2);
            }
        }


        [TestMethod]
        public void Number1_Is_Less_Than_Number2()
        {
            if (num1 < num2)
            {
                Assert.IsTrue(num1 < num2);
            }

            Assert.IsTrue(num1 > num2);
        }


        [TestMethod]
        public void Number1_Is_Greater_OrEqual_Than_Number2()
        {
            if (num1 >= num2)
            {
                Assert.IsTrue(num1 >= num2);
            }
        }


        [TestMethod]
        public void Number1_Is_Less_Than_OrEqual_Number2()
        {
            if (num1 <= num2)
            {
                Assert.IsTrue(num1 <= num2);
            }
            Assert.IsFalse(num1 <= num2);
        }
    }
}
