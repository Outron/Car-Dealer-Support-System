using CarDealerSupportSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class UsersManagePanel : Form
    {
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        private readonly List<Pracownicy> workers;
        private readonly Color gridDefaultBackColor;
        private readonly Color backColor;
        private bool passHidden = true;
        private int lastClickedRowIndex = -1;
        public UsersManagePanel()
        {
            workers=db.Pracownicy.ToList();
            InitializeComponent();
            gridDefaultBackColor = UsersGridView.DefaultCellStyle.BackColor;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UsersGridView.DataSource = workers;
            //foreach(DataGridViewRow row in UsersGridView.Rows)
            //{
            //    row.Cells["Haslo"].Value = new string('*', row.Cells["Haslo"].Value.ToString().Length);
            //}
        }

        private void SearchUsersTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchValue = SearchUsersTextBox.Text.ToLower();
            var clients = db.Pracownicy.Where(c => c.Nazwisko.ToLower().Contains(searchValue)).ToList();
            UsersGridView.DataSource = clients;
        }

        private void UsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {//do wywalenia narazie
            if (e.ColumnIndex == 2 && e.RowIndex>=0)
            {
               // DataGridViewCell currCell= UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (passHidden)
                {
                    UsersGridView.Rows[e.RowIndex].Cells[2].Value= workers[e.RowIndex].Haslo.ToString();
                    passHidden = false;
                }
                else
                {
                    UsersGridView.Rows[e.RowIndex].Cells[2].Value = new string('*',workers[e.RowIndex].Haslo.ToString().Length);
                    passHidden = true;
                }
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm userForm = new AddUserForm(this);
            userForm.ShowDialog();
        }

        private void UsersGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
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
                using (salon_samochodowyContext db = new salon_samochodowyContext())
                {
                    //workerToFind = db.Pracownicy
                    //    .Where(pracownik => pracownik.IdPracownika == workerId)
                    //    .Select(pracownik => new[] {pracownik.Imie,pracownik.Nazwisko,pracownik.Login,pracownik.Haslo,pracownik.Adres,pracownik.Telefon,pracownik.Email,pracownik.KodRoli})
                    //    .FirstOrDefault(); //dziala ale dobrze by bylo dorzucic nazwe roli nie skrot
                    workerToFind = (from pracownik in db.Pracownicy
                                   join r in db.Role on pracownik.KodRoli equals r.KodRoli
                                   where pracownik.IdPracownika == workerId
                                   select new string[] { pracownik.Imie, pracownik.Nazwisko, pracownik.Login, pracownik.Haslo, pracownik.Adres, pracownik.Telefon, pracownik.Email, r.Nazwa, pracownik.IdPracownika.ToString() }).FirstOrDefault();

                }
                // EditUserForm editUserForm= new EditUserForm(this,workerToFind);
                //editUserForm.ShowDialog();
                UserInfoForm infoForm = new UserInfoForm(this,workerToFind);
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
            UsersGridView.DataSource = db.Pracownicy.ToList();
        }
    }
}
