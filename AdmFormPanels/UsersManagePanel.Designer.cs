namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class UsersManagePanel
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchUsersTextBox = new System.Windows.Forms.TextBox();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.addUserButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passCheckBox = new System.Windows.Forms.CheckBox();
            this.idPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haslo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodRoliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsMenuPanel
            // 
            this.ClientsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientsMenuPanel.Controls.Add(this.passCheckBox);
            this.ClientsMenuPanel.Controls.Add(this.addUserButton);
            this.ClientsMenuPanel.Controls.Add(this.pictureBox2);
            this.ClientsMenuPanel.Controls.Add(this.SearchUsersTextBox);
            this.ClientsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.ClientsMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsMenuPanel.Name = "ClientsMenuPanel";
            this.ClientsMenuPanel.Size = new System.Drawing.Size(1148, 75);
            this.ClientsMenuPanel.TabIndex = 3;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addUserButton.BackgroundImage = global::CarDealerSupportSystem.Properties.Resources.user_plus;
            this.addUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addUserButton.Location = new System.Drawing.Point(647, 20);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(56, 48);
            this.addUserButton.TabIndex = 4;
            this.addUserButtonToolTip.SetToolTip(this.addUserButton, "Dodaj nowego użytkownika\r\n");
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarDealerSupportSystem.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(4, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // SearchUsersTextBox
            // 
            this.SearchUsersTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.SearchUsersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchUsersTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchUsersTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchUsersTextBox.Location = new System.Drawing.Point(74, 23);
            this.SearchUsersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchUsersTextBox.Name = "SearchUsersTextBox";
            this.SearchUsersTextBox.Size = new System.Drawing.Size(332, 32);
            this.SearchUsersTextBox.TabIndex = 1;
            this.SearchUsersTextBox.TextChanged += new System.EventHandler(this.SearchUsersTextBox_TextChanged);
            // 
            // UsersGridView
            // 
            this.UsersGridView.AllowUserToAddRows = false;
            this.UsersGridView.AllowUserToDeleteRows = false;
            this.UsersGridView.AllowUserToResizeColumns = false;
            this.UsersGridView.AllowUserToResizeRows = false;
            this.UsersGridView.AutoGenerateColumns = false;
            this.UsersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.UsersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UsersGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.UsersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 5, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.UsersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPracownikaDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.Haslo,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.kodRoliDataGridViewTextBoxColumn});
            this.UsersGridView.DataSource = this.pracownicyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersGridView.EnableHeadersVisualStyles = false;
            this.UsersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.UsersGridView.Location = new System.Drawing.Point(0, 75);
            this.UsersGridView.Margin = new System.Windows.Forms.Padding(4);
            this.UsersGridView.MultiSelect = false;
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.ReadOnly = true;
            this.UsersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            this.UsersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGridView.RowHeadersVisible = false;
            this.UsersGridView.RowHeadersWidth = 51;
            this.UsersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.UsersGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.UsersGridView.RowTemplate.Height = 36;
            this.UsersGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersGridView.ShowCellToolTips = false;
            this.UsersGridView.ShowEditingIcon = false;
            this.UsersGridView.Size = new System.Drawing.Size(1148, 577);
            this.UsersGridView.TabIndex = 4;
            this.UsersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellClick_1);
            this.UsersGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.UsersGridView_CellFormatting);
            this.UsersGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellMouseEnter);
            this.UsersGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellMouseLeave);
            this.UsersGridView.SelectionChanged += new System.EventHandler(this.UsersGridView_SelectionChanged);
            // 
            // addUserButtonToolTip
            // 
            this.addUserButtonToolTip.AutomaticDelay = 200;
            // 
            // passCheckBox
            // 
            this.passCheckBox.AutoSize = true;
            this.passCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passCheckBox.ForeColor = System.Drawing.Color.White;
            this.passCheckBox.Location = new System.Drawing.Point(434, 29);
            this.passCheckBox.Name = "passCheckBox";
            this.passCheckBox.Size = new System.Drawing.Size(141, 29);
            this.passCheckBox.TabIndex = 5;
            this.passCheckBox.Text = "Pokaż hasła";
            this.passCheckBox.UseVisualStyleBackColor = true;
            this.passCheckBox.CheckedChanged += new System.EventHandler(this.passCheckBox_CheckedChanged);
            // 
            // idPracownikaDataGridViewTextBoxColumn
            // 
            this.idPracownikaDataGridViewTextBoxColumn.DataPropertyName = "IdPracownika";
            this.idPracownikaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idPracownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPracownikaDataGridViewTextBoxColumn.Name = "idPracownikaDataGridViewTextBoxColumn";
            this.idPracownikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPracownikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // Haslo
            // 
            this.Haslo.DataPropertyName = "Haslo";
            this.Haslo.HeaderText = "Hasło";
            this.Haslo.MinimumWidth = 6;
            this.Haslo.Name = "Haslo";
            this.Haslo.ReadOnly = true;
            this.Haslo.Width = 125;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodRoliDataGridViewTextBoxColumn
            // 
            this.kodRoliDataGridViewTextBoxColumn.DataPropertyName = "KodRoli";
            this.kodRoliDataGridViewTextBoxColumn.HeaderText = "KodRoli";
            this.kodRoliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodRoliDataGridViewTextBoxColumn.Name = "kodRoliDataGridViewTextBoxColumn";
            this.kodRoliDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodRoliDataGridViewTextBoxColumn.Width = 125;
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Pracownicy);
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Klienci);
            // 
            // UsersManagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1148, 652);
            this.Controls.Add(this.UsersGridView);
            this.Controls.Add(this.ClientsMenuPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersManagePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.ClientsMenuPanel.ResumeLayout(false);
            this.ClientsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientsMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchUsersTextBox;
        public System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ToolTip addUserButtonToolTip;
        private System.Windows.Forms.CheckBox passCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haslo;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodRoliDataGridViewTextBoxColumn;
    }
}