using MySql.Data.MySqlClient;
using PublishingCenter.Main.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingCenter.Main.Authors
{
    public partial class AuthorsBookForm : Form
    {
        private MySqlConnection connection;
        private int ID = -1;
        public AuthorsBookForm(string id)
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();



            ID = Convert.ToInt32(id);
            GetAuthorName();
            SearchBooks();
        }

        private void GetAuthorName()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @"SELECT CONCAT(last_name, ' ', first_name, ' ', middle_name) AS author_name 
                             FROM Authors 
                             WHERE id = @AuthorId LIMIT 1";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AuthorId", ID);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    labelAuthor.Text = result.ToString();
                }
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

        private void SearchBooks()
        {
            dataGridViewBooks.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @"SELECT Books.id, Books.book_code, Books.title, Genres.genre_name 
                             FROM Books 
                             INNER JOIN Genres ON Books.genre_id = Genres.id 
                             WHERE Books.author_id = @AuthorId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AuthorId", ID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewBooks.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3]);
                }
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                try
                {
                    string id = dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BookCardForm bookCardForm = new BookCardForm(false, true, id);
                    bookCardForm.ShowDialog();

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
        }
    }
}
