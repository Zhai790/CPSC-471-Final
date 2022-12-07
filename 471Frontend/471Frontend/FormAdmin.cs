using System.Windows.Forms;

namespace _471Frontend
{
    public partial class FormAdmin : Form
    {
        FormAddClient AddClientForm;
        FormAddSailingBooking AddSailForm;
        public FormAdmin()
        {
            InitializeComponent();
            AddClientForm = new FormAddClient(this);
            AddSailForm = new FormAddSailingBooking(this);
            dataGridViewClient.AutoGenerateColumns = false;
            dataGridViewSailBooking.AutoGenerateColumns = false;
        }

        public void DisplayClient()
        {
            DbBoatBookings.GetClient("SELECT Client_ID, Phone_Number, Email, City, S_A_Number, Street, Apt_No, Province, Zip, FName, LName FROM clients", dataGridViewClient);
        }
        public void DisplaySailingBooking() 
        {
            DbBoatBookings.GetBooking("SELECT booking.Booking_ID, booking.Time, booking.Date, booking.Located_At, reserves.Boat_ID, reserves.Client_ID FROM booking, reserves", dataGridViewSailBooking);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormAddClient form = new FormAddClient(); 
            //form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //edit client button
                AddSailForm.Clear();
                AddSailForm.BookingID = (int)dataGridViewSailBooking.Rows[e.RowIndex].Cells[0].Value;
                AddSailForm.Time = (TimeOnly)dataGridViewSailBooking.Rows[e.RowIndex].Cells[1].Value;
                AddSailForm.Date = (DateOnly)dataGridViewSailBooking.Rows[e.RowIndex].Cells[2].Value;
                AddSailForm.Location = dataGridViewSailBooking.Rows[e.RowIndex].Cells[3].Value.ToString();
                AddSailForm.ClientID = (int)dataGridViewSailBooking.Rows[e.RowIndex].Cells[4].Value;
                AddSailForm.BoatID = (int)dataGridViewSailBooking.Rows[e.RowIndex].Cells[5].Value;             
                AddClientForm.UpdateInfo();
                AddSailForm.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 7)
            {
                //delete client button
                if (MessageBox.Show("Confirm Deletion?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbBoatBookings.DeleteBooking((int)dataGridViewSailBooking.Rows[e.RowIndex].Cells[0].Value);
                    DisplayClient();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addsailbtn_Click(object sender, EventArgs e)
        {
            //FormAddSailingBooking f = new FormAddSailingBooking(this);
            //f.ShowDialog();

            AddSailForm.Clear();
            AddSailForm.SaveInfo();
            AddSailForm.ShowDialog();
        }

        private void addammenitiesbtn_Click(object sender, EventArgs e)
        {
            FormAddAmmenitiesBooking fo = new FormAddAmmenitiesBooking();
            fo.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            DisplayClient();
            DisplaySailingBooking();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClientForm.Clear();
            AddClientForm.SaveInfo();
            AddClientForm.ShowDialog();
        }

        private void searchClients_TextChanged(object sender, EventArgs e)
        {
            DbBoatBookings.GetClient("SELECT Client_ID, Phone_Number, Email, City, S_A_Number, Street, Apt_No, Province, Zip, FName, LName FROM clients WHERE LName LIKE '%" + searchClients.Text + "%'", dataGridViewClient);
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                //edit client button
                AddClientForm.Clear();
                AddClientForm.GetID((int)dataGridViewClient.Rows[e.RowIndex].Cells[0].Value);
                AddClientForm.City = dataGridViewClient.Rows[e.RowIndex].Cells[1].Value.ToString();
                AddClientForm.FName = dataGridViewClient.Rows[e.RowIndex].Cells[2].Value.ToString();
                AddClientForm.LName = dataGridViewClient.Rows[e.RowIndex].Cells[3].Value.ToString();
                AddClientForm.Phone_Number = dataGridViewClient.Rows[e.RowIndex].Cells[4].Value.ToString();
                AddClientForm.Email = dataGridViewClient.Rows[e.RowIndex].Cells[5].Value.ToString();
                AddClientForm.Zip = dataGridViewClient.Rows[e.RowIndex].Cells[6].Value.ToString();
                AddClientForm.S_A_Number = dataGridViewClient.Rows[e.RowIndex].Cells[7].Value.ToString();
                AddClientForm.Street = dataGridViewClient.Rows[e.RowIndex].Cells[8].Value.ToString();
                AddClientForm.Apt_No = dataGridViewClient.Rows[e.RowIndex].Cells[9].Value.ToString();
                AddClientForm.Province = dataGridViewClient.Rows[e.RowIndex].Cells[10].Value.ToString();
                AddClientForm.UpdateInfo();
                AddClientForm.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 12)
            {
                //delete client button
                if (MessageBox.Show("Confirm Deletion?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbBoatBookings.DeleteClient((int)dataGridViewClient.Rows[e.RowIndex].Cells[0].Value);
                    DisplayClient();
                }
            }
        }

        private void searchBookings_TextChanged(object sender, EventArgs e)
        {
            DbBoatBookings.GetBooking("SELECT booking.Booking_ID, booking.Time, booking.Date, booking.Located_At, reserves.Boat_ID, reserves.Client_ID FROM booking, reserves WHERE reserves.Client_ID LIKE " + searchBookings.Text + "", dataGridViewSailBooking);
        }
    }
}