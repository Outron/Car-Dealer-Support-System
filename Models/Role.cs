using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Role
    {
        public Role()
        {
            Pracownicy = new HashSet<Pracownicy>();
        }

        public string KodRoli { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Pracownicy> Pracownicy { get; set; }
    }
}
