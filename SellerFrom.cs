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
    public partial class SellerPanel : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;

        public SellerPanel()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 57);
            LeftMenuPanel.Controls.Add(leftBorderBtn);
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

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(42, 42, 42);
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LeftMenuBtn1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            TopLabel.Text = LeftMenuBtn1.Text;
        }

        private void LeftMenuBtn2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            TopLabel.Text = LeftMenuBtn2.Text;
        }

        private void LeftMenuBtn3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            TopLabel.Text = LeftMenuBtn3.Text;
        }

        private void LeftMenuBtn4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            TopLabel.Text = LeftMenuBtn4.Text;
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

        private void TopLabel_Click(object sender, EventArgs e)
        {

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

        // End Drag Form

    }
}
