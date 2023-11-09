using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class UslugiPakiety
    {
        public int IdUslugi { get; set; }
        public int IdPakietu { get; set; }
        public int? WysokoscPromocji { get; set; }

        public virtual PakietyPromocyjne IdPakietuNavigation { get; set; }
        public virtual Uslugi IdUslugiNavigation { get; set; }
    }
}
