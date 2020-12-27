using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void Test_For_Loops()
        {
            
            //for (initialize; test; update)
            for (int outNum = 0; outNum <= 2; outNum++)
            {
                int inNum = 0;
                for (inNum = 10; inNum >= 6; inNum--)
                {
                    Console.WriteLine("{0}\t{1}", outNum, inNum);
                }
            }
        }

        [TestMethod]
        public void Strange_For_Loops()
        {
            //two variables initalized
            for (int counter = 0, val1 = 10; counter < val1; counter++)
            {

            }

            // Initialization not included as part of for statement
            int count2 = 0;
            for (; count2 < 100; count2 += 10)
            {

            }

            // No conditional expression included
            for (int j = 0; ; j++)
            {

            }

            // Use of floating point variables is permissible
            for (double d = 15.0; d < 20.0; d += 0.5)
            {

            }
        }
    }
}
