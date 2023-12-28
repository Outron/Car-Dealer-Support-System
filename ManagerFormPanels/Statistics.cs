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

            var shops = db.Zamowienia
                .Join(
                db.Pracownicy,
                Pracownik => Pracownik.IdPracownika,
                Zamowienie => Zamowienie.IdPracownika,
                (Zamowienie, Pracownik) => new { Zamowienie, Pracownik })
                .Join(
                db.Salony,
                zamPracownik => zamPracownik.Pracownik.IdSalonu,
                sal => sal.IdSalonu,
                (zamPracownik, sal) => new
                {
                    zamowieniePracownik = zamPracownik.Pracownik,
                    idSalon = sal.IdSalonu,
                    salon = sal.Miejscowosc,
                    ulica = sal.Ulica,
                    cena = zamPracownik.Zamowienie.CalkowityKoszt

                })
                .GroupBy(x => x.idSalon)
                .Select(s => new
                {
                    idt = s.Key,
                    id = s.Select(id=>id.idSalon),
                    miejscowosc = s.Select(sa => sa.salon),
                    ulica = s.Select(u => u.ulica),
                    c = s.Sum(i => i.cena)
                })
                .OrderByDescending(o => o.c)
                .ToList();
                this.BestShopGridView.DataSource = shops;
        }

       
    }
}
