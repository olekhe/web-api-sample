using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class AirTicket
    {
        public decimal AirTicketId { get; set; }
        public decimal FromDestId { get; set; }
        public decimal ToDestId { get; set; }
        public decimal? AirlineId { get; set; }
        public int AirTicketStatus { get; set; }
        public int AirTicketType { get; set; }
        public int AirTicketFeatured { get; set; }
        public string AirTicketText { get; set; }
        public decimal AirTicketRtpriceFrom { get; set; }
        public decimal AirTicketOwpriceFrom { get; set; }
        public string AirTicketCurrency { get; set; }
        public string AirTicketFlight { get; set; }
        public DateTime AirTicketPublished { get; set; }
        public DateTime AirTicketAdded { get; set; }
        public decimal? AirTicketRt7priceFrom { get; set; }
        public decimal? AirTicketRt1011priceFrom { get; set; }
        public decimal? AirTicketRt14priceFrom { get; set; }
        public decimal? AirTicketRt21priceFrom { get; set; }
        public decimal? AirTicketRt28priceFrom { get; set; }

        public virtual Company Airline { get; set; }
        public virtual Dest FromDest { get; set; }
        public virtual Dest ToDest { get; set; }
    }
}
