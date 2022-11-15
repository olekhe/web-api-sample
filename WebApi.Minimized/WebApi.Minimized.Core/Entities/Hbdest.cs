using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Hbdest
    {
        public Hbdest()
        {
            Dest = new HashSet<Dest>();
            Hbhotel = new HashSet<Hbhotel>();
        }

        public decimal HbdestId { get; set; }
        public string HbdestCountryCode { get; set; }
        public string HbdestCountry { get; set; }
        public string HbdestCountryMl { get; set; }
        public string HbdestDestCode { get; set; }
        public string HbdestDest { get; set; }
        public string HbdestDestMl { get; set; }
        public int? HbdestZoneCode { get; set; }
        public string HbdestZone { get; set; }
        public string HbdestZoneMl { get; set; }
        public DateTime HbdestAdded { get; set; }
        public DateTime? HbdestUpdated { get; set; }
        public string HbdestLatitude { get; set; }
        public string HbdestLongitude { get; set; }

        public virtual ICollection<Dest> Dest { get; set; }
        public virtual ICollection<Hbhotel> Hbhotel { get; set; }
    }
}
