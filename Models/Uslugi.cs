using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Uslugi
    {
        public Uslugi()
        {
            SamochodyUslugi = new HashSet<SamochodyUslugi>();
            SamochodyZamowienia = new HashSet<SamochodyZamowienia>();
            UslugiPakiety = new HashSet<UslugiPakiety>();
        }

        public int IdUslugi { get; set; }
        public string Nazwa { get; set; }
        public double? CenaUslugi { get; set; }
        public int? TypUslugi { get; set; }

        public virtual ICollection<SamochodyUslugi> SamochodyUslugi { get; set; }
        public virtual ICollection<SamochodyZamowienia> SamochodyZamowienia { get; set; }
        public virtual ICollection<UslugiPakiety> UslugiPakiety { get; set; }
    }
}
