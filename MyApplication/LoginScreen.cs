using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class LoginScreen : Form
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginScreen()
        {
            InitializeComponent();
        }

        //rufe Login function auf
        //Login Login = new Login("user","pass");
        
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //variables for user input
            string user = textBoxUser.Text;
            string pass = textBoxPassword.Text;
            

            //check if eligible to be logged in
            if(Login.IsLoggedIn = true)
            {
                //MessageBox.Show("You are logged in successfully!");
                //this.Hide();
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                
                //this.Close();
            }
            else
            {
                //show default fail
                MessageBox.Show("Login Error!");
            }
        }

        private void linkLabelNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
        }
    }
}
