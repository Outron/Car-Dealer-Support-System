using CarDealerSupportSystem.Models;
using CarDealerSupportSystem.SellerFormPanels;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class UserInfoForm : Form
    {
        private readonly UsersManagePanel mainForm;
        private readonly string[] workerValues;
        public UserInfoForm(Form mainForm, string[] values)
        {
            this.mainForm = mainForm as UsersManagePanel;
            workerValues = values;
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = workerValues[0];
            surnameLabel.Text = workerValues[1];
            phoneLabel.Text = workerValues[5];
            addressLabel.Text = workerValues[4];
            emailLabel.Text = workerValues[6];
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
        private void closeFormButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            EditUserForm edit = new(mainForm, workerValues);
            edit.ShowDialog();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno usunąć wybranego użytkownika? Operacja jest nieodwracalna.", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                using salon_samochodowyContext db = new();
                try
                {
                    var workerToRemove = db.Pracownicy.Find(int.Parse(workerValues[8]));
                    if (workerToRemove != null)
                    {
                        db.Pracownicy.Remove(workerToRemove);
                        db.SaveChanges();
                    }
                }
                catch { MessageBox.Show("Wystąpił błąd. Pracownik jest odpowiedzialny za zamówienie. Brak możliwości usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                mainForm.UsersGridView.DataSource = null;
                mainForm.UsersGridView.DataSource = db.Pracownicy.ToList();
                MessageBox.Show("Pomyślnie usunięto użytkownika", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
