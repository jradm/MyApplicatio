using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MyApplication
{
    public partial class LoginScreen : Form
    {

        public LoginScreen()
        {
            InitializeComponent();
        }

               
        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.SelectedItem.Equals("MySQL DB"))
            {
                //MySQL DB Connection
                MySqlConnector MySqlConnector  = new MySqlConnector();
                MySqlConnector.ConnectMySql();

                //TODO: MySQL Login
                MySqlConnection Con = new MySqlConnection("server=localhost;user id=user;password=pass;database=application");
                MySqlCommand cmd = new MySqlCommand("select count(*) from application.user where username = '" + textBoxUser.Text + "'and password = '" + textBoxPassword.Text + "'", Con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                try
                {
                    if (dataTable.Rows[0][0].ToString() == "1")
                    {

                        MessageBox.Show("Login successful!");

                        MainScreen mainScreen = new MainScreen();
                        mainScreen.Show();
                    }

                    else
                    {
                        MessageBox.Show("Login invalid!");
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySql Error: " + ex);
                }

            }
            if (checkedListBox1.SelectedItem.Equals("SQL DB"))
            {
                //SQL DB Connection
                SqlConnector SqlConnector = new SqlConnector();
                SqlConnector.ConnectSql();

                SqlConnection Con = new SqlConnection("Data Source=localhost;Initial Catalog=Application;User=dbuser;Password=dbpass");
                SqlCommand cmd = new SqlCommand("select count(*) from User where Username = " + textBoxUser.Text + " and Password = " + textBoxPassword.Text + "", Con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login successful!");

                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Show();
                }
                else
                {
                    MessageBox.Show("Login invalid!");
                }
            }
            if (checkedListBox1.SelectedItem.Equals(null))
            {
                MessageBox.Show("something went wrong!");
            }
        }

        private void linkLabelNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
