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
    }
}
