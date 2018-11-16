using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MyApplication
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Con = new MySqlConnection("server=localhost;user id=user;password=pass;database=application");
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `application`.`user` (`username`, `password`) VALUES ('" + TextBoxUsername.Text + "', '" + TextBoxPassword.Text + "')", Con);
                MySqlDataReader dataReader;
                Con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Login created!");
                while (dataReader.Read())
                {
                }
                Con.Close();
                
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();

                this.Close();

            }
            catch (MySqlException error)
            {
                    MessageBox.Show(error.Message);
            }
        }
    }
}
