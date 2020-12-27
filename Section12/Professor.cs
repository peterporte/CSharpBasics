using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12
{
    class Professor : Person, ITraveler
    {
        private string employeeId;
        private string subject;

        public Professor()
        {

        }

        public Professor(string idNum, string first, string last, int a, string empId, string subj)
            : base(idNum, first, last, a)
        {
            EmployeeId = empId;
            Subject = subj;
        }

        public string EmployeeId { get; set; }
        public string Subject { get; set; }



        public string GetDestination()
        {
            return "Beach";
        }

        public string GetStartLocation()
        {
            return "Home";

        }

        public double DetermineMiles()
        {
            return 200.0;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nEmployee ID: " + EmployeeId +
                   "\n Major: " + Subject +
                   "\nDestination: " + GetDestination() +
                   "\nStart Location: " + GetStartLocation() +
                   "\nMiles: " + DetermineMiles();
        }
    }
}
