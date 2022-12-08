using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471Frontend.Datatypes
{
    internal class ExternalClientBooking
    {

        public string Fname { get; set; }
        public string Lname { get; set; }
        public TimeOnly Time { get; set; }
        public DateTime Date { get; set; }
        public int Location { get; set; }
        public int ClientID { get; set; }
        public int BoatID { get; set; }

        public int bookingIDCounter = 2;    //find another solution

        public ExternalClientBooking(TimeOnly time, DateTime date, int location, int boatID, string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
            Time = time;
            Date = date;
            Location = location;
            BoatID = boatID;
        }
    }
}
