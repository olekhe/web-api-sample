using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Package
    {
        public Package()
        {
            PkgDate = new HashSet<PkgDate>();
            PkgExtra = new HashSet<PkgExtra>();
        }

        public decimal PackageId { get; set; }
        public decimal SupplierId { get; set; }
        public decimal DestId { get; set; }
        public int PackageStatus { get; set; }
        public int PackageType { get; set; }
        public string PackageTitle { get; set; }
        public DateTime PackageFromDate { get; set; }
        public DateTime PackageToDate { get; set; }
        public string PackageText { get; set; }
        public string PackageHtml { get; set; }
        public string PackageImg1 { get; set; }
        public decimal PackagePriceFrom { get; set; }
        public string PackageCurrency { get; set; }
        public DateTime PackagePublished { get; set; }
        public DateTime PackageAdded { get; set; }
        public decimal? DestId1 { get; set; }
        public decimal? DestId2 { get; set; }
        public int PackageSubtype { get; set; }
        public int? PackageSubtype1 { get; set; }
        public int? PackageSubtype2 { get; set; }
        public int? PackageSubtype3 { get; set; }
        public int? PackageSubtype4 { get; set; }
        public int? PackageTypeOld { get; set; }
        public string PackageKeywords { get; set; }
        public DateTime? PackageUpdated { get; set; }
        public decimal? PackageUpdatedById { get; set; }
        public decimal? PackageAddedById { get; set; }
        public int PackageFeatured { get; set; }
        public int PackageRank { get; set; }
        public int? PackageNights { get; set; }
        public string PackageSupplierUrl { get; set; }
        public string PackageRoute { get; set; }
        public int PackageViewed { get; set; }
        public decimal? AkkProdId { get; set; }
        public int PackageTmp { get; set; }
        public int? PackageKind { get; set; }
        public string PackageTitleMl { get; set; }
        public string PackageRouteMl { get; set; }
        public string PackageRouteC { get; set; }
        public string PackageRouteCml { get; set; }
        public string PackageKeywordsMl { get; set; }
        public string PackageTextMl { get; set; }
        public string PackageHtmlml { get; set; }
        public decimal? PackagePriceFromChd { get; set; }
        public string PackageTextInit { get; set; }
        public string PackageTextInitMl { get; set; }
        public string PackageSeourl { get; set; }
        public string PackageSeourlml { get; set; }
        public int? PackageSubtype5 { get; set; }
        public int? PackageSubtype6 { get; set; }
        public int? PackageSubtype7 { get; set; }
        public int? PackageSubtype8 { get; set; }
        public int? PackageSubtype9 { get; set; }
        public string SamotyrUrl { get; set; }

        public virtual Dest Dest { get; set; }
        public virtual Dest DestId1Navigation { get; set; }
        public virtual Dest DestId2Navigation { get; set; }
        public virtual Company Supplier { get; set; }
        public virtual ICollection<PkgDate> PkgDate { get; set; }
        public virtual ICollection<PkgExtra> PkgExtra { get; set; }
    }
}
