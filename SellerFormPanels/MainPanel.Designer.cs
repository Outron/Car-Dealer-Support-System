namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class MainPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.LastOrdersGrid = new System.Windows.Forms.DataGridView();
            this.IdKlienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajPlatnosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LastOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(104, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj zamówienie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.Location = new System.Drawing.Point(765, 36);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeftLayout = true;
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Gray;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ostatnie zamówienia";
            // 
            // LastOrdersGrid
            // 
            this.LastOrdersGrid.AllowUserToAddRows = false;
            this.LastOrdersGrid.AllowUserToDeleteRows = false;
            this.LastOrdersGrid.AllowUserToResizeColumns = false;
            this.LastOrdersGrid.AllowUserToResizeRows = false;
            this.LastOrdersGrid.AutoGenerateColumns = false;
            this.LastOrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LastOrdersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LastOrdersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastOrdersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LastOrdersGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.LastOrdersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LastOrdersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LastOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LastOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKlienta,
            this.idZamowieniaDataGridViewTextBoxColumn,
            this.rodzajPlatnosciDataGridViewTextBoxColumn,
            this.Column1,
            this.Data,
            this.statusDataGridViewTextBoxColumn});
            this.LastOrdersGrid.DataSource = this.zamowieniaBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LastOrdersGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.LastOrdersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LastOrdersGrid.EnableHeadersVisualStyles = false;
            this.LastOrdersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LastOrdersGrid.Location = new System.Drawing.Point(0, 328);
            this.LastOrdersGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastOrdersGrid.MultiSelect = false;
            this.LastOrdersGrid.Name = "LastOrdersGrid";
            this.LastOrdersGrid.ReadOnly = true;
            this.LastOrdersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Transparent;
            this.LastOrdersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.LastOrdersGrid.RowHeadersVisible = false;
            this.LastOrdersGrid.RowHeadersWidth = 51;
            this.LastOrdersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            this.LastOrdersGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.LastOrdersGrid.RowTemplate.Height = 36;
            this.LastOrdersGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastOrdersGrid.ShowCellToolTips = false;
            this.LastOrdersGrid.ShowEditingIcon = false;
            this.LastOrdersGrid.Size = new System.Drawing.Size(1148, 324);
            this.LastOrdersGrid.TabIndex = 6;
            this.LastOrdersGrid.SelectionChanged += new System.EventHandler(this.LastOrdersGrid_SelectionChanged);
            // 
            // IdKlienta
            // 
            this.IdKlienta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdKlienta.DataPropertyName = "IdKlienta";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.IdKlienta.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdKlienta.HeaderText = "IDk";
            this.IdKlienta.MinimumWidth = 6;
            this.IdKlienta.Name = "IdKlienta";
            this.IdKlienta.ReadOnly = true;
            this.IdKlienta.Width = 104;
            // 
            // idZamowieniaDataGridViewTextBoxColumn
            // 
            this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "IdZamowienia";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.idZamowieniaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "IDz";
            this.idZamowieniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
            this.idZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodzajPlatnosciDataGridViewTextBoxColumn
            // 
            this.rodzajPlatnosciDataGridViewTextBoxColumn.DataPropertyName = "RodzajPlatnosci";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.rodzajPlatnosciDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.rodzajPlatnosciDataGridViewTextBoxColumn.HeaderText = "Płatność";
            this.rodzajPlatnosciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rodzajPlatnosciDataGridViewTextBoxColumn.Name = "rodzajPlatnosciDataGridViewTextBoxColumn";
            this.rodzajPlatnosciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CalkowityKoszt";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Koszt";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.Data.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zamowieniaBindingSource1
            // 
            this.zamowieniaBindingSource1.DataSource = typeof(CarDealerSupportSystem.Models.Zamowienia);
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Zamowienia);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1148, 652);
            this.Controls.Add(this.LastOrdersGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPanel";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LastOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private System.Windows.Forms.DataGridView LastOrdersGrid;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajPlatnosciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}