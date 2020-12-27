using System;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Array_Test()
        {
            int[] scores = new int[14];
            scores[0] = 10;

            int score = scores[0];

            int numPosition = 10;
            int[] myArray = new int[numPosition];
        }

        [TestMethod]
        public void ForEach_Loop_Test()
        {
            int[] scores = {2, 4, 6, 8, 10};

            foreach (int count in scores)
            {
                Console.WriteLine(count);
            }
        }

        [TestMethod]
        public void Pass_Array()
        {
            int[] scores = {2, 4, 6, 8, 10};
            int sum = TotalScores(scores);
            Console.WriteLine(sum);
            Assert.AreEqual(30, sum);

        }

        public int TotalScores(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            return sum;
        }

        [TestMethod]
        public void Pass_Array_Element()
        {
            int[] scores = { 2, 4, 6, 8, 10 };
            foreach (int score in scores)
            {
                Console.WriteLine(CheckScores(score));
            }

            Console.WriteLine(CheckScores(scores[4]));

        }

        public string CheckScores(int score)
        {
            
            
                if (score >= 10)
                {
                    return "Pass";
                }
                else
                {
                    return "Fail"; 
                }
            
        }

        [TestMethod]
        public void Array_Class_Method()
        {
            double[] waterDepth = {12.1, 2.3, 6.7 };

            Array.Sort(waterDepth);
            foreach (double wD in waterDepth)
            {  
                Console.Write(wD + "\t");
            }

            Array.Reverse(waterDepth);
            foreach (double wD in waterDepth)
            {
                Console.Write(wD + "\t");
            }
        }

    }

}
