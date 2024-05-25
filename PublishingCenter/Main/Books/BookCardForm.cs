using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PublishingCenter.Main.Books
{
    public partial class BookCardForm : Form
    {
        private MySqlConnection connection;
        private int ID = -1;
        public BookCardForm(bool isNew, bool isReadOnly, string id = "-1")
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            if (isReadOnly)
            {
                textBoxBookCode.Enabled = false;
                textBoxTitle.Enabled = false;
                textBoxEditionQuantity.Enabled = false;
                dateTimePickerPublicationDate.Enabled = false;
                textBoxCostPrice.Enabled = false;
                textBoxSellingPrice.Enabled = false;
                textBoxRoyalty.Enabled = false;
                comboBoxAuthor.Enabled = false;
                comboBoxGenre.Enabled = false;
            }
            if (isNew)
            {
                buttonAdd.Visible = true;
                buttonAdd.Enabled = true;
                buttonDelete.Visible = false;
                buttonDelete.Enabled = false;
                buttonChange.Visible = false;

                SearchAuthors();
                if (comboBoxAuthor.Items.Count == 0)
                {
                    MessageBox.Show("Нет авторов. Добавьте автора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SearchGenres();
            }
            else
            {
                ID = Convert.ToInt32(id);
                if (isReadOnly)
                {
                    buttonAdd.Visible = false;
                    buttonDelete.Visible = false;
                    buttonChange.Visible = false;
                }
                else
                {
                    buttonAdd.Visible = false;
                    buttonAdd.Enabled = false;
                    buttonDelete.Visible = true;
                    buttonDelete.Enabled = true;
                    buttonChange.Visible = true;
                    textBoxBookCode.Enabled = false;
                    comboBoxAuthor.Enabled = false;
                    comboBoxGenre.Enabled = false;
                    SearchAuthors();
                    SearchGenres();
                }

                if (Employee.Position == 3)
                {
                    buttonAdd.Visible = false;
                    buttonDelete.Visible = false;
                    buttonChange.Visible = false;
                }

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    string query = @"SELECT Books.book_code, Books.title, Books.edition_quantity, Books.publication_date, 
                                    Books.cost_price, Books.selling_price, Books.royalty, 
                                    CONCAT(Authors.last_name, ' ', Authors.first_name, ' ', Authors.middle_name) AS author_name, 
                                    Genres.genre_name 
                             FROM Books 
                             INNER JOIN Authors ON Books.author_id = Authors.id 
                             INNER JOIN Genres ON Books.genre_id = Genres.id
                             WHERE Books.id = @BookId LIMIT 1";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookId", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxBookCode.Text = reader.GetString("book_code");
                            textBoxTitle.Text = reader.GetString("title");
                            textBoxEditionQuantity.Text = reader.GetInt32("edition_quantity").ToString();
                            dateTimePickerPublicationDate.Value = reader.GetDateTime("publication_date");
                            textBoxCostPrice.Text = reader.GetDecimal("cost_price").ToString();
                            textBoxSellingPrice.Text = reader.GetDecimal("selling_price").ToString();
                            textBoxRoyalty.Text = reader.GetDecimal("royalty").ToString();
                            if (!comboBoxAuthor.Items.Contains(reader.GetString("author_name")))
                            {
                                comboBoxAuthor.Items.Add(reader.GetString("author_name"));
                            }
                            comboBoxAuthor.SelectedItem = reader.GetString("author_name");
                            if (!comboBoxGenre.Items.Contains(reader.GetString("genre_name")))
                            {
                                comboBoxGenre.Items.Add(reader.GetString("genre_name"));
                            }
                            comboBoxGenre.SelectedItem = reader.GetString("genre_name");
                        }
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

        private void SearchAuthors()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @" SELECT CONCAT(last_name, ' ', first_name, ' ', middle_name) AS full_name FROM Authors";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = reader.GetString("full_name");
                            comboBoxAuthor.Items.Add(fullName);
                        }
                    }
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

        private void SearchGenres()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @"SELECT genre_name FROM Genres";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxGenre.Items.Add(reader.GetString("genre_name"));
                        }
                    }
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

        private int GetAuthorId()
        {
            string authorName = comboBoxAuthor.SelectedItem.ToString();

            try
            {
                string query = "SELECT id FROM Authors WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @AuthorName";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AuthorName", authorName);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Автор не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private int GetGenreId()
        {
            string genre = comboBoxGenre.SelectedItem.ToString();

            try
            {
                string query = "SELECT id FROM Genres WHERE genre_name = @Genre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Жанр не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckInputData()
        {
            if (textBoxBookCode.Text.Length == 0)
            {
                MessageBox.Show("Напишите код книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxBookCode.Focus();
                return false;
            }
            if (textBoxTitle.Text.Length == 0)
            {
                MessageBox.Show("Напишите название.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxTitle.Focus();
                return false;
            }
            if (textBoxEditionQuantity.Text.Length == 0)
            {
                MessageBox.Show("Напишите тираж.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxEditionQuantity.Focus();
                return false;
            }
            if (Convert.ToInt32(textBoxEditionQuantity.Text) == 0)
            {
                MessageBox.Show("Тираж должен быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxEditionQuantity.Focus();
                return false;
            }
            if (textBoxCostPrice.Text.Length == 0)
            {
                MessageBox.Show("Напишите себестоимость.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxCostPrice.Focus();
                return false;
            }
            if (Convert.ToInt32(textBoxCostPrice.Text) == 0)
            {
                MessageBox.Show("Себестоимость должна быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxCostPrice.Focus();
                return false;
            }
            if (textBoxSellingPrice.Text.Length == 0)
            {
                MessageBox.Show("Напишите цену.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxSellingPrice.Focus();
                return false;
            }
            if (Convert.ToInt32(textBoxSellingPrice.Text) == 0)
            {
                MessageBox.Show("Цена должна быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxSellingPrice.Focus();
                return false;
            }
            if (textBoxRoyalty.Text.Length == 0)
            {
                MessageBox.Show("Напишите гонорар.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxRoyalty.Focus();
                return false;
            }
            if (Convert.ToInt32(textBoxRoyalty.Text) == 0)
            {
                MessageBox.Show("Гонорар должен быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxRoyalty.Focus();
                return false;
            }
            if (comboBoxAuthor.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите писателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxAuthor.Focus();
                return false;
            }
            if (comboBoxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите жанр.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxGenre.Focus();
                return false;
            }
            if (Convert.ToDecimal(textBoxCostPrice.Text) > Convert.ToDecimal(textBoxSellingPrice.Text))
            {
                MessageBox.Show("Себестоимость больше цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxCostPrice.Focus();
                return false;
            }
            if (Convert.ToDecimal(textBoxRoyalty.Text) > Convert.ToDecimal(textBoxSellingPrice.Text))
            {
                MessageBox.Show("Гонорар больше цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxCostPrice.Focus();
                return false;
            }
            return true;
        }

        private void textBoxBookCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxEditionQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxRoyalty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                try
                {
                    int authorId = GetAuthorId();
                    if (authorId == -1)
                    {
                        return;
                    }

                    int genreId = GetGenreId();
                    if (genreId == -1)
                    {
                        return;
                    }

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    string query = "INSERT INTO Books (book_code, title, edition_quantity, publication_date, cost_price, selling_price, royalty, author_id, genre_id) " +
                           "VALUES (@BookCode, @Title, @EditionQuantity, @PublicationDate, @CostPrice, @SellingPrice, @Royalty, @AuthorId, @GenreId)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@BookCode", textBoxBookCode.Text);
                    cmd.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                    cmd.Parameters.AddWithValue("@EditionQuantity", Convert.ToInt32(textBoxEditionQuantity.Text));
                    cmd.Parameters.AddWithValue("@PublicationDate", dateTimePickerPublicationDate.Value);
                    cmd.Parameters.AddWithValue("@CostPrice", Convert.ToDecimal(textBoxCostPrice.Text));
                    cmd.Parameters.AddWithValue("@SellingPrice", Convert.ToDecimal(textBoxSellingPrice.Text));
                    cmd.Parameters.AddWithValue("@Royalty", Convert.ToDecimal(textBoxRoyalty.Text));
                    cmd.Parameters.AddWithValue("@AuthorId", authorId);
                    cmd.Parameters.AddWithValue("@GenreId", genreId);

                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Книга успешно добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Книга не добавлена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Ошибка MySQL: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = "DELETE FROM Books WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", ID);
                object result = cmd.ExecuteNonQuery();
                if (result != null)
                {
                    MessageBox.Show("Книга удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                try
                {
                    int authorId = GetAuthorId();
                    if (authorId == -1)
                    {
                        return;
                    }

                    int genreId = GetGenreId();
                    if (genreId == -1)
                    {
                        return;
                    }

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    string query = @"UPDATE Books 
                         SET book_code = @BookCode, title = @Title, edition_quantity = @EditionQuantity, 
                             publication_date = @PublicationDate, cost_price = @CostPrice, 
                             selling_price = @SellingPrice, royalty = @Royalty, 
                             author_id = @AuthorId, genre_id = @GenreId 
                         WHERE id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@BookCode", textBoxBookCode.Text);
                    cmd.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                    cmd.Parameters.AddWithValue("@EditionQuantity", Convert.ToInt32(textBoxEditionQuantity.Text));
                    cmd.Parameters.AddWithValue("@PublicationDate", dateTimePickerPublicationDate.Value);
                    cmd.Parameters.AddWithValue("@CostPrice", Convert.ToDecimal(textBoxCostPrice.Text));
                    cmd.Parameters.AddWithValue("@SellingPrice", Convert.ToDecimal(textBoxSellingPrice.Text));
                    cmd.Parameters.AddWithValue("@Royalty", Convert.ToDecimal(textBoxRoyalty.Text));
                    cmd.Parameters.AddWithValue("@AuthorId", authorId);
                    cmd.Parameters.AddWithValue("@GenreId", genreId); 

                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Книга изменена.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
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
}
