using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section11.Quiz
{
    [TestClass]
    public class QuizTicketTest
    {
        [TestMethod]
        public void Test_Musical()
        {
            DateTime date = new DateTime(2020, 12, 25, 12, 30, 00);
            Musical ticket = new Musical("HS Musical", "Palawan", "6PM", "Musical", 10, date, "Pavarotti");

            Console.WriteLine(ticket.Display_Ticket());
        }

        [TestMethod]
        public void Test_Lecture()
        {
            DateTime date = new DateTime(2020, 12, 25, 12, 30, 00);
            Lecture ticket = new Lecture("HS Musical", "Makati", "6PM", "Lecture", 20, date, "Science");

            Console.WriteLine(ticket.Display_Ticket());

        }

        [TestMethod]
        public void Test_Play()
        {
            DateTime date = new DateTime(2020, 12, 25, 12, 30, 00);
            Play ticket = new Play("HS Musical", "Maila", "6PM", "Play", 12, date, "Cats");

            Console.WriteLine(ticket.Display_Ticket());

        }
    }
}
