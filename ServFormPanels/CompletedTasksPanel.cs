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
    public partial class CompletedTasksPanel : Form
    {
        private readonly int id;
        public CompletedTasksPanel(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void SearchClientsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompletedTasksPanel_Load(object sender, EventArgs e)
        {
            using salon_samochodowyContext db = new();
            var completedTasks = (from szu in db.ZamowieniaSamochodyUslugi
                                  join u in db.Uslugi on szu.IdUslugi equals u.IdUslugi
                                  where szu.Status == "zakończone" && szu.IdPracownika == this.id
                                  select new { szu.IdZamowienia, u.Nazwa, szu.Status }).ToList();
            CompletedTasksGridView.Columns.Clear();
            CompletedTasksGridView.Columns.Add("IdZamowienia", "ID Zamówienia");
            CompletedTasksGridView.Columns.Add("Nazwa", "Nazwa usługi");
            CompletedTasksGridView.Columns.Add("Status", "Status");
            CompletedTasksGridView.Columns[0].DataPropertyName = "IdZamowienia";
            CompletedTasksGridView.Columns[1].DataPropertyName = "Nazwa";
            CompletedTasksGridView.Columns[2].DataPropertyName = "Status";
            CompletedTasksGridView.DefaultCellStyle.ForeColor = Color.White;
            CompletedTasksGridView.DataSource = completedTasks;
        }

        private void CompletedTasksGridView_SelectionChanged(object sender, EventArgs e)
        {
            CompletedTasksGridView.ClearSelection();
        }
    }
}
