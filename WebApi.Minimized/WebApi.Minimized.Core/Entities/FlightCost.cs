using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class FlightCost
    {
        public decimal FlightCostId { get; set; }
        public decimal FromAirportId { get; set; }
        public decimal ToAirportId { get; set; }
        public decimal? ConAirportId { get; set; }
        public int? FlightCostStatus { get; set; }
        public int? FlightCostType { get; set; }
        public int? FlightCostFeatured { get; set; }
        public string FlightCostText { get; set; }
        public string FlightCostTmp { get; set; }
        public decimal FlightCostRtpriceFrom { get; set; }
        public decimal FlightCostOwpriceFrom { get; set; }
        public string FlightCostCurrency { get; set; }
        public DateTime FlightCostPublished { get; set; }
        public DateTime FlightCostAdded { get; set; }
        public decimal? AirlineId { get; set; }
        public decimal? FlightCostRtpriceFromOld { get; set; }
        public decimal? FlightCostOwpriceFromOld { get; set; }

        public virtual Airline Airline { get; set; }
        public virtual Airport ConAirport { get; set; }
        public virtual Airport FromAirport { get; set; }
        public virtual Airport ToAirport { get; set; }
    }
}
