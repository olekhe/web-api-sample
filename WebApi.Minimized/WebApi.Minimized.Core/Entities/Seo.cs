using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Seo
    {
        public decimal SeoId { get; set; }
        public string SeoAirport { get; set; }
        public string SeoCity { get; set; }
        public string SeoIata { get; set; }
        public string SeoName { get; set; }
        public string SeoEmail { get; set; }
        public string SeoIpaddress { get; set; }
        public DateTime SeoAdded { get; set; }
        public int SeoStatus { get; set; }
        public int SeoType { get; set; }
        public Guid SeoGuid { get; set; }
        public DateTime? SeoSent { get; set; }
        public int SeoSentQty { get; set; }
        public string SeoComments { get; set; }
        public int SeoGroup { get; set; }
        public string SeoTag { get; set; }
        public string SeoPhone { get; set; }
        public string SeoEmail2 { get; set; }
    }
}
