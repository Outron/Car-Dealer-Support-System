using CarDealerSupportSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class NewTasksPanel : Form
    {
        private int _taskId;
        private string _servName;
        private int servId;
        private readonly Color gridDefaultBackColor;
        public NewTasksPanel(int id)
        {
            InitializeComponent();
            this.servId = id;
            gridDefaultBackColor = TasksGridView.DefaultCellStyle.BackColor;
        }

        private void NewTasksPanel_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        public void LoadTasks()
        {
            using (salon_samochodowyContext db = new())
            {
                var newTasks = (from z in db.Zamowienia
                                join szu in db.ZamowieniaSamochodyUslugi on z.IdZamowienia equals szu.IdZamowienia
                                join u in db.Uslugi on szu.IdUslugi equals u.IdUslugi
                                join s in db.Samochody on szu.IdSamochodu equals s.IdSamochodu
                                orderby z.IdZamowienia
                                where szu.Status == "wolne" && szu.IdPracownika == null
                                select new { z.IdZamowienia, s.Marka, s.Model, u.Nazwa }).ToList();
                if (newTasks is not null)
                {
                    TasksGridView.Columns.Clear();
                    TasksGridView.Columns.Add("IdZamowienia", "ID Zamówienia");
                    TasksGridView.Columns.Add("Marka", "Marka samochodu");
                    TasksGridView.Columns.Add("Model", "Model samochodu");
                    TasksGridView.Columns.Add("Nazwa", "Nazwa usługi");
                    TasksGridView.Columns[0].DataPropertyName = "IdZamowienia";
                    TasksGridView.Columns[1].DataPropertyName = "Marka";
                    TasksGridView.Columns[2].DataPropertyName = "Model";
                    TasksGridView.Columns[3].DataPropertyName = "Nazwa";
                    TasksGridView.DefaultCellStyle.ForeColor = Color.White;
                    TasksGridView.DataSource = newTasks;
                }
            }
        }

        private void TasksGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TasksGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void TasksGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TasksGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = gridDefaultBackColor;
            }
        }

        private void TasksGridView_SelectionChanged(object sender, EventArgs e)
        {
            TasksGridView.ClearSelection();
        }

        //dodatkowe info odnosnie roboty dla serwisanta
        private void TasksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string[] taskInfo;
                using (salon_samochodowyContext db = new())
                {
                    _taskId = (int)TasksGridView.Rows[e.RowIndex].Cells[0].Value;
                    var taskMoreInfo = (from z in db.Zamowienia
                                        join sz in db.ZamowieniaSamochodyUslugi on z.IdZamowienia equals sz.IdZamowienia
                                        join s in db.Samochody on sz.IdSamochodu equals s.IdSamochodu
                                        join k in db.Klienci on z.IdKlienta equals k.IdKlienta
                                        join p in db.Pracownicy on z.IdPracownika equals p.IdPracownika
                                        join u in db.Uslugi on sz.IdUslugi equals u.IdUslugi
                                        where z.IdZamowienia == _taskId
                                        select new string[] { _taskId.ToString(), k.Imie, k.Nazwisko, k.Telefon, k.Email, s.Marka, s.Model, s.TypSilnika, s.TypNadwozia, p.Imie, p.Nazwisko, s.IdSamochodu.ToString(), u.IdUslugi.ToString() }).FirstOrDefault();
                    taskInfo = taskMoreInfo;
                }
                TaskInfoForm infoForm = new(this, taskInfo,servId);
                infoForm.Show();
            }
        }

        private void TasksGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            TasksGridView.ClearSelection();
        }
    }
}
