using CarDealerSupportSystem.ManagerFormPanels;
using CarDealerSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopLoginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // End Drag Form

        private void button2_Click(object sender, EventArgs e)
        {
            //after clicking this button, the application will open the second form after successful login

            var db = new salon_samochodowyContext();
            var loginData = db.Pracownicy.Join(db.Role, p => p.KodRoli, r => r.KodRoli, (p, r) => new { p, r }).Where(pr => pr.p.Login == UsernameTextBox.Text).FirstOrDefault();

            // check if the login and password are correct then check role and open the correct form
            if (loginData != null && loginData.p.Login == UsernameTextBox.Text && ((loginData.p.Haslo == PasswordTextBox.Text) || (loginData.p.Haslo == null && PasswordTextBox.Text == "")))
            {
                /* if (loginData.r.KodRoli == "ADM")
                   {
                       AdminPanel adminpanel = new AdminPanel();
                       adminpanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                       adminpanel.RoleLabel.Text = loginData.r.Nazwa;
                       adminpanel.Show();
                       this.Hide();
                   }
               */
                /* else */ if (loginData.r.KodRoli == "SPR")
                {
                    SellerPanel sellerpanel = new SellerPanel();
                    sellerpanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                    sellerpanel.RoleLabel.Text = loginData.r.Nazwa;
                    sellerpanel.Show();
                    this.Hide();
                }
                else if (loginData.r.KodRoli == "KRW")
                {
                    ManagerPanel managerpanel = new ManagerPanel();
                    managerpanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                    managerpanel.RoleLabel.Text = loginData.r.Nazwa;
                    managerpanel.Show();
                    this.Hide();
                }
                //else if (loginData.r.KodRoli == "SRW")
                //{
                //    ServicePanel servicepanel = new ServicePanel();
                //    servicepanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                //    servicepanel.RoleLabel.Text = loginData.r.Nazwa;
                //    servicepanel.Show();
                //    this.Hide();
                //}

                else
                {   // role is not correct
                    MessageBox.Show("Nieprawidłowa rola");
                }
            }
            else
            {   // show the label with information about wrong login or password
                WrongLoginLabel.Visible = true;
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //quit the application
            Application.Exit();
        }

    }
}
