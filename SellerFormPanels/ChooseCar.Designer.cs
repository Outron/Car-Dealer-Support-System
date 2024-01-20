namespace CarDealerSupportSystem.SellerFormPanels
{
    partial class ChooseCar
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
            this.FilterCarPanel = new System.Windows.Forms.Panel();
            this.ApplyButton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BrandComboBox1 = new System.Windows.Forms.ComboBox();
            this.ModelComboBox1 = new System.Windows.Forms.ComboBox();
            this.CarLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FilterCarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterCarPanel
            // 
            this.FilterCarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.FilterCarPanel.Controls.Add(this.ApplyButton1);
            this.FilterCarPanel.Controls.Add(this.label3);
            this.FilterCarPanel.Controls.Add(this.label2);
            this.FilterCarPanel.Controls.Add(this.BrandComboBox1);
            this.FilterCarPanel.Controls.Add(this.ModelComboBox1);
            this.FilterCarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterCarPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterCarPanel.Name = "FilterCarPanel";
            this.FilterCarPanel.Size = new System.Drawing.Size(1112, 61);
            this.FilterCarPanel.TabIndex = 6;
            // 
            // ApplyButton1
            // 
            this.ApplyButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ApplyButton1.FlatAppearance.BorderSize = 0;
            this.ApplyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplyButton1.ForeColor = System.Drawing.Color.White;
            this.ApplyButton1.Location = new System.Drawing.Point(971, 18);
            this.ApplyButton1.Name = "ApplyButton1";
            this.ApplyButton1.Size = new System.Drawing.Size(122, 35);
            this.ApplyButton1.TabIndex = 21;
            this.ApplyButton1.Text = "Zastosuj";
            this.ApplyButton1.UseVisualStyleBackColor = false;
            this.ApplyButton1.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka";
            // 
            // BrandComboBox1
            // 
            this.BrandComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BrandComboBox1.DisplayMember = "Marka";
            this.BrandComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrandComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrandComboBox1.ForeColor = System.Drawing.Color.White;
            this.BrandComboBox1.FormattingEnabled = true;
            this.BrandComboBox1.Location = new System.Drawing.Point(22, 27);
            this.BrandComboBox1.Name = "BrandComboBox1";
            this.BrandComboBox1.Size = new System.Drawing.Size(120, 24);
            this.BrandComboBox1.TabIndex = 2;
            this.BrandComboBox1.ValueMember = "Marka";
            this.BrandComboBox1.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // ModelComboBox1
            // 
            this.ModelComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ModelComboBox1.DisplayMember = "Marka";
            this.ModelComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModelComboBox1.ForeColor = System.Drawing.Color.White;
            this.ModelComboBox1.FormattingEnabled = true;
            this.ModelComboBox1.Location = new System.Drawing.Point(171, 27);
            this.ModelComboBox1.Name = "ModelComboBox1";
            this.ModelComboBox1.Size = new System.Drawing.Size(120, 24);
            this.ModelComboBox1.TabIndex = 3;
            this.ModelComboBox1.ValueMember = "Marka";
            // 
            // CarLayoutPanel
            // 
            this.CarLayoutPanel.AutoScroll = true;
            this.CarLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarLayoutPanel.Location = new System.Drawing.Point(0, 61);
            this.CarLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.CarLayoutPanel.Name = "CarLayoutPanel";
            this.CarLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.CarLayoutPanel.Size = new System.Drawing.Size(1112, 572);
            this.CarLayoutPanel.TabIndex = 7;
            // 
            // ChooseCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1112, 633);
            this.Controls.Add(this.CarLayoutPanel);
            this.Controls.Add(this.FilterCarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseCar";
            this.Text = "ChooseCar";
            this.Load += new System.EventHandler(this.ChooseCar_Load);
            this.FilterCarPanel.ResumeLayout(false);
            this.FilterCarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FilterCarPanel;
        private System.Windows.Forms.Button ApplyButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BrandComboBox1;
        private System.Windows.Forms.ComboBox ModelComboBox1;
        private System.Windows.Forms.FlowLayoutPanel CarLayoutPanel;
    }
}