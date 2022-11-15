using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Ttcountry
    {
        public decimal TtcountryId { get; set; }
        public decimal TtcountryKey { get; set; }
        public string TtcountryName { get; set; }
        public string TtcountryNameLat { get; set; }
        public DateTime TtcountryAdded { get; set; }
    }
}
