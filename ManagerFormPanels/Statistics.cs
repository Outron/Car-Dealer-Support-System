using System;
using CarDealerSupportSystem.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CarDealerSupportSystem.ManagerFormPanels
{
    public partial class Statistics : Form
    {
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        public Statistics()
        {
            InitializeComponent();
        }

        private void bt1UpperBar_Click(object sender, EventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            var shops = db.Zamowienia.Join(
                db.Pracownicy,
                p => p.IdPracownika,
                z => z.IdPracownika,
                (z, p) => new { Zamowienie = z, Pracownik = p })
                .Join(
                db.Salony,
                pS => pS.Pracownik.IdSalonu,
                S => S.IdSalonu,
                (pS, S) => new { Pracownik = pS, Salon = S }).Select(x => new { x.Salon.IdSalonu, x.Salon.Miejscowosc, x.Salon.Ulica }).ToList();
                this.BestShopGridView.DataSource = shops;
        }

       
    }
}
