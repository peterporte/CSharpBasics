using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Employee
    {


        //constructor

        public Employee(int employeeId)
        {
            EmployeeId = employeeId;
        }


        public Employee (string name, string jobTitle, int employeeId)
        {
            Name = name;
            JobTitle = jobTitle;
            EmployeeId = employeeId;

        }

        //accesors
        public string Name
        {
            get;
            set;
        }

        public string JobTitle
        {
            get;
            set;
        }

        public int EmployeeId
        {
            get;
            set;
        }


        //methods
        public string JobLocation()
        {
            if (JobTitle == "Manager")
            {
                return "Boston";
            }
            else if (JobTitle == "Staff")
            {
                return "Chicago";
            }
            else
            {
                return "New York";
            }
        }
    }
}
