using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471Frontend.Datatypes
{
    internal class ExternalMemberBooking
    {
        public string Location { get; set; }
        public int ClientID { get; set; }
        public int BookingID { get; set; }
        public int AmmenitiesID { get; set; }
        public int MembershipCardNum { get; set; }

        public ExternalMemberBooking(string location, int bookingID)
        {
            Location = location;
            BookingID = bookingID;

        }
    }
}
