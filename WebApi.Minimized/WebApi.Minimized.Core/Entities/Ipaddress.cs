using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Ipaddress
    {
        public decimal IpaddressId { get; set; }
        public string IpaddressIp { get; set; }
        public bool IpaddressEnabled { get; set; }
        public string IpaddressNote { get; set; }
        public DateTime IpaddressAdded { get; set; }
    }
}
