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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelEmployee_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.TopLevel = false;
            //loginForm.Dock = DockStyle.Fill;
            //panelScndLogin.Controls.Add(loginForm);
            //loginForm.BringToFront();
            //loginForm.Show();
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
    }
}
