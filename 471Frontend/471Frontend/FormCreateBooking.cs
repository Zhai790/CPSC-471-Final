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
            this.dateTimePicker1.CustomFormat = "hh:00 tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ShowUpDown = true;

            this.ammenitiesTimePicker.CustomFormat = "hh:00 tt";
            this.ammenitiesTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ammenitiesTimePicker.ShowUpDown = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.TimeOfDay.ToString());
        }

        private void ammenitiesTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
