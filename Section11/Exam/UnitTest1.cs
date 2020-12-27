using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section11.Exam
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcHomeLoan()
        {
            HomeLoan myHomeLoan = new HomeLoan(01, "Pedro", "Porte", .035M, 210000, 30, "Palawan", 2020, 300 );
            decimal calcInterest = myHomeLoan.CalculateInterest();
            Assert.AreEqual(3010, calcInterest);
            Console.WriteLine(myHomeLoan);

        }

        [TestMethod]
        public void CalcAutoLoan()
        {
            AutoLoan myAutoLoan = new AutoLoan(02, "Angela", "Millora", .075M, 12000, 4, 2010, "SUV", "Black");
            decimal calcInterest = myAutoLoan.CalculateInterest();
            Assert.AreEqual(2925, calcInterest);
            Console.WriteLine(myAutoLoan);

        }
    }
}
