using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Exam
{
    abstract class Loan
    {
        private int loanNumber;
        private string firstName;
        private string lastName;
        private decimal interestRate;
        private decimal loanAmount;
        private int numberOfYears;

        public Loan(int loanNum, string fName, string lName, decimal intRate, decimal loanAmt, int numOfYears)
        {
            LoanNumber = loanNum;
            FirstName = fName;
            LastName = lName;
            InterestRate = intRate;
            LoanAmount = loanAmt;
            NumberOfYears = numOfYears;
        }


        public int LoanNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal InterestRate { get; set; }
        public decimal LoanAmount { get; set; }
        public int NumberOfYears { get; set; }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return "Customer:  " + FirstName + " " +
                   LastName +
                   "\nLoan amount:  " + LoanAmount.ToString("C") +
                   "\nInterest Rate:  " + InterestRate.ToString("p2") +
                   "\nLoan Duration: " + NumberOfYears;
        }
    }
}
