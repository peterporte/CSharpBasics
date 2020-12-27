using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class SwitchStatements
    {
        [TestMethod]
        public void Test_Switch_Statements()
        {
            int weekDay = 4;
            string testDay = "";

            switch (weekDay)
            {

                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Tuesday";
                    break;
                case 3:
                    testDay = "Wednesday";
                    break;
                case 4:
                    testDay = "Thursday";
                    break;
                case 5:
                    testDay = "Friday";
                    break;
                default:
                    testDay = "Days not within Monday to Friday";
                    break;
            }
             Assert.AreEqual("Thursday", testDay);

        }

        [TestMethod]
        public void Switch_States_Name()
        {
            string stateAbbre = "GA";
            string stateName = "";

            switch (stateAbbre)
            {
                case "AZ":
                    stateName = "Arizona";
                    break;
                case "GA":
                    stateName = "Georgia";
                    break;
                case "CA":
                    stateName = "California";
                    break;
                case "IL":
                    stateName = "Illinois";
                    break;
                default:
                    stateName = "no state";
                    break;
            }

            Assert.AreEqual("Georgia", stateName);
        }
    }
}
