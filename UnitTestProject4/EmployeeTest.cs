using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Test_Overload_String()
        {
            Employee myEmployee = new Employee("Pedro", "Manager", 1234);
            string myPay = myEmployee.PayType(myEmployee.JobTitle);
            Console.WriteLine(myPay);
            Assert.AreEqual("Salary", myPay);
        }

        [TestMethod]
        public void Test_Overload_Int()
        {
            Employee myEmployee= new Employee("Angela", "Staff", 4321);
            string myPay = myEmployee.PayType(myEmployee.EmployeeId);
            Console.WriteLine(myPay);
            Assert.AreEqual("Hourly", myPay);

        }
    }
}
