﻿namespace CarDealerSupportSystem
{
    partial class TaskInfoForm
    {
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
            this.acceptTaskButton = new System.Windows.Forms.Button();
            this.taskNumberLabel = new System.Windows.Forms.Label();
            this.TopLoginPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientPhoneLabel = new System.Windows.Forms.Label();
            this.clientEmailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.markaLabel = new System.Windows.Forms.Label();
            this.workerLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.engineTypeLabel = new System.Windows.Forms.Label();
            this.nadwozieLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TopLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // acceptTaskButton
            // 
            this.acceptTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.acceptTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acceptTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.acceptTaskButton.FlatAppearance.BorderSize = 0;
            this.acceptTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptTaskButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.acceptTaskButton.ForeColor = System.Drawing.Color.White;
            this.acceptTaskButton.Location = new System.Drawing.Point(290, 726);
            this.acceptTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.acceptTaskButton.Name = "acceptTaskButton";
            this.acceptTaskButton.Size = new System.Drawing.Size(227, 52);
            this.acceptTaskButton.TabIndex = 5;
            this.acceptTaskButton.Text = "Przyjmij zlecenie";
            this.acceptTaskButton.UseVisualStyleBackColor = false;
            // 
            // taskNumberLabel
            // 
            this.taskNumberLabel.AutoSize = true;
            this.taskNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.taskNumberLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskNumberLabel.ForeColor = System.Drawing.Color.White;
            this.taskNumberLabel.Location = new System.Drawing.Point(214, 60);
            this.taskNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskNumberLabel.Name = "taskNumberLabel";
            this.taskNumberLabel.Size = new System.Drawing.Size(336, 60);
            this.taskNumberLabel.TabIndex = 7;
            this.taskNumberLabel.Text = "Zamówienie nr";
            // 
            // TopLoginPanel
            // 
            this.TopLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TopLoginPanel.Controls.Add(this.button1);
            this.TopLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopLoginPanel.Name = "TopLoginPanel";
            this.TopLoginPanel.Size = new System.Drawing.Size(808, 45);
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
            this.button1.Location = new System.Drawing.Point(780, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // labelel
            // 
            this.labelel.AutoSize = true;
            this.labelel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.labelel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelel.ForeColor = System.Drawing.Color.White;
            this.labelel.Location = new System.Drawing.Point(24, 226);
            this.labelel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelel.Name = "labelel";
            this.labelel.Size = new System.Drawing.Size(155, 31);
            this.labelel.TabIndex = 9;
            this.labelel.Text = "Dane klienta:";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.clientNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientNameLabel.ForeColor = System.Drawing.Color.White;
            this.clientNameLabel.Location = new System.Drawing.Point(24, 268);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(160, 31);
            this.clientNameLabel.TabIndex = 10;
            this.clientNameLabel.Text = "Imienazwisko";
            // 
            // clientPhoneLabel
            // 
            this.clientPhoneLabel.AutoSize = true;
            this.clientPhoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.clientPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.clientPhoneLabel.Location = new System.Drawing.Point(24, 319);
            this.clientPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientPhoneLabel.Name = "clientPhoneLabel";
            this.clientPhoneLabel.Size = new System.Drawing.Size(93, 31);
            this.clientPhoneLabel.TabIndex = 11;
            this.clientPhoneLabel.Text = "Telefon";
            // 
            // clientEmailLabel
            // 
            this.clientEmailLabel.AutoSize = true;
            this.clientEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.clientEmailLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientEmailLabel.ForeColor = System.Drawing.Color.White;
            this.clientEmailLabel.Location = new System.Drawing.Point(24, 368);
            this.clientEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientEmailLabel.Name = "clientEmailLabel";
            this.clientEmailLabel.Size = new System.Drawing.Size(73, 31);
            this.clientEmailLabel.TabIndex = 12;
            this.clientEmailLabel.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dane samochodu:";
            // 
            // markaLabel
            // 
            this.markaLabel.AutoSize = true;
            this.markaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.markaLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.markaLabel.ForeColor = System.Drawing.Color.White;
            this.markaLabel.Location = new System.Drawing.Point(24, 472);
            this.markaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.markaLabel.Name = "markaLabel";
            this.markaLabel.Size = new System.Drawing.Size(94, 31);
            this.markaLabel.TabIndex = 14;
            this.markaLabel.Text = "Marka: ";
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.workerLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workerLabel.ForeColor = System.Drawing.Color.White;
            this.workerLabel.Location = new System.Drawing.Point(26, 143);
            this.workerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(220, 31);
            this.workerLabel.TabIndex = 15;
            this.workerLabel.Text = "Wystawione przez: ";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelLabel.ForeColor = System.Drawing.Color.White;
            this.modelLabel.Location = new System.Drawing.Point(24, 516);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(95, 31);
            this.modelLabel.TabIndex = 16;
            this.modelLabel.Text = "Model: ";
            // 
            // engineTypeLabel
            // 
            this.engineTypeLabel.AutoSize = true;
            this.engineTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.engineTypeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.engineTypeLabel.ForeColor = System.Drawing.Color.White;
            this.engineTypeLabel.Location = new System.Drawing.Point(24, 611);
            this.engineTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engineTypeLabel.Name = "engineTypeLabel";
            this.engineTypeLabel.Size = new System.Drawing.Size(140, 31);
            this.engineTypeLabel.TabIndex = 17;
            this.engineTypeLabel.Text = "Typ silnika: ";
            // 
            // nadwozieLabel
            // 
            this.nadwozieLabel.AutoSize = true;
            this.nadwozieLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nadwozieLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadwozieLabel.ForeColor = System.Drawing.Color.White;
            this.nadwozieLabel.Location = new System.Drawing.Point(24, 561);
            this.nadwozieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nadwozieLabel.Name = "nadwozieLabel";
            this.nadwozieLabel.Size = new System.Drawing.Size(172, 31);
            this.nadwozieLabel.TabIndex = 18;
            this.nadwozieLabel.Text = "Typ nadwozia: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(314, 368);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 274);
            this.textBox1.TabIndex = 19;
            // 
            // TaskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(808, 819);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nadwozieLabel);
            this.Controls.Add(this.engineTypeLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.markaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientEmailLabel);
            this.Controls.Add(this.clientPhoneLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.labelel);
            this.Controls.Add(this.TopLoginPanel);
            this.Controls.Add(this.taskNumberLabel);
            this.Controls.Add(this.acceptTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskInfoForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TaskInfoForm_Load);
            this.TopLoginPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptTaskButton;
        private System.Windows.Forms.Label taskNumberLabel;
        private System.Windows.Forms.Panel TopLoginPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelel;
        private System.Windows.Forms.Label clientEmailLabel;
        private System.Windows.Forms.Label clientPhoneLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label markaLabel;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label engineTypeLabel;
        private System.Windows.Forms.Label nadwozieLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
