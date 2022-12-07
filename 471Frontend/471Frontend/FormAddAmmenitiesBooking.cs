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
    public partial class FormAddAmmenitiesBooking : Form
    {
        public FormAddAmmenitiesBooking()
        {
            InitializeComponent();
            this.ammentiestime.CustomFormat = "hh:00 tt";
            this.ammentiestime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ammentiestime.ShowUpDown = true;
        }
    }
}
