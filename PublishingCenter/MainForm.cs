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
            flowLayoutPanelUser.Location = new Point(Width - flowLayoutPanelUser.Width - 10, 0);
            if (Employee.Position != 4)
            {
                buttonUser.Text = Employee.FirstName + " " + Employee.LastName;
            }
            else
            {
                buttonUser.Text = "Гость";
            }
        }

        bool menuExpand = false;

        private void timerAccountMenu_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                flowLayoutPanelUser.Height += 5;
                if (flowLayoutPanelUser.Height >= 116)
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
            //ActiveForm.Show();
            //StartForm startForm = new StartForm();
            //startForm.Show();
        }
    }
}
