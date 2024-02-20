using System.Windows.Forms;

namespace CarDealerSupportSystem.ManagerFormPanels
{
    partial class Statistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.StatisticsRightPanel = new System.Windows.Forms.Panel();
            this.BestCarGridView = new System.Windows.Forms.DataGridView();
            this.IleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsLeftPanel = new System.Windows.Forms.Panel();
            this.BestShopGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt1UpperBar = new System.Windows.Forms.Button();
            this.salonyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samochodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MiejscColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrzychodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.StatisticsRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestCarGridView)).BeginInit();
            this.StatisticsLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestShopGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mainPanel.Controls.Add(this.StatisticsRightPanel);
            this.mainPanel.Controls.Add(this.StatisticsLeftPanel);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.bt1UpperBar);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 10;
            // 
            // StatisticsRightPanel
            // 
            this.StatisticsRightPanel.Controls.Add(this.BestCarGridView);
            this.StatisticsRightPanel.Location = new System.Drawing.Point(497, 101);
            this.StatisticsRightPanel.Name = "StatisticsRightPanel";
            this.StatisticsRightPanel.Size = new System.Drawing.Size(294, 298);
            this.StatisticsRightPanel.TabIndex = 8;
            // 
            // BestCarGridView
            // 
            this.BestCarGridView.AllowUserToAddRows = false;
            this.BestCarGridView.AllowUserToDeleteRows = false;
            this.BestCarGridView.AllowUserToResizeColumns = false;
            this.BestCarGridView.AllowUserToResizeRows = false;
            this.BestCarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BestCarGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BestCarGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestCarGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BestCarGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.BestCarGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BestCarGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BestCarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BestCarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IleColumn,
            this.ModelColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BestCarGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BestCarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestCarGridView.EnableHeadersVisualStyles = false;
            this.BestCarGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BestCarGridView.Location = new System.Drawing.Point(0, 0);
            this.BestCarGridView.MultiSelect = false;
            this.BestCarGridView.Name = "BestCarGridView";
            this.BestCarGridView.ReadOnly = true;
            this.BestCarGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            this.BestCarGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BestCarGridView.RowHeadersVisible = false;
            this.BestCarGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.BestCarGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BestCarGridView.RowTemplate.Height = 36;
            this.BestCarGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BestCarGridView.ShowCellToolTips = false;
            this.BestCarGridView.ShowEditingIcon = false;
            this.BestCarGridView.Size = new System.Drawing.Size(294, 298);
            this.BestCarGridView.TabIndex = 3;
            this.BestCarGridView.SelectionChanged += new System.EventHandler(this.BestCarGridView_SelectionChanged);
            // 
            // IleColumn
            // 
            this.IleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IleColumn.DataPropertyName = "ile";
            this.IleColumn.HeaderText = "Ile";
            this.IleColumn.Name = "IleColumn";
            this.IleColumn.ReadOnly = true;
            this.IleColumn.Width = 55;
            // 
            // ModelColumn
            // 
            this.ModelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelColumn.DataPropertyName = "model";
            this.ModelColumn.HeaderText = "Model";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            // 
            // StatisticsLeftPanel
            // 
            this.StatisticsLeftPanel.Controls.Add(this.BestShopGridView);
            this.StatisticsLeftPanel.Location = new System.Drawing.Point(70, 101);
            this.StatisticsLeftPanel.Name = "StatisticsLeftPanel";
            this.StatisticsLeftPanel.Size = new System.Drawing.Size(400, 298);
            this.StatisticsLeftPanel.TabIndex = 6;
            // 
            // BestShopGridView
            // 
            this.BestShopGridView.AllowUserToAddRows = false;
            this.BestShopGridView.AllowUserToDeleteRows = false;
            this.BestShopGridView.AllowUserToResizeColumns = false;
            this.BestShopGridView.AllowUserToResizeRows = false;
            this.BestShopGridView.AutoGenerateColumns = false;
            this.BestShopGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BestShopGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BestShopGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestShopGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BestShopGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.BestShopGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BestShopGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BestShopGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BestShopGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MiejscColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.PrzychodColumn});
            this.BestShopGridView.DataSource = this.salonyBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BestShopGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BestShopGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestShopGridView.EnableHeadersVisualStyles = false;
            this.BestShopGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BestShopGridView.Location = new System.Drawing.Point(0, 0);
            this.BestShopGridView.MultiSelect = false;
            this.BestShopGridView.Name = "BestShopGridView";
            this.BestShopGridView.ReadOnly = true;
            this.BestShopGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            this.BestShopGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.BestShopGridView.RowHeadersVisible = false;
            this.BestShopGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.BestShopGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.BestShopGridView.RowTemplate.Height = 36;
            this.BestShopGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BestShopGridView.ShowCellToolTips = false;
            this.BestShopGridView.ShowEditingIcon = false;
            this.BestShopGridView.Size = new System.Drawing.Size(400, 298);
            this.BestShopGridView.TabIndex = 2;
            this.BestShopGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BestShopGridView_CellContentClick);
            this.BestShopGridView.SelectionChanged += new System.EventHandler(this.BestShopGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Statystyki";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.button1.Location = new System.Drawing.Point(222, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salony";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt1UpperBar
            // 
            this.bt1UpperBar.FlatAppearance.BorderSize = 0;
            this.bt1UpperBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1UpperBar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt1UpperBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.bt1UpperBar.Location = new System.Drawing.Point(600, 66);
            this.bt1UpperBar.Name = "bt1UpperBar";
            this.bt1UpperBar.Size = new System.Drawing.Size(97, 29);
            this.bt1UpperBar.TabIndex = 3;
            this.bt1UpperBar.Text = "Sprzedarz samochodów";
            this.bt1UpperBar.UseVisualStyleBackColor = true;
            this.bt1UpperBar.Click += new System.EventHandler(this.bt1UpperBar_Click);
            // 
            // salonyBindingSource
            // 
            this.salonyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Salony);
            // 
            // samochodyBindingSource
            // 
            this.samochodyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Samochody);
            this.samochodyBindingSource.CurrentChanged += new System.EventHandler(this.samochodyBindingSource_CurrentChanged);
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Zamowienia);
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Pracownicy);
            // 
            // MiejscColumn
            // 
            this.MiejscColumn.DataPropertyName = "MiejsceSalonu";
            this.MiejscColumn.HeaderText = "No.";
            this.MiejscColumn.Name = "MiejscColumn";
            this.MiejscColumn.ReadOnly = true;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            this.miejscowoscDataGridViewTextBoxColumn.ReadOnly = true;
            this.miejscowoscDataGridViewTextBoxColumn.Width = 121;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PrzychodColumn
            // 
            this.PrzychodColumn.DataPropertyName = "Cena";
            this.PrzychodColumn.HeaderText = "Przychód";
            this.PrzychodColumn.Name = "PrzychodColumn";
            this.PrzychodColumn.ReadOnly = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "statystyki";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.StatisticsRightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestCarGridView)).EndInit();
            this.StatisticsLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestShopGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button bt1UpperBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource salonyBindingSource;
        private Panel StatisticsLeftPanel;
        private DataGridView BestShopGridView;
        private Panel StatisticsRightPanel;
        private BindingSource samochodyBindingSource;
        private BindingSource zamowieniaBindingSource;
        private BindingSource pracownicyBindingSource;
        private DataGridView BestCarGridView;
        private DataGridViewTextBoxColumn IleColumn;
        private DataGridViewTextBoxColumn ModelColumn;
        private DataGridViewTextBoxColumn MiejscColumn;
        private DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PrzychodColumn;
    }
}