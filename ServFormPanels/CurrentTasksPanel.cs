using CarDealerSupportSystem.Models;
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
    public partial class CurrentTasksPanel : Form
    {
        private readonly int servId;
        private int _taskId;
        private readonly Color gridDefaultBackColor;
        public CurrentTasksPanel(int id)
        {
            this.servId = id;
            InitializeComponent();
            gridDefaultBackColor = TasksGridView.DefaultCellStyle.BackColor;
        }

        private void CurrentTasksPanel_Load(object sender, EventArgs e)
        {
            LoadCurrentTasks();
        }

        public void LoadCurrentTasks()
        {
            using salon_samochodowyContext db = new();
            var currentTasks = (from z in db.Zamowienia
                                join sz in db.ZamowieniaSamochodyUslugi on z.IdZamowienia equals sz.IdZamowienia
                                join s in db.Samochody on sz.IdSamochodu equals s.IdSamochodu
                                join u in db.Uslugi on sz.IdUslugi equals u.IdUslugi
                                where sz.IdPracownika == this.servId && sz.Status == "wtrakcie"  
                                select new { z.IdZamowienia, s.Marka, s.Model, u.Nazwa }).ToList();
            currentTasks = currentTasks.Any() ? currentTasks : null;
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
            TasksGridView.CellMouseEnter += TasksGridView_CellMouseEnter1;
            TasksGridView.CellClick += TasksGridView_CellClick1;
            if (currentTasks is not null)
            {
                TasksGridView.DataSource = currentTasks;
            }
            else
            {
                TasksGridView.Rows.Add();
                TasksGridView.Rows[0].Cells[0].Value = "Brak aktualnych zleceń";
                TasksGridView.CellMouseEnter -= TasksGridView_CellMouseEnter1;
                TasksGridView.CellClick -= TasksGridView_CellClick1;
            }
        }

        private void TasksGridView_CellClick1(object sender, DataGridViewCellEventArgs e)//info o wykonywanym zadaniu
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
                                        where z.IdZamowienia == _taskId && sz.IdPracownika==this.servId && sz.Status=="wtrakcie"
                                        select new string[] { _taskId.ToString(), k.Imie, k.Nazwisko, k.Telefon, k.Email, s.Marka, s.Model, s.TypSilnika, s.TypNadwozia, p.Imie, p.Nazwisko, s.IdSamochodu.ToString(), u.IdUslugi.ToString(),p.IdPracownika.ToString()}).FirstOrDefault();
                    taskInfo = taskMoreInfo;
                }
                TaskInfoForm infoForm = new(this, taskInfo,servId);
                infoForm.Show();
            }
        }

        private void TasksGridView_CellMouseEnter1(object sender, DataGridViewCellEventArgs e)
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
    }
}
