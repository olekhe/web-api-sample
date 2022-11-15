using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Dest
    {
        public Dest()
        {
            AirTicketFromDest = new HashSet<AirTicket>();
            AirTicketToDest = new HashSet<AirTicket>();
            Excursion = new HashSet<Excursion>();
            Hotel = new HashSet<Hotel>();
            PackageDest = new HashSet<Package>();
            PackageDestId1Navigation = new HashSet<Package>();
            PackageDestId2Navigation = new HashSet<Package>();
        }

        public decimal DestId { get; set; }
        public decimal? HbdestId { get; set; }
        public string DestCountry { get; set; }
        public string DestCountryMl { get; set; }
        public string DestDest { get; set; }
        public string DestDestMl { get; set; }
        public string DestZone { get; set; }
        public string DestZoneMl { get; set; }
        public DateTime DestAdded { get; set; }
        public int? DestFeatured { get; set; }
        public string DestText { get; set; }
        public int DestFroogle { get; set; }
        public int DestSearchType { get; set; }
        public decimal? TtresortId { get; set; }
        public string DestCountryMl1 { get; set; }
        public string DestCountryMl2 { get; set; }
        public string DestDestMl1 { get; set; }
        public string DestDestMl2 { get; set; }
        public string DestZoneMl1 { get; set; }
        public string DestZoneMl2 { get; set; }
        public bool DestIsland { get; set; }
        public bool DestCapital { get; set; }
        public string DestLatitude { get; set; }
        public string DestLongitude { get; set; }
        public DateTime? DestUpdated { get; set; }
        public int DestViewed { get; set; }
        public string DestCountryIso2 { get; set; }
        public decimal? IttourCountryId { get; set; }
        public string DestCountrySl { get; set; }
        public string DestCountrySl1 { get; set; }
        public string DestCountrySl2 { get; set; }
        public string DestDestSl { get; set; }
        public string DestDestSl1 { get; set; }
        public string DestDestSl2 { get; set; }
        public string DestZoneSl { get; set; }
        public string DestZoneSl1 { get; set; }
        public string DestZoneSl2 { get; set; }

        public virtual Hbdest Hbdest { get; set; }
        public virtual Ttresort Ttresort { get; set; }
        public virtual ICollection<AirTicket> AirTicketFromDest { get; set; }
        public virtual ICollection<AirTicket> AirTicketToDest { get; set; }
        public virtual ICollection<Excursion> Excursion { get; set; }
        public virtual ICollection<Hotel> Hotel { get; set; }
        public virtual ICollection<Package> PackageDest { get; set; }
        public virtual ICollection<Package> PackageDestId1Navigation { get; set; }
        public virtual ICollection<Package> PackageDestId2Navigation { get; set; }
    }
}
