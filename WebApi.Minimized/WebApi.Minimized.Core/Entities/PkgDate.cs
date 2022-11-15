using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class PkgDate
    {
        public decimal PkgDateId { get; set; }
        public decimal PackageId { get; set; }
        public DateTime PkgDateDate { get; set; }
        public DateTime? PkgDateDateTo { get; set; }
        public string PkgDateSpecial { get; set; }
        public int? PkgDateSpecialType { get; set; }
        public DateTime PkgDateAdded { get; set; }
        public decimal PkgDatePriceFrom { get; set; }
        public decimal? PkgDatePriceFromChd { get; set; }
        public DateTime? PkgDateUpdated { get; set; }
        public DateTime? PkgDateSpodateFrom { get; set; }
        public DateTime? PkgDateSpodateTo { get; set; }
        public decimal? BusTripId { get; set; }
        public string PkgDatePriceZero { get; set; }

        public virtual BusTrip BusTrip { get; set; }
        public virtual Package Package { get; set; }
    }
}
