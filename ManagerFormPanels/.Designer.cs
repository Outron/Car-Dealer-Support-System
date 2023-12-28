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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.StatisticsLeftPanel = new System.Windows.Forms.Panel();
            this.BestShopGridView = new System.Windows.Forms.DataGridView();
            this.salonyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt1UpperBar = new System.Windows.Forms.Button();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idSalonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.StatisticsLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestShopGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
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
            // StatisticsLeftPanel
            // 
            this.StatisticsLeftPanel.Controls.Add(this.BestShopGridView);
            this.StatisticsLeftPanel.Location = new System.Drawing.Point(73, 101);
            this.StatisticsLeftPanel.Name = "StatisticsLeftPanel";
            this.StatisticsLeftPanel.Size = new System.Drawing.Size(294, 298);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BestShopGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BestShopGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BestShopGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSalonuDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.cena});
            this.BestShopGridView.DataSource = this.salonyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BestShopGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BestShopGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestShopGridView.EnableHeadersVisualStyles = false;
            this.BestShopGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BestShopGridView.Location = new System.Drawing.Point(0, 0);
            this.BestShopGridView.MultiSelect = false;
            this.BestShopGridView.Name = "BestShopGridView";
            this.BestShopGridView.ReadOnly = true;
            this.BestShopGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            this.BestShopGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BestShopGridView.RowHeadersVisible = false;
            this.BestShopGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.BestShopGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BestShopGridView.RowTemplate.Height = 36;
            this.BestShopGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BestShopGridView.ShowCellToolTips = false;
            this.BestShopGridView.ShowEditingIcon = false;
            this.BestShopGridView.Size = new System.Drawing.Size(294, 298);
            this.BestShopGridView.TabIndex = 2;
            // 
            // salonyBindingSource
            // 
            this.salonyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Salony);
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
            this.button1.Location = new System.Drawing.Point(176, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salony";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt1UpperBar
            // 
            this.bt1UpperBar.FlatAppearance.BorderSize = 0;
            this.bt1UpperBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1UpperBar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt1UpperBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.bt1UpperBar.Location = new System.Drawing.Point(555, 66);
            this.bt1UpperBar.Name = "bt1UpperBar";
            this.bt1UpperBar.Size = new System.Drawing.Size(97, 29);
            this.bt1UpperBar.TabIndex = 3;
            this.bt1UpperBar.Text = "Sprzedarz samochodów";
            this.bt1UpperBar.UseVisualStyleBackColor = true;
            this.bt1UpperBar.Click += new System.EventHandler(this.bt1UpperBar_Click);
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Zamowienia);
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Pracownicy);
            // 
            // idSalonuDataGridViewTextBoxColumn
            // 
            this.idSalonuDataGridViewTextBoxColumn.DataPropertyName = "IdSalonu";
            this.idSalonuDataGridViewTextBoxColumn.HeaderText = "IdSalonu";
            this.idSalonuDataGridViewTextBoxColumn.Name = "idSalonuDataGridViewTextBoxColumn";
            this.idSalonuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            this.miejscowoscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.DataPropertyName = "Cena";
            this.cena.HeaderText = "Cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
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
            this.StatisticsLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestShopGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonyBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private Panel StatisticsLeftPanel;
        private DataGridView BestShopGridView;
        private DataGridViewTextBoxColumn idSalonuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cena;
    }
}