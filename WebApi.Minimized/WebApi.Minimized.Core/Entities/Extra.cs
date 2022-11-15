using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Core.Entities
{
    public partial class Extra
    {
        public Extra()
        {
            PkgExtra = new HashSet<PkgExtra>();
        }

        public decimal ExtraId { get; set; }
        public int ExtraType { get; set; }
        public int ExtraStatus { get; set; }
        public string ExtraTitle { get; set; }
        public string ExtraTitleMl { get; set; }
        public decimal ExtraPrice { get; set; }
        public decimal? ExtraPriceChd { get; set; }
        public string ExtraCurrency { get; set; }
        public int ExtraRank { get; set; }
        public decimal? ExtraUpdatedById { get; set; }
        public DateTime? ExtraUpdated { get; set; }
        public decimal? ExtraAddedById { get; set; }
        public DateTime ExtraAdded { get; set; }

        public virtual ICollection<PkgExtra> PkgExtra { get; set; }
    }
}
