﻿using _471Frontend.Datatypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471Frontend
{
    internal class DbBoatBookings
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=1234;database=boatbookingsdb";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        //utilizing SqlCommand automatically handles sql injection prevention

        public static void AddClient(Client cl)
        {
            string sql = "INSERT INTO clients VALUES (NULL, @Phone, @Email, @City, @SANumber, @Street, @Apt_No, @Province, @Zip, @Fname, @Lname)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = cl.Phone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cl.Email;
            cmd.Parameters.Add("@City", MySqlDbType.VarChar).Value = cl.City;
            cmd.Parameters.Add("@SANumber", MySqlDbType.Int32).Value = cl.S_A_Number;
            cmd.Parameters.Add("@Street", MySqlDbType.VarChar).Value = cl.Street;
            cmd.Parameters.Add("@Apt_No", MySqlDbType.Int32).Value = cl.Apt_No;
            cmd.Parameters.Add("@Province", MySqlDbType.VarChar).Value = cl.Province;
            cmd.Parameters.Add("@Zip", MySqlDbType.VarChar).Value = cl.Zip;
            cmd.Parameters.Add("@Fname", MySqlDbType.VarChar).Value = cl.Fname;
            cmd.Parameters.Add("@Lname", MySqlDbType.VarChar).Value = cl.Lname;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("New Client Not Inserted!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateClient(Client cl, int id)
        {
            string sql = "UPDATE clients SET Phone_Number = @Phone, Email = @Email, City = @City, S_A_Number = @SANumber, Street = @Street, Apt_No = @Apt_No, Province = @Province, Zip = @Zip, FName = @Fname, LName = @Lname WHERE Client_ID = @ClientID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClientID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = cl.Phone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cl.Email;
            cmd.Parameters.Add("@City", MySqlDbType.VarChar).Value = cl.City;
            cmd.Parameters.Add("@SANumber", MySqlDbType.Int32).Value = cl.S_A_Number;
            cmd.Parameters.Add("@Street", MySqlDbType.VarChar).Value = cl.Street;
            cmd.Parameters.Add("@Apt_No", MySqlDbType.Int32).Value = cl.Apt_No;
            cmd.Parameters.Add("@Province", MySqlDbType.VarChar).Value = cl.Province;
            cmd.Parameters.Add("@Zip", MySqlDbType.VarChar).Value = cl.Zip;
            cmd.Parameters.Add("@Fname", MySqlDbType.VarChar).Value = cl.Fname;
            cmd.Parameters.Add("@Lname", MySqlDbType.VarChar).Value = cl.Lname;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client Information Update Failed!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteClient(int id)
        {
            string sql = "DELETE FROM clients WHERE Client_ID = @ClientID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClientID", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client Deletion Failed!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void GetClient(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void GetBooking(string query, ComboBox cb, string colName)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            cb.DisplayMember = colName;
            cb.DataSource = tbl;
            con.Close();
        }
    }
}