﻿using System;
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
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=Shop;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DisplayPartsForm displayPartsForm = new DisplayPartsForm(connection);
                displayPartsForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                AddPartForm addPartForm = new AddPartForm(connection);
                addPartForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SearchPartForm searchPartForm = new SearchPartForm(connection, "Color");
                searchPartForm.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SearchPartForm searchPartForm = new SearchPartForm(connection, "Material");
                searchPartForm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DeletePartForm deletePartForm = new DeletePartForm(connection);
                deletePartForm.ShowDialog();
            }
        }
    }
}
