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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
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
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 35);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить книгу";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBooks
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBooks.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnBookCode.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnTitle.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnCostPrice.DefaultCellStyle = dataGridViewCellStyle5;
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
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 462);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

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
    }
}