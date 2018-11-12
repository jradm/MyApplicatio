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
            //MySQL DB Connection
            MySqlConnector MySqlConnector = new MySqlConnector();
            MySqlConnector.ConnectMySql();

            //MySQL Login
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

                    this.Hide();
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
        }
    }   
}
