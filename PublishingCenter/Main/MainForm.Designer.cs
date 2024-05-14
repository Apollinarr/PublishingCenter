namespace PublishingCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelUser = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUser = new System.Windows.Forms.Button();
            this.panelChangeAccount = new System.Windows.Forms.Panel();
            this.buttonChangeAccount = new System.Windows.Forms.Button();
            this.panelExit = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelSections = new System.Windows.Forms.Panel();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReports = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.buttonContracts = new Guna.UI2.WinForms.Guna2Button();
            this.buttonOrders = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAuthors = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBooks = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timerAccountMenu = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.flowLayoutPanelUser.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChangeAccount.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.panelSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumPurple;
            this.panelHeader.Controls.Add(this.labelLogo);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(462, 47);
            this.panelHeader.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(56, 10);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(227, 26);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "BookWise Publishing";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(9, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(41, 41);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // flowLayoutPanelUser
            // 
            this.flowLayoutPanelUser.Controls.Add(this.panelUser);
            this.flowLayoutPanelUser.Controls.Add(this.panelChangeAccount);
            this.flowLayoutPanelUser.Controls.Add(this.panelExit);
            this.flowLayoutPanelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanelUser.Location = new System.Drawing.Point(526, 0);
            this.flowLayoutPanelUser.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelUser.Name = "flowLayoutPanelUser";
            this.flowLayoutPanelUser.Size = new System.Drawing.Size(232, 47);
            this.flowLayoutPanelUser.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Controls.Add(this.buttonUser);
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(232, 47);
            this.panelUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUser.ForeColor = System.Drawing.Color.White;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.Location = new System.Drawing.Point(-23, -31);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(218, 108);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "name";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // panelChangeAccount
            // 
            this.panelChangeAccount.Controls.Add(this.buttonChangeAccount);
            this.panelChangeAccount.Location = new System.Drawing.Point(0, 47);
            this.panelChangeAccount.Margin = new System.Windows.Forms.Padding(0);
            this.panelChangeAccount.Name = "panelChangeAccount";
            this.panelChangeAccount.Size = new System.Drawing.Size(232, 24);
            this.panelChangeAccount.TabIndex = 0;
            this.panelChangeAccount.Click += new System.EventHandler(this.buttonChangeAccount_Click);
            // 
            // buttonChangeAccount
            // 
            this.buttonChangeAccount.BackColor = System.Drawing.Color.White;
            this.buttonChangeAccount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeAccount.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonChangeAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeAccount.Location = new System.Drawing.Point(-23, -41);
            this.buttonChangeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeAccount.Name = "buttonChangeAccount";
            this.buttonChangeAccount.Size = new System.Drawing.Size(292, 108);
            this.buttonChangeAccount.TabIndex = 1;
            this.buttonChangeAccount.Text = "Сменить аккаунт";
            this.buttonChangeAccount.UseVisualStyleBackColor = false;
            this.buttonChangeAccount.Click += new System.EventHandler(this.buttonChangeAccount_Click);
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.buttonExit);
            this.panelExit.Location = new System.Drawing.Point(0, 71);
            this.panelExit.Margin = new System.Windows.Forms.Padding(0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(232, 24);
            this.panelExit.TabIndex = 0;
            this.panelExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.Location = new System.Drawing.Point(-23, -41);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(292, 108);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelSections
            // 
            this.panelSections.BackColor = System.Drawing.Color.White;
            this.panelSections.Controls.Add(this.buttonSettings);
            this.panelSections.Controls.Add(this.buttonReports);
            this.panelSections.Controls.Add(this.buttonCustomers);
            this.panelSections.Controls.Add(this.buttonContracts);
            this.panelSections.Controls.Add(this.buttonOrders);
            this.panelSections.Controls.Add(this.buttonAuthors);
            this.panelSections.Controls.Add(this.buttonBooks);
            this.panelSections.Location = new System.Drawing.Point(0, 47);
            this.panelSections.Margin = new System.Windows.Forms.Padding(2);
            this.panelSections.Name = "panelSections";
            this.panelSections.Size = new System.Drawing.Size(892, 48);
            this.panelSections.TabIndex = 1;
            // 
            // buttonSettings
            // 
            this.buttonSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonSettings.CheckedState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonSettings.CustomBorderColor = System.Drawing.Color.White;
            this.buttonSettings.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSettings.FillColor = System.Drawing.Color.White;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonSettings.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonSettings.Location = new System.Drawing.Point(765, 0);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(128, 48);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Сотрудники";
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonReports.CheckedState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonReports.CustomBorderColor = System.Drawing.Color.White;
            this.buttonReports.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonReports.FillColor = System.Drawing.Color.White;
            this.buttonReports.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReports.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonReports.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonReports.Location = new System.Drawing.Point(638, 0);
            this.buttonReports.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(128, 48);
            this.buttonReports.TabIndex = 0;
            this.buttonReports.Text = "Отчеты";
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonCustomers.CheckedState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonCustomers.CustomBorderColor = System.Drawing.Color.White;
            this.buttonCustomers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCustomers.FillColor = System.Drawing.Color.White;
            this.buttonCustomers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCustomers.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonCustomers.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonCustomers.Location = new System.Drawing.Point(510, 0);
            this.buttonCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(128, 48);
            this.buttonCustomers.TabIndex = 0;
            this.buttonCustomers.Text = "Заказчики";
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonContracts.CheckedState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonContracts.CustomBorderColor = System.Drawing.Color.White;
            this.buttonContracts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonContracts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonContracts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonContracts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonContracts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonContracts.FillColor = System.Drawing.Color.White;
            this.buttonContracts.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContracts.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonContracts.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonContracts.Location = new System.Drawing.Point(255, 0);
            this.buttonContracts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(128, 48);
            this.buttonContracts.TabIndex = 0;
            this.buttonContracts.Text = "Контракты";
            this.buttonContracts.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonOrders.CheckedState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonOrders.CustomBorderColor = System.Drawing.Color.White;
            this.buttonOrders.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOrders.FillColor = System.Drawing.Color.White;
            this.buttonOrders.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonOrders.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonOrders.Location = new System.Drawing.Point(382, 0);
            this.buttonOrders.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(128, 48);
            this.buttonOrders.TabIndex = 0;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonAuthors.CheckedState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonAuthors.CustomBorderColor = System.Drawing.Color.White;
            this.buttonAuthors.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonAuthors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAuthors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAuthors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAuthors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAuthors.FillColor = System.Drawing.Color.White;
            this.buttonAuthors.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthors.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonAuthors.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonAuthors.Location = new System.Drawing.Point(128, 0);
            this.buttonAuthors.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(128, 48);
            this.buttonAuthors.TabIndex = 0;
            this.buttonAuthors.Text = "Авторы";
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonBooks.CheckedState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonBooks.CustomBorderColor = System.Drawing.Color.White;
            this.buttonBooks.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBooks.FillColor = System.Drawing.Color.White;
            this.buttonBooks.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBooks.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonBooks.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.buttonBooks.Location = new System.Drawing.Point(0, 0);
            this.buttonBooks.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(128, 48);
            this.buttonBooks.TabIndex = 0;
            this.buttonBooks.Text = "Книги";
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 92);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(892, 396);
            this.panelContainer.TabIndex = 2;
            // 
            // timerAccountMenu
            // 
            this.timerAccountMenu.Interval = 7;
            this.timerAccountMenu.Tick += new System.EventHandler(this.timerAccountMenu_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 488);
            this.Controls.Add(this.flowLayoutPanelUser);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSections);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookWise Publishing";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.flowLayoutPanelUser.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChangeAccount.ResumeLayout(false);
            this.panelExit.ResumeLayout(false);
            this.panelSections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSections;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button buttonBooks;
        private Guna.UI2.WinForms.Guna2Button buttonAuthors;
        private Guna.UI2.WinForms.Guna2Button buttonSettings;
        private Guna.UI2.WinForms.Guna2Button buttonReports;
        private Guna.UI2.WinForms.Guna2Button buttonCustomers;
        private Guna.UI2.WinForms.Guna2Button buttonOrders;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChangeAccount;
        private System.Windows.Forms.Button buttonChangeAccount;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUser;
        private System.Windows.Forms.Timer timerAccountMenu;
        private Guna.UI2.WinForms.Guna2Button buttonContracts;
    }
}