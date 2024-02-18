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
    public partial class MainPanel : Form
    {
        salon_samochodowyContext db = new salon_samochodowyContext();

        public MainPanel()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MakeOrderPanel makeorderpanel = new MakeOrderPanel();
            makeorderpanel.Show();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            //get the last 5 orders from the database and display them in the LastOrdersGrid grid
            var LastOrders = db.Zamowienia.OrderByDescending(z => z.Data).Take(6).ToList();
            LastOrdersGrid.DataSource = LastOrders;

        }
    }
}
