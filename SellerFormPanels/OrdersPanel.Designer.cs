namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class OrdersPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientsMenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchClientsTextBox = new System.Windows.Forms.TextBox();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.IdKlienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Samochód = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RodzajPlatnosci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource1)).BeginInit();
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
            this.ClientsMenuPanel.TabIndex = 4;
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
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AllowUserToAddRows = false;
            this.OrdersGridView.AllowUserToDeleteRows = false;
            this.OrdersGridView.AllowUserToResizeColumns = false;
            this.OrdersGridView.AllowUserToResizeRows = false;
            this.OrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.OrdersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrdersGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.OrdersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.OrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKlienta,
            this.Samochód,
            this.RodzajPlatnosci,
            this.Column1,
            this.Data});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.OrdersGridView.EnableHeadersVisualStyles = false;
            this.OrdersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.OrdersGridView.Location = new System.Drawing.Point(0, 38);
            this.OrdersGridView.MultiSelect = false;
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            this.OrdersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OrdersGridView.RowHeadersVisible = false;
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            this.OrdersGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.OrdersGridView.RowTemplate.Height = 36;
            this.OrdersGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrdersGridView.ShowCellToolTips = false;
            this.OrdersGridView.ShowEditingIcon = false;
            this.OrdersGridView.Size = new System.Drawing.Size(861, 493);
            this.OrdersGridView.TabIndex = 5;
            this.OrdersGridView.SelectionChanged += new System.EventHandler(this.OrdersGridView_SelectionChanged);
            // 
            // IdKlienta
            // 
            this.IdKlienta.DataPropertyName = "IdKlienta";
            this.IdKlienta.HeaderText = "IDklienta";
            this.IdKlienta.Name = "IdKlienta";
            this.IdKlienta.ReadOnly = true;
            // 
            // Samochód
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Samochód.DefaultCellStyle = dataGridViewCellStyle2;
            this.Samochód.FillWeight = 106.599F;
            this.Samochód.HeaderText = "Samochód";
            this.Samochód.MinimumWidth = 6;
            this.Samochód.Name = "Samochód";
            this.Samochód.ReadOnly = true;
            // 
            // RodzajPlatnosci
            // 
            this.RodzajPlatnosci.DataPropertyName = "RodzajPlatnosci";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.RodzajPlatnosci.DefaultCellStyle = dataGridViewCellStyle3;
            this.RodzajPlatnosci.HeaderText = "Płatność";
            this.RodzajPlatnosci.Name = "RodzajPlatnosci";
            this.RodzajPlatnosci.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CalkowityKoszt";
            this.Column1.HeaderText = "Koszt";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // zamowieniaBindingSource1
            // 
            this.zamowieniaBindingSource1.DataSource = typeof(CarDealerSupportSystem.Models.Zamowienia);
            // 
            // OrdersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.OrdersGridView);
            this.Controls.Add(this.ClientsMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersPanel";
            this.Text = "OrdersPanel";
            this.Load += new System.EventHandler(this.OrdersPanel_Load);
            this.ClientsMenuPanel.ResumeLayout(false);
            this.ClientsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientsMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchClientsTextBox;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn typZakupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samochód;
        private System.Windows.Forms.DataGridViewTextBoxColumn RodzajPlatnosci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource1;
    }
}