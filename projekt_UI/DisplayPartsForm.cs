using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace projekt_UI
{
    public partial class DisplayPartsForm : Form
    {
        private SqlConnection _connection;

        // Konstruktor, który przyjmuje SqlConnection
        public DisplayPartsForm(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            LoadParts();
        }

        // Metoda do załadowania danych do DataGridView
        private void LoadParts()
        {
            string query = "SELECT * FROM Parts";
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridViewParts.DataSource = dataTable;
                }
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
