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

namespace _471Frontend
{
    public partial class FormAddSailingBooking : Form
    {
        public FormAddSailingBooking()
        {
            InitializeComponent();
            this.sailstarttime.CustomFormat = "hh:00 tt";
            this.sailstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sailstarttime.ShowUpDown = true;
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
            string query = "SELECT Client_ID FROM clients";
            DbBoatBookings.GetBooking(query, sailclientIDtxt, "Client_ID");
        }

        private void sailclientIDtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saillocationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Client_ID FROM clients";
            DbBoatBookings.GetBooking(query, sailclientIDtxt, "Client_ID");
        }

        private void sailboatIDtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Client_ID FROM clients";
            DbBoatBookings.GetBooking(query, sailclientIDtxt, "Client_ID");
        }
    }
}
