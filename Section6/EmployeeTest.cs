using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void EmployeeLocation()
        {
            Employee employee1 = new Employee("pedro", "Manager", 123);
            string loc = employee1.JobLocation();
            Assert.AreEqual(loc, "Boston");
        }

        [TestMethod]
        public void EmployeeLocationTwo()
        {
            Employee employee1 = new Employee(123);
            employee1.JobTitle = "Manager";
            string loc = employee1.JobLocation();
            Assert.AreEqual(loc, "Boston");
        }
    }
}
