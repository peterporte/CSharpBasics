using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12
{
    abstract class Person
    {
        private string idNumber;
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        { }

        public Person(string idNum, string first, string last, int a)
        {
            idNumber = idNum;
            firstName = first;
            lastName = last;
            age = a;

        }

        public override string ToString()
        {
            return "Name: " + firstName + lastName;

        }
    }
}
