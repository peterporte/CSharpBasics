using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Quiz
{
    class Lecture : Ticket
    {
        private string lectureSubject;

        public Lecture(string eName, string eLocation, string eTIme, string eType, int tPrice, DateTime eDate, string lSubject)
            : base(eName, eLocation, eTIme, eType, tPrice, eDate)
        {
            LectureSubject = lSubject;
        }

        public string LectureSubject { get; set; }

        public override string Display_Ticket()
        {
            return "Event: " + EventName +
                   "\nEvent Location: " + EventLocation +
                   "\nEvent TIme: " + EventTime +
                   "\nEvent Type: " + EventType +
                   "\nTicket Price" + TicketPrice.ToString("C") +
                   "\nDate : " + EventDate +
                   "\nLecture Subject: " + LectureSubject;

        }

    }
}
