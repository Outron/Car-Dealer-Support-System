using CarDealerSupportSystem.SellerFormPanels;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class ServForm : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public ServForm()
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

        private void LeftMenuBtn1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new MainPanel());
        }

        private void LeftMenuBtn2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new NewTasksPanel());
        }

        private void LeftMenuBtn3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CarsPanel());
        }

        private void LeftMenuBtn4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ClientsForm());
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
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TopLabel.Text = currentBtn.Text;
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

        // End Drag Form

    }
}
