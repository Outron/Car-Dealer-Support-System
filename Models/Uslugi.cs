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
            Mozliweuslugisamochody = new HashSet<Mozliweuslugisamochody>();
            PakietyUslugi = new HashSet<PakietyUslugi>();
        }

        public int IdUslugi { get; set; }
        public string Nazwa { get; set; }
        public int? CenaUslugi { get; set; }
        public string TypUslugi { get; set; }

        public virtual ICollection<Mozliweuslugisamochody> Mozliweuslugisamochody { get; set; }
        public virtual ICollection<PakietyUslugi> PakietyUslugi { get; set; }
    }
}
