using PublishingCenter.Main.Books;
using PublishingCenter.Main.Contracts;
using PublishingCenter.Main.Customers;
using PublishingCenter.Main.Orders;
using PublishingCenter.Main.reports;
using PublishingCenter.Main.Settings;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizedBounds = Screen.GetWorkingArea(this);
            panelHeader.Width = MaximizedBounds.Width;
            panelSections.Width = MaximizedBounds.Width;
            panelContainer.Width = MaximizedBounds.Width;
            panelContainer.Height = MaximizedBounds.Height - panelHeader.Height - panelSections.Height;
            flowLayoutPanelUser.Location = new Point(Width - flowLayoutPanelUser.Width - 10, 0);
            buttonUser.Text = Employee.FirstName + " " + Employee.LastName;
            //if (Employee.Position != 4)
            //{
            //    buttonUser.Text = Employee.FirstName + " " + Employee.LastName;
            //}
            //else
            //{
            //    buttonUser.Text = "Гость";
            //}

            if (Employee.Position == 2)
            {
                buttonOrders.Visible = false;
                buttonCustomers.Visible = false;
                buttonSettings.Visible = false;
                buttonReports.Location = new Point(buttonContracts.Location.X + buttonContracts.Width, 0);
            }
            if (Employee.Position == 3)
            {
                buttonAuthors.Visible = false;
                buttonContracts.Visible = false;
                buttonSettings.Visible = false;
                buttonOrders.Location = new Point(buttonBooks.Width, 0);
                buttonCustomers.Location = new Point(buttonOrders.Location.X + buttonBooks.Width, 0);
                buttonReports.Location = new Point(buttonCustomers.Location.X + buttonCustomers.Width, 0);
            }
        }

        bool menuExpand = false;

        private void timerAccountMenu_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                flowLayoutPanelUser.Height += 5;
                if (flowLayoutPanelUser.Height >= 90)
                {
                    timerAccountMenu.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanelUser.Height -= 5;   
                if (flowLayoutPanelUser.Height <= 50)
                {
                    timerAccountMenu.Stop();
                    menuExpand = false;
                }
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            timerAccountMenu.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonChangeAccount_Click(object sender, EventArgs e)
        {
            Close();
            StartForm startForm = (StartForm)Application.OpenForms["StartForm"];
            startForm.ShowLoginForm();
            //ActiveForm.Show();
            //StartForm startForm = new StartForm();
            //startForm.Show();
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            AuthorsForm authorsForm = new AuthorsForm();
            authorsForm.TopLevel = false;
            authorsForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(authorsForm);
            authorsForm.BringToFront();
            authorsForm.Show();
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            ContractsForm contractsForm = new ContractsForm();
            contractsForm.TopLevel = false;
            contractsForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(contractsForm);
            contractsForm.BringToFront();
            contractsForm.Show();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.TopLevel = false;
            customersForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(customersForm);
            customersForm.BringToFront();
            customersForm.Show();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.TopLevel = false;
            booksForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(booksForm);
            booksForm.BringToFront();
            booksForm.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.TopLevel = false;
            orderForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(orderForm);
            orderForm.BringToFront();
            orderForm.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.TopLevel = false;
            settingsForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(settingsForm);
            settingsForm.BringToFront();
            settingsForm.Show();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.TopLevel = false;
            reportsForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(reportsForm);
            reportsForm.BringToFront();
            reportsForm.Show();
        }
    }
}
