using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section9
{
    [TestClass]
    public class PropertyTaxCalcTest
    {
        [TestMethod]
        public void Show_Tax_Calculator()
        {
            PropertyTaxCalc myPropertyTaxCalc1 = new PropertyTaxCalc("Palawan", 110000M, 115000M);
            Console.WriteLine(myPropertyTaxCalc1);

            PropertyTaxCalc myPropertyTaxCalc2 = new PropertyTaxCalc("Makati", 150000M, 160000M);
            Console.WriteLine(myPropertyTaxCalc2);

            PropertyTaxCalc myPropertyTaxCalc3 = new PropertyTaxCalc("Manila", 190000M, 200000M);
            Console.WriteLine(myPropertyTaxCalc3);


        }
    
        [TestMethod]
        public void Test_Taxable_Value()
        {
            PropertyTaxCalc myPropertyTaxCalc = new PropertyTaxCalc("Palawan", 110000M, 115000M);
            decimal taxableValue = myPropertyTaxCalc.Taxable_Value();
            Console.WriteLine(taxableValue);
            Assert.AreEqual(myPropertyTaxCalc.Current_Value() - 25000, taxableValue);
        }


        [TestMethod]
        public void Test_Tax_Due()
        {
            PropertyTaxCalc myPropertyTaxCalc = new PropertyTaxCalc("Palawan", 110000M, 115000M);
            Console.WriteLine(myPropertyTaxCalc.Taxes_Due());
            Assert.AreEqual((myPropertyTaxCalc.Taxable_Value() / 1000) * 10.03M, myPropertyTaxCalc.Taxes_Due() );
        }

        [TestMethod]
        public void Test_Current_Assesed_Value()
        {
            PropertyTaxCalc myPropertyTaxCalc = new PropertyTaxCalc("Palawan", 110000M, 115000M);
            decimal currentAssesedValue = myPropertyTaxCalc.Current_Value();
            Console.WriteLine(currentAssesedValue);
        }
    }
}
