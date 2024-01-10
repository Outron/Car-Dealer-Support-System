using CarDealerSupportSystem.Models;
using CarDealerSupportSystem.SellerFormPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class EditUserForm : Form
    {
        private UsersManagePanel mainForm;
        private readonly string[] userToEditValues;
        private Func<string, bool> isOnlyDigit = phone => phone.All(char.IsDigit);
        public EditUserForm(Form mainForm, string[] worker)
        {
            this.mainForm = mainForm as UsersManagePanel;
            this.userToEditValues = worker;
            InitializeComponent();
        }
        private void SetTextBoxes()
        {
            nameTextBox.Text = userToEditValues[0];
            surnameTextBox.Text = userToEditValues[1];
            usernameTextBox.Text = userToEditValues[2];
            passwordTextBox.Text = userToEditValues[3];
            addressTextBox.Text = userToEditValues[4];
            phoneTextBox.Text = userToEditValues[5];  //email i adres nie wyswietlane
            emailTextBox.Text = userToEditValues[6];  //kod roli bd pod 7 indeksem
            rolesComboBox.SelectedItem = userToEditValues[7];
        }
        private void SetTags()
        {
            nameTextBox.Tag = userToEditValues[0];
            surnameTextBox.Tag = userToEditValues[1];
            usernameTextBox.Tag = userToEditValues[2];
            passwordTextBox.Tag = userToEditValues[3];
            addressTextBox.Tag = userToEditValues[4];
            phoneTextBox.Tag = userToEditValues[5];  //email i adres nie wyswietlane
            emailTextBox.Tag = userToEditValues[6];  //kod roli bd pod 7 indeksem
        }
        private void EditUserForm_Load(object sender, EventArgs e)
        {
            //placeholdery ustawiane
            SetTextBoxes();
            SetTags();
            label1.Select();
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



        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Napewno zamknąć? Niezatwierdzone zmiany zostaną usunięte.", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void anyTextBox_Enter(object sender, EventArgs e)
        {
            var currTextBox = sender as TextBox;
            if (userToEditValues.Contains(currTextBox.Text))
            {
                if ((string)currTextBox.Tag=="Haslo")
                {
                    //currTextBox.PasswordChar = '*';
                }
                currTextBox.Text = "";
                currTextBox.ForeColor = Color.White;
            }
        }

        private void anyTextBox_Leave(object sender, EventArgs e)
        {
            var currTextBox = sender as TextBox;
            if (currTextBox.Text == "")
            {
                currTextBox.Text = (string)currTextBox.Tag;
                currTextBox.ForeColor = Color.Silver;
            }
        }

        private void rolesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text) || passwordTextBox.Text == "Hasło" || passwordTextBox.Text.Length < 8)
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordTextBox, "Hasło nie może pozostać puste oraz powinno mieć minimum 8 znaków");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTextBox, null);
            }

        }
        private string roleAbr()
        {
            string roleCode = string.Empty;
            if (rolesComboBox.SelectedItem.ToString() == "Sprzedawca")
            {
                roleCode = "SPR";
            }
            else if (rolesComboBox.SelectedItem.ToString() == "Serwisant")
            {
                roleCode = "SRW";
            }
            else if (rolesComboBox.SelectedItem.ToString() == "Kierownik")
            {
                roleCode = "KRW";
            }
            return roleCode;
        }
        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && rolesComboBox.SelectedItem != null)
            {
                using (salon_samochodowyContext db = new salon_samochodowyContext())
                {
                    var recordToUpdate = db.Pracownicy.FirstOrDefault(pracownik => pracownik.IdPracownika == int.Parse(userToEditValues[8]));
                    if (recordToUpdate != null)
                    {
                        recordToUpdate.Imie = nameTextBox.Text; recordToUpdate.Nazwisko = surnameTextBox.Text;
                        recordToUpdate.Login = usernameTextBox.Text; recordToUpdate.Haslo = passwordTextBox.Text;
                        recordToUpdate.Email = emailTextBox.Text; recordToUpdate.Adres = addressTextBox.Text;
                        recordToUpdate.Telefon = phoneTextBox.Text; recordToUpdate.KodRoli = roleAbr();
                        db.SaveChanges();
                        mainForm.UsersGridView.DataSource = null;
                        mainForm.UsersGridView.DataSource = db.Pracownicy.ToList();//insta aktualizacja grida
                    }
                }
            }

        }
        private bool isEmailValid(string email)
        {
            string pattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!isEmailValid(emailTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || emailTextBox.Text == "E-mail")
            {
                e.Cancel = true;
                errorProvider1.SetError(emailTextBox, "Poprawny format adresu: example@domena.com");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(emailTextBox, null);
            }
        }
        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!isOnlyDigit(phoneTextBox.Text) || phoneTextBox.Text.Length != 9)
            {
                e.Cancel = true;
                errorProvider1.SetError(phoneTextBox, "Numer telefonu składa się z 9 cyfr");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(phoneTextBox, null);
            }
        }

        private void passShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passShowCheckBox.Checked)
            {
                this.passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
