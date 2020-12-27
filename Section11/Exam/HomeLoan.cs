using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Exam
{
    class HomeLoan : Loan
    {
        private string address;
        private int yearBuilt;
        private int squareFootage;

        public HomeLoan(int loanNum, string fName, string lName, decimal intRate, int loanAmt, int numOfYears,
            string addr, int yrBuilt, int sqrFoot)
            : base(loanNum, fName, lName, intRate, loanAmt, numOfYears)
        {
            Address = addr;
            YearBuilt = yrBuilt;
            SquareFootage = sqrFoot;
        }

        public string Address { get; set; }
        public int  YearBuilt { get; set; }
        public int SquareFootage { get; set; }


        public override decimal CalculateInterest()
        {

            return (Convert.ToDecimal(InterestRate) / (Convert.ToDecimal(NumberOfYears) / 12M) *
                    (LoanAmount + 5000));
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nHome Loan Address: " + Address
                   + "\n Calculated Interest :" + CalculateInterest().ToString("C");
        }
    }
}
