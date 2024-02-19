using CarDealerSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //salon_samochodowyContext db=new salon_samochodowyContext();
            //db.Add(new Pracownicy() { Imie = "Grzegorz", Nazwisko = "Kowalski", Login = "grzeg23", Haslo = "grzegorz123", Adres = "xd", Telefon = "123456789", IdSalonu=1, Email = "grzegorz@aaa.pl", KodRoli = "KRW" });
            //db.SaveChanges();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SellerPanel());//LOginFOrm
        }
    }
}
