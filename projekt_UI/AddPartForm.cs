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
    public partial class AddPartForm : Form
    {
        private SqlConnection _connection;

        public AddPartForm(SqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            string partName = textBoxPartName.Text;
            string color = textBoxColor.Text;
            string material = textBoxMaterial.Text;

            if (string.IsNullOrWhiteSpace(partName) || string.IsNullOrWhiteSpace(color) || string.IsNullOrWhiteSpace(material))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Parts (PartName, Color, Material) VALUES (@PartName, @Color, @Material)";

            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@PartName", partName);
                command.Parameters.AddWithValue("@Color", color);
                command.Parameters.AddWithValue("@Material", material);

                // liczba wierszy, które zostały dodane
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Część została dodana do bazy danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd przy dodawaniu części.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
