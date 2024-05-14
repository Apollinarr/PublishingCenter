using Guna.UI2.WinForms.Suite;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PublishingCenter.Main.reports
{
    public partial class ReportsForm : Form
    {
        private MySqlConnection connection;
        public ReportsForm()
        {
            InitializeComponent();

            dataGridViewReports.Rows.Add("Список всех авторов и их книг");
            dataGridViewReports.Rows.Add("Продажи книг за определенный период");
            dataGridViewReports.Rows.Add("Количество книг каждого жанра");
            dataGridViewReports.Rows.Add("Доходы от продаж книг по авторам");
            dataGridViewReports.Rows.Add("Количество заказов по клиентам");
            dataGridViewReports.Rows.Add("Данные по невыполненным заказам");
            dataGridViewReports.Rows.Add("Количество проданных книг по жанрам");
            dataGridViewReports.Rows.Add("Список сотрудников и их должностей");
            dataGridViewReports.Rows.Add("Список заказов за определенный период");
            dataGridViewReports.Rows.Add("Список клиентов и их заказов");
        }

        private void dataGridViewReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string reportName = dataGridViewReports.Rows[e.RowIndex].Cells[0].Value.ToString();
                GenerateAndSendReport(reportName);
            }
        }

        private void GenerateAndSendReport(string reportName)
        {
            DataTable reportData = new DataTable();
            string query = string.Empty;

            switch (reportName)
            {
                case "Список всех авторов и их книг":
                    query = "SELECT a.last_name AS 'Фамилия', a.first_name AS 'Имя', a.middle_name AS 'Отчество', b.title AS 'Название книги' FROM Authors a JOIN Books b ON a.id = b.author_id";
                    break;
                case "Продажи книг за определенный период":
                    query = "SELECT o.id AS 'Номер заказа', c.name AS 'Заказчик', b.title AS 'Название книги', o.quantity AS 'Количество', o.order_date AS 'Дата заказа', o.order_fulfillment_date AS 'Дата выполнения', (o.quantity * b.selling_price) AS 'Сумма продажи' FROM Orders o JOIN Customers c ON o.customer_id = c.id JOIN Books b ON o.book_id = b.id WHERE o.order_date BETWEEN @StartDate AND @EndDate";
                    break;
                case "Количество книг каждого жанра":
                    query = "SELECT g.genre_name AS 'Жанр', COUNT(b.id) AS 'Количество книг' FROM Books b JOIN Genres g ON b.genre_id = g.id GROUP BY g.genre_name";
                    break;
                case "Доходы от продаж книг по авторам":
                    query = "SELECT a.last_name AS 'Фамилия', a.first_name AS 'Имя', a.middle_name AS 'Отчество', SUM(o.quantity * b.selling_price) AS 'Доход' FROM Orders o JOIN Books b ON o.book_id = b.id JOIN Authors a ON b.author_id = a.id GROUP BY a.id";
                    break;
                case "Количество заказов по клиентам":
                    query = "SELECT c.name AS 'Клиент', COUNT(o.id) AS 'Количество заказов' FROM Orders o JOIN Customers c ON o.customer_id = c.id GROUP BY c.id";
                    break;
                case "Данные по невыполненным заказам":
                    query = "SELECT o.id AS 'Номер заказа', c.name AS 'Клиент', b.title AS 'Название книги', o.quantity AS 'Количество', o.order_date AS 'Дата заказа', o.order_fulfillment_date AS 'Дата выполнения' FROM Orders o JOIN Customers c ON o.customer_id = c.id JOIN Books b ON o.book_id = b.id WHERE o.order_fulfillment_date IS NULL";
                    break;
                case "Количество проданных книг по жанрам":
                    query = "SELECT g.genre_name AS 'Жанр', SUM(o.quantity) AS 'Продано книг' FROM Orders o JOIN Books b ON o.book_id = b.id JOIN Genres g ON b.genre_id = g.id GROUP BY g.genre_name";
                    break;
                case "Список сотрудников и их должностей":
                    query = "SELECT e.last_name AS 'Фамилия', e.first_name AS 'Имя', e.middle_name AS 'Отчество', p.position_name AS 'Должность' FROM Employees e JOIN Positions p ON e.position_id = p.id";
                    break;
                case "Список заказов за определенный период":
                    query = "SELECT o.id AS 'Номер заказа', c.name AS 'Клиент', b.title AS 'Название книги', o.quantity AS 'Количество', o.order_date AS 'Дата заказа', o.order_fulfillment_date AS 'Дата выполнения' FROM Orders o JOIN Customers c ON o.customer_id = c.id JOIN Books b ON o.book_id = b.id WHERE o.order_date BETWEEN @StartDate AND @EndDate";
                    break;
                case "Список клиентов и их заказов":
                    query = "SELECT c.name AS 'Клиент', o.id AS 'Номер заказа', b.title AS 'Название книги', o.quantity AS 'Количество', o.order_date AS 'Дата заказа', o.order_fulfillment_date AS 'Дата выполнения' FROM Customers c JOIN Orders o ON c.id = o.customer_id JOIN Books b ON o.book_id = b.id";
                    break;
                default:
                    return;
            }

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                //if (query.Contains("@StartDate") || query.Contains("@EndDate"))
                //{
                //    command.Parameters.AddWithValue("@StartDate", dateTimePickerStart.Value);
                //    command.Parameters.AddWithValue("@EndDate", dateTimePickerEnd.Value);
                //}
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(reportData);

                // Создание PDF
                string pdfFilePath = CreatePDF(reportData, reportName);

                // Отправка по почте
                //Mailer.SendMessage(textBoxLogin.Text, "Регистрация", $"{textBoxFirstName.Text} {textBoxLastName.Text}, ваш аккаунт успешно зарегистрирован.");
                Mailer.SendMessage(Employee.Login, "Отчёт: " + reportName, "Во вложении отчёт.", pdfFilePath);
                //SendEmailWithAttachment(employeeEmail, "Отчет: " + reportName, "Во вложении отчет.", pdfFilePath);7
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
        private string CreatePDF(DataTable data, string reportName)
        {
            string pdfFilePath = Path.Combine(Path.GetTempPath(), $"{reportName}.pdf");

            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));
            document.Open();

            // Добавление заголовка
            document.Add(new Paragraph(reportName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)));
            document.Add(new Paragraph("\n"));

            // Создание таблицы
            PdfPTable table = new PdfPTable(data.Columns.Count);
            table.WidthPercentage = 100;

            // Добавление заголовков столбцов
            foreach (DataColumn column in data.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            // Добавление данных
            foreach (DataRow row in data.Rows)
            {
                foreach (var cellValue in row.ItemArray)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(cellValue.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();

            return pdfFilePath;
        }
    }
}
