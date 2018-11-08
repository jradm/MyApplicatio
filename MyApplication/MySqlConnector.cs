using System;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MyApplication
{

    public partial class MySqlConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        public MySqlConnector()
        {
            server = "localhost";
            database = "testdb";
            user = "root";
            password = "5edd4dXm0";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
        }

        private void connect()
        {
            try
            {
                connection.Open();

                MessageBox.Show("successful connection");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }

        internal class disconnet : MySqlConnector
        {
            MySqlConnection GetConnection;
        }
    }
}