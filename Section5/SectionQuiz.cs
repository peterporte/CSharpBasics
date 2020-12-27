using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class SectionQuiz
    {
        static int commonNum;
       

        [TestInitialize]
        public void ConvertInitialize()
        {
            commonNum = 32;
        }

        [TestMethod]
        public void Convert_F_To_C()
        {
            double  givenFahrenheit = 32;           
            double celToFahFormula = (givenFahrenheit - commonNum) * 5 / 9;

            Console.WriteLine($"The temp in F {givenFahrenheit} is {celToFahFormula} in C");
            Assert.AreEqual(celToFahFormula, 0);

        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            double givenCelsius = 0;
            double fahToCelFormula = (givenCelsius * 9 / 5) + commonNum;

            Trace.Write($"The temp in F {givenCelsius} is {fahToCelFormula} in C");
            Assert.AreEqual(fahToCelFormula, 32);

        }
    }
}
