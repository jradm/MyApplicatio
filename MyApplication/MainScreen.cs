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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arrivals arrivals = new Arrivals();
            arrivals.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inhouse inhouse = new Inhouse();
            inhouse.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Departures departures = new Departures();
            departures.Show();
        }

        public void ButtonExit_Click(object sender, EventArgs e)
        {
            MySqlConnector MySqlConnector = new MySqlConnector();
            MySqlConnector.DisconnectMySql();
            //this.Close();
            Application.Exit();
        }
    }
}
