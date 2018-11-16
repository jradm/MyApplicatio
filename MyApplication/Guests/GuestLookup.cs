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
            string lastname = TextBoxName.Text;
            string firstname = TextBoxFirstName.Text;
            string street = TextBoxStreet.Text;
            string zip = TextBoxZIP.Text;
            string city = TextBoxCity.Text;
            string country = TextBoxCountry.Text;
            string tel = TextBoxTelephone.Text;

            MySqlConnection connnection = new MySqlConnection("server=localhost;user id=user;password=pass;database=application");
            MySqlCommand command;
            MySqlDataAdapter adapter;
            DataTable table;

            if (lastname != null)
            {
                string query = "SELECT * FROM guests WHERE CONCAT(`id`, `lastname`, `firstname`, `street`, `zip`, `city`, `country`, `telephone`) like '%" + lastname + "%'";
                command = new MySqlCommand(query, connnection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                ViewGuestGrid.DataSource = table;

                if(ViewGuestGrid.Rows.Count == 0 )
                {
                    NoGuestFound noGuest = new NoGuestFound();
                    noGuest.Show();
                }
            }
            

            if (firstname != null)
            {
                string query = "SELECT * FROM guests WHERE CONCAT(`id`, `lastname`, `firstname`, `street`, `zip`, `city`, `country`, `telephone`) like '%" + firstname + "%'";
                command = new MySqlCommand(query, connnection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                ViewGuestGrid.DataSource = table;

                if (ViewGuestGrid.Rows.Count == 0)
                {
                    NoGuestFound noGuest = new NoGuestFound();
                    noGuest.Show();
                }
            }

            if (street != null)
            {
                string query = "SELECT * FROM guests WHERE CONCAT(`id`, `lastname`, `firstname`, `street`, `zip`, `city`, `country`, `telephone`) like '%" + street + "%'";
                command = new MySqlCommand(query, connnection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                ViewGuestGrid.DataSource = table;

                if (ViewGuestGrid.Rows.Count == 0)
                {
                    NoGuestFound noGuest = new NoGuestFound();
                    noGuest.Show();
                }
            }

            if (zip != null)
            {
                string query = "SELECT * FROM guests WHERE CONCAT(`id`, `lastname`, `firstname`, `street`, `zip`, `city`, `country`, `telephone`) like '%" + zip + "%'";
                command = new MySqlCommand(query, connnection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                ViewGuestGrid.DataSource = table;

                if (ViewGuestGrid.Rows.Count == 0)
                {
                    NoGuestFound noGuest = new NoGuestFound();
                    noGuest.Show();
                }
            }

            if (city != null)
            {
                string query = "SELECT * FROM guests WHERE CONCAT(`id`, `lastname`, `firstname`, `street`, `zip`, `city`, `country`, `telephone`) like '%" + city + "%'";
                command = new MySqlCommand(query, connnection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                ViewGuestGrid.DataSource = table;

                if (ViewGuestGrid.Rows.Count == 0)
                {
                    NoGuestFound noGuest = new NoGuestFound();
                    noGuest.Show();
                }
            }

            if (country != null)
            {
                string query = "SELECT * FROM guests WHERE CONCAT(`id`, `lastname`, `firstname`, `street`, `zip`, `city`, `country`, `telephone`) like '%" + country + "%'";
                command = new MySqlCommand(query, connnection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                ViewGuestGrid.DataSource = table;

                if (ViewGuestGrid.Rows.Count == 0)
                {
                    NoGuestFound noGuest = new NoGuestFound();
                    noGuest.Show();
                }
            }

            if (tel != null)
            {
                string query = "SELECT * FROM guests WHERE CONCAT(`id`, `lastname`, `firstname`, `street`, `zip`, `city`, `country`, `telephone`) like '%" + tel + "%'";
                command = new MySqlCommand(query, connnection);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                ViewGuestGrid.DataSource = table;

                if (ViewGuestGrid.Rows.Count == 0)
                {
                    NoGuestFound noGuest = new NoGuestFound();
                    noGuest.Show();
                }
            }

            else
            {
                MessageBox.Show("Please enter minimum a lastname!");
            }
        }

    }
}
