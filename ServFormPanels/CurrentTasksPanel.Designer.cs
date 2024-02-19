using System.Drawing;

namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class CurrentTasksPanel
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
            this.ClientsMenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchClientsTextBox = new System.Windows.Forms.TextBox();
            this.idZamowieniaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlientaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typZakupuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calkowityKosztDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownicyUslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samochodyZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlientaNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPracownikaNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasksGridView = new System.Windows.Forms.DataGridView();
            this.IDzamowienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsMenuPanel
            // 
            this.ClientsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientsMenuPanel.Controls.Add(this.pictureBox2);
            this.ClientsMenuPanel.Controls.Add(this.SearchClientsTextBox);
            this.ClientsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.ClientsMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsMenuPanel.Name = "ClientsMenuPanel";
            this.ClientsMenuPanel.Size = new System.Drawing.Size(1147, 72);
            this.ClientsMenuPanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarDealerSupportSystem.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(13, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 41);
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
            this.SearchClientsTextBox.Location = new System.Drawing.Point(77, 22);
            this.SearchClientsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchClientsTextBox.Name = "SearchClientsTextBox";
            this.SearchClientsTextBox.Size = new System.Drawing.Size(332, 32);
            this.SearchClientsTextBox.TabIndex = 1;
            // 
            // idZamowieniaDataGridViewTextBoxColumn1
            // 
            this.idZamowieniaDataGridViewTextBoxColumn1.DataPropertyName = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn1.HeaderText = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idZamowieniaDataGridViewTextBoxColumn1.Name = "idZamowieniaDataGridViewTextBoxColumn1";
            this.idZamowieniaDataGridViewTextBoxColumn1.Width = 89;
            // 
            // idKlientaDataGridViewTextBoxColumn1
            // 
            this.idKlientaDataGridViewTextBoxColumn1.DataPropertyName = "IdKlienta";
            this.idKlientaDataGridViewTextBoxColumn1.HeaderText = "IdKlienta";
            this.idKlientaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idKlientaDataGridViewTextBoxColumn1.Name = "idKlientaDataGridViewTextBoxColumn1";
            this.idKlientaDataGridViewTextBoxColumn1.Width = 88;
            // 
            // idPracownikaDataGridViewTextBoxColumn
            // 
            this.idPracownikaDataGridViewTextBoxColumn.DataPropertyName = "IdPracownika";
            this.idPracownikaDataGridViewTextBoxColumn.HeaderText = "IdPracownika";
            this.idPracownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPracownikaDataGridViewTextBoxColumn.Name = "idPracownikaDataGridViewTextBoxColumn";
            this.idPracownikaDataGridViewTextBoxColumn.Width = 88;
            // 
            // typZakupuDataGridViewTextBoxColumn
            // 
            this.typZakupuDataGridViewTextBoxColumn.DataPropertyName = "TypZakupu";
            this.typZakupuDataGridViewTextBoxColumn.HeaderText = "TypZakupu";
            this.typZakupuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typZakupuDataGridViewTextBoxColumn.Name = "typZakupuDataGridViewTextBoxColumn";
            this.typZakupuDataGridViewTextBoxColumn.Width = 88;
            // 
            // calkowityKosztDataGridViewTextBoxColumn
            // 
            this.calkowityKosztDataGridViewTextBoxColumn.DataPropertyName = "CalkowityKoszt";
            this.calkowityKosztDataGridViewTextBoxColumn.HeaderText = "CalkowityKoszt";
            this.calkowityKosztDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calkowityKosztDataGridViewTextBoxColumn.Name = "calkowityKosztDataGridViewTextBoxColumn";
            this.calkowityKosztDataGridViewTextBoxColumn.Width = 88;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 88;
            // 
            // pracownicyUslugiDataGridViewTextBoxColumn
            // 
            this.pracownicyUslugiDataGridViewTextBoxColumn.DataPropertyName = "PracownicyUslugi";
            this.pracownicyUslugiDataGridViewTextBoxColumn.HeaderText = "PracownicyUslugi";
            this.pracownicyUslugiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pracownicyUslugiDataGridViewTextBoxColumn.Name = "pracownicyUslugiDataGridViewTextBoxColumn";
            this.pracownicyUslugiDataGridViewTextBoxColumn.Width = 88;
            // 
            // samochodyZamowieniaDataGridViewTextBoxColumn
            // 
            this.samochodyZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "SamochodyZamowienia";
            this.samochodyZamowieniaDataGridViewTextBoxColumn.HeaderText = "SamochodyZamowienia";
            this.samochodyZamowieniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.samochodyZamowieniaDataGridViewTextBoxColumn.Name = "samochodyZamowieniaDataGridViewTextBoxColumn";
            this.samochodyZamowieniaDataGridViewTextBoxColumn.Width = 90;
            // 
            // idKlientaNavigationDataGridViewTextBoxColumn
            // 
            this.idKlientaNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdKlientaNavigation";
            this.idKlientaNavigationDataGridViewTextBoxColumn.HeaderText = "IdKlientaNavigation";
            this.idKlientaNavigationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idKlientaNavigationDataGridViewTextBoxColumn.Name = "idKlientaNavigationDataGridViewTextBoxColumn";
            this.idKlientaNavigationDataGridViewTextBoxColumn.Width = 89;
            // 
            // idPracownikaNavigationDataGridViewTextBoxColumn
            // 
            this.idPracownikaNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdPracownikaNavigation";
            this.idPracownikaNavigationDataGridViewTextBoxColumn.HeaderText = "IdPracownikaNavigation";
            this.idPracownikaNavigationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPracownikaNavigationDataGridViewTextBoxColumn.Name = "idPracownikaNavigationDataGridViewTextBoxColumn";
            this.idPracownikaNavigationDataGridViewTextBoxColumn.Width = 88;
            // 
            // TasksGridView
            // 
            this.TasksGridView.AllowUserToAddRows = false;
            this.TasksGridView.AllowUserToDeleteRows = false;
            this.TasksGridView.AllowUserToResizeColumns = false;
            this.TasksGridView.AllowUserToResizeRows = false;
            this.TasksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TasksGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.TasksGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TasksGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TasksGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TasksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDzamowienia,
            this.Marka,
            this.Model,
            this.Nazwa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TasksGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TasksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksGridView.EnableHeadersVisualStyles = false;
            this.TasksGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.TasksGridView.Location = new System.Drawing.Point(0, 72);
            this.TasksGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TasksGridView.MultiSelect = false;
            this.TasksGridView.Name = "TasksGridView";
            this.TasksGridView.ReadOnly = true;
            this.TasksGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            this.TasksGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TasksGridView.RowHeadersVisible = false;
            this.TasksGridView.RowHeadersWidth = 51;
            this.TasksGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.TasksGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TasksGridView.RowTemplate.Height = 36;
            this.TasksGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TasksGridView.ShowCellToolTips = false;
            this.TasksGridView.ShowEditingIcon = false;
            this.TasksGridView.Size = new System.Drawing.Size(1147, 565);
            this.TasksGridView.TabIndex = 6;
            this.TasksGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGridView_CellMouseLeave);
            this.TasksGridView.SelectionChanged += new System.EventHandler(this.TasksGridView_SelectionChanged);
            // 
            // IDzamowienia
            // 
            this.IDzamowienia.HeaderText = "ID zlecenia";
            this.IDzamowienia.MinimumWidth = 6;
            this.IDzamowienia.Name = "IDzamowienia";
            this.IDzamowienia.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Opis";
            this.Nazwa.MinimumWidth = 6;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // CurrentTasksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1147, 637);
            this.Controls.Add(this.TasksGridView);
            this.Controls.Add(this.ClientsMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentTasksPanel";
            this.Text = "OrdersPanel";
            this.Load += new System.EventHandler(this.CurrentTasksPanel_Load);
            this.ClientsMenuPanel.ResumeLayout(false);
            this.ClientsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientsMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchClientsTextBox;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typZakupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calkowityKosztDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaNavigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPracownikaNavigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownicyUslugiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn samochodyZamowieniaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView TasksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDzamowienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
    }
}