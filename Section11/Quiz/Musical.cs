using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Quiz
{
    class Musical : Ticket

    {
        private string bandName;

        public Musical(string eName, string eLocation, string eTIme, string eType, int tPrice, DateTime eDate,
            string bName)
            : base(eName, eLocation, eTIme, eType, tPrice, eDate)
        {
            BandName = bName;
        }

        public string BandName { get; set; }

        public override string Display_Ticket()
        {
            return "Event: " + EventName +
                   "\nEvent Location: " + EventLocation +
                   "\nEvent TIme: " + EventTime +
                   "\nEvent Type: " + EventType +
                   "\nTicket Price" + TicketPrice.ToString("C") +
                   "\nDate : " + EventDate +
                   "\nBand Name: " + BandName;

        }
    }
}
