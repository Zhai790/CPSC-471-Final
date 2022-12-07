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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void createbookingbtn_Click(object sender, EventArgs e)
        {
            FormCreateBooking book = new FormCreateBooking();
            book.ShowDialog();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
