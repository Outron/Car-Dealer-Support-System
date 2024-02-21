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
        public int idPraco;
        public OrdersPanel(int idPrac)
        {
            InitializeComponent();
            this.idPraco = idPrac;
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
            var orders = db.Zamowienia.Where(p=> p.IdPracownika==idPraco).ToList();
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

        private void SearchClientsTextBox_TextChanged(object sender, EventArgs e)
        {

            var searchValue = SearchClientsTextBox.Text.ToLower();

            var ordersRight = db.Zamowienia.Where(p => p.IdPracownika == idPraco).ToList();

            var orders = ordersRight.Where(c => c.RodzajPlatnosci.ToLower().Contains(searchValue)
            || c.IdKlienta.ToString().Contains(searchValue) || c.RodzajPlatnosci.ToLower().Contains(searchValue)
            || c.IdZamowienia.ToString().Contains(searchValue)
            || c.Status.ToLower().Contains(searchValue) || c.CalkowityKoszt.ToString().Contains(searchValue)||c.Data.ToString().Contains(searchValue)).ToList();

            OrdersGridView.DataSource = orders;

        }
    }
}
