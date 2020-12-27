using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class CodingQuiz
    {
        [TestMethod]
        public void Coding_Quiz()
        {
            int outNum = 0;
            //int inNum = 10;

            while (outNum <= 2)
            {
                int inNum = 10;
                while (inNum >= 6)
                {

                    Console.WriteLine("{0}\t{1}", outNum, inNum);                    
                    inNum--;
                }

                
                outNum++;
            }
        }
    }
}
