using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Zamowienia
    {
        public Zamowienia()
        {
            PracownicyUslugi = new HashSet<PracownicyUslugi>();
            SamochodyZamowienia = new HashSet<SamochodyZamowienia>();
        }

        public int IdZamowienia { get; set; }
        public int IdKlienta { get; set; }
        public int IdPracownika { get; set; }
        public string TypZakupu { get; set; }
        [NotMapped]
        public double? CalkowityKoszt { get; set; }
        public DateTime? Data { get; set; }

        public virtual Klienci IdKlientaNavigation { get; set; }
        public virtual Pracownicy IdPracownikaNavigation { get; set; }
        public virtual ICollection<PracownicyUslugi> PracownicyUslugi { get; set; }
        public virtual ICollection<SamochodyZamowienia> SamochodyZamowienia { get; set; }
    }
}
