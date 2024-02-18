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
           // var orders = db.Zamowienia.Join(db.ZamowieniaSamochodyUslugi, z => z.IdZamowienia, s => s.IdZamowienia, (z, s) => new { z, s }).Join(db.Samochody, z => z.s.IdSamochodu, s => s.IdSamochodu, (z, s) => new { z, s }).ToList();
           var orders = db.Zamowienia.ToList();
            //OrdersGridView.DataSource = orders;

            
            // column samochod in orders gridview has to be filled with the data from the Samochody table but it must be connected with the ZamowieniaSamochodyUslugi table and the Zamowienia table
            var order2s = orders.Join(db.ZamowieniaSamochodyUslugi, z => z.IdZamowienia, s => s.IdZamowienia, (z, s) => new { z, s }).Join(db.Samochody, z => z.s.IdSamochodu, s => s.IdSamochodu, (z, s) => new { z, s }).ToList();
            OrdersGridView.DataSource = order2s;


            



           //disp orders in console
           //foreach (var order in orders)
           // {
           //     Console.WriteLine(order.z.z.IdZamowienia + " " + order.s.IdSamochodu + " " + order.s.Marka);
           // }

        }

        private void OrdersGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrdersGridView.ClearSelection();
        }

        private void zamowieniaSamochodyUslugiBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
