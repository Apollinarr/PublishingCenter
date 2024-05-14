namespace PublishingCenter.Main.reports
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.dataGridViewReports = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnReport = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToResizeColumns = false;
            this.dataGridViewReports.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewReports.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReports.ColumnHeadersHeight = 40;
            this.dataGridViewReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnReport});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReports.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReports.Location = new System.Drawing.Point(15, 14);
            this.dataGridViewReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersVisible = false;
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewReports.RowTemplate.Height = 24;
            this.dataGridViewReports.Size = new System.Drawing.Size(851, 518);
            this.dataGridViewReports.TabIndex = 1;
            this.dataGridViewReports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReports.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewReports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewReports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewReports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewReports.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewReports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewReports.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewReports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewReports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewReports.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewReports.ThemeStyle.ReadOnly = false;
            this.dataGridViewReports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReports.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewReports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReports.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewReports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReports_CellContentClick);
            // 
            // ColumnReport
            // 
            this.ColumnReport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnReport.FillWeight = 503.7433F;
            this.ColumnReport.HeaderText = "Отчет";
            this.ColumnReport.MinimumWidth = 6;
            this.ColumnReport.Name = "ColumnReport";
            this.ColumnReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnReport.Width = 600;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Checked = true;
            this.dateTimePickerStart.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerStart.Location = new System.Drawing.Point(973, 58);
            this.dateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(297, 36);
            this.dateTimePickerStart.TabIndex = 6;
            this.dateTimePickerStart.Value = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelStartDate.Location = new System.Drawing.Point(968, 26);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(82, 23);
            this.labelStartDate.TabIndex = 7;
            this.labelStartDate.Text = "Начало";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Checked = true;
            this.dateTimePickerEnd.FillColor = System.Drawing.Color.MediumPurple;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(973, 251);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(297, 36);
            this.dateTimePickerEnd.TabIndex = 8;
            this.dateTimePickerEnd.Value = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelEndDate.Location = new System.Drawing.Point(968, 219);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(70, 23);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "Конец";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 554);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.dataGridViewReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewReports;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnReport;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEndDate;
    }
}