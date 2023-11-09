using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class PakietyPromocyjne
    {
        public PakietyPromocyjne()
        {
            PakietySamochody = new HashSet<PakietySamochody>();
            UslugiPakiety = new HashSet<UslugiPakiety>();
        }

        public int IdPakietu { get; set; }
        public string NazwaPakietu { get; set; }
        public DateTime? DataRozpoczecia { get; set; }
        public DateTime? DataZakonczenia { get; set; }

        public virtual ICollection<PakietySamochody> PakietySamochody { get; set; }
        public virtual ICollection<UslugiPakiety> UslugiPakiety { get; set; }
    }
}
