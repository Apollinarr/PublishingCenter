namespace PublishingCenter.Main.Orders
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnBook = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOrderFulfillmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.dateTimePickerSearch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelAttribute = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
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
            this.buttonAdd.Location = new System.Drawing.Point(928, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 35);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить контракт";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewOrders
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewOrders.ColumnHeadersHeight = 40;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCustomer,
            this.ColumnBook,
            this.ColumnOrderDate,
            this.ColumnOrderFulfillmentDate,
            this.ColumnQuantity});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewOrders.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(817, 421);
            this.dataGridViewOrders.TabIndex = 6;
            this.dataGridViewOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewOrders.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewOrders.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewOrders.ThemeStyle.ReadOnly = false;
            this.dataGridViewOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewOrders.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnId.FillWeight = 19.25134F;
            this.ColumnId.HeaderText = "id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnId.Width = 63;
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnCustomer.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColumnCustomer.FillWeight = 503.7433F;
            this.ColumnCustomer.HeaderText = "Заказчик";
            this.ColumnCustomer.MinimumWidth = 6;
            this.ColumnCustomer.Name = "ColumnCustomer";
            this.ColumnCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCustomer.Width = 200;
            // 
            // ColumnBook
            // 
            this.ColumnBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnBook.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColumnBook.FillWeight = 19.25134F;
            this.ColumnBook.HeaderText = "Книга";
            this.ColumnBook.MinimumWidth = 6;
            this.ColumnBook.Name = "ColumnBook";
            this.ColumnBook.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnBook.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnBook.Width = 200;
            // 
            // ColumnOrderDate
            // 
            this.ColumnOrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnOrderDate.FillWeight = 19.25134F;
            this.ColumnOrderDate.HeaderText = "Дата заказа";
            this.ColumnOrderDate.MinimumWidth = 6;
            this.ColumnOrderDate.Name = "ColumnOrderDate";
            this.ColumnOrderDate.Width = 200;
            // 
            // ColumnOrderFulfillmentDate
            // 
            this.ColumnOrderFulfillmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnOrderFulfillmentDate.FillWeight = 19.25134F;
            this.ColumnOrderFulfillmentDate.HeaderText = "Дата выполнения заказа";
            this.ColumnOrderFulfillmentDate.MinimumWidth = 6;
            this.ColumnOrderFulfillmentDate.Name = "ColumnOrderFulfillmentDate";
            this.ColumnOrderFulfillmentDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnOrderFulfillmentDate.Width = 200;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColumnQuantity.FillWeight = 19.25134F;
            this.ColumnQuantity.HeaderText = "Количество экземпляров";
            this.ColumnQuantity.MinimumWidth = 6;
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnQuantity.Width = 200;
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
            this.dateTimePickerSearch.Location = new System.Drawing.Point(856, 194);
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
            this.textBoxSearch.Location = new System.Drawing.Point(856, 194);
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
            this.labelAttribute.Location = new System.Drawing.Point(852, 169);
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
            this.labelSearch.Location = new System.Drawing.Point(852, 89);
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
            "Заказчик",
            "Книга",
            "Дата заказа",
            "Дата выполнения заказа"});
            this.comboBoxSearch.Location = new System.Drawing.Point(856, 114);
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
            this.buttonSearch.Location = new System.Drawing.Point(928, 268);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(170, 35);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 462);
            this.Controls.Add(this.dateTimePickerSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelAttribute);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.Text = "1107; 462";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnId;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderFulfillmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelAttribute;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}