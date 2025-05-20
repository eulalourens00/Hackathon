using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pomegranate
{
    public partial class Form1 : Form
    {
        DatabaseManager databaseManager = new DatabaseManager();
        public Form1()
        {
            databaseManager.Show();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
