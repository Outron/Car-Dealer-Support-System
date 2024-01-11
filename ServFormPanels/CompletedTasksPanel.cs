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
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        public CompletedTasksPanel()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            var clients = db.Klienci.ToList();
            ClientsGridView.DataSource = clients;
        }

        private void SearchClientsTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchValue = SearchClientsTextBox.Text.ToLower();
            var clients = db.Klienci.Where(c => c.Telefon.ToLower().Contains(searchValue)).ToList();
            ClientsGridView.DataSource = clients;
        }
    }
}
