namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class LogsPanel
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
            this.ClientsMenuPanel = new System.Windows.Forms.Panel();
            this.eventsCount = new System.Windows.Forms.Label();
            this.logsCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logsTextBox = new System.Windows.Forms.RichTextBox();
            this.exportLogsButton = new System.Windows.Forms.Button();
            this.exportLabel = new System.Windows.Forms.Label();
            this.refreshLogsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsMenuPanel
            // 
            this.ClientsMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientsMenuPanel.Controls.Add(this.eventsCount);
            this.ClientsMenuPanel.Controls.Add(this.logsCountLabel);
            this.ClientsMenuPanel.Controls.Add(this.label2);
            this.ClientsMenuPanel.Controls.Add(this.label1);
            this.ClientsMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.ClientsMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsMenuPanel.Name = "ClientsMenuPanel";
            this.ClientsMenuPanel.Size = new System.Drawing.Size(1148, 60);
            this.ClientsMenuPanel.TabIndex = 3;
            // 
            // eventsCount
            // 
            this.eventsCount.AutoSize = true;
            this.eventsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eventsCount.Location = new System.Drawing.Point(405, 16);
            this.eventsCount.Name = "eventsCount";
            this.eventsCount.Size = new System.Drawing.Size(0, 20);
            this.eventsCount.TabIndex = 7;
            // 
            // logsCountLabel
            // 
            this.logsCountLabel.AutoSize = true;
            this.logsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logsCountLabel.Location = new System.Drawing.Point(377, 16);
            this.logsCountLabel.Name = "logsCountLabel";
            this.logsCountLabel.Size = new System.Drawing.Size(0, 20);
            this.logsCountLabel.TabIndex = 2;
            this.logsCountLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(117, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba dzisiejszych zdarzeń:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikacja";
            // 
            // logsTextBox
            // 
            this.logsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.logsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logsTextBox.ForeColor = System.Drawing.Color.White;
            this.logsTextBox.HideSelection = false;
            this.logsTextBox.Location = new System.Drawing.Point(13, 147);
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ReadOnly = true;
            this.logsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logsTextBox.Size = new System.Drawing.Size(875, 500);
            this.logsTextBox.TabIndex = 4;
            this.logsTextBox.Text = "";
            this.logsTextBox.TextChanged += new System.EventHandler(this.logsTextBox_TextChanged);
            // 
            // exportLogsButton
            // 
            this.exportLogsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.exportLogsButton.BackgroundImage = global::CarDealerSupportSystem.Properties.Resources.upload;
            this.exportLogsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportLogsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.exportLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportLogsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.exportLogsButton.Location = new System.Drawing.Point(1009, 138);
            this.exportLogsButton.Name = "exportLogsButton";
            this.exportLogsButton.Size = new System.Drawing.Size(52, 49);
            this.exportLogsButton.TabIndex = 7;
            this.exportLogsButton.UseVisualStyleBackColor = false;
            this.exportLogsButton.Click += new System.EventHandler(this.exportLogsButton_Click);
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportLabel.Location = new System.Drawing.Point(947, 103);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(159, 20);
            this.exportLabel.TabIndex = 8;
            this.exportLabel.Text = "Eksportuj do pliku";
            // 
            // refreshLogsButton
            // 
            this.refreshLogsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.refreshLogsButton.BackgroundImage = global::CarDealerSupportSystem.Properties.Resources.refresh_cw;
            this.refreshLogsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshLogsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.refreshLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshLogsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.refreshLogsButton.Location = new System.Drawing.Point(808, 86);
            this.refreshLogsButton.Name = "refreshLogsButton";
            this.refreshLogsButton.Size = new System.Drawing.Size(69, 56);
            this.refreshLogsButton.TabIndex = 9;
            this.refreshLogsButton.UseVisualStyleBackColor = false;
            this.refreshLogsButton.Click += new System.EventHandler(this.refreshLogsButton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(934, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(934, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "Blad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(934, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 58);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sukces";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataSource = typeof(CarDealerSupportSystem.Models.Klienci);
            // 
            // LogsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1148, 652);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshLogsButton);
            this.Controls.Add(this.exportLabel);
            this.Controls.Add(this.exportLogsButton);
            this.Controls.Add(this.logsTextBox);
            this.Controls.Add(this.ClientsMenuPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogsPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.LogsPanel_Load);
            this.Shown += new System.EventHandler(this.LogsPanel_Shown);
            this.ClientsMenuPanel.ResumeLayout(false);
            this.ClientsMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ClientsMenuPanel;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logsCountLabel;
        private System.Windows.Forms.RichTextBox logsTextBox;
        private System.Windows.Forms.Label eventsCount;
        private System.Windows.Forms.Button exportLogsButton;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.Button refreshLogsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}