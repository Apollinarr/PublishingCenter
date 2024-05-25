using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PublishingCenter.Main.Contracts
{
    public partial class ContractCardForm : Form
    {
        private MySqlConnection connection;
        private int ID = -1;
        public ContractCardForm(bool isNew, bool isReadOnly, string id = "-1")
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            if (isReadOnly)
            {
                comboBoxAuthor.Enabled = false;
                comboBoxAuthor.Enabled = false;
                dateTimePickerConclusionDate.Enabled = false;
                comboBoxContractPeriod.Enabled = false;
                comboBoxContractPeriod.Enabled = false;
                comboBoxStatus.Enabled = false;
                dateTimePickerTerminationDate.Enabled = false;
            }
            if (isNew)
            {
                buttonAdd.Visible = true;
                buttonAdd.Enabled = true;
                buttonDelete.Visible = false;
                buttonDelete.Enabled = false;
                buttonUpdate.Visible = false;

                SearchAuthorsWithoutContracts();

                textBoxUpdate.Visible = false;
                labelUpdate.Visible = false;

                if (comboBoxAuthor.Items.Count == 0)
                {
                    MessageBox.Show("Нет авторов, у которых не заключен контракт. Добавьте автора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    buttonUpdate.Visible = true;

                    dateTimePickerConclusionDate.Enabled = false;
                    comboBoxContractPeriod.Enabled = false;
                    dateTimePickerTerminationDate.Enabled = false;
                }

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();                  
                    string query = "SELECT Contracts.author_id, Contracts.contract_date, Contracts.duration_years, Contracts.status, Contracts.termination_date," +
                        " CONCAT(Authors.last_name, ' ', Authors.first_name, ' ', Authors.middle_name) AS author_name FROM Contracts" +
                        " INNER JOIN Authors ON Contracts.author_id = Authors.id WHERE Contracts.id = @Id LIMIT 1";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comboBoxAuthor.Items.Add(reader.GetString("author_name"));
                            comboBoxAuthor.SelectedItem = reader.GetString("author_name");
                            dateTimePickerConclusionDate.Value = reader.GetDateTime("contract_date");
                            comboBoxContractPeriod.Items.Add(reader.GetInt32("duration_years").ToString());
                            comboBoxContractPeriod.SelectedItem = reader.GetInt32("duration_years").ToString();
                            comboBoxStatus.SelectedItem = reader.GetString("status");
                            dateTimePickerTerminationDate.Value = reader.GetDateTime("termination_date");
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

        private void SearchAuthorsWithoutContracts()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @" SELECT CONCAT(last_name, ' ', first_name, ' ', middle_name) AS full_name FROM Authors 
                                WHERE id NOT IN (SELECT DISTINCT author_id FROM Contracts)";

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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxContractPeriod_SelectedValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTerminationDate.Value = dateTimePickerConclusionDate.Value.AddYears(Convert.ToInt32(comboBoxContractPeriod.SelectedItem));
        }

        private bool CheckInputData()
        {
            if (comboBoxAuthor.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите автора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxAuthor.Focus();
                return false;
            }
            if (comboBoxContractPeriod.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите срок контракта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxContractPeriod.Focus();
                return false;
            }
            if (comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите статус контракта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxStatus.Focus();
                return false;
            }
            if (comboBoxStatus.SelectedItem != "Заключен")
            {
                MessageBox.Show("Новый контракт можно только заключить. Выберите статус \"Заключен\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxStatus.Focus();
                return false;
            }
            return true;
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

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "INSERT INTO Contracts (author_id, contract_date, duration_years, status, termination_date) " +
                   "VALUES (@AuthorId, @ContractDate, @DurationYears, @Status, @TerminationDate)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@AuthorId", authorId);
                    cmd.Parameters.AddWithValue("@ContractDate", dateTimePickerConclusionDate.Value);
                    cmd.Parameters.AddWithValue("@DurationYears", Convert.ToInt32(comboBoxContractPeriod.SelectedItem));
                    cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TerminationDate", dateTimePickerTerminationDate.Value);


                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Контракт успешно создан.", "Создание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Контракт не создан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "DELETE FROM Contracts WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", ID);
                object result = cmd.ExecuteNonQuery();
                if (result != null)
                {
                    MessageBox.Show("Контракт удален.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (comboBoxStatus.SelectedItem == "Продлен")
            {
                if (textBoxUpdate.Text.Length == 0)
                {
                    MessageBox.Show("Введите срок продления контракта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUpdate.Focus();
                    return;
                }
                if (Convert.ToInt32(textBoxUpdate.Text) > 5)
                {
                    MessageBox.Show("Контракт можно продлить максимум на 5 лет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUpdate.Focus();
                    return;
                }

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "UPDATE Contracts SET author_id = @AuthorId, contract_date = @ContractDate," +
                        " duration_years = @DurationYears, status = @Status, termination_date = @TerminationDate WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@AuthorId", GetAuthorId());
                    cmd.Parameters.AddWithValue("@ContractDate", dateTimePickerConclusionDate.Value);
                    cmd.Parameters.AddWithValue("@DurationYears", Convert.ToInt32(comboBoxContractPeriod.SelectedItem) + Convert.ToInt32(textBoxUpdate.Text));
                    cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TerminationDate", dateTimePickerTerminationDate.Value.AddYears(Convert.ToInt32(textBoxUpdate.Text)));
                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Контракт продлён.", "Продление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (comboBoxStatus.SelectedItem == "Расторжен")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "UPDATE Contracts SET author_id = @AuthorId, contract_date = @ContractDate," +
                        " duration_years = @DurationYears, status = @Status, termination_date = @TerminationDate WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@AuthorId", GetAuthorId());
                    cmd.Parameters.AddWithValue("@ContractDate", dateTimePickerConclusionDate.Value);
                    cmd.Parameters.AddWithValue("@DurationYears", Convert.ToInt32(comboBoxContractPeriod.SelectedItem));
                    cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TerminationDate", dateTimePickerTerminationDate.Value);
                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Контракт расторгнут.", "Расторжение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBoxUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedIndex == 1)
            {
                textBoxUpdate.Enabled = true;
            }
            if (comboBoxStatus.SelectedIndex == 2)
            {
                textBoxUpdate.Enabled = false;
                textBoxUpdate.Clear();
            }
        }
    }
}
