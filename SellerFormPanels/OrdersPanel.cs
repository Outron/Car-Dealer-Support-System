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
    public partial class OrdersPanel : Form
    {
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        public OrdersPanel()
        {
            InitializeComponent();
        }

        private void OrdersPanel_Load(object sender, EventArgs e)
        {
            var orders = db.Zamowienia.ToList();
            OrdersGridView.DataSource = orders;
        }

        private void OrdersGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrdersGridView.ClearSelection();
        }
    }
}
