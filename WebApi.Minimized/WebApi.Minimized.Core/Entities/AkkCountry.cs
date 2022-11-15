using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AkkCountry
    {
        public AkkCountry()
        {
            AkkLink = new HashSet<AkkLink>();
        }

        public decimal AkkCountryId { get; set; }
        public string AkkCountryName { get; set; }
        public DateTime? AkkCountryUpdated { get; set; }
        public DateTime AkkCountryAdded { get; set; }
        public int AkkCountryStatus { get; set; }
        public decimal? DestId { get; set; }

        public virtual ICollection<AkkLink> AkkLink { get; set; }
    }
}
