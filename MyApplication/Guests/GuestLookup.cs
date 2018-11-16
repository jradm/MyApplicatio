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

            if (!string.IsNullOrWhiteSpace(lastname))
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
            

            if (!string.IsNullOrWhiteSpace(firstname))
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

            if (!string.IsNullOrWhiteSpace(street))
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

            if (!string.IsNullOrWhiteSpace(zip))
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

            if (!string.IsNullOrWhiteSpace(city))
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

            if (!string.IsNullOrWhiteSpace(country))
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

            if (!string.IsNullOrWhiteSpace(tel))
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

        private void ButtonCreatenewguest_Click(object sender, EventArgs e)
        {
            CreateGuest createGuest = new CreateGuest();
            createGuest.Show();
        }
    }
}
