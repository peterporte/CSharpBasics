using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class SectionExam
    {

        [TestMethod]
        public void Resale_Value()
        {
            //call the constructor for the class and give it the item price
            ItemPrices myItem = new ItemPrices(12.99M);

            //header rows for tabular format
            Console.WriteLine("{0,-20} {1,25}", "Item", "Percentage Increase");
            Console.Write("{0,-10}", "Price");

            //create the output in tabular format
            for (decimal percentage = 0.05M; percentage <= 0.10M; percentage += 0.01M)
            {
                Console.Write("{0,12}", percentage);
            }

            //linebreak
            Console.WriteLine();

            Console.Write("{0,-10:C}", myItem.Wholesale);

            //create the output in tabular format
            for (decimal percentage = 0.05M; percentage <= 0.10M; percentage += 0.01M)
            {
                Console.Write("{0,10:C}", (myItem.Wholesale + (percentage * myItem.Wholesale)));
            }
        }
    }
}
