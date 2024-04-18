using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.SigI;
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

namespace PublishingCenter
{
    public partial class LoginForm : Form
    {
        private MySqlConnection connection;
        public LoginForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();

                string query = "SELECT Password FROM employees WHERE login = @login";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@login", login);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string hashedPasswordFromDatabase = result.ToString();
                    if (VerifyHashedPassword(hashedPasswordFromDatabase, password))
                    {
                        var account = new Employee();
                        if (account.SetUserData(login))
                        {
                            //MessageBox.Show("Пользователь авторизирован.", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            new MainForm().ShowDialog();
                            StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
                            startForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильное имя пользователя или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void labelBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
            startForm.ShowRegForm();
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
            startForm.ShowForgotPasswordForm();
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return ByteArraysEqual(buffer3, buffer4);
        }

        public static bool ByteArraysEqual(byte[] b1, byte[] b2)
        {
            if (b1 == b2) return true;
            if (b1 == null || b2 == null) return false;
            if (b1.Length != b2.Length) return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i]) return false;
            }
            return true;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
            }
        }
    }
}
