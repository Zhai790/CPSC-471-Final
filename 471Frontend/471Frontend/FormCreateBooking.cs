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

namespace _471Frontend
{
    public partial class FormCreateBooking : Form
    {
        public FormCreateBooking()
        {
            InitializeComponent();

            //this.ammenitiesTimePicker.CustomFormat = "hh:00 tt";
            //this.ammenitiesTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //this.ammenitiesTimePicker.ShowUpDown = true;
        }

        public void Clear()
        {
            fnametxt.Text = lnametxt.Text = memberinputtxt.Text = string.Empty;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ammenitiesTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormCreateBooking_Load(object sender, EventArgs e)
        {
            string locationQuery = "SELECT Location_NO FROM location";
            DbBoatBookings.GetBooking(locationQuery, locationoptions, "Location_No");
            string boatQuery = "SELECT Boat_ID FROM boat";
            DbBoatBookings.GetBooking(boatQuery, boatOptions, "Boat_ID");

            string memLocationQuery = "SELECT Location_NO FROM location";
            DbBoatBookings.GetBooking(memLocationQuery, amenLocationBox, "Location_No");
            string amenQuery = "SELECT Booking_ID FROM booking";
            DbBoatBookings.GetBooking(amenQuery, amenBookingbox, "Booking_ID");
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitbtnnewbookingSailing_Click(object sender, EventArgs e)
        {
            ExternalClientBooking cb = new ExternalClientBooking(TimeOnly.Parse(sailstarttime.Text), sailDatePicker.Value.Date, Convert.ToInt32(locationoptions.Text), Convert.ToInt32(boatOptions.Text), fnametxt.Text, lnametxt.Text);
            
            cb.ClientID = DbBoatBookings.FindClientID(cb);
            cb.BookingID = DbBoatBookings.GetID("Booking_ID", "booking") + 1;
            DbBoatBookings.AddBooking(cb);
            Clear();
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void selectboattype_Click(object sender, EventArgs e)
        {

        }

        private void selectammenitiestitle_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newAmmenitiesSbmt_Click(object sender, EventArgs e)
        {
            if (!DbBoatBookings.CheckMembership(Convert.ToInt32(memberinputtxt.Text)))
            {
                MessageBox.Show("Sorry, Invalid Membership. Please Try Again");
                return;
            }
            ExternalMemberBooking imb = new ExternalMemberBooking(amenLocationBox.Text, Convert.ToInt32(amenBookingbox.Text.Trim()));
            imb.AmmenitiesID = DbBoatBookings.GetID("Amenities_ID", "amenities") + 1;
            imb.ClientID = DbBoatBookings.MembershipToID(Convert.ToInt32(memberinputtxt.Text));
            DbBoatBookings.AddMemBooking(imb);
            Clear();
        }
    }
}
