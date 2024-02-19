namespace CarDealerSupportSystem.ManagerFormPanels
{
    partial class paramField
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
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.modelPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modelPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.modelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelTextBox.ForeColor = System.Drawing.Color.Silver;
            this.modelTextBox.Location = new System.Drawing.Point(55, 15);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(261, 28);
            this.modelTextBox.TabIndex = 27;
            this.modelTextBox.Tag = "Imię";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(15, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 1);
            this.panel6.TabIndex = 26;
            // 
            // modelPicBox
            // 
            this.modelPicBox.Image = global::CarDealerSupportSystem.Properties.Resources.clipboard;
            this.modelPicBox.Location = new System.Drawing.Point(15, 15);
            this.modelPicBox.Name = "modelPicBox";
            this.modelPicBox.Size = new System.Drawing.Size(33, 35);
            this.modelPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modelPicBox.TabIndex = 28;
            this.modelPicBox.TabStop = false;
            // 
            // paramField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelPicBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.panel6);
            this.Name = "paramField";
            this.Size = new System.Drawing.Size(335, 74);
            ((System.ComponentModel.ISupportInitialize)(this.modelPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox modelPicBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Panel panel6;
    }
}
