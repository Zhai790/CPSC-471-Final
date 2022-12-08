using _471Frontend.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _471Frontend
{
    public partial class FormAddAmmenitiesBooking : Form
    {
        private readonly FormAdmin _parent;
        public int ClientID, BookingID, AmmenitiesID;
        public string Location;

        private void ammenitiesIDtitle_Click(object sender, EventArgs e)
        {

        }

        public FormAddAmmenitiesBooking(FormAdmin parent)
        {
            InitializeComponent();
            //this.ammentiestime.CustomFormat = "hh:00 tt";
            //this.ammentiestime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //this.ammentiestime.ShowUpDown = true;
            _parent = parent;
        }

        public void UpdateInfo()
        {
            addammenitiestitle.Text = "Update Booking";
            submitbtnammenities.Text = "Update";
        }

        public void SaveInfo()
        {
            addammenitiestitle.Text = "Add Booking";
            submitbtnammenities.Text = "Submit";
        }

        public void Clear()
        {
            sailclientIDtxt.Text = saillocationtxt.Text = bookingIDtxt.Text = string.Empty;
        }

        private void FormAddAmmenitiesBooking_Load(object sender, EventArgs e)
        {
            string IDQuery = "SELECT Client_ID FROM clients";
            DbBoatBookings.GetBooking(IDQuery, sailclientIDtxt, "Client_ID");
            string locationQuery = "SELECT Location_NO FROM location";
            DbBoatBookings.GetBooking(locationQuery, saillocationtxt, "Location_No");
            string amenQuery = "SELECT Booking_ID FROM booking";
            DbBoatBookings.GetBooking(amenQuery, bookingIDtxt, "Booking_ID");
        }

        private void submitbtnammenities_Click(object sender, EventArgs e)
        {
            if (submitbtnammenities.Text == "Submit")
            {
                InternalMemberBooking imb = new InternalMemberBooking(saillocationtxt.Text.Trim(), Convert.ToInt32(sailclientIDtxt.Text.Trim()), Convert.ToInt32(bookingIDtxt.Text.Trim()));
                AmmenitiesID = DbBoatBookings.GetID("Amenities_ID", "amenities")+1;
                DbBoatBookings.AddMemBooking(imb, AmmenitiesID);
                Clear();
            }
            if (submitbtnammenities.Text == "Update")
            {
                InternalMemberBooking imb = new InternalMemberBooking(saillocationtxt.Text.Trim(), Convert.ToInt32(sailclientIDtxt.Text.Trim()), Convert.ToInt32(bookingIDtxt.Text.Trim()));
                DbBoatBookings.UpdateMemBooking(imb, AmmenitiesID);
                Clear();
            }

            _parent.DisplayAmenBooking();
        }
    }
}
