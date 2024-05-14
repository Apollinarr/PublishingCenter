namespace PublishingCenter
{
    partial class AuthorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsForm));
            this.dataGridViewAuthors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBooks = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAuthors
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewAuthors.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAuthors.ColumnHeadersHeight = 40;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnLastName,
            this.ColumnFirstName,
            this.ColumnMiddleName,
            this.ColumnDateOfBirthday,
            this.ColumnBooks});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAuthors.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAuthors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAuthors.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewAuthors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersVisible = false;
            this.dataGridViewAuthors.RowHeadersWidth = 51;
            this.dataGridViewAuthors.RowTemplate.Height = 24;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(797, 421);
            this.dataGridViewAuthors.TabIndex = 0;
            this.dataGridViewAuthors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAuthors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewAuthors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAuthors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewAuthors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAuthors.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAuthors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAuthors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewAuthors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAuthors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewAuthors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAuthors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAuthors.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewAuthors.ThemeStyle.ReadOnly = false;
            this.dataGridViewAuthors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAuthors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAuthors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewAuthors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAuthors.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewAuthors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAuthors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAuthors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAuthors_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(928, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 35);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить автора";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.ColumnLastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // ColumnDateOfBirthday
            // 
            this.ColumnDateOfBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDateOfBirthday.FillWeight = 19.25134F;
            this.ColumnDateOfBirthday.HeaderText = "Дата рождения";
            this.ColumnDateOfBirthday.MinimumWidth = 6;
            this.ColumnDateOfBirthday.Name = "ColumnDateOfBirthday";
            this.ColumnDateOfBirthday.Width = 200;
            // 
            // ColumnBooks
            // 
            this.ColumnBooks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnBooks.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnBooks.FillWeight = 19.25134F;
            this.ColumnBooks.HeaderText = "Книги";
            this.ColumnBooks.MinimumWidth = 6;
            this.ColumnBooks.Name = "ColumnBooks";
            this.ColumnBooks.Text = "Смотреть";
            this.ColumnBooks.Width = 200;
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1107, 462);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewAuthors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAuthors;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfBirthday;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnBooks;
    }
}