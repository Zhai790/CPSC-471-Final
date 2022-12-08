using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471Frontend.Datatypes
{
    internal class InternalMemberBooking
    {
        public string Location { get; set; }
        public int ClientID { get; set; }
        public int BookingID { get; set; }
        public int AmmenitiesID { get; set; }

        public InternalMemberBooking(string location, int clientID, int bookingID)
        {
            Location = location;
            ClientID = clientID;
            BookingID = bookingID;
        }
    }
}
