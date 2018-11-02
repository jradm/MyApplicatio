using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyApplication
{
    class Login
    {
        //declare properties
        public string Username { get; set; }
        public string Password { get; set; }

        //init
        public Login(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }

        //valid
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if(Regex.IsMatch(input,pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //clear user input
        private void ClearTexts(string user, string pass)
        {
            user = string.Empty;
            pass = string.Empty;
        }

        //check if eligible to login
        internal bool IsLoggedIn(string user, string pass)
        {
            //check user name empty
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter Username!");
                return false;
            }

            //check is valid type
            else if (StringValidator(user) == true)
            {
                MessageBox.Show("Enter only Text!");
                ClearTexts(user, pass);
                return false;
            }

            //check user name is correct
            else
            {
                if (Username != user)
                {
                    MessageBox.Show("Username is correct!");
                    ClearTexts(user, pass);
                    return false;
                }

                //check password is empty
                else
                {
                    if (string.IsNullOrEmpty(pass))
                        {
                        MessageBox.Show("Enter Password!");
                        return false;
                        }

                    //check if password is valid
                    else if (Password!=pass)
                        {
                        MessageBox.Show("Password correct!");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
