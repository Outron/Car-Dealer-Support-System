﻿using CarDealerSupportSystem.SellerFormPanels;
using CarDealerSupportSystem.ManagerFormPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class ManagerPanel : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public string login;

        public ManagerPanel(string l)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 57);
            LeftMenuPanel.Controls.Add(leftBorderBtn);
            login = l;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(134, 2, 12);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(51, 51, 51);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
               
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
               
            }
        }
        private void ActivateButton2(object senderBtn)
        {
            if (senderBtn != null)
            { 
                //Button
                currentBtn = (Button)senderBtn;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(42, 42, 42);
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            ActivateButton(LeftMenuBtn3, RGBColors.color1);
            SpisSamochodowButton.Visible = true;
            EditSpisSamochodowButton.Visible = true;
            try
            {
                OpenChildForm(new CarsPanel(login));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void LeftMenuBtn1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new MainPanel());
        }

        private void LeftMenuBtn2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new OrdersPanel());
        }

        private void LeftMenuBtn3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            SpisSamochodowButton.Visible = true;
            EditSpisSamochodowButton.Visible = true;
            try
            {
                OpenChildForm(new CarsPanel(login));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void LeftMenuBtn4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ClientsForm());
        }

        private void LeftMenuBtn5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Statistics());
        }



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            //after clicking this button, the application will open the first form
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Hide();

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            if(childForm.GetType() != typeof(CarsPanel))
            {
                SpisSamochodowButton.Visible = false;
                EditSpisSamochodowButton.Visible = false;
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TopLabel.Text = currentBtn.Text;
        }
        private void OpenChildForm2(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SpisSamochodowButton_Click(object sender, EventArgs e)
        {
            ActivateButton2(sender);
            OpenChildForm2(new CarsPanel(login));
        }

        private void EditSpisSamochodowButton_Click(object sender, EventArgs e)
        {
            ActivateButton2(sender);
            OpenChildForm2(new CarsManager(login));
        }




        // End Drag Form

    }
}
