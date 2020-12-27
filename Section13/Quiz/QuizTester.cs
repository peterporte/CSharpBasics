using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section13.Quiz
{
    [TestClass]
    public class QuizTester
    {
        [TestMethod]
        public void Calculate_BMI()
        {
            string weight = "150";
            string heightInFeet = "6";
            string heightInInches = "72";
            BodyMassIndexCalculator bmi = null;

            try
            {
                 bmi = new BodyMassIndexCalculator(int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }


            string result = bmi.ToString();

            Assert.AreEqual("BMI: 5.09", result);

        }
    }
}
