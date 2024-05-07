using MySql.Data.MySqlClient;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingCenter
{
    public partial class AuthorsForm : Form
    {
        private MySqlConnection connection;
        public AuthorsForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            dataGridViewAuthors.Width = Width;
            buttonAdd.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 130, dataGridViewAuthors.Location.Y);
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewAuthors.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = "SELECT * FROM Authors";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewAuthors.Rows.Add(row.ItemArray[0], row.ItemArray[2], row.ItemArray[1], row.ItemArray[3], ((DateTime)row.ItemArray[4]).ToShortDateString());
                }


                //    System.Data.DataSet dataSet = new System.Data.DataSet();
                //    adapter.Fill(dataSet, "Authors");
                //    dataGridViewAuthors.DataSource = dataSet.Tables["Authors"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AuthorCardForm authorCardForm = new AuthorCardForm(true);
            authorCardForm.ShowDialog();

            UpdateTable();
        }

        private void dataGridViewAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                try
                {
                    //connection.Open();
                    string id = dataGridViewAuthors.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //string query = "SELECT * FROM Authors WHERE id = @Id LIMIT 1";
                    //MySqlCommand command = new MySqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@AuthorId", id);
                    AuthorCardForm authorCardForm = new AuthorCardForm(false, id);
                    authorCardForm.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();

                    UpdateTable();
                }
            }
        }
    }
}
