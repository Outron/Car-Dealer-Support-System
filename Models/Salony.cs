using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Salony
    {
        public Salony()
        {
            Pracownicy = new HashSet<Pracownicy>();
            Samochody = new HashSet<Samochody>();
        }

        public int IdSalonu { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string KodPocztowy { get; set; }

        public virtual ICollection<Pracownicy> Pracownicy { get; set; }
        public virtual ICollection<Samochody> Samochody { get; set; }
    }
}
