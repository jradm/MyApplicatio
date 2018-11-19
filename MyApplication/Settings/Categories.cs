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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "applicationDataSet.categories". Sie können sie bei Bedarf verschieben oder entfernen.
            this.categoriesTableAdapter.Fill(this.applicationDataSet.categories);

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
