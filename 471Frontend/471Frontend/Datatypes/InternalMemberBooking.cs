using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471Frontend.Datatypes
{
    internal class InternalMemberBooking
    {
        public TimeOnly Time { get; set; }
        public DateOnly Date { get; set; }
        public string Location { get; set; }
        public int ClientID { get; set; }
        public int BoatID { get; set; }
        public string Name { get; set; }
        public int AmmenitiesID { get; set; }
        public int Num_Grills { get; set; }
        public int Num_Lanes { get; set; }
        public int PoolSize { get; set; }

        public InternalMemberBooking(TimeOnly time, DateOnly date, string location, int clientID, int boatID, int ammenitiesID, int numGrills, int numLanes, int poolSize)
        {
            Time = time;
            Date = date;
            Location = location;
            ClientID = clientID;
            BoatID = boatID;
            AmmenitiesID = ammenitiesID;
            Num_Grills = numGrills;
            Num_Lanes = numLanes;
            PoolSize = poolSize;
        }
    }
}
