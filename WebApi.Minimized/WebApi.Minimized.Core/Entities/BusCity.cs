using System;
using System.Collections.Generic;
using WebApi.Minimized.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusCity
    {
        public decimal BusCityId { get; set; }
        public decimal BusRouteId { get; set; }
        public decimal CityId { get; set; }
        public int BusCityDay { get; set; }
        public string BusCityTime { get; set; }
        public string BusCityDesc { get; set; }
        public string BusCityDescMl { get; set; }
        public int BusCityRank { get; set; }
        public bool? BusCityEnabled { get; set; }
        public string BusCityNote { get; set; }
        public DateTime? BusCityUpdated { get; set; }
        public DateTime BusCityAdded { get; set; }

        public virtual BusRoute BusRoute { get; set; }
        public virtual City City { get; set; }
    }
}
