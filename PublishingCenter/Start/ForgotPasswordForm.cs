using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PublishingCenter
{
    public partial class ForgotPasswordForm : Form
    {
        private MySqlConnection connection;
        private string code;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            labelCode.Visible = false;
            textBoxCode.Visible = false;
            pictureBoxCode.Visible = false;
            labelPassword.Visible = false;
            labelConfirmPassword.Visible = false;
            textBoxPassword.Visible = false;
            textBoxConfirmePassword.Visible = false;
            checkBoxShowPassword.Visible = false;
            buttonChangePassword.Visible = false;
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
            startForm.ShowLoginForm();
        }

        private string GenerateCode()
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder recoveryCode = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                recoveryCode.Append(chars[random.Next(chars.Length)]);
            }

            return recoveryCode.ToString();
        }

        private void pictureBoxMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM employees WHERE login = @login";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@login", textBoxMail.Text);
                int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (userCount == 0)
                {
                    MessageBox.Show("Пользователя с таким адресом не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }

                code = GenerateCode();
                Mailer.SendMessage(textBoxMail.Text, "Код восстановления", $"Код для восстановления пароля для учетной записи: {code}");
                MessageBox.Show($"На почту: {textBoxMail.Text} направлен код для восстановления пароля.",
                    "Код", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelCode.Visible = true;
                textBoxCode.Visible = true;
                pictureBoxCode.Visible = true;
                textBoxMail.Enabled = false;
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

        private void pictureBoxCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                if (textBoxCode.Text != code)
                {
                    MessageBox.Show("Код введен неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                labelPassword.Visible = true;
                labelConfirmPassword.Visible = true;
                textBoxPassword.Visible = true;
                textBoxConfirmePassword.Visible = true;
                checkBoxShowPassword.Visible = true;
                buttonChangePassword.Visible = true;
                textBoxCode.Enabled = false;
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

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                if (textBoxPassword.Text.Length < 5 && textBoxPassword.Text != textBoxConfirmePassword.Text)
                {
                    MessageBox.Show("Неверно введен пароль. Пароль должен быть не короче 5 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    textBoxPassword.Focus();
                    return;
                }

                string updatePasswordQuery = "UPDATE employees SET password = @NewPassword WHERE login = @login";
                MySqlCommand updatePasswordCommand = new MySqlCommand(updatePasswordQuery, connection);
                updatePasswordCommand.Parameters.AddWithValue("@login", textBoxMail.Text);
                updatePasswordCommand.Parameters.AddWithValue("@NewPassword", HashPassword(textBoxPassword.Text));
                updatePasswordCommand.ExecuteNonQuery();

                MessageBox.Show($"Пароль успешно обновлен.",
                    "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                Hide();
                StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
                startForm.ShowLoginForm();
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

        private void textBoxMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void textBoxConfirmePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
    }
}
