namespace _471Frontend
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddClient form = new FormAddClient(); ;
            form.ShowDialog();
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

        }
    }
}