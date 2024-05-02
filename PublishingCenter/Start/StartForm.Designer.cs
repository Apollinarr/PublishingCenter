namespace PublishingCenter
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panelName = new System.Windows.Forms.Panel();
            this.labelDeveloperName = new System.Windows.Forms.Label();
            this.labelDevelopBy = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelScndLogin = new System.Windows.Forms.Panel();
            this.panelGuest = new System.Windows.Forms.Panel();
            this.pictureBoxGuest = new System.Windows.Forms.PictureBox();
            this.labelGuest = new System.Windows.Forms.Label();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelScndLogin.SuspendLayout();
            this.panelGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuest)).BeginInit();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.MediumPurple;
            this.panelName.Controls.Add(this.labelDeveloperName);
            this.panelName.Controls.Add(this.labelDevelopBy);
            this.panelName.Controls.Add(this.labelLogo);
            this.panelName.Controls.Add(this.pictureBoxLogo);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(300, 530);
            this.panelName.TabIndex = 0;
            // 
            // labelDeveloperName
            // 
            this.labelDeveloperName.AutoSize = true;
            this.labelDeveloperName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeveloperName.ForeColor = System.Drawing.Color.White;
            this.labelDeveloperName.Location = new System.Drawing.Point(157, 483);
            this.labelDeveloperName.Name = "labelDeveloperName";
            this.labelDeveloperName.Size = new System.Drawing.Size(126, 21);
            this.labelDeveloperName.TabIndex = 2;
            this.labelDeveloperName.Text = "Polina Kosova";
            // 
            // labelDevelopBy
            // 
            this.labelDevelopBy.AutoSize = true;
            this.labelDevelopBy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDevelopBy.ForeColor = System.Drawing.Color.White;
            this.labelDevelopBy.Location = new System.Drawing.Point(176, 458);
            this.labelDevelopBy.Name = "labelDevelopBy";
            this.labelDevelopBy.Size = new System.Drawing.Size(107, 21);
            this.labelDevelopBy.TabIndex = 2;
            this.labelDevelopBy.Text = "Develop by";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(3, 204);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(289, 34);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "BookWise Publishing";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(95, 40);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(178, 139);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelScndLogin);
            this.panelLogin.Controls.Add(this.buttonClose);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(300, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(450, 530);
            this.panelLogin.TabIndex = 1;
            // 
            // panelScndLogin
            // 
            this.panelScndLogin.Controls.Add(this.panelGuest);
            this.panelScndLogin.Controls.Add(this.panelEmployee);
            this.panelScndLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelScndLogin.Location = new System.Drawing.Point(0, 77);
            this.panelScndLogin.Name = "panelScndLogin";
            this.panelScndLogin.Size = new System.Drawing.Size(450, 453);
            this.panelScndLogin.TabIndex = 2;
            // 
            // panelGuest
            // 
            this.panelGuest.Controls.Add(this.pictureBoxGuest);
            this.panelGuest.Controls.Add(this.labelGuest);
            this.panelGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelGuest.Location = new System.Drawing.Point(253, 102);
            this.panelGuest.Name = "panelGuest";
            this.panelGuest.Size = new System.Drawing.Size(165, 162);
            this.panelGuest.TabIndex = 3;
            this.panelGuest.Visible = false;
            this.panelGuest.Click += new System.EventHandler(this.panelGuest_Click);
            // 
            // pictureBoxGuest
            // 
            this.pictureBoxGuest.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuest.Image")));
            this.pictureBoxGuest.Location = new System.Drawing.Point(14, 3);
            this.pictureBoxGuest.Name = "pictureBoxGuest";
            this.pictureBoxGuest.Size = new System.Drawing.Size(122, 117);
            this.pictureBoxGuest.TabIndex = 0;
            this.pictureBoxGuest.TabStop = false;
            this.pictureBoxGuest.Click += new System.EventHandler(this.panelGuest_Click);
            // 
            // labelGuest
            // 
            this.labelGuest.AutoSize = true;
            this.labelGuest.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuest.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelGuest.Location = new System.Drawing.Point(35, 123);
            this.labelGuest.Name = "labelGuest";
            this.labelGuest.Size = new System.Drawing.Size(93, 34);
            this.labelGuest.TabIndex = 1;
            this.labelGuest.Text = "Гость";
            this.labelGuest.Click += new System.EventHandler(this.panelGuest_Click);
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.pictureBox1);
            this.panelEmployee.Controls.Add(this.label1);
            this.panelEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelEmployee.Location = new System.Drawing.Point(25, 102);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(165, 162);
            this.panelEmployee.TabIndex = 3;
            this.panelEmployee.Visible = false;
            this.panelEmployee.Click += new System.EventHandler(this.panelEmployee_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panelEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(-6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            this.label1.Click += new System.EventHandler(this.panelEmployee_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonClose.Location = new System.Drawing.Point(410, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelLogin.Location = new System.Drawing.Point(19, 40);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(83, 34);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Вход\r\n";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookWisePublishing";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelScndLogin.ResumeLayout(false);
            this.panelGuest.ResumeLayout(false);
            this.panelGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuest)).EndInit();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelDevelopBy;
        private System.Windows.Forms.Label labelDeveloperName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelScndLogin;
        private System.Windows.Forms.Panel panelGuest;
        private System.Windows.Forms.PictureBox pictureBoxGuest;
        private System.Windows.Forms.Label labelGuest;
    }
}

