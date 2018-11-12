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

namespace MyApplication
{
    public class SqlConnector
    {
       
        SqlConnection Con = new SqlConnection("Data Source=localhost;Initial Catalog=Application;User=dbuser;Password=dbpass");
       
        public void ConnectSql()
        {
            try
            {
                Con.Open();

            }
            catch (SqlException e)
            {
                MessageBox.Show("SQL Error:" + e);
            }
        }

        public void DisconnectMySql()
        {
            try
            {
                Con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("SQL Error:" + e);
            }
        }
    }
}
