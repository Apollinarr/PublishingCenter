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
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ContractCardForm contractCardForm = new ContractCardForm(true);
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
                    ContractCardForm contractCardForm = new ContractCardForm(false, id);
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
                    connection.Open();
                    string authorIdQuery = "SELECT author_id FROM Contracts WHERE id = @ContractId";
                    MySqlCommand authorIdCmd = new MySqlCommand(authorIdQuery, connection);
                    authorIdCmd.Parameters.AddWithValue("@ContractId", contractId);
                    object authorIdResult = authorIdCmd.ExecuteScalar();

                    if (authorIdResult != null)
                    {
                        string authorId = authorIdResult.ToString();
                        AuthorCardForm authorCardForm = new AuthorCardForm(false, authorId);
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
    }
}
