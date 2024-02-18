using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Samochody
    {
        public Samochody()
        {
            Mozliweuslugisamochody = new HashSet<Mozliweuslugisamochody>();
            PakietySamochody = new HashSet<PakietySamochody>();
        }

        public int IdSamochodu { get; set; }
        public byte[] Zdjecie { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Kolor { get; set; }
        public string TypNadwozia { get; set; }
        public int? MocSilnika { get; set; }
        public string Wyposazenie { get; set; }
        public int? SrednieSpalanie { get; set; }
        public string TypSilnika { get; set; }
        public int? CenaPodstawowa { get; set; }
        public int? LiczbaDrzwi { get; set; }
        public int? IloscMiejsc { get; set; }
        public string Vin { get; set; }
        public int? Rabat { get; set; }
        public int? IdSalonu { get; set; }
        public string Dostepnosc { get; set; }
        public int? RokProdukcji { get; set; }

        public virtual Salony IdSalonuNavigation { get; set; }
        public virtual ICollection<Mozliweuslugisamochody> Mozliweuslugisamochody { get; set; }
        public virtual ICollection<PakietySamochody> PakietySamochody { get; set; }
    }
}
