using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class ZamowieniaUslugi
    {
        public int IdZamowienia { get; set; }
        public int IdUslugi { get; set; }

        public virtual Uslugi IdUslugiNavigation { get; set; }
        public virtual Zamowienia IdZamowieniaNavigation { get; set; }
    }
}
