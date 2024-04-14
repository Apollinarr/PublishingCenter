namespace PublishingCenter
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.pictureBoxMail = new System.Windows.Forms.PictureBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.pictureBoxCode = new System.Windows.Forms.PictureBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmePassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMail.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelMail.Location = new System.Drawing.Point(12, 19);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(207, 19);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Введи адрес эл. почты";
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(12, 41);
            this.textBoxMail.MaxLength = 50;
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(350, 40);
            this.textBoxMail.TabIndex = 3;
            // 
            // pictureBoxMail
            // 
            this.pictureBoxMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMail.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMail.Image")));
            this.pictureBoxMail.Location = new System.Drawing.Point(373, 41);
            this.pictureBoxMail.Name = "pictureBoxMail";
            this.pictureBoxMail.Size = new System.Drawing.Size(38, 35);
            this.pictureBoxMail.TabIndex = 5;
            this.pictureBoxMail.TabStop = false;
            this.pictureBoxMail.Click += new System.EventHandler(this.pictureBoxMail_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(12, 124);
            this.textBoxCode.MaxLength = 50;
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(350, 40);
            this.textBoxCode.TabIndex = 3;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCode.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelCode.Location = new System.Drawing.Point(12, 102);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(340, 19);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "Введи код, отправленный на эл. почту";
            // 
            // pictureBoxCode
            // 
            this.pictureBoxCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCode.Image")));
            this.pictureBoxCode.Location = new System.Drawing.Point(373, 124);
            this.pictureBoxCode.Name = "pictureBoxCode";
            this.pictureBoxCode.Size = new System.Drawing.Size(38, 35);
            this.pictureBoxCode.TabIndex = 5;
            this.pictureBoxCode.TabStop = false;
            this.pictureBoxCode.Click += new System.EventHandler(this.pictureBoxCode_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonChangePassword.FlatAppearance.BorderSize = 0;
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePassword.ForeColor = System.Drawing.Color.White;
            this.buttonChangePassword.Location = new System.Drawing.Point(116, 320);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(206, 41);
            this.buttonChangePassword.TabIndex = 28;
            this.buttonChangePassword.Text = "Сменить пароль";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(13, 266);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(173, 23);
            this.checkBoxShowPassword.TabIndex = 27;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelConfirmPassword.Location = new System.Drawing.Point(227, 200);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(166, 19);
            this.labelConfirmPassword.TabIndex = 29;
            this.labelConfirmPassword.Text = "Повторить пароль";
            // 
            // textBoxConfirmePassword
            // 
            this.textBoxConfirmePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxConfirmePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmePassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmePassword.Location = new System.Drawing.Point(231, 222);
            this.textBoxConfirmePassword.MaxLength = 50;
            this.textBoxConfirmePassword.Multiline = true;
            this.textBoxConfirmePassword.Name = "textBoxConfirmePassword";
            this.textBoxConfirmePassword.PasswordChar = '•';
            this.textBoxConfirmePassword.Size = new System.Drawing.Size(190, 35);
            this.textBoxConfirmePassword.TabIndex = 26;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelPassword.Location = new System.Drawing.Point(9, 200);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(72, 19);
            this.labelPassword.TabIndex = 30;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(13, 222);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(190, 35);
            this.textBoxPassword.TabIndex = 25;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelBack.Location = new System.Drawing.Point(176, 386);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(62, 19);
            this.labelBack.TabIndex = 31;
            this.labelBack.Text = "Назад";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 359);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxConfirmePassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBoxCode);
            this.Controls.Add(this.pictureBoxMail);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.PictureBox pictureBoxMail;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.PictureBox pictureBoxCode;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmePassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelBack;
    }
}