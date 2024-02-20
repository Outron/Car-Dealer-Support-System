namespace CarDealerSupportSystem
{
    partial class RaportyForm   {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zakonczoneButton = new System.Windows.Forms.Button();
            this.labelRaport = new System.Windows.Forms.Label();
            this.TopLoginPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.wTrakcieButton = new System.Windows.Forms.Button();
            this.zakonczoneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OkRaportButton = new System.Windows.Forms.Button();
            this.TopLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // zakonczoneButton
            // 
            this.zakonczoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.zakonczoneButton.BackgroundImage = global::CarDealerSupportSystem.Properties.Resources.check_circle;
            this.zakonczoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zakonczoneButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zakonczoneButton.FlatAppearance.BorderSize = 0;
            this.zakonczoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zakonczoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakonczoneButton.ForeColor = System.Drawing.Color.White;
            this.zakonczoneButton.Location = new System.Drawing.Point(61, 226);
            this.zakonczoneButton.Name = "zakonczoneButton";
            this.zakonczoneButton.Size = new System.Drawing.Size(140, 140);
            this.zakonczoneButton.TabIndex = 5;
            this.zakonczoneButton.Tag = "zakonczone";
            this.zakonczoneButton.UseVisualStyleBackColor = false;
            this.zakonczoneButton.Click += new System.EventHandler(this.button_click);
            // 
            // labelRaport
            // 
            this.labelRaport.AutoSize = true;
            this.labelRaport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.labelRaport.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRaport.ForeColor = System.Drawing.Color.White;
            this.labelRaport.Location = new System.Drawing.Point(53, 56);
            this.labelRaport.Name = "labelRaport";
            this.labelRaport.Size = new System.Drawing.Size(359, 47);
            this.labelRaport.TabIndex = 7;
            this.labelRaport.Text = "Raporty zamówienia";
            // 
            // TopLoginPanel
            // 
            this.TopLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TopLoginPanel.Controls.Add(this.button1);
            this.TopLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLoginPanel.Name = "TopLoginPanel";
            this.TopLoginPanel.Size = new System.Drawing.Size(494, 37);
            this.TopLoginPanel.TabIndex = 8;
            this.TopLoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopLoginPanel_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = global::CarDealerSupportSystem.Properties.Resources.x;
            this.button1.Location = new System.Drawing.Point(472, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 19);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeFormButton);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // wTrakcieButton
            // 
            this.wTrakcieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.wTrakcieButton.BackgroundImage = global::CarDealerSupportSystem.Properties.Resources.clock;
            this.wTrakcieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wTrakcieButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.wTrakcieButton.FlatAppearance.BorderSize = 0;
            this.wTrakcieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wTrakcieButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wTrakcieButton.ForeColor = System.Drawing.Color.White;
            this.wTrakcieButton.Location = new System.Drawing.Point(287, 226);
            this.wTrakcieButton.Name = "wTrakcieButton";
            this.wTrakcieButton.Size = new System.Drawing.Size(140, 140);
            this.wTrakcieButton.TabIndex = 9;
            this.wTrakcieButton.Tag = "wtrakcie";
            this.wTrakcieButton.UseVisualStyleBackColor = false;
            this.wTrakcieButton.Click += new System.EventHandler(this.button_click);
            // 
            // zakonczoneLabel
            // 
            this.zakonczoneLabel.AutoSize = true;
            this.zakonczoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.zakonczoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakonczoneLabel.ForeColor = System.Drawing.Color.White;
            this.zakonczoneLabel.Location = new System.Drawing.Point(40, 377);
            this.zakonczoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zakonczoneLabel.Name = "zakonczoneLabel";
            this.zakonczoneLabel.Size = new System.Drawing.Size(184, 20);
            this.zakonczoneLabel.TabIndex = 10;
            this.zakonczoneLabel.Text = "Zamówienia zakończone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zamówienia w trakcie";
            // 
            // OkRaportButton
            // 
            this.OkRaportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OkRaportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OkRaportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OkRaportButton.FlatAppearance.BorderSize = 0;
            this.OkRaportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkRaportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.OkRaportButton.ForeColor = System.Drawing.Color.White;
            this.OkRaportButton.Location = new System.Drawing.Point(185, 475);
            this.OkRaportButton.Name = "OkRaportButton";
            this.OkRaportButton.Size = new System.Drawing.Size(109, 30);
            this.OkRaportButton.TabIndex = 18;
            this.OkRaportButton.Text = "OK";
            this.OkRaportButton.UseVisualStyleBackColor = false;
            this.OkRaportButton.Click += new System.EventHandler(this.closeFormButton);
            // 
            // RaportyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(494, 548);
            this.ControlBox = false;
            this.Controls.Add(this.OkRaportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zakonczoneLabel);
            this.Controls.Add(this.wTrakcieButton);
            this.Controls.Add(this.TopLoginPanel);
            this.Controls.Add(this.labelRaport);
            this.Controls.Add(this.zakonczoneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaportyForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopLoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button zakonczoneButton;
        private System.Windows.Forms.Label labelRaport;
        private System.Windows.Forms.Panel TopLoginPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button wTrakcieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zakonczoneLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OkRaportButton;
    }
}

