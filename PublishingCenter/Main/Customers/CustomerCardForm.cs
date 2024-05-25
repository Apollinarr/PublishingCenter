using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PublishingCenter.Main.Customers
{
    public partial class CustomerCardForm : Form
    {
        private MySqlConnection connection;
        private int ID = -1;
        public CustomerCardForm(bool isNew, bool isReadOnly, string id = "-1")
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            if (isReadOnly)
            {
                textBoxName.Enabled = false;
                textBoxAddress.Enabled = false;
                textBoxContactPerson.Enabled = false;
                textBoxPhone.Enabled = false;
            }
            if (isNew)
            {
                buttonAdd.Visible = true;
                buttonAdd.Enabled = true;
                buttonDelete.Visible = false;
                buttonDelete.Enabled = false;
                buttonChange.Visible = false;
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
                }    

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "SELECT * FROM Customers WHERE id = @Id LIMIT 1";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxName.Text = reader.GetString("customer_name");
                            textBoxAddress.Text = reader.GetString("address");
                            textBoxContactPerson.Text = reader.GetString("contact_person");
                            textBoxPhone.Text = reader.GetString("phone");
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckInputData()
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Неверно введено название.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxName.Focus();
                return false;
            }
            if (textBoxAddress.Text.Length == 0)
            {
                MessageBox.Show("Неверно введен адрес.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxAddress.Focus();
                return false;
            }
            if (textBoxPhone.Text.Length != 18)
            {
                MessageBox.Show("Неверно введен телефон.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxPhone.Focus();
                return false;
            }
            if (textBoxContactPerson.Text.Length == 0)
            {
                MessageBox.Show("Неверно введено контактное лицо.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxContactPerson.Focus();
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "INSERT INTO Customers (customer_name, address, phone, contact_person) VALUES (@CustomerName, @Address, @Phone, @ContactPerson)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CustomerName", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@ContactPerson", textBoxContactPerson.Text);

                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Заказчик добавлен.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Заказчик не добавлен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Такой заказчик уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "DELETE FROM Customers WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", ID);
                object result = cmd.ExecuteNonQuery();
                if (result != null)
                {
                    MessageBox.Show("Заказчик удален.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "UPDATE Customers SET customer_name = @CustomerName, address = @Address," +
                        " phone = @Phone, contact_person = @ContactPerson WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@CustomerName", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@ContactPerson", textBoxContactPerson.Text);
                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Заказчик изменен.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
