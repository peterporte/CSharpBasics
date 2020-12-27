using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section12
{
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void Test_Traveller()
        {
            Student Student1 = new Student("001", "Peter", "Porte", 18, "ComSci", "101");
            Student Student2 = new Student("002", "Angela", "Millora", 17, "Psych", "202");
            Professor Prof1 = new Professor("003", "CHarles", "Xavier", 50, "303", "Math");
            Professor Prof2 = new Professor("003", "CHarlesss", "Xavierrrr", 60, "404", "Science");

            Person[] ListOfPeople = new Person[4];

            ListOfPeople[0] = Student1;
            ListOfPeople[1] = Student2;
            ListOfPeople[2] = Prof1;
            ListOfPeople[3] = Prof2;

            foreach (Person someone in ListOfPeople)
            {
                Console.WriteLine(someone);
            }
        }
    
    }
}
