namespace CarDealerSupportSystem
{
    partial class AdminForm
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
            this.LeftMenuPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.LeftMenuBtn4 = new System.Windows.Forms.Button();
            this.LeftMenuBtn3 = new System.Windows.Forms.Button();
            this.LeftMenuBtn2 = new System.Windows.Forms.Button();
            this.LeftMenuBtn1 = new System.Windows.Forms.Button();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMenuPanel
            // 
            this.LeftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.LeftMenuPanel.Controls.Add(this.LogOutBtn);
            this.LeftMenuPanel.Controls.Add(this.LeftMenuBtn4);
            this.LeftMenuPanel.Controls.Add(this.LeftMenuBtn3);
            this.LeftMenuPanel.Controls.Add(this.LeftMenuBtn2);
            this.LeftMenuPanel.Controls.Add(this.LeftMenuBtn1);
            this.LeftMenuPanel.Controls.Add(this.RoleLabel);
            this.LeftMenuPanel.Controls.Add(this.NameLabel);
            this.LeftMenuPanel.Controls.Add(this.pictureBox1);
            this.LeftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMenuPanel.Name = "LeftMenuPanel";
            this.LeftMenuPanel.Size = new System.Drawing.Size(239, 600);
            this.LeftMenuPanel.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Image = global::CarDealerSupportSystem.Properties.Resources.log_out;
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(3, 550);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(233, 47);
            this.LogOutBtn.TabIndex = 8;
            this.LogOutBtn.Text = "Wyloguj";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // LeftMenuBtn4
            // 
            this.LeftMenuBtn4.FlatAppearance.BorderSize = 0;
            this.LeftMenuBtn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeftMenuBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftMenuBtn4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftMenuBtn4.ForeColor = System.Drawing.Color.White;
            this.LeftMenuBtn4.Image = global::CarDealerSupportSystem.Properties.Resources.users;
            this.LeftMenuBtn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeftMenuBtn4.Location = new System.Drawing.Point(3, 374);
            this.LeftMenuBtn4.Name = "LeftMenuBtn4";
            this.LeftMenuBtn4.Size = new System.Drawing.Size(247, 57);
            this.LeftMenuBtn4.TabIndex = 7;
            this.LeftMenuBtn4.Text = "   Zarządzanie użytkownikami";
            this.LeftMenuBtn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LeftMenuBtn4.UseVisualStyleBackColor = true;
            this.LeftMenuBtn4.Click += new System.EventHandler(this.LeftMenuBtn4_Click);
            // 
            // LeftMenuBtn3
            // 
            this.LeftMenuBtn3.FlatAppearance.BorderSize = 0;
            this.LeftMenuBtn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeftMenuBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftMenuBtn3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftMenuBtn3.ForeColor = System.Drawing.Color.White;
            this.LeftMenuBtn3.Image = global::CarDealerSupportSystem.Properties.Resources.database;
            this.LeftMenuBtn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeftMenuBtn3.Location = new System.Drawing.Point(3, 311);
            this.LeftMenuBtn3.Name = "LeftMenuBtn3";
            this.LeftMenuBtn3.Size = new System.Drawing.Size(233, 57);
            this.LeftMenuBtn3.TabIndex = 6;
            this.LeftMenuBtn3.Text = "   Zarządzanie bazą danych";
            this.LeftMenuBtn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LeftMenuBtn3.UseVisualStyleBackColor = true;
            this.LeftMenuBtn3.Click += new System.EventHandler(this.LeftMenuBtn3_Click);
            // 
            // LeftMenuBtn2
            // 
            this.LeftMenuBtn2.FlatAppearance.BorderSize = 0;
            this.LeftMenuBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeftMenuBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftMenuBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftMenuBtn2.ForeColor = System.Drawing.Color.White;
            this.LeftMenuBtn2.Image = global::CarDealerSupportSystem.Properties.Resources.terminal;
            this.LeftMenuBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeftMenuBtn2.Location = new System.Drawing.Point(3, 248);
            this.LeftMenuBtn2.Name = "LeftMenuBtn2";
            this.LeftMenuBtn2.Size = new System.Drawing.Size(233, 57);
            this.LeftMenuBtn2.TabIndex = 5;
            this.LeftMenuBtn2.Text = "    Logi systemowe";
            this.LeftMenuBtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LeftMenuBtn2.UseVisualStyleBackColor = true;
            this.LeftMenuBtn2.Click += new System.EventHandler(this.LeftMenuBtn2_Click);
            // 
            // LeftMenuBtn1
            // 
            this.LeftMenuBtn1.FlatAppearance.BorderSize = 0;
            this.LeftMenuBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeftMenuBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftMenuBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftMenuBtn1.ForeColor = System.Drawing.Color.White;
            this.LeftMenuBtn1.Image = global::CarDealerSupportSystem.Properties.Resources.home;
            this.LeftMenuBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeftMenuBtn1.Location = new System.Drawing.Point(3, 185);
            this.LeftMenuBtn1.Name = "LeftMenuBtn1";
            this.LeftMenuBtn1.Size = new System.Drawing.Size(233, 57);
            this.LeftMenuBtn1.TabIndex = 4;
            this.LeftMenuBtn1.Text = "    Panel główny";
            this.LeftMenuBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LeftMenuBtn1.UseVisualStyleBackColor = true;
            this.LeftMenuBtn1.Click += new System.EventHandler(this.LeftMenuBtn1_Click);
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoleLabel.ForeColor = System.Drawing.Color.White;

            this.RoleLabel.Location = new System.Drawing.Point(78, 155);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(133, 28);
            this.RoleLabel.TabIndex = 3;
            this.RoleLabel.Text = "Administrator";

           

            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;

            this.NameLabel.CausesValidation = false;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(47, 118);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(229, 37);

            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Zbigniew Kapusta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarDealerSupportSystem.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(239, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(861, 70);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TopLabel.Location = new System.Drawing.Point(16, 12);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(0, 37);
            this.TopLabel.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitBtn.Image = global::CarDealerSupportSystem.Properties.Resources.x;
            this.ExitBtn.Location = new System.Drawing.Point(834, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(15, 13);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(239, 70);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(861, 530);
            this.MainPanel.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftMenuPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.LeftMenuPanel.ResumeLayout(false);
            this.LeftMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenuPanel;

        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopPanel;
        public System.Windows.Forms.Label RoleLabel;

        

        private System.Windows.Forms.Button LeftMenuBtn1;
        private System.Windows.Forms.Button LeftMenuBtn2;
        private System.Windows.Forms.Button LeftMenuBtn4;
        private System.Windows.Forms.Button LeftMenuBtn3;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label RoleLabel;
    }
}