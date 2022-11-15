using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Chflight
    {
        public Chflight()
        {
            ChflightSeat = new HashSet<ChflightSeat>();
        }

        public decimal ChflightId { get; set; }
        public decimal SupplierId { get; set; }
        public decimal AirlineId { get; set; }
        public decimal FromAirportId { get; set; }
        public decimal ToAirportId { get; set; }
        public string ChflightFlightThere { get; set; }
        public string ChflightFlightThereDep { get; set; }
        public string ChflightFlightThereArr { get; set; }
        public string ChflightFlightBack { get; set; }
        public string ChflightFlightBackDep { get; set; }
        public string ChflightFlightBackArr { get; set; }
        public DateTime ChflightDate { get; set; }
        public int ChflightSeatsThere { get; set; }
        public int ChflightSeatsBack { get; set; }
        public decimal ChflightTariff { get; set; }
        public decimal ChflightFromAirportTax { get; set; }
        public decimal? ChflightToAirportTax { get; set; }
        public decimal ChflightBoardBasisOw { get; set; }
        public string ChflightCurrency { get; set; }
        public decimal? ChflightPrice7 { get; set; }
        public decimal? ChflightPrice1011 { get; set; }
        public decimal? ChflightPrice14 { get; set; }
        public decimal? ChflightPrice21 { get; set; }
        public DateTime? ChflightUpdated { get; set; }
        public DateTime ChflightAdded { get; set; }
        public string ChflightTitle { get; set; }

        public virtual Airline Airline { get; set; }
        public virtual Airport FromAirport { get; set; }
        public virtual Company Supplier { get; set; }
        public virtual Airport ToAirport { get; set; }
        public virtual ICollection<ChflightSeat> ChflightSeat { get; set; }
    }
}
