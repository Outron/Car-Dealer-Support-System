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
        private string _serviceName;
        private int _taskId;
        private readonly Color gridDefaultBackColor;
        public event EventHandler MyEvent;
        public NewTasksPanel()
        {
            InitializeComponent();
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
                                join sz in db.SamochodyZamowienia on z.IdZamowienia equals sz.IdZamowienia
                                join u in db.Uslugi on sz.IdUslugi equals u.IdUslugi
                                join s in db.Samochody on sz.IdSamochodu equals s.IdSamochodu
                                select new { z.IdZamowienia, s.Marka, u.Nazwa }).ToList();
                if (newTasks is not null)
                {
                    _serviceName = newTasks[2].ToString();
                    _taskId = int.Parse(newTasks[0].ToString());
                    TasksGridView.Columns.Clear();
                    TasksGridView.Columns.Add("IdZamowienia", "ID Zamówienia");
                    TasksGridView.Columns.Add("Marka", "Marka Samochodu");
                    TasksGridView.Columns.Add("Nazwa", "Nazwa Usługi");
                    TasksGridView.Columns[0].DataPropertyName = "IdZamowienia";
                    TasksGridView.Columns[1].DataPropertyName = "Marka";
                    TasksGridView.Columns[2].DataPropertyName = "Nazwa";
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

        private void TasksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (salon_samochodowyContext db = new())
                {
                    var taskMoreInfo = (from z in db.Zamowienia
                                        join sz in db.SamochodyZamowienia on z.IdZamowienia equals sz.IdZamowienia
                                        join s in db.Samochody on sz.IdSamochodu equals s.IdSamochodu
                                        join k in db.Klienci on z.IdKlienta equals k.IdKlienta
                                        select new string[] { k.Imie, k.Nazwisko, k.Telefon, k.Email, s.Marka, s.Model, s.  });
                }
                TaskInfoForm infoForm = new(this, _taskId, _serviceName);
                infoForm.Show();
            }
        }

        private void TasksGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            TasksGridView.ClearSelection();
        }
    }
}
