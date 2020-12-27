using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Exam
{
    class AutoLoan : Loan
    {
        private int yearBuilt;
        private string carModel;
        private string carColor;

        public AutoLoan(int loanNum, string fName, string lName, decimal intRate, int loanAmt, int numOfYears,
            int yrBuilt, string model, string color)
            : base(loanNum, fName, lName, intRate, loanAmt, numOfYears)
        {
            YearBuilt = yrBuilt;
            CarModel = model;
            CarColor = color;
        }

        public int YearBuilt { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }


        public override decimal CalculateInterest()
        {
            return (Convert.ToDecimal(InterestRate) / (Convert.ToDecimal(NumberOfYears) / 12M) *
                    (LoanAmount + 1000));
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nType of Car: " +
                   YearBuilt + " " +
                   CarColor + " " + CarModel
                   + "\n Calculated Interest :" + CalculateInterest().ToString("C");

        }
    }
}
