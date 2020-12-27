using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section11
{
    [TestClass]
    public class InheristanceTest
    {
        [TestMethod]
        public void Check_Person_Student_Relationship()
        {
            //Abstract class cannot be used directly
            //Person myPerson = new Person("Peter", "Porte", "8", 34);

            //Student myStudent = new Student("Angela", "Millora", "28", 29, "HR", 64);
            //string response = myStudent.Get_Exercise_Routine();
        }

        [TestMethod]
        public void Composition()
        {
            DateTime dobDateTime = new DateTime(1986, 6,8);
            Student myStudent = new Student("Angela", "Millora", "28", 29, "HR", 64, dobDateTime);
        }
    }
}
