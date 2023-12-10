namespace CarDealerSupportSystem.paneleKierownika
{
    partial class klienciControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.whoLb = new System.Windows.Forms.Label();
            this.indexNameLb = new System.Windows.Forms.Label();
            this.descTypeLb = new System.Windows.Forms.Label();
            this.descLb = new System.Windows.Forms.Label();
            this.idLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // whoLb
            // 
            this.whoLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whoLb.AutoSize = true;
            this.whoLb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.whoLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.whoLb.Location = new System.Drawing.Point(111, 17);
            this.whoLb.Name = "whoLb";
            this.whoLb.Size = new System.Drawing.Size(89, 25);
            this.whoLb.TabIndex = 0;
            this.whoLb.Text = "Mariusz";
            // 
            // indexNameLb
            // 
            this.indexNameLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.indexNameLb.AutoSize = true;
            this.indexNameLb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.indexNameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.indexNameLb.Location = new System.Drawing.Point(35, 17);
            this.indexNameLb.Name = "indexNameLb";
            this.indexNameLb.Size = new System.Drawing.Size(38, 25);
            this.indexNameLb.TabIndex = 1;
            this.indexNameLb.Text = "Id.";
            // 
            // descTypeLb
            // 
            this.descTypeLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descTypeLb.AutoSize = true;
            this.descTypeLb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descTypeLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.descTypeLb.Location = new System.Drawing.Point(259, 25);
            this.descTypeLb.Name = "descTypeLb";
            this.descTypeLb.Size = new System.Drawing.Size(82, 15);
            this.descTypeLb.TabIndex = 2;
            this.descTypeLb.Text = "Ostatni zakup:";
            // 
            // descLb
            // 
            this.descLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descLb.AutoSize = true;
            this.descLb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.descLb.Location = new System.Drawing.Point(358, 24);
            this.descLb.Name = "descLb";
            this.descLb.Size = new System.Drawing.Size(87, 16);
            this.descLb.TabIndex = 3;
            this.descLb.Text = "Honda Civic";
            // 
            // idLb
            // 
            this.idLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLb.AutoSize = true;
            this.idLb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.idLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.idLb.Location = new System.Drawing.Point(69, 17);
            this.idLb.Name = "idLb";
            this.idLb.Size = new System.Drawing.Size(24, 25);
            this.idLb.TabIndex = 4;
            this.idLb.Text = "1";
            // 
            // klienciControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.idLb);
            this.Controls.Add(this.descLb);
            this.Controls.Add(this.descTypeLb);
            this.Controls.Add(this.indexNameLb);
            this.Controls.Add(this.whoLb);
            this.Name = "klienciControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(525, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whoLb;
        private System.Windows.Forms.Label indexNameLb;
        private System.Windows.Forms.Label descTypeLb;
        private System.Windows.Forms.Label descLb;
        private System.Windows.Forms.Label idLb;
    }
}
