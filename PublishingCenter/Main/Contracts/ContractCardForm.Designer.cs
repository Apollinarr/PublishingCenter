namespace PublishingCenter.Main.Contracts
{
    partial class ContractCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractCardForm));
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelContractPeriod = new System.Windows.Forms.Label();
            this.labelConclusionDate = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTerminationDate = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerTerminationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerConclusionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comboBoxContractPeriod = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelAuthor.Location = new System.Drawing.Point(416, 44);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(101, 23);
            this.labelAuthor.TabIndex = 11;
            this.labelAuthor.Text = "Писатель";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelStatus.Location = new System.Drawing.Point(776, 44);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 23);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Статус";
            // 
            // labelContractPeriod
            // 
            this.labelContractPeriod.AutoSize = true;
            this.labelContractPeriod.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractPeriod.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelContractPeriod.Location = new System.Drawing.Point(416, 246);
            this.labelContractPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContractPeriod.Name = "labelContractPeriod";
            this.labelContractPeriod.Size = new System.Drawing.Size(60, 23);
            this.labelContractPeriod.TabIndex = 16;
            this.labelContractPeriod.Text = "Срок";
            // 
            // labelConclusionDate
            // 
            this.labelConclusionDate.AutoSize = true;
            this.labelConclusionDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConclusionDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelConclusionDate.Location = new System.Drawing.Point(416, 147);
            this.labelConclusionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConclusionDate.Name = "labelConclusionDate";
            this.labelConclusionDate.Size = new System.Drawing.Size(179, 23);
            this.labelConclusionDate.TabIndex = 17;
            this.labelConclusionDate.Text = "Дата заключения";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonClose.Location = new System.Drawing.Point(1124, -2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 32);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(40, 416);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(144, 49);
            this.buttonUpdate.TabIndex = 19;
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
            this.buttonDelete.Location = new System.Drawing.Point(263, 416);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 49);
            this.buttonDelete.TabIndex = 20;
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
            this.buttonAdd.Location = new System.Drawing.Point(40, 416);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 49);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTerminationDate
            // 
            this.labelTerminationDate.AutoSize = true;
            this.labelTerminationDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTerminationDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelTerminationDate.Location = new System.Drawing.Point(776, 147);
            this.labelTerminationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTerminationDate.Name = "labelTerminationDate";
            this.labelTerminationDate.Size = new System.Drawing.Size(198, 23);
            this.labelTerminationDate.TabIndex = 15;
            this.labelTerminationDate.Text = "Дата расторжения";
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
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerTerminationDate
            // 
            this.dateTimePickerTerminationDate.Checked = true;
            this.dateTimePickerTerminationDate.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerTerminationDate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerTerminationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerTerminationDate.Location = new System.Drawing.Point(780, 180);
            this.dateTimePickerTerminationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTerminationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTerminationDate.Name = "dateTimePickerTerminationDate";
            this.dateTimePickerTerminationDate.Size = new System.Drawing.Size(297, 36);
            this.dateTimePickerTerminationDate.TabIndex = 23;
            this.dateTimePickerTerminationDate.Value = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAuthor.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(420, 76);
            this.comboBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(297, 40);
            this.comboBoxAuthor.TabIndex = 25;
            // 
            // dateTimePickerConclusionDate
            // 
            this.dateTimePickerConclusionDate.Checked = true;
            this.dateTimePickerConclusionDate.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerConclusionDate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerConclusionDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerConclusionDate.Location = new System.Drawing.Point(420, 179);
            this.dateTimePickerConclusionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerConclusionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerConclusionDate.Name = "dateTimePickerConclusionDate";
            this.dateTimePickerConclusionDate.Size = new System.Drawing.Size(297, 36);
            this.dateTimePickerConclusionDate.TabIndex = 23;
            this.dateTimePickerConclusionDate.Value = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            // 
            // comboBoxContractPeriod
            // 
            this.comboBoxContractPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxContractPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxContractPeriod.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.comboBoxContractPeriod.FormattingEnabled = true;
            this.comboBoxContractPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxContractPeriod.Location = new System.Drawing.Point(420, 278);
            this.comboBoxContractPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxContractPeriod.Name = "comboBoxContractPeriod";
            this.comboBoxContractPeriod.Size = new System.Drawing.Size(297, 40);
            this.comboBoxContractPeriod.TabIndex = 25;
            this.comboBoxContractPeriod.SelectedValueChanged += new System.EventHandler(this.comboBoxContractPeriod_SelectedValueChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Заключен",
            "Продлен",
            "Расторжен"});
            this.comboBoxStatus.Location = new System.Drawing.Point(780, 76);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(297, 40);
            this.comboBoxStatus.TabIndex = 25;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpdate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelUpdate.Location = new System.Drawing.Point(775, 256);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(181, 23);
            this.labelUpdate.TabIndex = 27;
            this.labelUpdate.Text = "Продлить на (лет)";
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUpdate.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpdate.Location = new System.Drawing.Point(780, 286);
            this.textBoxUpdate.MaxLength = 1;
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(297, 32);
            this.textBoxUpdate.TabIndex = 26;
            this.textBoxUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUpdate_KeyPress);
            // 
            // ContractCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 532);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.textBoxUpdate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxContractPeriod);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.dateTimePickerConclusionDate);
            this.Controls.Add(this.dateTimePickerTerminationDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelTerminationDate);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelContractPeriod);
            this.Controls.Add(this.labelConclusionDate);
            this.Controls.Add(this.labelAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContractCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractCardForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelContractPeriod;
        private System.Windows.Forms.Label labelConclusionDate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelTerminationDate;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerTerminationDate;
        private System.Windows.Forms.ComboBox comboBoxContractPeriod;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerConclusionDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.TextBox textBoxUpdate;
    }
}