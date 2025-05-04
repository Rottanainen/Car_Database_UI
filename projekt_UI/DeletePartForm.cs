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
    public partial class DeletePartForm : Form
    {
        private SqlConnection connection;

        public DeletePartForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string partIdText = textBoxPartId.Text.Trim();

            if (string.IsNullOrEmpty(partIdText) || !int.TryParse(partIdText, out int partId))
            {
                MessageBox.Show("Proszę wprowadzić poprawny ID części.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM Parts WHERE ID = @ID";
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                command.Parameters.AddWithValue("@ID", partId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Część o ID {partId} została usunięta.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPartId.Clear();
                }
                else
                {
                    MessageBox.Show($"Część o ID {partId} nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}