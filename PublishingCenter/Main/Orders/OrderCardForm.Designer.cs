namespace PublishingCenter.Main.Orders
{
    partial class OrderCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCardForm));
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOrderDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerOrderFulfillmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelOrderFulfillmentDate = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelQuantity.Location = new System.Drawing.Point(415, 260);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(251, 23);
            this.labelQuantity.TabIndex = 44;
            this.labelQuantity.Text = "Количество экземпляров";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuantity.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(420, 290);
            this.textBoxQuantity.MaxLength = 50;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(297, 32);
            this.textBoxQuantity.TabIndex = 33;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBook.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(779, 78);
            this.comboBoxBook.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(297, 40);
            this.comboBoxBook.TabIndex = 31;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCustomer.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(419, 78);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(297, 40);
            this.comboBoxCustomer.TabIndex = 28;
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Checked = true;
            this.dateTimePickerOrderDate.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerOrderDate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(419, 181);
            this.dateTimePickerOrderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerOrderDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(297, 36);
            this.dateTimePickerOrderDate.TabIndex = 29;
            this.dateTimePickerOrderDate.Value = new System.DateTime(2024, 5, 13, 0, 0, 0, 0);
            // 
            // dateTimePickerOrderFulfillmentDate
            // 
            this.dateTimePickerOrderFulfillmentDate.Checked = true;
            this.dateTimePickerOrderFulfillmentDate.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerOrderFulfillmentDate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerOrderFulfillmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerOrderFulfillmentDate.Location = new System.Drawing.Point(779, 182);
            this.dateTimePickerOrderFulfillmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerOrderFulfillmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerOrderFulfillmentDate.Name = "dateTimePickerOrderFulfillmentDate";
            this.dateTimePickerOrderFulfillmentDate.Size = new System.Drawing.Size(297, 36);
            this.dateTimePickerOrderFulfillmentDate.TabIndex = 32;
            this.dateTimePickerOrderFulfillmentDate.Value = new System.DateTime(2024, 5, 13, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(39, 418);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(144, 49);
            this.buttonUpdate.TabIndex = 40;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(262, 418);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 49);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(39, 418);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 49);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonClose.Location = new System.Drawing.Point(1123, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 32);
            this.buttonClose.TabIndex = 39;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelOrderFulfillmentDate
            // 
            this.labelOrderFulfillmentDate.AutoSize = true;
            this.labelOrderFulfillmentDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderFulfillmentDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelOrderFulfillmentDate.Location = new System.Drawing.Point(775, 149);
            this.labelOrderFulfillmentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderFulfillmentDate.Name = "labelOrderFulfillmentDate";
            this.labelOrderFulfillmentDate.Size = new System.Drawing.Size(251, 23);
            this.labelOrderFulfillmentDate.TabIndex = 36;
            this.labelOrderFulfillmentDate.Text = "Дата выполнения заказа";
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBook.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelBook.Location = new System.Drawing.Point(775, 46);
            this.labelBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(65, 23);
            this.labelBook.TabIndex = 35;
            this.labelBook.Text = "Книга";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelOrderDate.Location = new System.Drawing.Point(415, 149);
            this.labelOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(133, 23);
            this.labelOrderDate.TabIndex = 38;
            this.labelOrderDate.Text = "Дата заказа";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomer.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelCustomer.Location = new System.Drawing.Point(415, 46);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(97, 23);
            this.labelCustomer.TabIndex = 34;
            this.labelCustomer.Text = "Заказчик";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // OrderCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 532);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.dateTimePickerOrderFulfillmentDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelOrderFulfillmentDate);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.labelCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderCardForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerOrderDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerOrderFulfillmentDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelOrderFulfillmentDate;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelCustomer;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}