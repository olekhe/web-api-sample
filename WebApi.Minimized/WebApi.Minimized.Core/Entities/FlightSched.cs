using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class FlightSched
    {
        public decimal FlightSchedId { get; set; }
        public string FlightSchedTag { get; set; }
        public string FlightSchedNumber { get; set; }
        public string FlightSchedRoute { get; set; }
        public string FlightSchedTime { get; set; }
        public string FlightSchedDay { get; set; }
        public string FlightSchedPeriod { get; set; }
        public DateTime? FlightSchedUpdated { get; set; }
        public DateTime FlightSchedAdded { get; set; }
    }
}
