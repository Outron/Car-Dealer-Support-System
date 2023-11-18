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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CarsFilterPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarBrandFilter = new System.Windows.Forms.Label();
            this.EngineComboBox = new System.Windows.Forms.ComboBox();
            this.PowerComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.BodyComboBox = new System.Windows.Forms.ComboBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            this.CarsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CarsFilterPanel.SuspendLayout();
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
            this.CarsGridView.Location = new System.Drawing.Point(0, 45);
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
            this.CarsGridView.Size = new System.Drawing.Size(865, 485);
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
            this.SearchCarsTextBox.Location = new System.Drawing.Point(35, 6);
            this.SearchCarsTextBox.Name = "SearchCarsTextBox";
            this.SearchCarsTextBox.Size = new System.Drawing.Size(251, 26);
            this.SearchCarsTextBox.TabIndex = 1;
            this.SearchCarsTextBox.Text = "Search";
            this.SearchCarsTextBox.TextChanged += new System.EventHandler(this.SearchCarsTextBox_TextChanged);
            // 
            // CarsMenuPanel
            // 
            this.CarsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CarsMenuPanel.Controls.Add(this.pictureBox1);
            this.CarsMenuPanel.Controls.Add(this.SearchCarsTextBox);
            this.CarsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CarsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.CarsMenuPanel.Name = "CarsMenuPanel";
            this.CarsMenuPanel.Size = new System.Drawing.Size(845, 39);
            this.CarsMenuPanel.TabIndex = 2;
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
            // CarsFilterPanel
            // 
            this.CarsFilterPanel.Controls.Add(this.label6);
            this.CarsFilterPanel.Controls.Add(this.label5);
            this.CarsFilterPanel.Controls.Add(this.label4);
            this.CarsFilterPanel.Controls.Add(this.label3);
            this.CarsFilterPanel.Controls.Add(this.label2);
            this.CarsFilterPanel.Controls.Add(this.label1);
            this.CarsFilterPanel.Controls.Add(this.CarBrandFilter);
            this.CarsFilterPanel.Controls.Add(this.EngineComboBox);
            this.CarsFilterPanel.Controls.Add(this.PowerComboBox);
            this.CarsFilterPanel.Controls.Add(this.ColorComboBox);
            this.CarsFilterPanel.Controls.Add(this.BodyComboBox);
            this.CarsFilterPanel.Controls.Add(this.ModelComboBox);
            this.CarsFilterPanel.Controls.Add(this.BrandComboBox);
            this.CarsFilterPanel.Controls.Add(this.PriceComboBox);
            this.CarsFilterPanel.Location = new System.Drawing.Point(0, 100);
            this.CarsFilterPanel.Name = "CarsFilterPanel";
            this.CarsFilterPanel.Size = new System.Drawing.Size(845, 133);
            this.CarsFilterPanel.TabIndex = 3;
            this.CarsFilterPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(775, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(663, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Silnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(546, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Moc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kolor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nadwozie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Model";
            // 
            // CarBrandFilter
            // 
            this.CarBrandFilter.AutoSize = true;
            this.CarBrandFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CarBrandFilter.ForeColor = System.Drawing.Color.White;
            this.CarBrandFilter.Location = new System.Drawing.Point(43, 9);
            this.CarBrandFilter.Name = "CarBrandFilter";
            this.CarBrandFilter.Size = new System.Drawing.Size(45, 17);
            this.CarBrandFilter.TabIndex = 7;
            this.CarBrandFilter.Text = "Marka";
            // 
            // EngineComboBox
            // 
            this.EngineComboBox.FormattingEnabled = true;
            this.EngineComboBox.Location = new System.Drawing.Point(624, 29);
            this.EngineComboBox.Name = "EngineComboBox";
            this.EngineComboBox.Size = new System.Drawing.Size(121, 21);
            this.EngineComboBox.TabIndex = 6;
            // 
            // PowerComboBox
            // 
            this.PowerComboBox.FormattingEnabled = true;
            this.PowerComboBox.Location = new System.Drawing.Point(522, 29);
            this.PowerComboBox.Name = "PowerComboBox";
            this.PowerComboBox.Size = new System.Drawing.Size(85, 21);
            this.PowerComboBox.TabIndex = 5;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(381, 29);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(108, 21);
            this.ColorComboBox.TabIndex = 4;
            // 
            // BodyComboBox
            // 
            this.BodyComboBox.FormattingEnabled = true;
            this.BodyComboBox.Location = new System.Drawing.Point(261, 29);
            this.BodyComboBox.Name = "BodyComboBox";
            this.BodyComboBox.Size = new System.Drawing.Size(103, 21);
            this.BodyComboBox.TabIndex = 3;
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(134, 29);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(112, 21);
            this.ModelComboBox.TabIndex = 2;
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.DataSource = this.samochodyBindingSource;
            this.BrandComboBox.DisplayMember = "Marka";
            this.BrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(12, 29);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(104, 21);
            this.BrandComboBox.TabIndex = 1;
            this.BrandComboBox.ValueMember = "Marka";
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "Cena rosnąco",
            "Cena malejąco"});
            this.PriceComboBox.Location = new System.Drawing.Point(762, 29);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(80, 21);
            this.PriceComboBox.TabIndex = 0;
            // 
            // CarsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(845, 530);
            this.Controls.Add(this.CarsFilterPanel);
            this.Controls.Add(this.CarsMenuPanel);
            this.Controls.Add(this.CarsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsPanel";
            this.Text = "CarsPanel";
            this.Load += new System.EventHandler(this.CarsPanel_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            this.CarsMenuPanel.ResumeLayout(false);
            this.CarsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CarsFilterPanel.ResumeLayout(false);
            this.CarsFilterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource samochodyBindingSource;
        private System.Windows.Forms.DataGridView CarsGridView;
        private System.Windows.Forms.TextBox SearchCarsTextBox;
        private System.Windows.Forms.Panel CarsMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CarsFilterPanel;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typNadwoziaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mocSilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typSilnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaPodstawowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox BodyComboBox;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox EngineComboBox;
        private System.Windows.Forms.ComboBox PowerComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label CarBrandFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}