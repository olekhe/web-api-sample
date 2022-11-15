using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AdvRoute
    {
        public decimal AdvRouteId { get; set; }
        public string AdvRouteCountry { get; set; }
        public string AdvRouteTitle { get; set; }
        public string AdvRouteUrl { get; set; }
        public int AdvRouteRank { get; set; }
        public DateTime AdvRouteAdded { get; set; }
    }
}
