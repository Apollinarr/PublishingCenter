namespace PublishingCenter.Main.Books
{
    partial class BooksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookCode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditionQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnpublicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoyalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.dateTimePickerSearch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelAttribute = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(848, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 35);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBooks
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridViewBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBooks.ColumnHeadersHeight = 40;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnBookCode,
            this.ColumnTitle,
            this.ColumnEditionQuantity,
            this.ColumnpublicationDate,
            this.ColumnCostPrice,
            this.ColumnSellingPrice,
            this.ColumnRoyalty,
            this.ColumnAuthor,
            this.ColumnGenre});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBooks.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(817, 421);
            this.dataGridViewBooks.TabIndex = 6;
            this.dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewBooks.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewBooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewBooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewBooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewBooks.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewBooks.ThemeStyle.ReadOnly = false;
            this.dataGridViewBooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewBooks.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnId.FillWeight = 19.25134F;
            this.ColumnId.HeaderText = "id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnId.Width = 63;
            // 
            // ColumnBookCode
            // 
            this.ColumnBookCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnBookCode.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnBookCode.FillWeight = 503.7433F;
            this.ColumnBookCode.HeaderText = "Код";
            this.ColumnBookCode.MinimumWidth = 6;
            this.ColumnBookCode.Name = "ColumnBookCode";
            this.ColumnBookCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnBookCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnBookCode.Width = 200;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnTitle.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnTitle.FillWeight = 19.25134F;
            this.ColumnTitle.HeaderText = "Название";
            this.ColumnTitle.MinimumWidth = 6;
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.Width = 200;
            // 
            // ColumnEditionQuantity
            // 
            this.ColumnEditionQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEditionQuantity.FillWeight = 19.25134F;
            this.ColumnEditionQuantity.HeaderText = "Тираж";
            this.ColumnEditionQuantity.MinimumWidth = 6;
            this.ColumnEditionQuantity.Name = "ColumnEditionQuantity";
            this.ColumnEditionQuantity.Width = 200;
            // 
            // ColumnpublicationDate
            // 
            this.ColumnpublicationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnpublicationDate.FillWeight = 19.25134F;
            this.ColumnpublicationDate.HeaderText = "Выход в печать";
            this.ColumnpublicationDate.MinimumWidth = 6;
            this.ColumnpublicationDate.Name = "ColumnpublicationDate";
            this.ColumnpublicationDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnpublicationDate.Width = 200;
            // 
            // ColumnCostPrice
            // 
            this.ColumnCostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnCostPrice.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnCostPrice.FillWeight = 19.25134F;
            this.ColumnCostPrice.HeaderText = "Себестоимость";
            this.ColumnCostPrice.MinimumWidth = 6;
            this.ColumnCostPrice.Name = "ColumnCostPrice";
            this.ColumnCostPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCostPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCostPrice.Width = 200;
            // 
            // ColumnSellingPrice
            // 
            this.ColumnSellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSellingPrice.HeaderText = "Цена продажи";
            this.ColumnSellingPrice.Name = "ColumnSellingPrice";
            this.ColumnSellingPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSellingPrice.Width = 200;
            // 
            // ColumnRoyalty
            // 
            this.ColumnRoyalty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnRoyalty.HeaderText = "Гонорар атора";
            this.ColumnRoyalty.Name = "ColumnRoyalty";
            this.ColumnRoyalty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnRoyalty.Width = 200;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnAuthor.HeaderText = "Автор";
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.Width = 200;
            // 
            // ColumnGenre
            // 
            this.ColumnGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnGenre.HeaderText = "Жанр";
            this.ColumnGenre.Name = "ColumnGenre";
            this.ColumnGenre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnGenre.Width = 200;
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpdate.Image")));
            this.pictureBoxUpdate.Location = new System.Drawing.Point(831, 10);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxUpdate.TabIndex = 8;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.pictureBoxUpdate_Click);
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Checked = true;
            this.dateTimePickerSearch.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerSearch.Location = new System.Drawing.Point(829, 188);
            this.dateTimePickerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerSearch.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerSearch.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(242, 32);
            this.dateTimePickerSearch.TabIndex = 25;
            this.dateTimePickerSearch.Value = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.textBoxSearch.Location = new System.Drawing.Point(829, 188);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.MaxLength = 50;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(242, 32);
            this.textBoxSearch.TabIndex = 24;
            // 
            // labelAttribute
            // 
            this.labelAttribute.AutoSize = true;
            this.labelAttribute.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttribute.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelAttribute.Location = new System.Drawing.Point(825, 163);
            this.labelAttribute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAttribute.Name = "labelAttribute";
            this.labelAttribute.Size = new System.Drawing.Size(91, 23);
            this.labelAttribute.TabIndex = 22;
            this.labelAttribute.Text = "Атрибут";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelSearch.Location = new System.Drawing.Point(825, 83);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(68, 23);
            this.labelSearch.TabIndex = 23;
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
            "Код",
            "Название",
            "Выход в печать",
            "Автор",
            "Жанр"});
            this.comboBoxSearch.Location = new System.Drawing.Point(829, 108);
            this.comboBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(242, 33);
            this.comboBoxSearch.TabIndex = 21;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(901, 262);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(170, 35);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 462);
            this.Controls.Add(this.dateTimePickerSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelAttribute);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnBookCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEditionQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnpublicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoyalty;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenre;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelAttribute;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}