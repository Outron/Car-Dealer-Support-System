using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Pracownicy
    {
        public Pracownicy()
        {
            PracownicyUslugi = new HashSet<PracownicyUslugi>();
            Zamowienia = new HashSet<Zamowienia>();
        }

        public int IdPracownika { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int IdSalonu { get; set; }
        public string KodRoli { get; set; }

        public virtual Salony IdSalonuNavigation { get; set; }
        public virtual Role KodRoliNavigation { get; set; }
        public virtual ICollection<PracownicyUslugi> PracownicyUslugi { get; set; }
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }
}
