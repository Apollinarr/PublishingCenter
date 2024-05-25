using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PublishingCenter.Main.Orders
{
    public partial class OrderCardForm : Form
    {
        private MySqlConnection connection;
        private int ID = -1;
        public OrderCardForm(bool isNew, bool isReadOnly, string id = "-1")
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            if (isReadOnly)
            {
                comboBoxCustomer.Enabled = false;
                comboBoxBook.Enabled = false;
                dateTimePickerOrderDate.Enabled = false;
                dateTimePickerOrderFulfillmentDate.Enabled = false;
                textBoxQuantity.Enabled = false;
            }
            if (isNew)
            {
                buttonAdd.Visible = true;
                buttonAdd.Enabled = true;
                buttonDelete.Visible = false;
                buttonDelete.Enabled = false;
                buttonUpdate.Visible = false;

                SearchCustomers();
                SearchBooks();

                if (comboBoxCustomer.Items.Count == 0)
                {
                    MessageBox.Show("Нет заказчиков. Добавьте заказчика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ID = Convert.ToInt32(id);
                if (isReadOnly)
                {
                    buttonAdd.Visible = false;
                    buttonDelete.Visible = false;
                    buttonUpdate.Visible = false;
                }
                else
                {
                    buttonAdd.Visible = false;
                    buttonAdd.Enabled = false;
                    buttonDelete.Visible = true;
                    buttonDelete.Enabled = true;
                    SearchCustomers();
                    SearchBooks();
                }

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    string query = @"SELECT Orders.id, Customers.customer_name, Books.title, Orders.order_date, Orders.order_fulfillment_date, Orders.quantity 
                         FROM Orders 
                         INNER JOIN Customers ON Orders.customer_id = Customers.id 
                         INNER JOIN Books ON Orders.book_id = Books.id
                         WHERE Orders.id = @OrderId LIMIT 1";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderId", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!comboBoxCustomer.Items.Contains(reader.GetString("customer_name")))
                            {
                                comboBoxCustomer.Items.Add(reader.GetString("customer_name"));
                            }
                            comboBoxCustomer.SelectedItem = reader.GetString("customer_name");
                            if (!comboBoxBook.Items.Contains(reader.GetString("title")))
                            {
                                comboBoxBook.Items.Add(reader.GetString("title"));
                            }
                            comboBoxBook.SelectedItem = reader.GetString("title");
                            dateTimePickerOrderDate.Value = reader.GetDateTime("order_date");
                            dateTimePickerOrderFulfillmentDate.Value = reader.GetDateTime("order_fulfillment_date");
                            textBoxQuantity.Text = reader.GetInt32("quantity").ToString();
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

        private void SearchCustomers()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @"SELECT customer_name FROM Customers";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxCustomer.Items.Add(reader.GetString("customer_name"));
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

        private void SearchBooks()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @"SELECT title FROM Books";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxBook.Items.Add(reader.GetString("title"));
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

        private int GetCustomerId()
        {
            string customer = comboBoxCustomer.SelectedItem.ToString();

            try
            {
                string query = "SELECT id FROM Customers WHERE customer_name = @Customer";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Customer", customer);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Заказчик не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private int GetBookId()
        {
            string title = comboBoxBook.SelectedItem.ToString();

            try
            {
                string query = "SELECT id FROM Books WHERE title = @Title";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Книга не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (comboBoxCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите заказчика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxCustomer.Focus();
                return false;
            }
            if (comboBoxBook.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите книгу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxBook.Focus();
                return false;
            }
            if (dateTimePickerOrderDate.Value >= dateTimePickerOrderFulfillmentDate.Value)
            {
                MessageBox.Show("Дата выполнения заказа должна быть позже даты заказа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                dateTimePickerOrderDate.Focus();
                return false;
            }
            if (textBoxQuantity.Text.Length == 0)
            {
                MessageBox.Show("Напишите количество экземпляров.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxQuantity.Focus();
                return false;
            }
            if (Convert.ToInt32(textBoxQuantity.Text) == 0)
            {
                MessageBox.Show("Rоличество экземпляров должно быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxQuantity.Focus();
                return false;
            }

            int totalQuantity = GetTotalBookQuantity(GetBookId());
            int otherOrdersQuantity = GetOtherOrdersQuantity(GetBookId());
            int availableQuantity = totalQuantity - otherOrdersQuantity;

            if (Convert.ToInt32(textBoxQuantity.Text) > totalQuantity - otherOrdersQuantity)
            {
                MessageBox.Show($"Введенное количество экземпляров превышает доступное. Максимально возможное количество: {availableQuantity}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxQuantity.Focus();
                return false;
            }
            return true;
        }

        private int GetTotalBookQuantity(int bookId)
        {
            int totalQuantity = 0;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = "SELECT SUM(edition_quantity) AS total_quantity FROM Books WHERE id = @BookId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@BookId", bookId);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    totalQuantity = Convert.ToInt32(result);
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

            return totalQuantity;
        }

        private int GetOtherOrdersQuantity(int bookId)
        {
            int otherOrdersQuantity = 0;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand cmd;
                if (ID == -1)
                {
                    string query = "SELECT SUM(quantity) AS other_orders_quantity FROM Orders WHERE book_id = @BookId";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                }
                else
                {
                    string query = "SELECT SUM(quantity) AS other_orders_quantity FROM Orders WHERE book_id = @BookId AND id != @CurrentOrderId";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@CurrentOrderId", ID);
                }
                

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    otherOrdersQuantity = Convert.ToInt32(result);
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

            return otherOrdersQuantity;
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
                    int customerId = GetCustomerId();
                    if (customerId == -1)
                    {
                        return;
                    }

                    int bookId = GetBookId();
                    if (bookId == -1)
                    {
                        return;
                    }

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    string query = "INSERT INTO Orders (customer_id, book_id, order_date, order_fulfillment_date, quantity) " +
                            "VALUES (@CustomerId, @BookId, @OrderDate, @OrderFulfillmentDate, @Quantity)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePickerOrderDate.Value);
                    cmd.Parameters.AddWithValue("@OrderFulfillmentDate", dateTimePickerOrderFulfillmentDate.Value);
                    cmd.Parameters.AddWithValue("@Quantity", textBoxQuantity.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Заказ успешно добавлен.", "Добавление заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении заказа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "DELETE FROM Orders WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", ID);
                object result = cmd.ExecuteNonQuery();
                if (result != null)
                {
                    MessageBox.Show("Заказ удален.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                try
                {
                    int customerId = GetCustomerId();
                    if (customerId == -1)
                    {
                        return;
                    }

                    int bookId = GetBookId();
                    if (bookId == -1)
                    {
                        return;
                    }

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    string query = @"UPDATE Orders 
                             SET customer_id = @CustomerId, book_id = @BookId, 
                                 order_date = @OrderDate, order_fulfillment_date = @OrderFulfillmentDate, 
                                 quantity = @Quantity 
                             WHERE id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePickerOrderDate.Value);
                    cmd.Parameters.AddWithValue("@OrderFulfillmentDate", dateTimePickerOrderFulfillmentDate.Value);
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(textBoxQuantity.Text));

                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Заказ изменен.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
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
    }
}
