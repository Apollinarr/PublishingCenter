namespace PublishingCenter.Main.Books
{
    partial class BookCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCardForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerPublicationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPublicationDate = new System.Windows.Forms.Label();
            this.labelEditionQuantity = new System.Windows.Forms.Label();
            this.textBoxEditionQuantity = new System.Windows.Forms.TextBox();
            this.labelTittle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelBookCode = new System.Windows.Forms.Label();
            this.textBoxBookCode = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxCostPrice = new System.Windows.Forms.TextBox();
            this.labelCostPrice = new System.Windows.Forms.Label();
            this.textBoxSellingPrice = new System.Windows.Forms.TextBox();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.textBoxRoyalty = new System.Windows.Forms.TextBox();
            this.labelRoyalty = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerPublicationDate
            // 
            this.dateTimePickerPublicationDate.Checked = true;
            this.dateTimePickerPublicationDate.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerPublicationDate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerPublicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerPublicationDate.Location = new System.Drawing.Point(406, 275);
            this.dateTimePickerPublicationDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerPublicationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerPublicationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerPublicationDate.Name = "dateTimePickerPublicationDate";
            this.dateTimePickerPublicationDate.Size = new System.Drawing.Size(297, 32);
            this.dateTimePickerPublicationDate.TabIndex = 3;
            this.dateTimePickerPublicationDate.Value = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(44, 405);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(144, 49);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(305, 405);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 49);
            this.buttonDelete.TabIndex = 18;
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
            this.buttonAdd.Location = new System.Drawing.Point(44, 405);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 49);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPublicationDate
            // 
            this.labelPublicationDate.AutoSize = true;
            this.labelPublicationDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPublicationDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelPublicationDate.Location = new System.Drawing.Point(403, 249);
            this.labelPublicationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPublicationDate.Name = "labelPublicationDate";
            this.labelPublicationDate.Size = new System.Drawing.Size(179, 23);
            this.labelPublicationDate.TabIndex = 13;
            this.labelPublicationDate.Text = "Дата публикации";
            // 
            // labelEditionQuantity
            // 
            this.labelEditionQuantity.AutoSize = true;
            this.labelEditionQuantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditionQuantity.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelEditionQuantity.Location = new System.Drawing.Point(403, 181);
            this.labelEditionQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditionQuantity.Name = "labelEditionQuantity";
            this.labelEditionQuantity.Size = new System.Drawing.Size(70, 23);
            this.labelEditionQuantity.TabIndex = 14;
            this.labelEditionQuantity.Text = "Тираж";
            // 
            // textBoxEditionQuantity
            // 
            this.textBoxEditionQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxEditionQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEditionQuantity.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.textBoxEditionQuantity.Location = new System.Drawing.Point(406, 206);
            this.textBoxEditionQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditionQuantity.MaxLength = 5;
            this.textBoxEditionQuantity.Name = "textBoxEditionQuantity";
            this.textBoxEditionQuantity.Size = new System.Drawing.Size(297, 32);
            this.textBoxEditionQuantity.TabIndex = 2;
            this.textBoxEditionQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEditionQuantity_KeyPress);
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTittle.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelTittle.Location = new System.Drawing.Point(403, 112);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(102, 23);
            this.labelTittle.TabIndex = 15;
            this.labelTittle.Text = "Название";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.textBoxTitle.Location = new System.Drawing.Point(406, 136);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.MaxLength = 50;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(297, 32);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelBookCode
            // 
            this.labelBookCode.AutoSize = true;
            this.labelBookCode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookCode.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelBookCode.Location = new System.Drawing.Point(403, 44);
            this.labelBookCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBookCode.Name = "labelBookCode";
            this.labelBookCode.Size = new System.Drawing.Size(46, 23);
            this.labelBookCode.TabIndex = 16;
            this.labelBookCode.Text = "Код";
            // 
            // textBoxBookCode
            // 
            this.textBoxBookCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxBookCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBookCode.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookCode.Location = new System.Drawing.Point(406, 68);
            this.textBoxBookCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookCode.MaxLength = 15;
            this.textBoxBookCode.Name = "textBoxBookCode";
            this.textBoxBookCode.Size = new System.Drawing.Size(297, 32);
            this.textBoxBookCode.TabIndex = 0;
            this.textBoxBookCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBookCode_KeyPress);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonClose.Location = new System.Drawing.Point(1421, -2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 32);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxCostPrice
            // 
            this.textBoxCostPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxCostPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCostPrice.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.textBoxCostPrice.Location = new System.Drawing.Point(743, 68);
            this.textBoxCostPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCostPrice.MaxLength = 50;
            this.textBoxCostPrice.Name = "textBoxCostPrice";
            this.textBoxCostPrice.Size = new System.Drawing.Size(297, 32);
            this.textBoxCostPrice.TabIndex = 4;
            this.textBoxCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostPrice_KeyPress);
            // 
            // labelCostPrice
            // 
            this.labelCostPrice.AutoSize = true;
            this.labelCostPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostPrice.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelCostPrice.Location = new System.Drawing.Point(739, 44);
            this.labelCostPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCostPrice.Name = "labelCostPrice";
            this.labelCostPrice.Size = new System.Drawing.Size(165, 23);
            this.labelCostPrice.TabIndex = 16;
            this.labelCostPrice.Text = "Себестоимость";
            // 
            // textBoxSellingPrice
            // 
            this.textBoxSellingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSellingPrice.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.textBoxSellingPrice.Location = new System.Drawing.Point(743, 136);
            this.textBoxSellingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSellingPrice.MaxLength = 50;
            this.textBoxSellingPrice.Name = "textBoxSellingPrice";
            this.textBoxSellingPrice.Size = new System.Drawing.Size(297, 32);
            this.textBoxSellingPrice.TabIndex = 5;
            this.textBoxSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSellingPrice_KeyPress);
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoSize = true;
            this.labelSellingPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSellingPrice.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelSellingPrice.Location = new System.Drawing.Point(739, 112);
            this.labelSellingPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(60, 23);
            this.labelSellingPrice.TabIndex = 15;
            this.labelSellingPrice.Text = "Цена";
            // 
            // textBoxRoyalty
            // 
            this.textBoxRoyalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxRoyalty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoyalty.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.textBoxRoyalty.Location = new System.Drawing.Point(743, 206);
            this.textBoxRoyalty.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRoyalty.MaxLength = 50;
            this.textBoxRoyalty.Name = "textBoxRoyalty";
            this.textBoxRoyalty.Size = new System.Drawing.Size(297, 32);
            this.textBoxRoyalty.TabIndex = 6;
            this.textBoxRoyalty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRoyalty_KeyPress);
            // 
            // labelRoyalty
            // 
            this.labelRoyalty.AutoSize = true;
            this.labelRoyalty.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoyalty.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelRoyalty.Location = new System.Drawing.Point(739, 181);
            this.labelRoyalty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoyalty.Name = "labelRoyalty";
            this.labelRoyalty.Size = new System.Drawing.Size(374, 23);
            this.labelRoyalty.TabIndex = 14;
            this.labelRoyalty.Text = "Гонорар (фикс. сумма за одну книгу)";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenre.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(1121, 136);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(297, 33);
            this.comboBoxGenre.TabIndex = 8;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAuthor.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(1121, 68);
            this.comboBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(297, 33);
            this.comboBoxAuthor.TabIndex = 7;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelGenre.Location = new System.Drawing.Point(1118, 112);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(64, 23);
            this.labelGenre.TabIndex = 27;
            this.labelGenre.Text = "Жанр";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelAuthor.Location = new System.Drawing.Point(1118, 44);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(101, 23);
            this.labelAuthor.TabIndex = 26;
            this.labelAuthor.Text = "Писатель";
            // 
            // BookCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 517);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerPublicationDate);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPublicationDate);
            this.Controls.Add(this.labelRoyalty);
            this.Controls.Add(this.labelEditionQuantity);
            this.Controls.Add(this.textBoxRoyalty);
            this.Controls.Add(this.textBoxEditionQuantity);
            this.Controls.Add(this.labelSellingPrice);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.textBoxSellingPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelCostPrice);
            this.Controls.Add(this.textBoxCostPrice);
            this.Controls.Add(this.labelBookCode);
            this.Controls.Add(this.textBoxBookCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCardForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerPublicationDate;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPublicationDate;
        private System.Windows.Forms.Label labelEditionQuantity;
        private System.Windows.Forms.TextBox textBoxEditionQuantity;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelBookCode;
        private System.Windows.Forms.TextBox textBoxBookCode;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRoyalty;
        private System.Windows.Forms.TextBox textBoxRoyalty;
        private System.Windows.Forms.Label labelSellingPrice;
        private System.Windows.Forms.TextBox textBoxSellingPrice;
        private System.Windows.Forms.Label labelCostPrice;
        private System.Windows.Forms.TextBox textBoxCostPrice;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAuthor;
    }
}