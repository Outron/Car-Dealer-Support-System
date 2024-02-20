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
using System.Threading;

namespace CarDealerSupportSystem.ManagerFormPanels
{
    public partial class Statistics : Form
    {
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        public readonly int id;
        public Statistics(int i)
        {
            id = i;
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
            public string model { get; set; }
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
                Zamowienie => Zamowienie.IdPracownika,
                Pracownik => Pracownik.IdPracownika,
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

                var cars = 
                    (from sort in
                        (from lista in
                            (from tabela in
                                (from zsu in db.ZamowieniaSamochodyUslugi
                                join z in db.Zamowienia on zsu.IdZamowienia equals z.IdZamowienia
                                join p in db.Pracownicy on z.IdPracownika equals p.IdPracownika
                                join s in db.Salony on p.IdSalonu equals s.IdSalonu
                                join sam in db.Samochody on zsu.IdSamochodu equals sam.IdSamochodu
                                where s.IdSalonu == 38 && (z.TypZamowienia == "auto+uslug" || z.TypZamowienia == "zakupauta")
                                select new { id_samochodu = sam.IdSamochodu, model = sam.Model, idZamowienia = zsu.IdZamowienia }).ToList()
                            group tabela by new { tabela.idZamowienia, tabela.id_samochodu } into g
                            select new { id_samochodu = g.Key, Model = g.FirstOrDefault().model }).ToList()
                        group lista by new { lista.Model } into l
                        select new { idsamochodu = l.Key, m = l.FirstOrDefault().Model, i = l.Count() }).ToList()
                    orderby sort.i descending
                    select new {model = sort.m, ile = sort.i }).ToList();


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

        private void BestShopGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            RaportyForm raport = new RaportyForm(this);
            raport.ShowDialog();
        }
    }
}
