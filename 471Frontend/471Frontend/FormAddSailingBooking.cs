using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using _471Frontend.Datatypes;

namespace _471Frontend
{
    public partial class FormAddSailingBooking : Form
    {
        private readonly FormAdmin _parent;
        public int ClientID, BoatID, BookingID;
        public TimeOnly Time;
        public DateOnly Date;
        public string Location;
        public FormAddSailingBooking(FormAdmin parent)
        {
            InitializeComponent();
            this.sailstarttime.CustomFormat = "hh:00 tt";
            this.sailstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sailstarttime.ShowUpDown = true;
            _parent = parent;
        }

        public void UpdateInfo()
        {
            addsailtitle.Text = "Update Booking";
            submitbtnsail.Text = "Update";


        }

        public void SaveInfo()
        {
            addsailtitle.Text = "Add Booking";
            submitbtnsail.Text = "Submit";
        }

        public void Clear()
        {
            sailclientIDtxt.Text = sailtimepicker.Text = sailstarttime.Text = saillocationtxt.Text = sailboatIDtxt.Text = string.Empty;
        }

        private void addclienttitle_Click(object sender, EventArgs e)
        {

        }

        private void sailboatIDtitle_Click(object sender, EventArgs e)
        {

        }

        private void sailstarttime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormAddSailingBooking_Load(object sender, EventArgs e)
        {
            string IDQuery = "SELECT Client_ID FROM clients";
            DbBoatBookings.GetBooking(IDQuery, sailclientIDtxt, "Client_ID");
            string locationQuery = "SELECT Location_NO FROM location";
            DbBoatBookings.GetBooking(locationQuery, saillocationtxt, "Location_No");
            string boatQuery = "SELECT Boat_ID FROM boat";
            DbBoatBookings.GetBooking(boatQuery, sailboatIDtxt, "Boat_ID");
        }

        private void sailclientIDtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saillocationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sailboatIDtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitbtnsail_Click(object sender, EventArgs e)
        {
            if (submitbtnsail.Text == "Submit")
            {
                ClientBooking cb = new ClientBooking(TimeOnly.Parse(sailstarttime.Text), sailtimepicker.Value.Date, saillocationtxt.Text.Trim(), Convert.ToInt32(sailclientIDtxt.Text.Trim()), Convert.ToInt32(sailboatIDtxt.Text.Trim()));
                DbBoatBookings.AddBooking(cb, cb.bookingIDCounter);
                Clear();
            }
            if (submitbtnsail.Text == "Update")
            {

                ClientBooking cb = new ClientBooking(TimeOnly.Parse(sailstarttime.Text), sailtimepicker.Value.Date, saillocationtxt.Text.Trim(), Convert.ToInt32(sailclientIDtxt.Text.Trim()), Convert.ToInt32(sailboatIDtxt.Text.Trim()));
                DbBoatBookings.UpdateBooking(cb, BookingID);
                Clear();
            }

            _parent.DisplaySailingBooking();
        }
    }
}
