using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Klienci
    {
        public Klienci()
        {
            Zamowienia = new HashSet<Zamowienia>();
        }

        public int IdKlienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }
}
