using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Quiz
{
    abstract class Ticket
    {
        private string eventName;
        private string eventLocation;
        private string eventTime;
        private string eventType;
        private int ticketPrice;
        private DateTime eventDate;

        public Ticket(string eName, string eLocation, string eTIme, string eType, int tPrice, DateTime eDate)
        {
            EventName = eName;
            EventLocation = eLocation;
            EventTime = eTIme;
            EventType = eType;
            TicketPrice = tPrice;
            EventDate = eDate;
        }

        public string EventName { get; set; }
        public string EventLocation { get; set; }
        public string EventTime { get; set; }
        public string EventType { get; set; }
        public int TicketPrice { get; set; }
        public DateTime EventDate { get; set; }


        public abstract string Display_Ticket();

    }
}
