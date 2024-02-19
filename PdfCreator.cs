using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CarDealerSupportSystem.Models;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CarDealerSupportSystem
{
    internal class PdfCreator
    {
        private readonly Document document;
        public PdfCreator(string fileName)
        {
            document = new();
            PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
        }
        private void DocOpen() => this.document.Open();
        private void DocClose() => this.document.Close();
        private void NewPage() => this.document.NewPage();
        private void Dispose() => this.document.Dispose();
        private void Add(IElement x) => this.document.Add(x);
        private void AddParagraph(string content, float size, float spacing, int align)
        {
            var bigFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, size);
            Paragraph paragraph = new(content, bigFont);
            paragraph.SpacingAfter = spacing;
            paragraph.Alignment = align;
            document.Add(paragraph);
        }

        private void AddTable(List<List<string>> itemsList, params string[] columnNames)
        {
            int rowsInTable = itemsList.Count();
            var bigFont = FontFactory.GetFont(BaseFont.TIMES_BOLD, BaseFont.CP1257, 12);
            var cellsFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, 12);
            if (rowsInTable > 0)
            {
                PdfPTable table = new(itemsList[0].Count());
                table.WidthPercentage = 100;
                float[] centerValues = Enumerable.Repeat(-1f, itemsList[0].Count()).ToArray();
                table.SetWidths(centerValues);
                table.DefaultCell.NoWrap = true;
                table.SpacingAfter = 20;
                foreach (string valueN in columnNames)
                {
                    PdfPCell cell = new(new Phrase(valueN, bigFont));
                    cell.HorizontalAlignment = 1;
                    cell.FixedHeight = 20;
                    table.AddCell(cell);
                }
                foreach (List<string> row in itemsList)
                {
                    foreach (string value in row)
                    {
                        PdfPCell cell = new(new Phrase(value, cellsFont));
                        cell.FixedHeight = 20;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);
                    }
                }
                document.Add(table);
            }
            else
            {
                AddParagraph("brak danych", 12, 1, 0);
            }
        }
        public void GenerateRaport(string orderState, int id)
        {

            using salon_samochodowyContext db = new();
            var salonID = (from p in db.Pracownicy
                           join s in db.Salony on p.IdSalonu equals s.IdSalonu
                           where p.IdPracownika == id
                           select p.IdSalonu).FirstOrDefault();
            var ordersInfo = (from z in db.Zamowienia
                              join p in db.Pracownicy on z.IdPracownika equals p.IdPracownika
                              join k in db.Klienci on z.IdKlienta equals k.IdKlienta
                              join s in db.Salony on p.IdSalonu equals s.IdSalonu
                              where z.Status == orderState && p.IdSalonu == salonID
                              orderby z.IdZamowienia
                              select new List<string> { z.IdZamowienia.ToString(), p.Imie, p.Nazwisko, k.Imie, k.Nazwisko, k.Telefon, k.Email, z.TypZamowienia, z.CalkowityKoszt.ToString() }).ToList();
            ordersInfo = ordersInfo.Any() ? ordersInfo : null;
            List<List<string>> ordersList = new();
            if (ordersInfo is not null)
            {
                ordersList = ordersInfo;
            }
            else
            {
                MessageBox.Show("Brak danych do wygenerowania raportu", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (orderState == "zakończone")
            {
                orderState = "zakończonych";
            }
            else if (orderState == "wtrakcie")
            {
                orderState = "trwających";
            }
            int i = 0;
            this.DocOpen();
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            Font fontDate = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            Paragraph date = new(DateTime.Now.ToString("dd.MM.yyyy"), fontDate) { Alignment = Element.ALIGN_RIGHT };
            this.Add(date);
            Font font = new(bf, 20);
            font.SetStyle(Font.BOLD);
            Paragraph header = new($"Raport {orderState} zamówień", font);
            header.Alignment = Element.ALIGN_CENTER;
            header.SpacingAfter = 20;
            this.Add(header);
            foreach (List<string> orderData in ordersList)
            {
                Paragraph title = new($"Zamówienie nr {orderData[0]}");
                title.Font.SetStyle(Font.BOLD);
                title.Alignment = Element.ALIGN_LEFT;
                this.Add(title);
                this.AddParagraph($"Wystawione przez: {orderData[1]} {orderData[2]}", 12, 2, 0);
                this.AddParagraph($"Dla klienta: {orderData[3]} {orderData[4]}\nNr telefonu klienta: {orderData[5]}, Adres e-mail klienta: {orderData[6]}", 12, 2, 0);
                this.AddParagraph($"Typ zamówienia: {orderData[7]}", 12, 2, 0);
                this.AddParagraph("Dane pojazdu / pojazdów:", 12, 8, 0);
                var carsInfo = (from s in db.Samochody
                                join zsu in db.ZamowieniaSamochodyUslugi on s.IdSamochodu equals zsu.IdSamochodu
                                where zsu.IdZamowienia == int.Parse(orderData[0])
                                select new
                                {
                                    s.Marka,
                                    s.Model,
                                    s.RokProdukcji,
                                    s.MocSilnika,
                                    s.TypSilnika,
                                    s.TypNadwozia
                                })
            .Distinct()
            .ToList()
            .Select(x => new List<string> {
                    x.Marka,
                    x.Model,
                    x.RokProdukcji.ToString(),
                    x.MocSilnika.ToString() + " KM",
                    x.TypSilnika,
                    x.TypNadwozia
            })
            .ToList();

                this.AddTable(carsInfo, "Marka", "Model", "Rok produkcji", "Moc silnika", "Typ silnika", "Typ nadwozia");
                var servicesInfo = (from u in db.Uslugi
                                    join zsu in db.ZamowieniaSamochodyUslugi on u.IdUslugi equals zsu.IdUslugi
                                    where zsu.IdZamowienia == int.Parse(orderData[0])
                                    select new List<string> { u.Nazwa, u.CenaUslugi.ToString() + "zł", u.TypUslugi }).ToList();
                servicesInfo = servicesInfo.Any() ? servicesInfo : null;
                if (servicesInfo is not null)
                {
                    this.AddParagraph("Zakupione usługi: ", 12, 5, 0);
                    this.AddTable(servicesInfo, "Usługa", "Cena", "Typ usługi");
                }
                else
                {
                    this.AddParagraph("Zakupione usługi: brak ", 12, 5, 0);
                }
                this.AddParagraph($"Całkowity koszt zamówienia: {orderData[8]}zł", 12, 8, 0);
                i++;
                if (i == 2)
                {
                    this.NewPage();
                    i = 0;
                }
            }
            this.DocClose();
            this.Dispose();
        }
    }
}
