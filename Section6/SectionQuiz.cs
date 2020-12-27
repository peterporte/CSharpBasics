using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void FirstnameLastname()
        {

            //arrange
            Employee emplopyee1 = new Employee("01", "Peter", "Porte", "Aug 20, 2020", "QA", "IT", 1000);


            //Act
            string fullname = emplopyee1.ReturnsFirstnameSpaceLastname();

            //Assert

            Assert.AreEqual(fullname, "Peter Porte");

        }

        [TestMethod]
        public void LastnameFirstname()
        {

            //arrange
            Employee emplopyee1 = new Employee("01", "Peter", "Porte", "Aug 20, 2020", "QA", "IT", 1000);


            //Act

            string fullname = emplopyee1.ReturnsLastnameCommaSpaceFirstname();

            //Assert

            Assert.AreEqual(fullname, "Porte, Peter");

        }



        public class Employee
        {

            //private variables to help define properties of car
            string _employeeNum;
            string _firstName;
            string _lastName;
            string _date;
            string _jobDescription;
            string _department;
            double _salary;

            //Contructor - factory for creating objects for a class
            public Employee(string employeeNum, string firstName, string lastName, string date, string jobDescription, string department, double salary)
            {
                EmployeeNum = employeeNum;
                FirstName = firstName;
                LastName = lastName;
                Date = date;
                JobDescription = jobDescription;
                Department = department;
                Salary = salary;

            }



            //Get and Set Accessors - properties that define noun-like properties of a class

            public string EmployeeNum
            {
                get { return _employeeNum; }
                set { _employeeNum = value; }
            }

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }

            public string Date
            {
                get { return _date; }
                set { _date = value; }
            }

            public string JobDescription
            {
                get { return _jobDescription; }
                set { _jobDescription = value; }
            }

            public string Department
            {
                get { return _department; }
                set { _department = value; }
            }

            public double Salary
            {
                get { return _salary; }
                set { _salary = value; }
            }


            //Method - verb attributes that tell what a class can do

            public string ReturnsFirstnameSpaceLastname()
            {
                return FirstName + " " + LastName;
            }

            public string ReturnsLastnameCommaSpaceFirstname()
            {
                return LastName + ", " + LastName;
            }


        }
    }
}