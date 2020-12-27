using System;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionExam2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = IsLeapYear(2000);
            Assert.AreEqual("Yes", result);
        }


        public string IsLeapYear(int givenYear)

        {

            int divFour;
            int divHun;
            int divFourHun;
            int even;
            int year;
            string sFour;
            string sHun;
            string sFourHun;

            year = givenYear;

            divFour = givenYear % 4;
            if (divFour == 0)
            {
                sFour = "Divisible by 4: Yes";
            }
            else
            {
                sFour = "Divisible by 4: No";
            }

            divHun = givenYear % 100;
            if (divHun == 0)
            {
                sHun = "Divisible by 4: Yes";
            }
            else
            {
                sHun = "Divisible by 4: No";
            }

            divFourHun = givenYear % 400;
            if (divFourHun == 0)
            {
                sFourHun = "Divisible by 4: Yes";
            }
            else
            {
                sFourHun = "Divisible by 4: No";
            }

            even = givenYear % 2;

            Console.WriteLine($"Year: {year}");
            Console.WriteLine(sFour);
            Console.WriteLine(sHun);
            Console.WriteLine(sFourHun);

            if ((divFour == 0) && (even == 0) && (divHun == 0) & (divFourHun == 0))
            {
                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }
            else if ((divFour == 0) && (even == 0) && (divHun != 0) & (divFourHun != 0))
            {

                Console.WriteLine("Leap Year: Yes");
                return "Yes";
            }
            else if ((divFour == 0) && (even == 0) && (divHun == 0) & (divFourHun != 0))
            {

                Console.WriteLine("Leap Year: No");
                return "No";
            }
            else if ((divFour == 0) && (even == 0) && (divHun != 0) & (divFourHun == 0))
            {

                Console.WriteLine("Leap Year: No");
                return "No";
            }
            else if (even == 1)
            {
                Console.WriteLine("Leap Year: No");
                return "No";
            }

            return "No";
        } 
    }
}
