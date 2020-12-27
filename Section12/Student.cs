using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12
{ 
    class Student : Person, ITraveler
    {
        private string major;
        private string studenId;

        public Student(string idNum, string first, string last, int a, string maj, string sId)
            : base(idNum, first, last, a)
        {
            major = maj;
            studenId = sId;
        }

        public string GetDestination()
        {
            return "Home";
        }

        public string GetStartLocation()
        {
            return "School";

        }

        public double DetermineMiles()
        {
            return 75.0;
        }

       


        public override string ToString()
        {
            return base.ToString() +
                   "\nStudent ID: " + studenId +
                   "\n Major: " + major +
                   "\nDestination: " + GetDestination() +
                   "\nStart Location: " + GetStartLocation() +
                   "\nMiles: " + DetermineMiles();
        }
    }
}
