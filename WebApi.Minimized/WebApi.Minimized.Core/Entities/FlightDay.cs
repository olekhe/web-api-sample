using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class FlightDay
    {
        public decimal FlightDayId { get; set; }
        public decimal? FlightSchedId { get; set; }
        public DateTime? FlightDayDate { get; set; }
        public int? FlightDayDay { get; set; }
        public int? FlightDayPrice7 { get; set; }
        public int? FlightDayPrice1011 { get; set; }
        public int? FlightDayPrice14 { get; set; }
        public int? FlightDayPrice21 { get; set; }
        public int? FlightDayPrice28 { get; set; }
        public string FlightDayCurrency { get; set; }
        public DateTime? FlightDayUpdated { get; set; }
        public DateTime FlightDayAdded { get; set; }
    }
}
