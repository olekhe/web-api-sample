using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class PkgExtra
    {
        public decimal PkgExtraId { get; set; }
        public decimal PackageId { get; set; }
        public decimal? ExtraId { get; set; }
        public int PkgExtraType { get; set; }
        public int? PkgExtraStatus { get; set; }
        public string PkgExtraTitle { get; set; }
        public string PkgExtraTitleMl { get; set; }
        public decimal PkgExtraPrice { get; set; }
        public decimal? PkgExtraPriceChd { get; set; }
        public string PkgExtraCurrency { get; set; }
        public int PkgExtraRank { get; set; }
        public decimal? PkgExtraUpdatedById { get; set; }
        public DateTime? PkgExtraUpdated { get; set; }
        public decimal? PkgExtraAddedById { get; set; }
        public DateTime PkgExtraAdded { get; set; }
        public decimal? ExcursionId { get; set; }

        public virtual Excursion Excursion { get; set; }
        public virtual Extra Extra { get; set; }
        public virtual Package Package { get; set; }
    }
}
