using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class InternalClientBooking
{
    public TimeOnly Time { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public int ClientID { get; set; }
    public int BoatID { get; set; }

    public int bookingIDCounter = 2;    //find another solution

    public InternalClientBooking(TimeOnly time, DateTime date, string location, int clientID, int boatID)
	{
        Time = time;
        Date = date;
        Location = location;
        ClientID = clientID;
        BoatID = boatID;
	}
}
