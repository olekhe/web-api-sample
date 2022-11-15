using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Airline
    {
        public Airline()
        {
            Chflight = new HashSet<Chflight>();
            Chmap = new HashSet<Chmap>();
            FlightCost = new HashSet<FlightCost>();
        }

        public decimal AirlineId { get; set; }
        public int AirlineType { get; set; }
        public string AirlineName { get; set; }
        public string AirlineNameMl { get; set; }
        public string AirlineCountry { get; set; }
        public string AirlineCountryMl { get; set; }
        public string AirlineIataCode { get; set; }
        public string AirlineIcaoCode { get; set; }
        public string AirlineAddress { get; set; }
        public string AirlinePhone { get; set; }
        public string AirlinePhoneLocal { get; set; }
        public string AirlineFax { get; set; }
        public string AirlineUrl { get; set; }
        public string AirlineBaseAirports { get; set; }
        public string AirlineFlightsDom { get; set; }
        public string AirlineFlightsInt { get; set; }
        public string AirlineAirplanes { get; set; }
        public DateTime AirlineAdded { get; set; }
        public string AirlineDesc { get; set; }
        public string AirlineDescMl { get; set; }
        public string AirlineEmail { get; set; }
        public string AirlineFlightsCis { get; set; }
        public DateTime? AirlinePublished { get; set; }
        public DateTime? AirlineUpdated { get; set; }
        public int AirlineRank { get; set; }

        public virtual ICollection<Chflight> Chflight { get; set; }
        public virtual ICollection<Chmap> Chmap { get; set; }
        public virtual ICollection<FlightCost> FlightCost { get; set; }
    }
}
