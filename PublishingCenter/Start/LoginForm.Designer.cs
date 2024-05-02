namespace PublishingCenter
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.labelDontHaveAcc = new System.Windows.Forms.Label();
            this.labelReg = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelLogin.Location = new System.Drawing.Point(52, 53);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 27);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(57, 83);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(297, 40);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(57, 167);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(290, 40);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelPassword.Location = new System.Drawing.Point(52, 137);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 27);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(57, 213);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(173, 23);
            this.checkBoxShowPassword.TabIndex = 2;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(133, 257);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(144, 49);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForgotPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelForgotPassword.Location = new System.Drawing.Point(129, 321);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(148, 19);
            this.labelForgotPassword.TabIndex = 2;
            this.labelForgotPassword.Text = "Забыли пароль?";
            this.labelForgotPassword.Click += new System.EventHandler(this.labelForgotPassword_Click);
            // 
            // labelDontHaveAcc
            // 
            this.labelDontHaveAcc.AutoSize = true;
            this.labelDontHaveAcc.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDontHaveAcc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDontHaveAcc.ForeColor = System.Drawing.Color.Gray;
            this.labelDontHaveAcc.Location = new System.Drawing.Point(42, 363);
            this.labelDontHaveAcc.Name = "labelDontHaveAcc";
            this.labelDontHaveAcc.Size = new System.Drawing.Size(136, 19);
            this.labelDontHaveAcc.TabIndex = 2;
            this.labelDontHaveAcc.Text = "Нет аккаунта?";
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelReg.Location = new System.Drawing.Point(186, 363);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(189, 19);
            this.labelReg.TabIndex = 2;
            this.labelReg.Text = "Зарегистрироваться";
            this.labelReg.Click += new System.EventHandler(this.labelReg_Click);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelBack.Location = new System.Drawing.Point(178, 401);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(62, 19);
            this.labelBack.TabIndex = 2;
            this.labelBack.Text = "Назад";
            this.labelBack.Visible = false;
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(432, 406);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.labelDontHaveAcc);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Label labelDontHaveAcc;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Label labelBack;
    }
}