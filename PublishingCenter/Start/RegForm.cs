using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PublishingCenter
{
    public partial class RegForm : Form
    {
        private MySqlConnection connection;
        public RegForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (textBoxFirstName.Text.Length == 0)
                {
                    MessageBox.Show("Неверно введено имя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    textBoxFirstName.Focus();
                    return;
                }
                else if (textBoxLastName.Text.Length == 0)
                {
                    MessageBox.Show("Неверно введена фамилия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    textBoxLastName.Focus();
                    return;
                }
                else if (textBoxMiddleName.Text.Length == 0)
                {
                    MessageBox.Show("Неверно введено отчество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    textBoxLastName.Focus();
                    return;
                }
                else if (comboBoxPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите должность.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    comboBoxPosition.Focus();
                    return;
                }
                else if (!CheckLogin())
                {
                    return;
                }          
                else if (textBoxPassword.Text.Length < 5 && textBoxPassword.Text != textBoxConfirmePassword.Text)
                {
                    MessageBox.Show("Неверно введен пароль. Пароль должен быть не короче 5 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    textBoxPassword.Focus();
                    return;
                }
                else
                {
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

                    Hide();
                    StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
                    startForm.ShowLoginForm();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
            startForm.ShowLoginForm();
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

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmePassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmePassword.PasswordChar = '•';
            }
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

        private void textBoxConfirmePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 33 || e.KeyChar > 126) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private bool CheckLogin()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (!Regex.IsMatch(textBoxLogin.Text, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Неверно введен логин. Введите адрес электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }

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

            return true;
        }
    }
}
