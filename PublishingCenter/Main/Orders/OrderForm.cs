using MySql.Data.MySqlClient;
using PublishingCenter.Main.Books;
using PublishingCenter.Main.Contracts;
using PublishingCenter.Main.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingCenter.Main.Orders
{
    public partial class OrderForm : Form
    {
        private MySqlConnection connection;
        public OrderForm()
        {
            InitializeComponent();
            connection = new Connection().GetConnectionString();

            dataGridViewOrders.Width = Width;
            buttonAdd.Location = new System.Drawing.Point(dataGridViewOrders.Width + 130, dataGridViewOrders.Location.Y);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewOrders.Rows.Clear();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = @"SELECT Orders.id, Customers.customer_name, Books.title, Orders.order_date, Orders.order_fulfillment_date, Orders.quantity 
                         FROM Orders 
                         INNER JOIN Customers ON Orders.customer_id = Customers.id 
                         INNER JOIN Books ON Orders.book_id = Books.id";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewOrders.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], ((DateTime)row.ItemArray[3]).ToShortDateString(),
                                                ((DateTime)row.ItemArray[4]).ToShortDateString(), row.ItemArray[5]);
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
            OrderCardForm orderCardForm = new OrderCardForm(true);
            orderCardForm.ShowDialog();

            UpdateTable();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                try
                {
                    string id = dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
                    OrderCardForm orderCardForm = new OrderCardForm(false, id);
                    orderCardForm.ShowDialog();

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
                    string orderId = dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string customerIdQuery = "SELECT customer_id FROM Orders WHERE id = @OrderId";
                    MySqlCommand customerIdCmd = new MySqlCommand(customerIdQuery, connection);
                    customerIdCmd.Parameters.AddWithValue("@OrderId", orderId);
                    object customerIdResult = customerIdCmd.ExecuteScalar();

                    if (customerIdResult != null)
                    {
                        string customerId = customerIdResult.ToString();
                        CustomerCardForm customerCardForm = new CustomerCardForm(false, customerId);
                        customerCardForm.ShowDialog();
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
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                try
                {
                    string orderId = dataGridViewOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string bookIdQuery = "SELECT book_id FROM Orders WHERE id = @OrderId";
                    MySqlCommand bookIdCmd = new MySqlCommand(bookIdQuery, connection);
                    bookIdCmd.Parameters.AddWithValue("@OrderId", orderId);
                    object bookIdResult = bookIdCmd.ExecuteScalar();

                    if (bookIdResult != null)
                    {
                        string bookId = bookIdResult.ToString();
                        BookCardForm bookCardForm = new BookCardForm(false, bookId);
                        bookCardForm.ShowDialog();
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
    }
}
