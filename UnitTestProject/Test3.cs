using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Part3")]
    public class Test3
    {
        private int a;
        public TestContext Test3Context { get; set; }
        private static TestContext _testContext;

        [TestInitialize]
        public void RunBeforeEverTest()
        {
            a = 1;
        }

        [TestCleanup]
        public void RunAfterEveryTest()
        {
            
            Trace.Write("RunAfterEveryTest will run every after every singel test method in a class");
        }

        [ClassInitialize]
        public static void RunBeforeAllMethodStartsInAClass(TestContext testContext)
        {
            _testContext = testContext;
            Trace.Write("RunBeforeAllMethodStartsInAClass runs before all the tests in the class started");
        }

        [ClassCleanup]
        public static void RunEveryAfterTestClass()
        {
            Trace.Write("RunBeforeAllMethodStartsInAClass runs before all the tests in the class started");
        }

        [TestMethod]
        public void TestMethod1()
        {
  
            var b = 2;
            Assert.AreEqual(3, a + b);

        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.IsTrue(a == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreNotEqual(1, a);

        }
    }
}
