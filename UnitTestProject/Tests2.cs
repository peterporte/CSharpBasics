using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Tests2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 1 + 1;
            Assert.AreEqual(2, num);
        }

        [TestMethod]
        public void TestMethod2()
        {
          
            Assert.Fail("Always fail");
        }

        [TestMethod]
        public void TestMethod3()
        {
            int sum = 10 + 10;
            Assert.IsTrue(sum==21);
        }
    }
}
