namespace CarDealerSupportSystem.ManagerFormPanels
{
    partial class CarsManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchCarsTextBox = new System.Windows.Forms.TextBox();
            this.CarsMenuPanel = new System.Windows.Forms.Panel();
            this.CarSortComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CarsGridView = new System.Windows.Forms.DataGridView();
            this.IdSamochodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZdjecieColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DostepnyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typNadwoziaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaPodstawowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samochodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchCarsTextBox
            // 
            this.SearchCarsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.SearchCarsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchCarsTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchCarsTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchCarsTextBox.Location = new System.Drawing.Point(47, 6);
            this.SearchCarsTextBox.Name = "SearchCarsTextBox";
            this.SearchCarsTextBox.Size = new System.Drawing.Size(249, 26);
            this.SearchCarsTextBox.TabIndex = 1;
            this.SearchCarsTextBox.TextChanged += new System.EventHandler(this.SearchCarsTextBox_TextChanged);
            // 
            // CarsMenuPanel
            // 
            this.CarsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CarsMenuPanel.Controls.Add(this.CarSortComboBox);
            this.CarsMenuPanel.Controls.Add(this.pictureBox2);
            this.CarsMenuPanel.Controls.Add(this.SearchCarsTextBox);
            this.CarsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.CarsMenuPanel.Name = "CarsMenuPanel";
            this.CarsMenuPanel.Size = new System.Drawing.Size(861, 39);
            this.CarsMenuPanel.TabIndex = 2;
            // 
            // CarSortComboBox
            // 
            this.CarSortComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CarSortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarSortComboBox.ForeColor = System.Drawing.Color.White;
            this.CarSortComboBox.Items.AddRange(new object[] {
            "Cena malejąco",
            "Cena rosnąco"});
            this.CarSortComboBox.Location = new System.Drawing.Point(666, 11);
            this.CarSortComboBox.Name = "CarSortComboBox";
            this.CarSortComboBox.Size = new System.Drawing.Size(118, 21);
            this.CarSortComboBox.TabIndex = 26;
            this.CarSortComboBox.Text = "Sortowanie";
            this.CarSortComboBox.SelectedIndexChanged += new System.EventHandler(this.CarSortComboBox_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarDealerSupportSystem.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // CarsGridView
            // 
            this.CarsGridView.AllowUserToAddRows = false;
            this.CarsGridView.AllowUserToDeleteRows = false;
            this.CarsGridView.AllowUserToResizeColumns = false;
            this.CarsGridView.AllowUserToResizeRows = false;
            this.CarsGridView.AutoGenerateColumns = false;
            this.CarsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CarsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.CarsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CarsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSamochodColumn,
            this.ZdjecieColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.typNadwoziaDataGridViewTextBoxColumn,
            this.kolorDataGridViewTextBoxColumn,
            this.cenaPodstawowaDataGridViewTextBoxColumn,
            this.DostepnyColumn});
            this.CarsGridView.DataSource = this.samochodyBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarsGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.CarsGridView.EnableHeadersVisualStyles = false;
            this.CarsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CarsGridView.Location = new System.Drawing.Point(0, 108);
            this.CarsGridView.MultiSelect = false;
            this.CarsGridView.Name = "CarsGridView";
            this.CarsGridView.ReadOnly = true;
            this.CarsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Transparent;
            this.CarsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CarsGridView.RowHeadersVisible = false;
            this.CarsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            this.CarsGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.CarsGridView.RowTemplate.Height = 36;
            this.CarsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CarsGridView.ShowCellToolTips = false;
            this.CarsGridView.ShowEditingIcon = false;
            this.CarsGridView.Size = new System.Drawing.Size(861, 422);
            this.CarsGridView.TabIndex = 0;
            this.CarsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsGridView_CellClick);
            this.CarsGridView.SelectionChanged += new System.EventHandler(this.CarsGridView_SelectionChanged);
            // 
            // IdSamochodColumn
            // 
            this.IdSamochodColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdSamochodColumn.DataPropertyName = "IdSamochodu";
            this.IdSamochodColumn.HeaderText = "Id";
            this.IdSamochodColumn.Name = "IdSamochodColumn";
            this.IdSamochodColumn.ReadOnly = true;
            this.IdSamochodColumn.Width = 77;
            // 
            // ZdjecieColumn
            // 
            this.ZdjecieColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZdjecieColumn.DataPropertyName = "Zdjecie";
            this.ZdjecieColumn.HeaderText = "Zdjecie";
            this.ZdjecieColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ZdjecieColumn.Name = "ZdjecieColumn";
            this.ZdjecieColumn.ReadOnly = true;
            // 
            // DostepnyColumn
            // 
            this.DostepnyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DostepnyColumn.DataPropertyName = "Dostepnosc";
            this.DostepnyColumn.HeaderText = "Dostepnosc";
            this.DostepnyColumn.Name = "DostepnyColumn";
            this.DostepnyColumn.ReadOnly = true;
            this.DostepnyColumn.Width = 163;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Silver;
            this.AddButton.BackgroundImage = global::CarDealerSupportSystem.Properties.Resources.plus;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(37, 53);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(776, 39);
            this.AddButton.TabIndex = 13;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.markaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            this.markaDataGridViewTextBoxColumn.Width = 115;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.modelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modelDataGridViewTextBoxColumn.Width = 117;
            // 
            // typNadwoziaDataGridViewTextBoxColumn
            // 
            this.typNadwoziaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typNadwoziaDataGridViewTextBoxColumn.DataPropertyName = "TypNadwozia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.typNadwoziaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.typNadwoziaDataGridViewTextBoxColumn.HeaderText = "Nadwozie";
            this.typNadwoziaDataGridViewTextBoxColumn.Name = "typNadwoziaDataGridViewTextBoxColumn";
            this.typNadwoziaDataGridViewTextBoxColumn.ReadOnly = true;
            this.typNadwoziaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typNadwoziaDataGridViewTextBoxColumn.Width = 147;
            // 
            // kolorDataGridViewTextBoxColumn
            // 
            this.kolorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kolorDataGridViewTextBoxColumn.DataPropertyName = "Kolor";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.kolorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.kolorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            this.kolorDataGridViewTextBoxColumn.Name = "kolorDataGridViewTextBoxColumn";
            this.kolorDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kolorDataGridViewTextBoxColumn.Width = 108;
            // 
            // cenaPodstawowaDataGridViewTextBoxColumn
            // 
            this.cenaPodstawowaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cenaPodstawowaDataGridViewTextBoxColumn.DataPropertyName = "CenaPodstawowa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.cenaPodstawowaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.cenaPodstawowaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaPodstawowaDataGridViewTextBoxColumn.Name = "cenaPodstawowaDataGridViewTextBoxColumn";
            this.cenaPodstawowaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaPodstawowaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cenaPodstawowaDataGridViewTextBoxColumn.Width = 103;
            // 
            // samochodyBindingSource
            // 
            this.samochodyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Samochody);
            // 
            // CarsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CarsMenuPanel);
            this.Controls.Add(this.CarsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsManager";
            this.Text = "CarsManager";
            this.Load += new System.EventHandler(this.CarsManager_Load);
            this.CarsMenuPanel.ResumeLayout(false);
            this.CarsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource samochodyBindingSource;
        private System.Windows.Forms.TextBox SearchCarsTextBox;
        private System.Windows.Forms.Panel CarsMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CarSortComboBox;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.DataGridView CarsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSamochodColumn;
        private System.Windows.Forms.DataGridViewImageColumn ZdjecieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typNadwoziaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaPodstawowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DostepnyColumn;
    }
}