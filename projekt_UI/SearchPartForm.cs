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
    public partial class SearchPartForm : Form
    {
        private SqlConnection connection;
        private string searchType; // Przechowuje typ wyszukiwania (Color" lub "Material), więc mam tylko jedną metodę na oba wyszukiwania

        public SearchPartForm(SqlConnection connection, string searchType)
        {
            InitializeComponent();
            this.connection = connection;
            this.searchType = searchType; // Color lub Material
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearchValue.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show($"Proszę podać {this.searchType.ToLower()} do wyszukiwania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT ID, PartName, Color, Material FROM Parts WHERE {this.searchType} = @Value";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@Value", searchValue);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridViewResults.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show($"Brak części o {this.searchType.ToLower()} '{searchValue}'.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewResults.DataSource = null;
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
