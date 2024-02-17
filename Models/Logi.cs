using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class Logi
    {
        public int IdLogu { get; set; }
        public DateTime? DataGodzina { get; set; }
        public string Typ { get; set; }
        public string Wiadomosc { get; set; }
    }
}
