using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Quiz
{
    class Play : Ticket
    {
        private string playName;

        public Play(string eName, string eLocation, string eTIme, string eType, int tPrice, DateTime eDate, string sName)
            : base(eName, eLocation, eTIme, eType, tPrice, eDate)
        {
            PlayName = sName;
        }

        public string PlayName { get; set; }

        public override string Display_Ticket()
        {
            return "Event: " + EventName +
                   "\nEvent Location: " + EventLocation +
                   "\nEvent TIme: " + EventTime +
                   "\nEvent Type: " + EventType +
                   "\nTicket Price" + TicketPrice.ToString("C") +
                   "\nDate : " + EventDate +
                   "\nBPlay Name: " + PlayName;

        }
    }
}
