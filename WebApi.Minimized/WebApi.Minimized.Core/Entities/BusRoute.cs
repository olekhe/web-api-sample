using System;
using System.Collections.Generic;
using WebApi.Minimized.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class BusRoute
    {
        public BusRoute()
        {
            BusCity = new HashSet<BusCity>();
            BusPrice = new HashSet<BusPrice>();
            BusTrip = new HashSet<BusTrip>();
        }

        public decimal BusRouteId { get; set; }
        public decimal BusProgramId { get; set; }
        public decimal CityIdfrom { get; set; }
        public decimal? CityIdto { get; set; }
        public string BusRouteName { get; set; }
        public string BusRouteNameMl { get; set; }
        public DateTime BusRouteDateStart { get; set; }
        public DateTime BusRouteDateEnd { get; set; }
        public int BusRouteDuration { get; set; }
        public bool? BusRouteEnabled { get; set; }
        public string BusRouteNote { get; set; }
        public DateTime? BusRouteUpdated { get; set; }
        public DateTime BusRouteAdded { get; set; }

        public virtual BusProgram BusProgram { get; set; }
        public virtual City CityIdfromNavigation { get; set; }
        public virtual City CityIdtoNavigation { get; set; }
        public virtual ICollection<BusCity> BusCity { get; set; }
        public virtual ICollection<BusPrice> BusPrice { get; set; }
        public virtual ICollection<BusTrip> BusTrip { get; set; }
    }
}
