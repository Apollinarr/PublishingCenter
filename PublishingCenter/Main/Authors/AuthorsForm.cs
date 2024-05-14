using MySql.Data.MySqlClient;
using PublishingCenter.Main.Authors;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingCenter
{
    public partial class AuthorsForm : Form
    {
        private MySqlConnection connection;
        public AuthorsForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            dataGridViewAuthors.Width = Width;
            buttonAdd.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 130, dataGridViewAuthors.Location.Y);
            pictureBoxUpdate.Location = new System.Drawing.Point(dataGridViewAuthors.Width, dataGridViewAuthors.Location.Y);
            labelSearch.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 70, dataGridViewAuthors.Location.Y + 90);
            comboBoxSearch.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 70, dataGridViewAuthors.Location.Y + 120);
            labelAttribute.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 70, dataGridViewAuthors.Location.Y + 220);
            textBoxSearch.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 70, dataGridViewAuthors.Location.Y + 250);
            dateTimePickerSearch.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 70, dataGridViewAuthors.Location.Y + 250);
            buttonSearch.Location = new System.Drawing.Point(dataGridViewAuthors.Width + 130, dataGridViewAuthors.Location.Y + 350);
            labelAttribute.Visible = false;
            textBoxSearch.Visible = false;
            dateTimePickerSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewAuthors.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = "SELECT * FROM Authors";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewAuthors.Rows.Add(row.ItemArray[0], row.ItemArray[2], row.ItemArray[1], row.ItemArray[3], ((DateTime)row.ItemArray[4]).ToShortDateString(), "Смотреть");
                }


                //    System.Data.DataSet dataSet = new System.Data.DataSet();
                //    adapter.Fill(dataSet, "Authors");
                //    dataGridViewAuthors.DataSource = dataSet.Tables["Authors"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                comboBoxSearch.SelectedIndex = -1;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AuthorCardForm authorCardForm = new AuthorCardForm(true);
            authorCardForm.ShowDialog();

            UpdateTable();
        }

        private void dataGridViewAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                try
                {
                    //connection.Open();
                    string id = dataGridViewAuthors.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //string query = "SELECT * FROM Authors WHERE id = @Id LIMIT 1";
                    //MySqlCommand command = new MySqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@AuthorId", id);
                    AuthorCardForm authorCardForm = new AuthorCardForm(false, id);
                    authorCardForm.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();

                    UpdateTable();
                }
            }
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                try
                {
                    string id = dataGridViewAuthors.Rows[e.RowIndex].Cells[0].Value.ToString();
                    AuthorsBookForm authorsBookForm = new AuthorsBookForm(id);
                    authorsBookForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();

                    UpdateTable();
                }
            }
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearch.SelectedIndex)
            {
                case -1:
                    labelAttribute.Visible = false;
                    textBoxSearch.Visible = false;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = false;
                    textBoxSearch.Clear();
                    break;
                case 0:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Фамилия";
                    break;
                case 1:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Имя";
                    break;
                case 2:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Отчество";
                    break;
                case 3:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = false;
                    dateTimePickerSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Дата рождения";
                    break;
                default:
                    break;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = comboBoxSearch.SelectedItem.ToString();
            string query = string.Empty;
            MySqlCommand command = new MySqlCommand();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                switch (searchCriteria)
                {
                    case "Фамилия":
                        query = "SELECT id, last_name, first_name, middle_name, date_of_birth FROM Authors WHERE last_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Имя":
                        query = "SELECT id, last_name, first_name, middle_name, date_of_birth FROM Authors WHERE first_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Отчество":
                        query = "SELECT id, last_name, first_name, middle_name, date_of_birth FROM Authors WHERE middle_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Дата рождения":
                        query = "SELECT id, last_name, first_name, middle_name, date_of_birth FROM Authors WHERE date_of_birth = @SearchDate";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchDate", dateTimePickerSearch.Value.Date);
                        break;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewAuthors.Rows.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewAuthors.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], ((DateTime)row.ItemArray[4]).ToShortDateString(), "Смотреть");
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
