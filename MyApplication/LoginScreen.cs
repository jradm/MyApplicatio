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
            }
            if (checkedListBox1.SelectedItem.Equals("SQL DB"))
            {
                //SQL DB Connection
                SqlConnector SqlConnector = new SqlConnector();
                SqlConnector.ConnectSql();
             
                string Username = textBoxUser.Text;
                string Password = textBoxPassword.Text;

                SqlDataAdapter dataAdapter = new SqlDataAdapter("select count(*) from User where Username = " + Username + " and Password = " + Password + ";");
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
