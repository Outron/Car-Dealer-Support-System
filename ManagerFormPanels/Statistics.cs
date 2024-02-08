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
using System.Collections;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Internal;

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
        private class salony
        {
            public int miejsceSalonu { get; set; }
            public string miejscowosc { get; set; }
            public int pracownik { get; set; }   
            public string ulica { get; set; }
            public double? cena { get; set; }
        }
        private class samochody
        {
            public int idsamochodu { get; set; }
            public string marka { get; set; }
            public int ile { get; set; }
        }
        private void Statistics_Load(object sender, EventArgs e)
        {
              
            List<salony> shops = new List<salony>();
            try
            {
                shops = db.Zamowienia
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
                    zamPracownik = zamPracownik.Pracownik,
                    zamowieniePracownik = zamPracownik.Pracownik.IdSalonu,
                    idSalon = sal.IdSalonu,
                    salon = sal.Miejscowosc,
                    uli = sal.Ulica,
                    cena = zamPracownik.Zamowienie.CalkowityKoszt

                })
                .ToList()
                .GroupBy(y => y.idSalon)
                .Select(y => new salony
                {
                    miejsceSalonu = 1,
                    miejscowosc = y.FirstOrDefault().salon,
                    ulica = y.FirstOrDefault().uli,
                    pracownik = y.FirstOrDefault().idSalon,
                    cena = y.Sum(s => s.cena)
                })
                .OrderByDescending(y => y.cena)
                .ToList();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Błąd serwera bazy danych najlepszy salon");
            }
            if (shops == null || shops.Count == 0)
                return;

            int i = 1;
            shops.ForEach(shop => { shop.miejsceSalonu = i++; });

            List<samochody> cars = new List<samochody>();

            cars = db.Zamowienia
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
                    zamPracownik = zamPracownik.Pracownik,
                    zamPracId = zamPracownik.Pracownik.IdSalonu,
                    idSalon = sal.IdSalonu,
                    salon = sal.Miejscowosc,
                    uli = sal.Ulica,
                    cena = zamPracownik.Zamowienie.CalkowityKoszt,
                    idZam = zamPracownik.Zamowienie.IdZamowienia,
                })
                .Join(
                db.SamochodyZamowienia,
                zamPracSal => zamPracSal.idZam,
                samochodZamowienie => samochodZamowienie.IdZamowienia,
                (zamPracSal, samochodZamowienie) => new
                {
                    zamPracSal,
                    samochodZamowienie
                })
                .Join(
                db.Samochody,
                zamPracSalSamZam => zamPracSalSamZam.samochodZamowienie.IdSamochodu,
                samochod => samochod.IdSamochodu,
                (zamPracSalSamZam, samochod) => new
                {
                    zamPracSalSamZam,samochod
                })
                .ToList()
                .GroupBy(y=>y.samochod.IdSamochodu)
                .Select(y => new samochody
                {
                    ile = y.Count(),
                    marka=y.FirstOrDefault().samochod.Marka,
                })
                .OrderByDescending(y=>y.ile)
                .ToList();

            this.BestShopGridView.DataSource = shops;
            this.BestCarGridView.DataSource = cars;
        }

        private void samochodyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BestShopGridView_SelectionChanged(object sender, EventArgs e)
        {
            BestShopGridView.ClearSelection();
        }

        private void BestCarGridView_SelectionChanged(object sender, EventArgs e)
        {
            BestCarGridView.ClearSelection();
        }
    }
}
