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

namespace PublishingCenter.Main.Contracts
{
    public partial class ContractsForm : Form
    {
        private MySqlConnection connection;
        public ContractsForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            dataGridViewContracts.Width = Width;
            buttonAdd.Location = new System.Drawing.Point(dataGridViewContracts.Width + 130, dataGridViewContracts.Location.Y);
            pictureBoxUpdate.Location = new System.Drawing.Point(dataGridViewContracts.Width, dataGridViewContracts.Location.Y);
            labelSearch.Location = new System.Drawing.Point(dataGridViewContracts.Width + 70, dataGridViewContracts.Location.Y + 90);
            comboBoxSearch.Location = new System.Drawing.Point(dataGridViewContracts.Width + 70, dataGridViewContracts.Location.Y + 120);
            labelAttribute.Location = new System.Drawing.Point(dataGridViewContracts.Width + 70, dataGridViewContracts.Location.Y + 220);
            textBoxSearch.Location = new System.Drawing.Point(dataGridViewContracts.Width + 70, dataGridViewContracts.Location.Y + 250);
            dateTimePickerSearch.Location = new System.Drawing.Point(dataGridViewContracts.Width + 70, dataGridViewContracts.Location.Y + 250);
            buttonSearch.Location = new System.Drawing.Point(dataGridViewContracts.Width + 130, dataGridViewContracts.Location.Y + 350);
            labelAttribute.Visible = false;
            textBoxSearch.Visible = false;
            dateTimePickerSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewContracts.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = "SELECT Contracts.id, CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, contract_date, duration_years, status, termination_date FROM Contracts INNER JOIN Authors ON Contracts.author_id = Authors.id";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewContracts.Rows.Add(row.ItemArray[0], row.ItemArray[1], ((DateTime)row.ItemArray[2]).ToShortDateString(), row.ItemArray[3], row.ItemArray[4], ((DateTime)row.ItemArray[5]).ToShortDateString());
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
            ContractCardForm contractCardForm = new ContractCardForm(true, false);
            contractCardForm.ShowDialog();

            UpdateTable();
        }

        private void dataGridViewContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                try
                {
                    string id = dataGridViewContracts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ContractCardForm contractCardForm = new ContractCardForm(false, false, id);
                    contractCardForm.ShowDialog();

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
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                try
                {
                    string contractId = dataGridViewContracts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string authorIdQuery = "SELECT author_id FROM Contracts WHERE id = @ContractId";
                    MySqlCommand authorIdCmd = new MySqlCommand(authorIdQuery, connection);
                    authorIdCmd.Parameters.AddWithValue("@ContractId", contractId);
                    object authorIdResult = authorIdCmd.ExecuteScalar();

                    if (authorIdResult != null)
                    {
                        string authorId = authorIdResult.ToString();
                        AuthorCardForm authorCardForm = new AuthorCardForm(false, true, authorId);
                        authorCardForm.ShowDialog();
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
                    labelAttribute.Text = "Писатель";
                    break;
                case 1:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = false;
                    dateTimePickerSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Дата заключения";
                    break;
                case 2:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Срок";
                    break;
                case 3:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    dateTimePickerSearch.Visible = false;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Статус";
                    break;
                case 4:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = false;
                    dateTimePickerSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Дата расторжения";
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
                    case "Писатель":
                        query = @"SELECT Contracts.id, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Contracts.contract_date, Contracts.duration_years, Contracts.status, Contracts.termination_date 
                          FROM Contracts 
                          INNER JOIN Authors ON Contracts.author_id = Authors.id 
                          WHERE Authors.last_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Дата заключения":
                        query = @"SELECT Contracts.id, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Contracts.contract_date, Contracts.duration_years, Contracts.status, Contracts.termination_date 
                          FROM Contracts 
                          INNER JOIN Authors ON Contracts.author_id = Authors.id 
                          WHERE Contracts.contract_date = @SearchDate";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchDate", dateTimePickerSearch.Value.Date);
                        break;
                    case "Срок":
                        query = @"SELECT Contracts.id, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Contracts.contract_date, Contracts.duration_years, Contracts.status, Contracts.termination_date 
                          FROM Contracts 
                          INNER JOIN Authors ON Contracts.author_id = Authors.id 
                          WHERE Contracts.duration_years = @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", textBoxSearch.Text);
                        break;
                    case "Статус":
                        query = @"SELECT Contracts.id, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Contracts.contract_date, Contracts.duration_years, Contracts.status, Contracts.termination_date 
                          FROM Contracts 
                          INNER JOIN Authors ON Contracts.author_id = Authors.id 
                          WHERE Contracts.status LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Дата расторжения":
                        query = @"SELECT Contracts.id, 
                                 CONCAT(Authors.last_name, ' ', LEFT(Authors.first_name, 1), '.', LEFT(Authors.middle_name, 1), '.') AS author_name, 
                                 Contracts.contract_date, Contracts.duration_years, Contracts.status, Contracts.termination_date 
                          FROM Contracts 
                          INNER JOIN Authors ON Contracts.author_id = Authors.id 
                          WHERE Contracts.termination_date = @SearchDate";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchDate", dateTimePickerSearch.Value.Date);
                        break;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewContracts.Rows.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewContracts.Rows.Add(row.ItemArray[0], row.ItemArray[1], ((DateTime)row.ItemArray[2]).ToShortDateString(), row.ItemArray[3], row.ItemArray[4], ((DateTime)row.ItemArray[5]).ToShortDateString());
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
