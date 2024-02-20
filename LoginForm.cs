using CarDealerSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class LoginForm : Form
    {
        public string login;
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
            try
            {
                var db = new salon_samochodowyContext();
            // join role to pracownicy
            var loginData = db.Pracownicy.Join(db.Role, p => p.KodRoli, r => r.KodRoli, (p, r) => new { p, r }).Where(p => p.p.Login == UsernameTextBox.Text && p.p.Haslo == PasswordTextBox.Text).FirstOrDefault();
          
            // get id of the logged user
            var id = db.Pracownicy.Where(p => p.Login == UsernameTextBox.Text && p.Haslo == PasswordTextBox.Text).Select(p => p.IdPracownika).FirstOrDefault();

                if (loginData == null)
                {
                    WrongLoginLabel.Text = "Logowanie nie powiodło się!";
                    WrongLoginLabel.Visible = true;
                    Log.SaveLog("Logowanie pracownika nie powiodło się", LogType.Blad);
                    return;
                }
                switch (loginData.r.KodRoli)
                {
                    case "ADM":
                        AdminForm adminpanel = new AdminForm(id);
                        Log.SaveLog("Wykryto logowanie do systemu, pracownik: " + loginData.p.Login, LogType.Informacja);
                        adminpanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                        adminpanel.RoleLabel.Text = loginData.r.Nazwa;
                        adminpanel.Show();
                        this.Hide();
                        break;
                    case "SPR":
                        SellerPanel sellerpanel = new SellerPanel(id);
                        Log.SaveLog("Wykryto logowanie do systemu, pracownik: " + loginData.p.Login, LogType.Informacja);
                        sellerpanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                        sellerpanel.RoleLabel.Text = loginData.r.Nazwa;
                        sellerpanel.Show();
                        this.Hide();
                        break;
                    case "KRW":
                        ManagerPanel managerpanel = new ManagerPanel(id);
                        Log.SaveLog("Wykryto logowanie do systemu, pracownik: " + loginData.p.Login, LogType.Informacja);
                        managerpanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                        managerpanel.RoleLabel.Text = loginData.r.Nazwa;
                        managerpanel.Show();
                        this.Hide();
                        break;
                    case "SRW":
                        ServForm servicepanel = new ServForm(id);
                        Log.SaveLog("Wykryto logowanie do systemu, pracownik: " + loginData.p.Login, LogType.Informacja);
                        servicepanel.NameLabel.Text = loginData.p.Imie + " " + loginData.p.Nazwisko;
                        servicepanel.RoleLabel.Text = loginData.r.Nazwa;
                        servicepanel.Show();
                        this.Hide();
                        break;
                    default:
                        Log.SaveLog("Logowanie pracownika nie powiodło się", LogType.Blad);
                        WrongLoginLabel.Text = "Nieprawidłowa rola";
                        WrongLoginLabel.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message, caption: "Logowanie się nie powiodło");
                Log.SaveLog("Logowanie pracownika nie powiodło się", LogType.Blad);
            }
       }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
