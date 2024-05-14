namespace PublishingCenter.Main.Settings
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelAttribute = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.textBoxSearch.Location = new System.Drawing.Point(1539, 233);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.MaxLength = 50;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(323, 32);
            this.textBoxSearch.TabIndex = 32;
            // 
            // labelAttribute
            // 
            this.labelAttribute.AutoSize = true;
            this.labelAttribute.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttribute.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelAttribute.Location = new System.Drawing.Point(1533, 202);
            this.labelAttribute.Name = "labelAttribute";
            this.labelAttribute.Size = new System.Drawing.Size(91, 23);
            this.labelAttribute.TabIndex = 30;
            this.labelAttribute.Text = "Атрибут";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelSearch.Location = new System.Drawing.Point(1533, 103);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(68, 23);
            this.labelSearch.TabIndex = 31;
            this.labelSearch.Text = "Поиск";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearch.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Должность",
            "Логин"});
            this.comboBoxSearch.Location = new System.Drawing.Point(1539, 134);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(321, 33);
            this.comboBoxSearch.TabIndex = 29;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(1635, 324);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(227, 43);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpdate.Image")));
            this.pictureBoxUpdate.Location = new System.Drawing.Point(1481, 12);
            this.pictureBoxUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(43, 39);
            this.pictureBoxUpdate.TabIndex = 27;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.pictureBoxUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(1640, 14);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(227, 43);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить автора";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeight = 40;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnLastName,
            this.ColumnFirstName,
            this.ColumnMiddleName,
            this.ColumnPosition,
            this.ColumnLogin});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1463, 518);
            this.dataGridViewUsers.TabIndex = 33;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewUsers.ThemeStyle.ReadOnly = false;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewUsers.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnId.FillWeight = 19.25134F;
            this.ColumnId.HeaderText = "id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 63;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnLastName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnLastName.FillWeight = 503.7433F;
            this.ColumnLastName.HeaderText = "Фамилия";
            this.ColumnLastName.MinimumWidth = 6;
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnLastName.Width = 200;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnFirstName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnFirstName.FillWeight = 19.25134F;
            this.ColumnFirstName.HeaderText = "Имя";
            this.ColumnFirstName.MinimumWidth = 6;
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.Width = 200;
            // 
            // ColumnMiddleName
            // 
            this.ColumnMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnMiddleName.FillWeight = 19.25134F;
            this.ColumnMiddleName.HeaderText = "Отчество";
            this.ColumnMiddleName.MinimumWidth = 6;
            this.ColumnMiddleName.Name = "ColumnMiddleName";
            this.ColumnMiddleName.Width = 200;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPosition.FillWeight = 19.25134F;
            this.ColumnPosition.HeaderText = "Должность";
            this.ColumnPosition.MinimumWidth = 6;
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.Width = 200;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnLogin.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnLogin.FillWeight = 19.25134F;
            this.ColumnLogin.HeaderText = "Логин";
            this.ColumnLogin.MinimumWidth = 6;
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.Text = "Смотреть";
            this.ColumnLogin.Width = 200;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 569);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelAttribute);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelAttribute;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnLogin;
    }
}