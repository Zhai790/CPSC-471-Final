using System.Windows.Forms;

namespace _471Frontend
{
    public partial class FormAdmin : Form
    {
        FormAddClient form;
        public FormAdmin()
        {
            InitializeComponent();
            form = new FormAddClient(this);
        }

        public void Display()
        {
            DbBoatBookings.GetClient("SELECT Client_ID, Phone_Number, Email, City, S_A_Number, Street, Apt_No, Province, Zip, FName, LName FROM clients", dataGridViewClient);
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

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addsailbtn_Click(object sender, EventArgs e)
        {
            FormAddSailingBooking f = new FormAddSailingBooking();
            f.ShowDialog();
        }

        private void addammenitiesbtn_Click(object sender, EventArgs e)
        {
            FormAddAmmenitiesBooking fo = new FormAddAmmenitiesBooking();
            fo.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
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
                form.Clear();
                form.GetID((int)dataGridViewClient.Rows[e.RowIndex].Cells[0].Value);
                form.City = dataGridViewClient.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.FName = dataGridViewClient.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.LName = dataGridViewClient.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.Phone_Number = dataGridViewClient.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.Email = dataGridViewClient.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.Zip = dataGridViewClient.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.S_A_Number = dataGridViewClient.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.Street = dataGridViewClient.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.Apt_No = dataGridViewClient.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.Province = dataGridViewClient.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 12)
            {
                //delete client button
                if (MessageBox.Show("Confirm Deletion?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbBoatBookings.DeleteClient((int)dataGridViewClient.Rows[e.RowIndex].Cells[0].Value);
                    Display();
                }
            }
        }
    }
}