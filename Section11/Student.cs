using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    class Student : Person
    {
        private string major;
        private int studentID;

        public Student(string fname, string lname, string id, int anAge, string maj, int sId, DateTime dob)
            :base(fname, lname, id, anAge, dob)
        {
            major = maj;
            studentID = sId;
        }

        public override string Get_Exercise_Routine()
        {
            return "No time to exercise";
        }

    }
}
