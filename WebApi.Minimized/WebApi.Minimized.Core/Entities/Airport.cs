using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Airport
    {
        public Airport()
        {
            ChflightFromAirport = new HashSet<Chflight>();
            ChflightToAirport = new HashSet<Chflight>();
            ChmapFromAirport = new HashSet<Chmap>();
            ChmapToAirport = new HashSet<Chmap>();
            FlightCostConAirport = new HashSet<FlightCost>();
            FlightCostFromAirport = new HashSet<FlightCost>();
            FlightCostToAirport = new HashSet<FlightCost>();
        }

        public decimal AirportId { get; set; }
        public string AirportIataCode { get; set; }
        public string AirportIcaoCode { get; set; }
        public string AirportName { get; set; }
        public string AirportNameMl { get; set; }
        public string AirportCity { get; set; }
        public string AirportCityMl { get; set; }
        public string AirportGmt { get; set; }
        public string AirportCountryCode { get; set; }
        public string AirportCountry { get; set; }
        public string AirportCountryMl { get; set; }
        public string AirportLatitude { get; set; }
        public string AirportLongitude { get; set; }
        public int? AirportRunwayLength { get; set; }
        public int? AirportRunwayElevation { get; set; }
        public string AirportPhone { get; set; }
        public string AirportFax { get; set; }
        public string AirportEmail { get; set; }
        public string AirportWebsite { get; set; }
        public int AirportFeatured { get; set; }
        public string AirportCityIata { get; set; }
        public string AirportCityMl1 { get; set; }
        public string AirportCityMl2 { get; set; }
        public string AirportCountryMl1 { get; set; }
        public string AirportCountryMl2 { get; set; }
        public string AirportCountryMl1prefix { get; set; }
        public string AirportCityMl1prefix { get; set; }
        public decimal AirportViewed { get; set; }
        public decimal AirportRank { get; set; }
        public string AirportMorpherXmlru { get; set; }
        public string AirportMorpherXmlua { get; set; }

        public virtual ICollection<Chflight> ChflightFromAirport { get; set; }
        public virtual ICollection<Chflight> ChflightToAirport { get; set; }
        public virtual ICollection<Chmap> ChmapFromAirport { get; set; }
        public virtual ICollection<Chmap> ChmapToAirport { get; set; }
        public virtual ICollection<FlightCost> FlightCostConAirport { get; set; }
        public virtual ICollection<FlightCost> FlightCostFromAirport { get; set; }
        public virtual ICollection<FlightCost> FlightCostToAirport { get; set; }
    }
}
