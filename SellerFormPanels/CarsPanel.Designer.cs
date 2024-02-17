namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class CarsPanel
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
            this.samochodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchCarsTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CarsMenuPanel = new System.Windows.Forms.Panel();
            this.CarSortComboBox = new System.Windows.Forms.ComboBox();
            this.CarsGridView = new System.Windows.Forms.DataGridView();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typNadwoziaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mocSilnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typSilnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaPodstawowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.BodyComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.EngineComboBox = new System.Windows.Forms.ComboBox();
            this.CarBrandFilter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MinPriceTextBox = new System.Windows.Forms.TextBox();
            this.MaxPriceTextBox = new System.Windows.Forms.TextBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.MinPowerTextBox = new System.Windows.Forms.TextBox();
            this.MaxPowerTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DoorsComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CarsFilterPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CarsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CarsFilterPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.SearchCarsTextBox.Location = new System.Drawing.Point(47, 6);
            this.SearchCarsTextBox.Name = "SearchCarsTextBox";
            this.SearchCarsTextBox.Size = new System.Drawing.Size(249, 26);
            this.SearchCarsTextBox.TabIndex = 1;
            this.SearchCarsTextBox.TextChanged += new System.EventHandler(this.SearchCarsTextBox_TextChanged);
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
            // CarsMenuPanel
            // 
            this.CarsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CarsMenuPanel.Controls.Add(this.CarSortComboBox);
            this.CarsMenuPanel.Controls.Add(this.pictureBox2);
            this.CarsMenuPanel.Controls.Add(this.pictureBox1);
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
            this.CarSortComboBox.Location = new System.Drawing.Point(657, 6);
            this.CarSortComboBox.Name = "CarSortComboBox";
            this.CarSortComboBox.Size = new System.Drawing.Size(121, 21);
            this.CarSortComboBox.TabIndex = 26;
            this.CarSortComboBox.Text = "Sortowanie";
            this.CarSortComboBox.SelectedIndexChanged += new System.EventHandler(this.CarSortComboBox_SelectedIndexChanged);
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
            this.CarsGridView.Location = new System.Drawing.Point(0, 38);
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
            this.CarsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            this.CarsGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.CarsGridView.RowTemplate.Height = 36;
            this.CarsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CarsGridView.ShowCellToolTips = false;
            this.CarsGridView.ShowEditingIcon = false;
            this.CarsGridView.Size = new System.Drawing.Size(861, 490);
            this.CarsGridView.TabIndex = 12;
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
            this.mocSilnikaDataGridViewTextBoxColumn.Name = "mocSilnikaDataGridViewTextBoxColumn";
            this.mocSilnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mocSilnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.cenaPodstawowaDataGridViewTextBoxColumn.Name = "cenaPodstawowaDataGridViewTextBoxColumn";
            this.cenaPodstawowaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaPodstawowaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cenaPodstawowaDataGridViewTextBoxColumn.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarDealerSupportSystem.Properties.Resources.sliders;
            this.pictureBox1.Location = new System.Drawing.Point(802, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BrandComboBox.DataSource = this.samochodyBindingSource;
            this.BrandComboBox.DisplayMember = "Marka";
            this.BrandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BrandComboBox.ForeColor = System.Drawing.Color.White;
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(19, 20);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(104, 21);
            this.BrandComboBox.TabIndex = 1;
            this.BrandComboBox.ValueMember = "Marka";
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ModelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelComboBox.ForeColor = System.Drawing.Color.White;
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(141, 20);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(112, 21);
            this.ModelComboBox.TabIndex = 2;
            this.ModelComboBox.SelectedIndexChanged += new System.EventHandler(this.ModelComboBox_SelectedIndexChanged);
            // 
            // BodyComboBox
            // 
            this.BodyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BodyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BodyComboBox.ForeColor = System.Drawing.Color.White;
            this.BodyComboBox.FormattingEnabled = true;
            this.BodyComboBox.Location = new System.Drawing.Point(268, 20);
            this.BodyComboBox.Name = "BodyComboBox";
            this.BodyComboBox.Size = new System.Drawing.Size(109, 21);
            this.BodyComboBox.TabIndex = 3;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ColorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorComboBox.ForeColor = System.Drawing.Color.White;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(393, 20);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(100, 21);
            this.ColorComboBox.TabIndex = 4;
            // 
            // EngineComboBox
            // 
            this.EngineComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EngineComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EngineComboBox.ForeColor = System.Drawing.Color.White;
            this.EngineComboBox.FormattingEnabled = true;
            this.EngineComboBox.Location = new System.Drawing.Point(629, 20);
            this.EngineComboBox.Name = "EngineComboBox";
            this.EngineComboBox.Size = new System.Drawing.Size(98, 21);
            this.EngineComboBox.TabIndex = 6;
            // 
            // CarBrandFilter
            // 
            this.CarBrandFilter.AutoSize = true;
            this.CarBrandFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CarBrandFilter.ForeColor = System.Drawing.Color.White;
            this.CarBrandFilter.Location = new System.Drawing.Point(44, 0);
            this.CarBrandFilter.Name = "CarBrandFilter";
            this.CarBrandFilter.Size = new System.Drawing.Size(45, 17);
            this.CarBrandFilter.TabIndex = 7;
            this.CarBrandFilter.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kolor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Minimalna moc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(654, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Silnik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(277, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cena minimalna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(397, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cena maksymalna";
            // 
            // MinPriceTextBox
            // 
            this.MinPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MinPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MinPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.MinPriceTextBox.Location = new System.Drawing.Point(268, 73);
            this.MinPriceTextBox.Name = "MinPriceTextBox";
            this.MinPriceTextBox.Size = new System.Drawing.Size(109, 20);
            this.MinPriceTextBox.TabIndex = 16;
            // 
            // MaxPriceTextBox
            // 
            this.MaxPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MaxPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MaxPriceTextBox.ForeColor = System.Drawing.Color.White;
            this.MaxPriceTextBox.Location = new System.Drawing.Point(393, 73);
            this.MaxPriceTextBox.Name = "MaxPriceTextBox";
            this.MaxPriceTextBox.Size = new System.Drawing.Size(116, 20);
            this.MaxPriceTextBox.TabIndex = 17;
            // 
            // YearComboBox
            // 
            this.YearComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.YearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearComboBox.ForeColor = System.Drawing.Color.White;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(751, 20);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(91, 21);
            this.YearComboBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(771, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rocznik";
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ApplyButton.FlatAppearance.BorderSize = 0;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplyButton.ForeColor = System.Drawing.Color.White;
            this.ApplyButton.Location = new System.Drawing.Point(727, 63);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(122, 35);
            this.ApplyButton.TabIndex = 20;
            this.ApplyButton.Text = "Zastosuj";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // MinPowerTextBox
            // 
            this.MinPowerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MinPowerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinPowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MinPowerTextBox.ForeColor = System.Drawing.Color.White;
            this.MinPowerTextBox.Location = new System.Drawing.Point(19, 73);
            this.MinPowerTextBox.Name = "MinPowerTextBox";
            this.MinPowerTextBox.Size = new System.Drawing.Size(104, 20);
            this.MinPowerTextBox.TabIndex = 21;
            // 
            // MaxPowerTextBox
            // 
            this.MaxPowerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MaxPowerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxPowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MaxPowerTextBox.ForeColor = System.Drawing.Color.White;
            this.MaxPowerTextBox.Location = new System.Drawing.Point(141, 73);
            this.MaxPowerTextBox.Name = "MaxPowerTextBox";
            this.MaxPowerTextBox.Size = new System.Drawing.Size(112, 20);
            this.MaxPowerTextBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(144, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Maksymalna moc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nadwozie";
            // 
            // DoorsComboBox
            // 
            this.DoorsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DoorsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoorsComboBox.ForeColor = System.Drawing.Color.White;
            this.DoorsComboBox.FormattingEnabled = true;
            this.DoorsComboBox.Location = new System.Drawing.Point(509, 20);
            this.DoorsComboBox.Name = "DoorsComboBox";
            this.DoorsComboBox.Size = new System.Drawing.Size(98, 21);
            this.DoorsComboBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(517, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Liczba drzwi";
            // 
            // CarsFilterPanel
            // 
            this.CarsFilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CarsFilterPanel.Controls.Add(this.label10);
            this.CarsFilterPanel.Controls.Add(this.DoorsComboBox);
            this.CarsFilterPanel.Controls.Add(this.label2);
            this.CarsFilterPanel.Controls.Add(this.label9);
            this.CarsFilterPanel.Controls.Add(this.MaxPowerTextBox);
            this.CarsFilterPanel.Controls.Add(this.MinPowerTextBox);
            this.CarsFilterPanel.Controls.Add(this.ApplyButton);
            this.CarsFilterPanel.Controls.Add(this.label8);
            this.CarsFilterPanel.Controls.Add(this.YearComboBox);
            this.CarsFilterPanel.Controls.Add(this.MaxPriceTextBox);
            this.CarsFilterPanel.Controls.Add(this.MinPriceTextBox);
            this.CarsFilterPanel.Controls.Add(this.label7);
            this.CarsFilterPanel.Controls.Add(this.label6);
            this.CarsFilterPanel.Controls.Add(this.label5);
            this.CarsFilterPanel.Controls.Add(this.label4);
            this.CarsFilterPanel.Controls.Add(this.label3);
            this.CarsFilterPanel.Controls.Add(this.label1);
            this.CarsFilterPanel.Controls.Add(this.CarBrandFilter);
            this.CarsFilterPanel.Controls.Add(this.EngineComboBox);
            this.CarsFilterPanel.Controls.Add(this.ColorComboBox);
            this.CarsFilterPanel.Controls.Add(this.BodyComboBox);
            this.CarsFilterPanel.Controls.Add(this.ModelComboBox);
            this.CarsFilterPanel.Controls.Add(this.BrandComboBox);
            this.CarsFilterPanel.Location = new System.Drawing.Point(0, 38);
            this.CarsFilterPanel.Name = "CarsFilterPanel";
            this.CarsFilterPanel.Size = new System.Drawing.Size(861, 112);
            this.CarsFilterPanel.TabIndex = 3;
            this.CarsFilterPanel.Visible = false;
            this.CarsFilterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CarsFilterPanel_Paint);
            // 
            // CarsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.CarsFilterPanel);
            this.Controls.Add(this.CarsMenuPanel);
            this.Controls.Add(this.CarsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsPanel";
            this.Text = "CarsPanel";
            this.Load += new System.EventHandler(this.CarsPanel_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CarsMenuPanel.ResumeLayout(false);
            this.CarsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CarsFilterPanel.ResumeLayout(false);
            this.CarsFilterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource samochodyBindingSource;
        private System.Windows.Forms.TextBox SearchCarsTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel CarsMenuPanel;
        private System.Windows.Forms.ComboBox CarSortComboBox;
        private System.Windows.Forms.DataGridView CarsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typNadwoziaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mocSilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typSilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaPodstawowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.ComboBox BodyComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.ComboBox EngineComboBox;
        private System.Windows.Forms.Label CarBrandFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MinPriceTextBox;
        private System.Windows.Forms.TextBox MaxPriceTextBox;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox MinPowerTextBox;
        private System.Windows.Forms.TextBox MaxPowerTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DoorsComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel CarsFilterPanel;
    }
}