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

namespace PublishingCenter.Main.Customers
{
    public partial class CustomersForm : Form
    {
        private MySqlConnection connection;
        public CustomersForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            dataGridViewCustomers.Width = Width;
            buttonAdd.Location = new System.Drawing.Point(dataGridViewCustomers.Width + 130, dataGridViewCustomers.Location.Y);
            pictureBoxUpdate.Location = new System.Drawing.Point(dataGridViewCustomers.Width, dataGridViewCustomers.Location.Y);
            labelSearch.Location = new System.Drawing.Point(dataGridViewCustomers.Width + 70, dataGridViewCustomers.Location.Y + 90);
            comboBoxSearch.Location = new System.Drawing.Point(dataGridViewCustomers.Width + 70, dataGridViewCustomers.Location.Y + 120);
            labelAttribute.Location = new System.Drawing.Point(dataGridViewCustomers.Width + 70, dataGridViewCustomers.Location.Y + 220);
            textBoxSearch.Location = new System.Drawing.Point(dataGridViewCustomers.Width + 70, dataGridViewCustomers.Location.Y + 250);
            buttonSearch.Location = new System.Drawing.Point(dataGridViewCustomers.Width + 130, dataGridViewCustomers.Location.Y + 350);
            labelAttribute.Visible = false;
            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewCustomers.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string query = "SELECT * FROM Customers";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewCustomers.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
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
            CustomerCardForm customerCardForm = new CustomerCardForm(true);
            customerCardForm.ShowDialog();

            UpdateTable();
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                try
                {
                    string id = dataGridViewCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CustomerCardForm customerCardForm = new CustomerCardForm(false, id);
                    customerCardForm.ShowDialog();

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
                    labelAttribute.Text = "Название";
                    break;
                case 1:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Адрес";
                    break;
                case 2:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "Телефон";
                    break;
                case 3:
                    labelAttribute.Visible = true;
                    textBoxSearch.Visible = true;
                    buttonSearch.Visible = true;
                    labelAttribute.Text = "обращаться к";
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
                    case "Название":
                        query = @"SELECT id, customer_name, address, phone, contact_person 
                          FROM Customers 
                          WHERE customer_name LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Адрес":
                        query = @"SELECT id, customer_name, address, phone, contact_person 
                          FROM Customers 
                          WHERE address LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Телефон":
                        query = @"SELECT id, customer_name, address, phone, contact_person 
                          FROM Customers 
                          WHERE phone LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                    case "Обращаться к":
                        query = @"SELECT id, customer_name, address, phone, contact_person 
                          FROM Customers 
                          WHERE contact_person LIKE @SearchText";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SearchText", "%" + textBoxSearch.Text + "%");
                        break;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewCustomers.Rows.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewCustomers.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
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

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
