using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyApplication
{
    public class SqlConnection
    {
        string ConnectionString = null;
        SqlConnection Con;
        ConnectionString = "Data Source=localhost;Initial Catalog=Application;User ID=user;Password=pass";
            Con = new SqlConnection(ConnectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
    }
}
