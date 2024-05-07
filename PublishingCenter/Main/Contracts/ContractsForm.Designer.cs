namespace PublishingCenter.Main.Contracts
{
    partial class ContractsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractsForm));
            this.dataGridViewContracts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnConclusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContractPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTerminationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContracts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewContracts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewContracts.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContracts.ColumnHeadersHeight = 40;
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnAuthor,
            this.ColumnConclusionDate,
            this.ColumnContractPeriod,
            this.ColumnStatus,
            this.ColumnTerminationDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContracts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewContracts.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.RowHeadersVisible = false;
            this.dataGridViewContracts.RowHeadersWidth = 51;
            this.dataGridViewContracts.RowTemplate.Height = 24;
            this.dataGridViewContracts.Size = new System.Drawing.Size(797, 421);
            this.dataGridViewContracts.TabIndex = 1;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewContracts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewContracts.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewContracts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewContracts.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewContracts.ThemeStyle.ReadOnly = false;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewContracts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewContracts.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewContracts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewContracts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewContracts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContracts_CellContentClick);
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
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить контракт";
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
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnId.Width = 63;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnAuthor.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnAuthor.FillWeight = 503.7433F;
            this.ColumnAuthor.HeaderText = "Писатель";
            this.ColumnAuthor.MinimumWidth = 6;
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAuthor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnAuthor.Width = 200;
            // 
            // ColumnConclusionDate
            // 
            this.ColumnConclusionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnConclusionDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnConclusionDate.FillWeight = 19.25134F;
            this.ColumnConclusionDate.HeaderText = "Дата заключения";
            this.ColumnConclusionDate.MinimumWidth = 6;
            this.ColumnConclusionDate.Name = "ColumnConclusionDate";
            this.ColumnConclusionDate.Width = 200;
            // 
            // ColumnContractPeriod
            // 
            this.ColumnContractPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnContractPeriod.FillWeight = 19.25134F;
            this.ColumnContractPeriod.HeaderText = "Срок";
            this.ColumnContractPeriod.MinimumWidth = 6;
            this.ColumnContractPeriod.Name = "ColumnContractPeriod";
            this.ColumnContractPeriod.Width = 200;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnStatus.FillWeight = 19.25134F;
            this.ColumnStatus.HeaderText = "Статус";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStatus.Width = 200;
            // 
            // ColumnTerminationDate
            // 
            this.ColumnTerminationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnTerminationDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnTerminationDate.FillWeight = 19.25134F;
            this.ColumnTerminationDate.HeaderText = "Дата расторжения";
            this.ColumnTerminationDate.MinimumWidth = 6;
            this.ColumnTerminationDate.Name = "ColumnTerminationDate";
            this.ColumnTerminationDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTerminationDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTerminationDate.Width = 200;
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 462);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewContracts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContractsForm";
            this.Text = "ContractsForm";
            this.Load += new System.EventHandler(this.ContractsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewContracts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnId;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConclusionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContractPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTerminationDate;
    }
}