using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void Calculate_MilesPerGallon()
        {           
            Trip myTrip = new Trip("Bulacan", 100, 21, 10);           
            Console.WriteLine(myTrip.MilesPerGallon());
            Assert.AreEqual(myTrip.MilesPerGallon(), 10);
            
        }

        [TestMethod]
        public void Calculate_CostPerMile()
        {
            Trip myTrip = new Trip("Bulacan", 100, 20, 10);
            double bulacanTrip = myTrip.CostPerMile();
            Console.WriteLine(myTrip);
            Assert.AreEqual(bulacanTrip, .2);
        }


    }
}
