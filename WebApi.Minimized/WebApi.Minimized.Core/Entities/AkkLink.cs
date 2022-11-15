using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AkkLink
    {
        public decimal AkkLinkId { get; set; }
        public decimal? AkkProdId { get; set; }
        public decimal? AkkCountryId { get; set; }
        public decimal? AkkCtgId { get; set; }
        public int AkkLinkStatus { get; set; }
        public DateTime? AkkLinkUpdated { get; set; }
        public DateTime AkkLinkAdded { get; set; }
        public DateTime? AkkLinkProdLoaded { get; set; }

        public virtual AkkCountry AkkCountry { get; set; }
        public virtual AkkCtg AkkCtg { get; set; }
        public virtual AkkProd AkkProd { get; set; }
    }
}
