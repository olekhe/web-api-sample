using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Flight
    {
        public decimal FlightId { get; set; }
        public decimal? BookingId { get; set; }
        public decimal PersonId { get; set; }
        public decimal? SupplierId { get; set; }
        public decimal? AgencyId { get; set; }
        public int FlightStatus { get; set; }
        public int FlightOrigin { get; set; }
        public string FlightPwd { get; set; }
        public string FlightRefNo { get; set; }
        public string FlightSupplierRefNo { get; set; }
        public string FlightAgencyRefNo { get; set; }
        public int FlightAdults { get; set; }
        public int FlightChildren { get; set; }
        public int FlightInfants { get; set; }
        public string FlightChildAges { get; set; }
        public string FlightDepAirport { get; set; }
        public string FlightDepAirportCode { get; set; }
        public DateTime FlightDepDate { get; set; }
        public string FlightDepTime { get; set; }
        public string FlightArrAirport { get; set; }
        public string FlightArrAirportCode { get; set; }
        public DateTime FlightArrDate { get; set; }
        public string FlightArrTime { get; set; }
        public string FlightNo { get; set; }
        public string FlightRetDepAirport { get; set; }
        public string FlightRetDepAirportCode { get; set; }
        public DateTime? FlightRetDepDate { get; set; }
        public string FlightRetDepTime { get; set; }
        public string FlightRetArrAirport { get; set; }
        public string FlightRetArrAirportCode { get; set; }
        public DateTime? FlightRetArrDate { get; set; }
        public string FlightRetArrTime { get; set; }
        public string FlightRetNo { get; set; }
        public string FlightImportantInfo { get; set; }
        public string FlightSpecialRequest { get; set; }
        public string FlightCurrency { get; set; }
        public decimal FlightTotalCost { get; set; }
        public decimal FlightTotalPaid { get; set; }
        public decimal FlightNetCost { get; set; }
        public DateTime? FlightPaidDate { get; set; }
        public decimal? FlightAgencyCommision { get; set; }
        public DateTime? FlightAgencyPaidDate { get; set; }
        public DateTime? FlightSupplierPaidDate { get; set; }
        public string FlightNote { get; set; }
        public DateTime FlightAdded { get; set; }
        public string FlightCancellationPolicy { get; set; }

        public virtual Company Agency { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Person Person { get; set; }
        public virtual Company Supplier { get; set; }
    }
}
