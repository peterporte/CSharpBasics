using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Section9
{
    class Employee
    {

        public Employee(string name, string jobTitle, int employeeId)
        {
            Name = name;
            JobTitle = jobTitle;
            EmployeeId = employeeId;
        }

        public string Name { get; set; }
        public string JobTitle { get; set; }
        public int EmployeeId { get; set; }


        public string JobLocation()
        {
            if (JobTitle == "Manager")
            {
                return "Chicago";
            }
            else if (JobTitle == "Staff")
            {
                return "New York";
            }
            return "Boston";
        }

        public string PayType(string title)
        {
            if (JobTitle == "Manager")
            {
                return "Salary";
            }
            else if (JobTitle == "Staff")
            {
                return "Hourly";
            }

            return "Daily";
        }

        public string PayType(int id)
        {
            if (EmployeeId == 1234)
            {
                return "Salary";
            }
            else if (EmployeeId == 4321)
            {
                return "Hourly";
            }

            return "Daily";
        }



        public override string ToString()
        {
            return EmployeeId + " " + Name + " " + JobTitle;
        }

    }
}
