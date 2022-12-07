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
    }
}
