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
    public partial class CreateGuest : Form
    {
        public CreateGuest()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastname = TextBoxLastname.Text;
            string firstname = TextBoxFirstname.Text;
            string street = TextBoxStreet.Text;
            string zip = TextBoxZip.Text;
            string city = TextBoxCity.Text;
            string country = TextBoxCountry.Text;
            //var dob = DateTimePickerDob.Value;
            
            DateTime dateTimeVariable = DateTimePickerDob.Value;
            string dob = dateTimeVariable.ToString("yyyy-MM-dd H:mm:ss");

            string language = TextBoxLanguage.Text;

            MySqlConnection connnection = new MySqlConnection("server=localhost;user id=user;password=pass;database=application");
            MySqlCommand command;
            MySqlDataAdapter adapter;
            DataTable table;
            String query = "INSERT INTO `application`.`guests` (`lastname`,`firstname`,`street`,`zip`,`city`,`country`,`date_of_birth`,`language`)" +
                "VALUES('"+lastname+"','"+firstname+"','"+street+"','"+zip+"','"+city+"','"+country+"','"+dob+"','"+language+"')";

            command = new MySqlCommand(query, connnection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

            MessageBox.Show("Gast" + lastname + ", " + firstname + " created!");
            this.Close();
        }
    }
}
