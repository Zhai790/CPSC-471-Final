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
using System.Xml.Linq;

namespace _471Frontend
{
    public partial class FormAddClient : Form
    {
        private readonly FormAdmin _parent;
        int Client_ID;
        public string Phone_Number, Email, City, S_A_Number, Street, Apt_No, Province, Zip, FName, LName;
        public FormAddClient(FormAdmin parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            addclienttitle.Text = "Update Client";
            submitbtnclient.Text = "Update";

            Fnametxt.Text = FName;
            Lnametxt.Text = LName;
            AptNotxt.Text = Apt_No;
            Citytxt.Text = City;
            Streettxt.Text = Street;
            emailtxt.Text = Email;
            phonetxt.Text = Phone_Number;
            Provincetxt.Text = Province;
            SANumbertxt.Text = S_A_Number;
            ziptxt.Text = Zip;
        }

        public void SaveInfo()
        {
            addclienttitle.Text = "Add Client";
            submitbtnclient.Text = "Submit";
        }

        public void GetID(int id)
        {
            Client_ID = id;
        }

        public void Clear()
        {
            Fnametxt.Text = AptNotxt.Text = Citytxt.Text = emailtxt.Text = Lnametxt.Text = phonetxt.Text = Provincetxt.Text = SANumbertxt.Text = Streettxt.Text = ziptxt.Text = string.Empty;
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            
        }

        private void addclienttitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAddClient_Load(object sender, EventArgs e)
        {

        }

        private void submitbtnclient_Click(object sender, EventArgs e)
        {
            //minimum name char length set to 3
            if(Fnametxt.Text.Trim().Length < 3) 
            {
                MessageBox.Show("Client First Name is Empty (length < 3)");
                return;
            }
            if (Lnametxt.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client Last Name is Empty (length < 3)");
                return;
            }
            if (Citytxt.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client Address is Empty (length < 3)");
                return;
            }
            if (phonetxt.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client Phone Number is Empty (length < 3)");
                return;
            }
            if (emailtitle.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client Email is Empty (length < 3)");
                return;
            }
            if (Citytxt.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client City is Empty (length < 3)");
                return;
            }
            if (SANumbertxt.Text.Trim().Length < 1)
            {
                MessageBox.Show("Client Street Address Number is Empty (length < 1)");
                return;
            }
            if (Streettxt.Text.Trim().Length < 2)
            {
                MessageBox.Show("Client Street is Empty (length < 2)");
                return;
            }
            if (AptNotxt.Text.Trim().Length < 1)
            {
                MessageBox.Show("Client Apartment Number is Empty (length < 1)");
                return;
            }
            if (ziptxt.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client Zip Code is Empty (length < 3)");
                return;
            }


            if(submitbtnclient.Text == "Submit")
            {
                Client cl = new Client(Fnametxt.Text.Trim(), Lnametxt.Text.Trim(), phonetxt.Text.Trim(), emailtxt.Text.Trim(), Citytxt.Text.Trim(), Convert.ToInt32(SANumbertxt.Text.Trim()), Streettxt.Text.Trim(), Convert.ToInt32(AptNotxt.Text.Trim()), Provincetxt.Text.Trim(), ziptxt.Text.Trim());
                DbBoatBookings.AddClient(cl);
                Clear();
            }
            if(submitbtnclient.Text == "Update")
            {
                Client cl = new Client(Fnametxt.Text.Trim(), Lnametxt.Text.Trim(), phonetxt.Text.Trim(), emailtxt.Text.Trim(), Citytxt.Text.Trim(), Convert.ToInt32(SANumbertxt.Text.Trim()), Streettxt.Text.Trim(), Convert.ToInt32(AptNotxt.Text.Trim()), Provincetxt.Text.Trim(), ziptxt.Text.Trim());
                DbBoatBookings.UpdateClient(cl, Client_ID);
                Clear();
            }

            _parent.Display();
        }

        private void emailtitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ziptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresstitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
