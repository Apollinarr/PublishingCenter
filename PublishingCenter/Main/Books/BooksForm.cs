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
            pictureBoxUpdate.Location = new System.Drawing.Point(dataGridViewBooks.Width + 15, dataGridViewBooks.Location.Y);
            labelSearch.Location = new System.Drawing.Point(dataGridViewBooks.Width + 70, dataGridViewBooks.Location.Y + 90);
            comboBoxSearch.Location = new System.Drawing.Point(dataGridViewBooks.Width + 70, dataGridViewBooks.Location.Y + 120);
            labelAttribute.Location = new System.Drawing.Point(dataGridViewBooks.Width + 70, dataGridViewBooks.Location.Y + 220);
            textBoxSearch.Location = new System.Drawing.Point(dataGridViewBooks.Width + 70, dataGridViewBooks.Location.Y + 250);
            dateTimePickerSearch.Location = new System.Drawing.Point(dataGridViewBooks.Width + 70, dataGridViewBooks.Location.Y + 250);
            buttonSearch.Location = new System.Drawing.Point(dataGridViewBooks.Width + 130, dataGridViewBooks.Location.Y + 350);
            labelAttribute.Visible = false;
            textBoxSearch.Visible = false;
            dateTimePickerSearch.Visible = false;
            buttonSearch.Visible = false;
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
                comboBoxSearch.SelectedIndex = -1;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BookCardForm bookCardForm = new BookCardForm(true, false);
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
                    BookCardForm bookCardForm = new BookCardForm(false, false, id);
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
                        AuthorCardForm authorCardForm = new AuthorCardForm(false, true, authorId);
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

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearch.SelectedIndex)
            {
                case -1:
                    labelAttribute.Visible = false;
                    textBoxSearch.Visible = false;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = false;
                    textBoxSearch.Clear();
                    break;
                case 0:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Код";
                    break;
                case 1:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Название";
                    break;
                case 2:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = false;
                    dateTimePickerSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Выход в печать";
                    break;
                case 3:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Автор";
                    break;
                case 4:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Жанр";
                    break;
                default:
                    break;
            }
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = comboBoxSearch.SelectedItem.ToString();
            string query = string.Empty;
            MySqlCommand command = new MySqlCommand();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                switch (searchCriteria)
                {
                    case "Код":
                        query = @"SELECT Books.id, Books.book_code, Books.title, Books.edition_quantity, Books.publication_date, 
                                 Books.cost_price, Books.selling_price, Books.royalty, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Genres.genre_name 
                          FROM Books 
                          INNER JOIN Authors ON Books.author_id = Authors.id 
                          INNER JOIN Genres ON Books.genre_id = Genres.id
                          WHERE Books.book_code LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Название":
                        query = @"SELECT Books.id, Books.book_code, Books.title, Books.edition_quantity, Books.publication_date, 
                                 Books.cost_price, Books.selling_price, Books.royalty, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Genres.genre_name 
                          FROM Books 
                          INNER JOIN Authors ON Books.author_id = Authors.id 
                          INNER JOIN Genres ON Books.genre_id = Genres.id
                          WHERE Books.title LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Выход в печать":
                        query = @"SELECT Books.id, Books.book_code, Books.title, Books.edition_quantity, Books.publication_date, 
                                 Books.cost_price, Books.selling_price, Books.royalty, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Genres.genre_name 
                          FROM Books 
                          INNER JOIN Authors ON Books.author_id = Authors.id 
                          INNER JOIN Genres ON Books.genre_id = Genres.id
                          WHERE Books.publication_date = @SearchDate";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchDate", dateTimePickerSearch.Value.Date);
                        break;
                    case "Автор":
                        query = @"SELECT Books.id, Books.book_code, Books.title, Books.edition_quantity, Books.publication_date, 
                                 Books.cost_price, Books.selling_price, Books.royalty, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Genres.genre_name 
                          FROM Books 
                          INNER JOIN Authors ON Books.author_id = Authors.id 
                          INNER JOIN Genres ON Books.genre_id = Genres.id
                          WHERE Authors.last_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Жанр":
                        query = @"SELECT Books.id, Books.book_code, Books.title, Books.edition_quantity, Books.publication_date, 
                                 Books.cost_price, Books.selling_price, Books.royalty, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Genres.genre_name 
                          FROM Books 
                          INNER JOIN Authors ON Books.author_id = Authors.id 
                          INNER JOIN Genres ON Books.genre_id = Genres.id
                          WHERE Genres.genre_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewBooks.Rows.Clear();

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
    }
}
