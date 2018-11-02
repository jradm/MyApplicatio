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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        string Conn = ("Data Source=localhost;Initial Catalog=Application;User ID=dbuser;Password=dbpass");

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
