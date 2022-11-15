using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Excursion
    {
        public Excursion()
        {
            PkgExtra = new HashSet<PkgExtra>();
        }

        public decimal ExcursionId { get; set; }
        public decimal SupplierId { get; set; }
        public decimal DestId { get; set; }
        public int ExcursionStatus { get; set; }
        public string ExcursionTitle { get; set; }
        public string ExcursionTitleMl { get; set; }
        public string ExcursionKeywords { get; set; }
        public string ExcursionKeywordsMl { get; set; }
        public string ExcursionText { get; set; }
        public string ExcursionTextMl { get; set; }
        public string ExcursionImg1 { get; set; }
        public string ExcursionTextInit { get; set; }
        public string ExcursionTextInitMl { get; set; }
        public string ExcursionHtml { get; set; }
        public string ExcursionHtmlml { get; set; }
        public decimal ExcursionPrice { get; set; }
        public decimal? ExcursionPriceChd { get; set; }
        public string ExcursionCurrency { get; set; }
        public DateTime? ExcursionPublished { get; set; }
        public int ExcursionRank { get; set; }
        public int ExcursionViewed { get; set; }
        public int? ExcursionUpdatedById { get; set; }
        public DateTime? ExcursionUpdated { get; set; }
        public decimal? ExcursionAddedById { get; set; }
        public DateTime ExcursionAdded { get; set; }
        public string ExcursionSeourl { get; set; }
        public string ExcursionSeourlml { get; set; }

        public virtual Dest Dest { get; set; }
        public virtual Company Supplier { get; set; }
        public virtual ICollection<PkgExtra> PkgExtra { get; set; }
    }
}
