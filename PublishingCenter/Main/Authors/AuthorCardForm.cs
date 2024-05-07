using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PublishingCenter
{
    public partial class AuthorCardForm : Form
    {
        private MySqlConnection connection;
        private int ID = -1;
        public AuthorCardForm(bool isNew, string id = "-1")
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
            }
            else
            {
                ID = Convert.ToInt32(id);
                buttonAdd.Visible = false;
                buttonAdd.Enabled = false;
                buttonDelete.Visible = true;
                buttonDelete.Enabled = true;
                buttonChange.Visible = true;

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "SELECT * FROM Authors WHERE id = @Id LIMIT 1";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxFirstName.Text = reader.GetString("first_name");
                            textBoxLastName.Text = reader.GetString("last_name");
                            textBoxMiddleName.Text = reader.GetString("middle_name");
                            dateTimePickerBirth.Value = reader.GetDateTime("date_of_birth");
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

        //public AuthorCardForm(string id)
        //{
        //    InitializeComponent();
        //    connection = new Connection().GetConnectionString();
        //    connection.Open();

        //    buttonAdd.Visible = false;
        //        buttonAdd.Enabled = false;
        //        buttonDelete.Visible = true;
        //        buttonDelete.Enabled = true;
        //        buttonChange.Visible = true;

        //    try
        //    {
        //        string query = "SELECT * FROM Authors WHERE id = @Id LIMIT 1";
        //        MySqlCommand command = new MySqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@Id", id);

        //        using (MySqlDataReader reader = command.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                textBoxFirstName.Text = reader.GetString("first_name");
        //                textBoxLastName.Text = reader.GetString("last_name");
        //                textBoxMiddleName.Text = reader.GetString("middle_name");
        //                dateTimePickerBirth.Value = reader.GetDateTime("date_of_birth");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        if (connection.State == ConnectionState.Open)
        //            connection.Close();
        //    }
        //}

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckInputData()
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
            return true;
        }

        //private void CleareFields()
        //{
        //    textBoxFirstName.Clear();
        //    textBoxLastName.Clear();
        //    textBoxMiddleName.Clear();
        //    dateTimePickerBirth.Value = DateTime.Now;
        //}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string query = "INSERT INTO Authors (first_name, last_name, middle_name, date_of_birth) VALUES (@FirstName, @LastName, @MiddleName, @DateOfBirth)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", textBoxMiddleName.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePickerBirth.Value);

                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Автор добавлен.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Автор не добавлен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Такой автор уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "DELETE FROM Authors WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", ID);
                object result = cmd.ExecuteNonQuery();
                if (result != null)
                {
                    MessageBox.Show("Автор удален.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string query = "UPDATE Authors SET first_name = @FirstName, last_name = @LastName," +
                        " middle_name = @MiddleName, date_of_birth = @DateOfBirth WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", textBoxMiddleName.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePickerBirth.Value);
                    object result = cmd.ExecuteNonQuery();
                    if (result != null)
                    {
                        MessageBox.Show("Автор изменен.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
