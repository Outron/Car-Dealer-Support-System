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
    public partial class OrdersPanel : Form
    {
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        public OrdersPanel()
        {
            InitializeComponent();
        }

        private void OrdersPanel_Load(object sender, EventArgs e)
        {
            var CarNameOrders = db.Zamowienia
                 .Join(db.ZamowieniaSamochodyUslugi,
                       z => z.IdZamowienia,
                       s => s.IdZamowienia,
                       (z, s) => new { z, s })
                 .Join(db.Samochody,
                       zs => zs.s.IdSamochodu,
                       s => s.IdSamochodu,
                       (zs, s) => new { zs, s })
                 .Select(result => new { result.s.Marka, result.s.Model })
                 .ToList();



            //var Orders = db.Database.ExecuteSqlRaw("SELECT * FROM zamowienia zam JOIN zamowienia_samochody_uslugi zsu ON zam.id_zamowienia = zsu.id_zamowienia JOIN samochody s ON zsu.id_samochodu = s.id_samochodu;");
            var orders = db.Zamowienia.ToList();
            OrdersGridView.DataSource = orders;
           
            //disp orders in console
            foreach (var name in CarNameOrders)
            {
                Console.WriteLine(name.Marka + " " + name.Model);
            }

        }

        private void OrdersGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrdersGridView.ClearSelection();
        }
    }
}
