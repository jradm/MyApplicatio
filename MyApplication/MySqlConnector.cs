using System;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;


namespace MyApplication
{

    public partial class MySqlConnector
    {
        MySqlConnection Con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=testdb;User=user;Password=pass");

        public void ConnectMySql()
        {
            try
            {
                Con.Open();
            }
            catch(MySqlException e)
            {
                MessageBox.Show("MySQL Error:" + e);
            }
        }

        public void DisconnectMySql()
        {
            try
            {
                Con.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("MySQL Error:" + e);
            }
        }
    }    
}
