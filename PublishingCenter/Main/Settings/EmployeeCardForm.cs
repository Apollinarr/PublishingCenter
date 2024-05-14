using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingCenter.Main.Settings
{
    public partial class EmployeeCardForm : Form
    {
        private MySqlConnection connection;
        private int ID = -1;
        public EmployeeCardForm(bool isNew, string id = "-1")
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            if (isNew)
            {
                buttonAdd.Visible = true;
                buttonAdd.Enabled = true;
                buttonDelete.Visible = false;
                buttonDelete.Enabled = false;
                buttonChange.Visible = false;
                labelPassword.Visible = true;
                textBoxPassword.Visible = true;
                labelConfirmPassword.Visible = true;
                textBoxConfirmPassword.Visible = true;
                checkBoxShowPassword.Visible = true;
            }
            else
            {
                ID = Convert.ToInt32(id);
                buttonAdd.Visible = false;
                buttonAdd.Enabled = false;
                buttonDelete.Visible = true;
                buttonDelete.Enabled = true;
                buttonChange.Visible = true;
                labelPassword.Visible = false;
                textBoxPassword.Visible = false;
                labelConfirmPassword.Visible = false;
                textBoxConfirmPassword.Visible = false;
                checkBoxShowPassword.Visible = false;
                textBoxLogin.Enabled = false;

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = @"SELECT Employees.first_name, Employees.last_name, Employees.middle_name, 
                        Employees.position_id, Employees.login, 
                        Positions.position_name FROM Employees
                        INNER JOIN Positions ON Employees.position_id = Positions.id
                        WHERE Employees.id = @EmployeeId LIMIT 1";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxFirstName.Text = reader.GetString("first_name");
                            textBoxLastName.Text = reader.GetString("last_name");
                            textBoxMiddleName.Text = reader.GetString("middle_name");

                            int positionId = reader.GetInt32("position_id");
                            string positionName = reader.GetString("position_name");

                            if (!comboBoxPosition.Items.Contains(positionName))
                            {
                                comboBoxPosition.Items.Add(positionName);
                            }
                            comboBoxPosition.SelectedItem = positionName;

                            textBoxLogin.Text = reader.GetString("login");
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

        private bool CheckInputData(bool isNew = true)
        {
            if (textBoxFirstName.Text.Length == 0)
            {
                MessageBox.Show("Неверно введено имя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxFirstName.Focus();
                return false;
            }
            if (textBoxLastName.Text.Length == 0)
            {
                MessageBox.Show("Неверно введена фамилия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxLastName.Focus();
                return false;
            }
            if (textBoxMiddleName.Text.Length == 0)
            {
                MessageBox.Show("Неверно введено отчество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                textBoxLastName.Focus();
                return false;
            }
            if (comboBoxPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите должность.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                comboBoxPosition.Focus();
                return false;
            }
            if (!CheckLogin(isNew))
            {
                connection.Close();
                textBoxLogin.Focus();
                return false;
            }
            return true;
        }

        private bool CheckLogin(bool isNew)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
               @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

                if (!Regex.IsMatch(textBoxLogin.Text, pattern, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Неверно введен логин. Введите адрес электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return false;
                }

                if (isNew)
                {
                    string checkQuery = "SELECT COUNT(*) FROM employees WHERE login = @login";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                if (textBoxPassword.Text.Length < 5 && textBoxPassword.Text != textBoxConfirmPassword.Text)
                {
                    MessageBox.Show("Неверно введен пароль. Пароль должен быть не короче 5 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    textBoxPassword.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        string query = "INSERT INTO employees (first_name, last_name, middle_name, position_id, login, password)" +
                       " VALUES (@first_name, @last_name, @middle_name, @position, @login, @password)";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@first_name", textBoxFirstName.Text);
                        cmd.Parameters.AddWithValue("@middle_name", textBoxMiddleName.Text);
                        cmd.Parameters.AddWithValue("@last_name", textBoxLastName.Text);
                        cmd.Parameters.AddWithValue("@position", comboBoxPosition.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                        cmd.Parameters.AddWithValue("@password", HashPassword(textBoxPassword.Text));
                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Аккаунт успешно зарегистрирован.", "Регистрация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Mailer.SendMessage(textBoxLogin.Text, "Регистрация", $"{textBoxFirstName.Text} {textBoxLastName.Text}, ваш аккаунт успешно зарегистрирован.");

                        Close();
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

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 33 || e.KeyChar > 126) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 33 || e.KeyChar > 126) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Employee.Login == textBoxLogin.Text)
            {
                MessageBox.Show("Нельзя удалить пользователя, за которого вы сейчас в системе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "DELETE FROM Employees WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Пользователь удален.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (CheckInputData(false))
            {
                if (textBoxPassword.Text.Length < 5 && textBoxPassword.Text != textBoxConfirmPassword.Text)
                {
                    MessageBox.Show("Неверно введен пароль. Пароль должен быть не короче 5 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    textBoxPassword.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        string query = @"UPDATE Employees 
                             SET first_name = @FirstName, 
                                 last_name = @LastName, 
                                 middle_name = @MiddleName, 
                                 position_id = @PositionId, 
                                 login = @Login 
                             WHERE id = @Id";

                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", textBoxMiddleName.Text);
                        cmd.Parameters.AddWithValue("@PositionId", comboBoxPosition.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@Login", textBoxLogin.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Сотрудник изменен.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось изменить данные сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show($"Ошибка MySQL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmPassword.PasswordChar = '•';
            }
        }
    }
}
