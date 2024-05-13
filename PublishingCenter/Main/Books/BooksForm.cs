using MySql.Data.MySqlClient;
using PublishingCenter.Main.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingCenter.Main.Books
{
    public partial class BooksForm : Form
    {
        private MySqlConnection connection;
        public BooksForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            dataGridViewBooks.Width = Width;
            buttonAdd.Location = new System.Drawing.Point(dataGridViewBooks.Width + 130, dataGridViewBooks.Location.Y);
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewBooks.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @"SELECT Books.id, Books.book_code, Books.title, Books.edition_quantity, Books.publication_date, 
                                Books.cost_price, Books.selling_price, Books.royalty, 
                                CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                Genres.genre_name 
                         FROM Books 
                         INNER JOIN Authors ON Books.author_id = Authors.id 
                         INNER JOIN Genres ON Books.genre_id = Genres.id";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewBooks.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], ((DateTime)row.ItemArray[4]).ToShortDateString(),
                                                row.ItemArray[5], row.ItemArray[6], row.ItemArray[7], row.ItemArray[8], row.ItemArray[9]);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BookCardForm bookCardForm = new BookCardForm(true);
            bookCardForm.ShowDialog();

            UpdateTable();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                try
                {
                    string id = dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                    BookCardForm bookCardForm = new BookCardForm(false, id);
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

                    UpdateTable();
                }
            }
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                try
                {
                    string bookId = dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string authorIdQuery = "SELECT author_id FROM Books WHERE id = @BookId";
                    MySqlCommand authorIdCmd = new MySqlCommand(authorIdQuery, connection);
                    authorIdCmd.Parameters.AddWithValue("@BookId", bookId);
                    object authorIdResult = authorIdCmd.ExecuteScalar();

                    if (authorIdResult != null)
                    {
                        string authorId = authorIdResult.ToString();
                        AuthorCardForm authorCardForm = new AuthorCardForm(false, authorId);
                        authorCardForm.ShowDialog();
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

                    UpdateTable();
                }
            }
        }
    }
}
