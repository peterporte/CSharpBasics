using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private string idnumber;
        private int age;
        private DateTime dateOFBirth;

        public Person()
        {

        }


        public Person(string fname, string lname, string id, int anAge, DateTime dob)
        {
            firstName = fname;
            lastName = lname;
            idnumber = id;
            age = anAge;
            dateOFBirth = dob;

        }

        public abstract string Get_Exercise_Routine();
    }
}
