using CarDealerSupportSystem.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GenerateRaport("zakończone");
            Application.Run(new LoginForm());
        }
        static void GenerateRaport(string orderState)
        {
            int i = 0;
            List<List<string>> ordersList = new();
            PdfCreator raport = new(@"C:\Users\Admin\Desktop\raport.pdf");
            using (salon_samochodowyContext db = new())
            {
                var ordersInfo = (from z in db.Zamowienia
                                  join p in db.Pracownicy on z.IdPracownika equals p.IdPracownika
                                  join k in db.Klienci on z.IdKlienta equals k.IdKlienta
                                  where z.Status == orderState
                                  select new List<string> { z.IdZamowienia.ToString(), p.Imie, p.Nazwisko, k.Imie, k.Nazwisko, k.Telefon, k.Email, z.TypZamowienia }).ToList();
                if (ordersInfo is not null)
                {   
                    ordersList = ordersInfo;
                }
                if (orderState == "zakończone")
                {
                    orderState = "zakończonych";
                }
                else if (orderState == "wtrakcie")
                {
                    orderState = "trwających";
                }
                raport.DocOpen();
                //--DATA i HEADER
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
                Font fontDate = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                Paragraph date = new(DateTime.Now.ToString("dd.MM.yyyy"), fontDate) { Alignment = Element.ALIGN_RIGHT };
                raport.Add(date);
                Font font = new(bf, 20);
                font.SetStyle(Font.BOLD);
                Paragraph header = new($"Raport {orderState} zamówień", font);
                header.Alignment = Element.ALIGN_CENTER;
                header.SpacingAfter = 20;
                raport.Add(header);
                //--KONIEC daty i HEADERA

                //raport.AddTable(ordersList, "ID zamówienia", "Imię", "Nazwisko", "Imię", "Nazwisko", "Nazwa usługi");
                //--INFORMACJE O ZAMOWIENIU (klient, kto wystawil, typ)
                foreach (List<string> orderData in ordersList)
                {
                    // Dodanie tytułu "Zamówienie nr x"
                    Paragraph title = new($"Zamówienie nr {orderData[0]}");
                    title.Font.SetStyle(Font.BOLD);
                    title.Alignment = Element.ALIGN_LEFT;
                    raport.Add(title);
                    // Dodanie informacji o pracowniku
                    //Paragraph employeeInfo = new Paragraph($"Sporządzone przez: {orderData[1]} {orderData[2]}");
                    //employeeInfo.Alignment = Element.ALIGN_LEFT;
                    raport.AddParagraph($"Wystawione przez: {orderData[1]} {orderData[2]}", 12, 2, 0);
                    // Dodanie informacji o kliencie
                    //Paragraph clientInfo = new Paragraph($"Dane klienta: {orderData[3]} {orderData[4]}");
                    //clientInfo.Alignment = Element.ALIGN_LEFT;
                    raport.AddParagraph($"Dla klienta: {orderData[3]} {orderData[4]}\nNr telefonu klienta: {orderData[5]}, Adres e-mail klienta: {orderData[6]}", 12, 2, 0);
                    // Dodanie pustej linii po każdym zamówieniu
                    raport.AddParagraph($"Typ zamówienia: {orderData[7]}", 12, 2, 0);
                    //--KONIEC info o zamowienia
                    //--INFO o aucie
                    raport.AddParagraph("Dane pojazdu / pojazdów:",12,8,0);
                    var carsInfo = (from s in db.Samochody
                                    join zsu in db.ZamowieniaSamochodyUslugi on s.IdSamochodu equals zsu.IdSamochodu
                                    where zsu.IdZamowienia == int.Parse(orderData[0])
                                    select new List<string> { s.Marka, s.Model, s.RokProdukcji.ToString(), s.MocSilnika.ToString() + " KM", s.TypSilnika, s.TypNadwozia }).ToList();

                    raport.AddTable(carsInfo, "Marka", "Model", "Rok produkcji", "Moc silnika", "Typ silnika", "Typ nadwozia");
                    var servicesInfo = (from u in db.Uslugi
                                       join zsu in db.ZamowieniaSamochodyUslugi on u.IdUslugi equals zsu.IdUslugi
                                       where zsu.IdZamowienia == int.Parse(orderData[0])
                                       select new List<string> { u.Nazwa, u.CenaUslugi.ToString()+"zł", u.TypUslugi}).ToList();
                    
                    if(servicesInfo is not null)
                    {
                        raport.AddParagraph("Zakupione usługi: ", 12, 5, 0); //12,5,0
                        raport.AddTable(servicesInfo, "Usługa", "Cena", "Typ usługi");
                    }
                    else
                    {
                        raport.AddParagraph("Zakupione usługi: brak ", 12, 4, 0);
                    }
                    // raport.Add(new Paragraph("\n"));
                    i++;
                    if (i == 2) {
                        raport.NewPage();
                        i = 0;
                    }
                }
            }
            raport.DocClose();
        }
    }
}
