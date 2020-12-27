using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void While_Test_Loops()
        {
            int num = 1;
            while (num < 11)
            {
                //this code will continue to run while the condition statement is true
                Console.WriteLine(num);
                num++;                  //num = num + 1;
            }
        }

        [TestMethod]
        public void Test_Operators()
        {
            int num = 1;

            Console.WriteLine($"Suffix increment: {num++}");
            Console.WriteLine("Prefix increment: {0}", ++num);
            Console.WriteLine("Suffix decrement: {0}", num--);
            Console.WriteLine("Prefix decrement: {0}", --num);

        }

        [TestMethod]
        public void Sentinel_Controlled_Repetition()
        {
            string invalue = "";

            while (invalue != "-99")
            {
                Console.WriteLine("enter -99 to exit the program:");
                invalue = Console.ReadLine();
            }

            Console.ReadKey();

        }


        [TestMethod]
        public void Nested_Loop()
        {
            int num1 = 1;
            int num2 = 1;

            while (num1 <= 5)
            {
                while (num2 <= num1)
                {
                    Console.WriteLine(num2);
                    num2++;
                } //inner loop

                num1++;
            }//outer loop
        }
    }
}
