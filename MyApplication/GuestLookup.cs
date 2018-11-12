using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace MyApplication
{
    public partial class GuestLookup : Form
    {
        public GuestLookup()
        {
            InitializeComponent();
        }



        private void ButtonGuestSearch_Click_1(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string firstname = TextBoxFirstName.Text;
            string street = TextBoxStreet.Text;
            string zip = TextBoxZIP.Text;
            string city = TextBoxCity.Text;
            string country = TextBoxCountry.Text;
            string tel = TextBoxTelephone.Text;

            if (name != null)
            {

            }

            if (firstname != null)
            {

            }

            if (street != null)
            {

            }

            if (zip != null)
            {

            }

            if (city != null)
            {

            }

            if (country != null)
            {

            }

            if (tel != null)
            {

            }

            //MySqlConnection Con = new MySqlConnection("server=localhost;user id=user;password=pass;database=application");
            //MySqlCommand cmd = new MySqlCommand("", Con);
            //MySqlDataReader dataReader;
            //Con.Open();
            //dataReader = cmd.ExecuteReader();
            //MessageBox.Show("Login created!");
            //while (dataReader.Read())
            //{
            //}
            //Con.Close();

        }
    }
}
