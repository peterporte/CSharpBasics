using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionExam
    {
        static double year;
        static string divByFour;
        static string divBy100;
        static string divBy400;
        static string no;
        static string yes;
        static string leap;



        [ClassInitialize]
        public static void SectionExamInitialize(TestContext testContext)
        {
            year = 2018;
            yes = "Yes";
            no = "No";
        }

        [TestMethod]
        public void LeapYear()
        {
            if ((year % 4) == 0)
            {
                divByFour = yes;
                leap = yes;
                divBy100 = no;
                divBy400 = no;

                if (((year % 4) == 0) && ((year % 100) == 0))
                {
                    leap = no;
                    divByFour = yes;
                    divBy100 = yes;
                    divBy400 = no;

                    if (((year % 4) == 0) && ((year % 100) == 0) && ((year % 400) == 0))
                    {
                        leap = yes;
                        divByFour = yes;
                        divBy100 = yes;
                        divBy400 = yes;
                    }               
                }
            }

            else
            {
                    leap = no;
                    divByFour = no;
                    divBy100 = no;
                    divBy400 = no;
            }
                Console.WriteLine($"Year Entered: {year}");
                Console.WriteLine($"Divisiable by 4: {divByFour}");
                Console.WriteLine($"Divisiable by 100: {divBy100}");
                Console.WriteLine($"Divisiable by 400: {divBy400}");
                Console.WriteLine($"Leap year: {leap}");

        }
           

           

    }


}

