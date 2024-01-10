namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class AdmMainPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CarsGridView = new System.Windows.Forms.DataGridView();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typNadwoziaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mocSilnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typSilnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaPodstawowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samochodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchCarsTextBox = new System.Windows.Forms.TextBox();
            this.CarsMenuPanel = new System.Windows.Forms.Panel();
            this.CarSortComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            this.CarsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.typNadwoziaDataGridViewTextBoxColumn,
            this.kolorDataGridViewTextBoxColumn,
            this.mocSilnikaDataGridViewTextBoxColumn,
            this.typSilnikaDataGridViewTextBoxColumn,
            this.cenaPodstawowaDataGridViewTextBoxColumn});
            this.CarsGridView.DataSource = this.samochodyBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarsGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.CarsGridView.EnableHeadersVisualStyles = false;
            this.CarsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CarsGridView.Location = new System.Drawing.Point(0, 48);
            this.CarsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CarsGridView.MultiSelect = false;
            this.CarsGridView.Name = "CarsGridView";
            this.CarsGridView.ReadOnly = true;
            this.CarsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Transparent;
            this.CarsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.CarsGridView.RowHeadersVisible = false;
            this.CarsGridView.RowHeadersWidth = 51;
            this.CarsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            this.CarsGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.CarsGridView.RowTemplate.Height = 36;
            this.CarsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CarsGridView.ShowCellToolTips = false;
            this.CarsGridView.ShowEditingIcon = false;
            this.CarsGridView.Size = new System.Drawing.Size(1148, 604);
            this.CarsGridView.TabIndex = 0;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.markaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.markaDataGridViewTextBoxColumn.FillWeight = 156.1083F;
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            this.markaDataGridViewTextBoxColumn.Width = 120;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.modelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.modelDataGridViewTextBoxColumn.FillWeight = 137.8736F;
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // typNadwoziaDataGridViewTextBoxColumn
            // 
            this.typNadwoziaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typNadwoziaDataGridViewTextBoxColumn.DataPropertyName = "TypNadwozia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.typNadwoziaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.typNadwoziaDataGridViewTextBoxColumn.FillWeight = 112.4991F;
            this.typNadwoziaDataGridViewTextBoxColumn.HeaderText = "Nadwozie";
            this.typNadwoziaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typNadwoziaDataGridViewTextBoxColumn.Name = "typNadwoziaDataGridViewTextBoxColumn";
            this.typNadwoziaDataGridViewTextBoxColumn.ReadOnly = true;
            this.typNadwoziaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kolorDataGridViewTextBoxColumn
            // 
            this.kolorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kolorDataGridViewTextBoxColumn.DataPropertyName = "Kolor";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.kolorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.kolorDataGridViewTextBoxColumn.FillWeight = 74.08795F;
            this.kolorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            this.kolorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolorDataGridViewTextBoxColumn.Name = "kolorDataGridViewTextBoxColumn";
            this.kolorDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kolorDataGridViewTextBoxColumn.Width = 120;
            // 
            // mocSilnikaDataGridViewTextBoxColumn
            // 
            this.mocSilnikaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mocSilnikaDataGridViewTextBoxColumn.DataPropertyName = "MocSilnika";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.mocSilnikaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.mocSilnikaDataGridViewTextBoxColumn.FillWeight = 53.2995F;
            this.mocSilnikaDataGridViewTextBoxColumn.HeaderText = "Moc";
            this.mocSilnikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mocSilnikaDataGridViewTextBoxColumn.Name = "mocSilnikaDataGridViewTextBoxColumn";
            this.mocSilnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mocSilnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mocSilnikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // typSilnikaDataGridViewTextBoxColumn
            // 
            this.typSilnikaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typSilnikaDataGridViewTextBoxColumn.DataPropertyName = "TypSilnika";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.typSilnikaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.typSilnikaDataGridViewTextBoxColumn.FillWeight = 83.06579F;
            this.typSilnikaDataGridViewTextBoxColumn.HeaderText = "Silnik";
            this.typSilnikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typSilnikaDataGridViewTextBoxColumn.Name = "typSilnikaDataGridViewTextBoxColumn";
            this.typSilnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.typSilnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typSilnikaDataGridViewTextBoxColumn.Width = 120;
            // 
            // cenaPodstawowaDataGridViewTextBoxColumn
            // 
            this.cenaPodstawowaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cenaPodstawowaDataGridViewTextBoxColumn.DataPropertyName = "CenaPodstawowa";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.cenaPodstawowaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.cenaPodstawowaDataGridViewTextBoxColumn.FillWeight = 83.06579F;
            this.cenaPodstawowaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaPodstawowaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaPodstawowaDataGridViewTextBoxColumn.Name = "cenaPodstawowaDataGridViewTextBoxColumn";
            this.cenaPodstawowaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaPodstawowaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cenaPodstawowaDataGridViewTextBoxColumn.Width = 120;
            // 
            // samochodyBindingSource
            // 
            this.samochodyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Samochody);
            // 
            // SearchCarsTextBox
            // 
            this.SearchCarsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.SearchCarsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchCarsTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchCarsTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchCarsTextBox.Location = new System.Drawing.Point(63, 7);
            this.SearchCarsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCarsTextBox.Name = "SearchCarsTextBox";
            this.SearchCarsTextBox.Size = new System.Drawing.Size(332, 32);
            this.SearchCarsTextBox.TabIndex = 1;
            // 
            // CarsMenuPanel
            // 
            this.CarsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CarsMenuPanel.Controls.Add(this.CarSortComboBox);
            this.CarsMenuPanel.Controls.Add(this.pictureBox2);
            this.CarsMenuPanel.Controls.Add(this.pictureBox1);
            this.CarsMenuPanel.Controls.Add(this.SearchCarsTextBox);
            this.CarsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.CarsMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CarsMenuPanel.Name = "CarsMenuPanel";
            this.CarsMenuPanel.Size = new System.Drawing.Size(1148, 48);
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
            this.CarSortComboBox.Location = new System.Drawing.Point(876, 7);
            this.CarSortComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CarSortComboBox.Name = "CarSortComboBox";
            this.CarSortComboBox.Size = new System.Drawing.Size(160, 24);
            this.CarSortComboBox.TabIndex = 26;
            this.CarSortComboBox.Text = "Sortowanie";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarDealerSupportSystem.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(5, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarDealerSupportSystem.Properties.Resources.sliders;
            this.pictureBox1.Location = new System.Drawing.Point(1069, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(381, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nadwozie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // AdmMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1148, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarsMenuPanel);
            this.Controls.Add(this.CarsGridView);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdmMainPanel";
            this.Text = "CarsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            this.CarsMenuPanel.ResumeLayout(false);
            this.CarsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource samochodyBindingSource;
        private System.Windows.Forms.DataGridView CarsGridView;
        private System.Windows.Forms.TextBox SearchCarsTextBox;
        private System.Windows.Forms.Panel CarsMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typNadwoziaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mocSilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typSilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaPodstawowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CarSortComboBox;
        private System.Windows.Forms.Label label1;
    }
}