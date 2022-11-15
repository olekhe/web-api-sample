using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Chmap
    {
        public decimal ChmapId { get; set; }
        public decimal SupplierId { get; set; }
        public decimal AirlineId { get; set; }
        public decimal FromAirportId { get; set; }
        public decimal ToAirportId { get; set; }
        public string ChmapFlightThere { get; set; }
        public string ChmapFlightThereDep { get; set; }
        public string ChmapFlightThereArr { get; set; }
        public string ChmapFlightBack { get; set; }
        public string ChmapFlightBackDep { get; set; }
        public string ChmapFlightBackArr { get; set; }
        public DateTime ChmapFromDate { get; set; }
        public DateTime? ChmapToDate { get; set; }
        public string ChmapEvery { get; set; }
        public int ChmapSeats { get; set; }
        public decimal ChmapTariff { get; set; }
        public decimal ChmapFromAirportTax { get; set; }
        public decimal ChmapToAirportTax { get; set; }
        public decimal ChmapBoardBasisOw { get; set; }
        public string ChmapFlightsTotal { get; set; }
        public string ChmapCurrency { get; set; }
        public DateTime? ChmapUpdated { get; set; }
        public DateTime ChmapAdded { get; set; }
        public string ChmapTitle { get; set; }

        public virtual Airline Airline { get; set; }
        public virtual Airport FromAirport { get; set; }
        public virtual Company Supplier { get; set; }
        public virtual Airport ToAirport { get; set; }
    }
}
