using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingCenter.Main.Settings
{
    public partial class SettingsForm : Form
    {
        private MySqlConnection connection;
        public SettingsForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            //dataGridViewUsers.Width = Width;
            buttonAdd.Location = new System.Drawing.Point(dataGridViewUsers.Width + 130, dataGridViewUsers.Location.Y);
            pictureBoxUpdate.Location = new System.Drawing.Point(dataGridViewUsers.Width + 15, dataGridViewUsers.Location.Y);
            labelSearch.Location = new System.Drawing.Point(dataGridViewUsers.Width + 70, dataGridViewUsers.Location.Y + 90);
            comboBoxSearch.Location = new System.Drawing.Point(dataGridViewUsers.Width + 70, dataGridViewUsers.Location.Y + 120);
            labelAttribute.Location = new System.Drawing.Point(dataGridViewUsers.Width + 70, dataGridViewUsers.Location.Y + 220);
            textBoxSearch.Location = new System.Drawing.Point(dataGridViewUsers.Width + 70, dataGridViewUsers.Location.Y + 250);
            buttonSearch.Location = new System.Drawing.Point(dataGridViewUsers.Width + 130, dataGridViewUsers.Location.Y + 350);
            labelAttribute.Visible = false;
            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewUsers.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = @"SELECT Employees.id, Employees.first_name, Employees.last_name, Employees.middle_name, 
                    Positions.position_name, Employees.login FROM Employees
                    INNER JOIN Positions ON Employees.position_id = Positions.id";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewUsers.Rows.Add(row.ItemArray[0], row.ItemArray[2], row.ItemArray[1], row.ItemArray[3], row.ItemArray[4], row.ItemArray[5]);
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
                comboBoxSearch.SelectedIndex = -1;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EmployeeCardForm employeeCardForm = new EmployeeCardForm(true);
            employeeCardForm.ShowDialog();

            UpdateTable();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                try
                {
                    string id = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    EmployeeCardForm employeeCardForm = new EmployeeCardForm(false, id);
                    employeeCardForm.ShowDialog();

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
                    buttonSearch.Visible = false;
                    textBoxSearch.Clear();
                    break;
                case 0:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Фамилия";
                    break;
                case 1:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Имя";
                    break;
                case 2:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Отчество";
                    break;
                case 3:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Должность";
                    break;
                case 4:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Логин";
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
                        query = @"SELECT Employees.id, Employees.last_name, Employees.first_name, Employees.middle_name, Positions.position_name, Employees.login 
                      FROM Employees 
                      INNER JOIN Positions ON Employees.position_id = Positions.id 
                      WHERE Employees.last_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Имя":
                        query = @"SELECT Employees.id, Employees.last_name, Employees.first_name, Employees.middle_name, Positions.position_name, Employees.login 
                      FROM Employees 
                      INNER JOIN Positions ON Employees.position_id = Positions.id 
                      WHERE Employees.first_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Отчество":
                        query = @"SELECT Employees.id, Employees.last_name, Employees.first_name, Employees.middle_name, Positions.position_name, Employees.login 
                      FROM Employees 
                      INNER JOIN Positions ON Employees.position_id = Positions.id 
                      WHERE Employees.middle_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Должность":
                        query = @"SELECT Employees.id, Employees.last_name, Employees.first_name, Employees.middle_name, Positions.position_name, Employees.login 
                      FROM Employees 
                      INNER JOIN Positions ON Employees.position_id = Positions.id 
                      WHERE Positions.position_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Логин":
                        query = @"SELECT Employees.id, Employees.last_name, Employees.first_name, Employees.middle_name, Positions.position_name, Employees.login 
                      FROM Employees 
                      INNER JOIN Positions ON Employees.position_id = Positions.id 
                      WHERE Employees.login LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.Rows.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewUsers.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4], row.ItemArray[5]);
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
