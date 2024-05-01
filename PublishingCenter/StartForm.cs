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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelEmployee_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        public void ShowRegForm()
        {
            RegForm regForm = new RegForm();
            regForm.TopLevel = false;
            regForm.Dock = DockStyle.Fill;
            panelScndLogin.Controls.Add(regForm);
            regForm.BringToFront();
            regForm.Show();
        }

        public void ShowLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.Dock = DockStyle.Fill;
            panelScndLogin.Controls.Add(loginForm);
            loginForm.BringToFront();
            loginForm.Show();
        }

        public void ShowForgotPasswordForm()
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.TopLevel = false;
            forgotPasswordForm.Dock = DockStyle.Fill;
            panelScndLogin.Controls.Add(forgotPasswordForm);
            forgotPasswordForm.BringToFront();
            forgotPasswordForm.Show();
        }

        //unused
        private void panelGuest_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.SetGuest();
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Show();
        }
    }
}
