using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section7
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        public void Calculate_Total_Cost()
        {
            Receipt myReceipt = new Receipt(-1, "Sept 9,2020", 1, "Angela", "Porte", "09991234567", 99, "Tea", 2, 5);
            Console.WriteLine(myReceipt.TotalCost());
            Console.WriteLine(myReceipt);
        }

        [TestMethod]
        public void Receipt_Num_Greater_Than_Zero()
        {
            Receipt myReceipt = new Receipt(123, "Sept 9,2020", 1, "Angela", "Porte", "09991234567", 99, "Tea", 2, 5);
            Assert.AreEqual(123, myReceipt.ReceiptNumber);
            Console.WriteLine(myReceipt.ReceiptNumber);
        }

        [TestMethod]
        public void Receipt_Num_Greater_Than_Zero_Invalid()
        {
            Receipt myReceipt = new Receipt(-1, "Sept 9,2020", 1, "Angela", "Porte", "09991234567", 99, "Tea", 2, 5);
            Assert.AreEqual(0, myReceipt.ReceiptNumber);
            Console.WriteLine(myReceipt.ReceiptNumber);
        }

        [TestMethod]
        public void Custnum_Greater_Than_Zero()
        {
            Receipt myReceipt = new Receipt(123, "Sept 9,2020", 1, "Angela", "Porte", "09991234567", 99, "Tea", 2, 5);
            Assert.AreEqual(1, myReceipt.CustomerNumber);
            Console.WriteLine(myReceipt.CustomerNumber);
        }

        [TestMethod]
        public void Custnum_Greater_Than_Zero_Invalid()
        {
            Receipt myReceipt = new Receipt(123, "Sept 9,2020", -1, "Angela", "Porte", "09991234567", 99, "Tea", 2, 5);
            Assert.AreEqual(0, myReceipt.CustomerNumber);
            Console.WriteLine(myReceipt.CustomerNumber);

        }
    }
}
