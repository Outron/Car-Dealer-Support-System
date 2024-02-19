using CarDealerSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class UsersManagePanel : Form
    {
        private readonly salon_samochodowyContext db = new();
        private readonly List<Pracownicy> workers;
        private readonly int adminID;
        private readonly Color gridDefaultBackColor;
        public UsersManagePanel(int id)
        {
            this.adminID = id;
            var salonID = (from p in db.Pracownicy
                           join s in db.Salony on p.IdSalonu equals s.IdSalonu
                           where p.IdPracownika == adminID
                           select p.IdSalonu).FirstOrDefault();
            workers = (from p in db.Pracownicy
                       join s in db.Salony on p.IdSalonu equals s.IdSalonu
                       where p.IdSalonu == salonID && p.IdPracownika != adminID
                       select p).ToList();
            InitializeComponent();
            gridDefaultBackColor = UsersGridView.DefaultCellStyle.BackColor;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UsersGridView.DataSource = workers;
        }

        private void SearchUsersTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchValue = SearchUsersTextBox.Text.ToLower();
            var clients = db.Pracownicy.Where(c => c.Nazwisko.ToLower().Contains(searchValue)).ToList();
            UsersGridView.DataSource = clients;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm userForm = new(this);
            userForm.ShowDialog();
        }

        public void UsersGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UsersGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void UsersGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UsersGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = gridDefaultBackColor;
            }
        }

        private void UsersGridView_SelectionChanged(object sender, EventArgs e)
        {
            UsersGridView.ClearSelection();
        }

        private void UsersGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string[] workerToFind;
                int workerId = (int)UsersGridView.Rows[e.RowIndex].Cells[0].Value;
                using (salon_samochodowyContext db = new())
                {
                    workerToFind = (from pracownik in db.Pracownicy
                                    join r in db.Role on pracownik.KodRoli equals r.KodRoli
                                    where pracownik.IdPracownika == workerId
                                    select new string[] { pracownik.Imie, pracownik.Nazwisko, pracownik.Login, pracownik.Haslo, pracownik.Adres, pracownik.Telefon, pracownik.Email, r.Nazwa, pracownik.IdPracownika.ToString() }).FirstOrDefault();
                }
                UserInfoForm infoForm = new(this, workerToFind);
                infoForm.Show();
            }
        }

        private void UsersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (passCheckBox.Checked == false)
            {
                if (e.ColumnIndex == 2)
                {
                    string originalValue = e.Value.ToString();
                    e.Value = new string('*', originalValue.Length);
                    e.FormattingApplied = true;
                }
            }
        }

        private void passCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UsersGridView.DataSource = null;
            UsersGridView.DataSource = workers;
        }
    }
}
