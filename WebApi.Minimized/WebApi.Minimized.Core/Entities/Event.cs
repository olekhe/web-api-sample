using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Event
    {
        public decimal EventId { get; set; }
        public int EventType { get; set; }
        public int EventStatus { get; set; }
        public int EventNumber { get; set; }
        public string EventSource { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventAdded { get; set; }
        public string EventClientIp { get; set; }
    }
}
