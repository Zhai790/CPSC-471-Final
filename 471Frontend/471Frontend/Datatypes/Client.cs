using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471Frontend.Datatypes
{
    internal class Client
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int S_A_Number { get; set; }
        public string Street { get; set; }
        public int Apt_No { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }

        public Client(string fname, string lname, string phone, string email, string city, int s_A_Number, string street, int apt_No, string province, string zip)
        {
            Fname = fname;
            Lname = lname;
            Phone = phone;
            Email = email;
            City = city;
            S_A_Number = s_A_Number;
            Street = street;
            Apt_No = apt_No;
            Province = province;
            Zip = zip;
        }

        
    }
}
