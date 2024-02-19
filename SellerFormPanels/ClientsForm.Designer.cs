namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class ClientsForm
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
            this.ClientsMenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchClientsTextBox = new System.Windows.Forms.TextBox();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.idKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsMenuPanel
            // 
            this.ClientsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientsMenuPanel.Controls.Add(this.pictureBox2);
            this.ClientsMenuPanel.Controls.Add(this.SearchClientsTextBox);
            this.ClientsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.ClientsMenuPanel.Name = "ClientsMenuPanel";
            this.ClientsMenuPanel.Size = new System.Drawing.Size(861, 39);
            this.ClientsMenuPanel.TabIndex = 3;
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
            // SearchClientsTextBox
            // 
            this.SearchClientsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.SearchClientsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchClientsTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchClientsTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchClientsTextBox.Location = new System.Drawing.Point(47, 6);
            this.SearchClientsTextBox.Name = "SearchClientsTextBox";
            this.SearchClientsTextBox.Size = new System.Drawing.Size(249, 26);
            this.SearchClientsTextBox.TabIndex = 1;
            this.SearchClientsTextBox.TextChanged += new System.EventHandler(this.SearchClientsTextBox_TextChanged);
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.AllowUserToAddRows = false;
            this.ClientsGridView.AllowUserToDeleteRows = false;
            this.ClientsGridView.AllowUserToResizeColumns = false;
            this.ClientsGridView.AllowUserToResizeRows = false;
            this.ClientsGridView.AutoGenerateColumns = false;
            this.ClientsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ClientsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClientsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKlientaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.ClientsGridView.DataSource = this.klienciBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.ClientsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsGridView.EnableHeadersVisualStyles = false;
            this.ClientsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientsGridView.Location = new System.Drawing.Point(0, 39);
            this.ClientsGridView.MultiSelect = false;
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.ReadOnly = true;
            this.ClientsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Transparent;
            this.ClientsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ClientsGridView.RowHeadersVisible = false;
            this.ClientsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            this.ClientsGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ClientsGridView.RowTemplate.Height = 36;
            this.ClientsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClientsGridView.ShowCellToolTips = false;
            this.ClientsGridView.ShowEditingIcon = false;
            this.ClientsGridView.Size = new System.Drawing.Size(861, 491);
            this.ClientsGridView.TabIndex = 4;
            this.ClientsGridView.SelectionChanged += new System.EventHandler(this.ClientsGridView_SelectionChanged);
            // 
            // idKlientaDataGridViewTextBoxColumn
            // 
            this.idKlientaDataGridViewTextBoxColumn.DataPropertyName = "IdKlienta";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.idKlientaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idKlientaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idKlientaDataGridViewTextBoxColumn.Name = "idKlientaDataGridViewTextBoxColumn";
            this.idKlientaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.imieDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieDataGridViewTextBoxColumn.Width = 143;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.nazwiskoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoDataGridViewTextBoxColumn.Width = 144;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.adresDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Width = 167;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.telefonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Width = 144;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 165;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Klienci);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.ClientsGridView);
            this.Controls.Add(this.ClientsMenuPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.ClientsMenuPanel.ResumeLayout(false);
            this.ClientsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientsMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchClientsTextBox;
        private System.Windows.Forms.DataGridView ClientsGridView;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}