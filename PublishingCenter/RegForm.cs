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

                Hide();
                StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
                startForm.ShowLoginForm();
            }
            catch (Exception)
            {

                throw;
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
    }
}
